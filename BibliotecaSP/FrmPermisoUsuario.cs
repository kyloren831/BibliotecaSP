using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using BLL.Servicios;
using DAL.Models;

namespace BibliotecaSP
{
    public partial class FrmPermisoUsuario : Form
    {
        private ServicioPermisosDirectos servicioPermisosDirectos;

        private FrmUsuarios frmUsuarios;
        private List<string> idsUsuarios;
        private List<string> idsPantallas;
        public FrmPermisoUsuario(FrmUsuarios frmUsuarios,ServicioPermisosDirectos servicioPermisosDirectos, List<string> idsPantallas, List<string> idsUsuarios)
        {
            InitializeComponent();
            this.servicioPermisosDirectos = servicioPermisosDirectos;
            this.idsPantallas = idsPantallas;
            this.idsUsuarios = idsUsuarios;
            this.frmUsuarios= frmUsuarios;
        }

        private void cargarCombos()
        {
            foreach (var item in idsUsuarios)
            { 
                this.comboIdUsuario.Items.Add(item);
            }
            foreach (var item in idsPantallas)
            {
                this.comboIdPantalla.Items.Add(item);
            }
            comboIdPantalla.SelectedIndex = 0;
            comboIdUsuario.SelectedIndex = 0;
        }
        private void FrmPermisoUsuario_Load(object sender, EventArgs e)
        {
            cargarCombos();
            this.checkInsertar.Appearance = Appearance.Button;
            this.checkInsertar.Text = "Desactivado";
            this.checkInsertar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkInsertar.Size = new Size(100, 30);
            this.checkInsertar.CheckedChanged += (s, ev) =>
             {
                 if (this.checkInsertar.Checked)
                 {
                     this.checkInsertar.Text = "Activado";
                     this.checkInsertar.BackColor = Color.Green;
                 }
                 else
                 {
                     this.checkInsertar.Text = "Desactivado";
                     this.checkInsertar.BackColor = Color.Gray;
                 }
             };
            //Estilo para check box modificar 
            this.checkModificar.Appearance = Appearance.Button;
            this.checkModificar.Text = "Desactivado";
            this.checkModificar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkModificar.Size = new Size(100, 30);
            this.checkModificar.CheckedChanged += (s, ev) =>
            {
                if (this.checkModificar.Checked)
                {
                    this.checkModificar.Text = "Activado";
                    this.checkModificar.BackColor = Color.Green;
                }
                else
                {
                    this.checkModificar.Text = "Desactivado";
                    this.checkModificar.BackColor = Color.Gray;
                }
            };

            //Estilo para check box consultar 
            this.checkConsultar.Appearance = Appearance.Button;
            this.checkConsultar.Text = "Desactivado";
            this.checkConsultar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkConsultar.Size = new Size(100, 30);
            this.checkConsultar.CheckedChanged += (s, ev) =>
            {
                if (this.checkConsultar.Checked)
                {
                    this.checkConsultar.Text = "Activado";
                    this.checkConsultar.BackColor = Color.Green;
                }
                else
                {
                    this.checkConsultar.Text = "Desactivado";
                    this.checkConsultar.BackColor = Color.Gray;
                }
            };

            //Estilo para check box Eliminar 
            this.checkBorrar.Appearance = Appearance.Button;
            this.checkBorrar.Text = "Desactivado";
            this.checkBorrar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkBorrar.Size = new Size(100, 30);
            this.checkBorrar.CheckedChanged += (s, ev) =>
            {
                if (this.checkBorrar.Checked)
                {
                    this.checkBorrar.Text = "Activado";
                    this.checkBorrar.BackColor = Color.Green;
                }
                else
                {
                    this.checkBorrar.Text = "Desactivado";
                    this.checkBorrar.BackColor = Color.Gray;
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var permiso = this.GetPermisoUsuario();
            if (permiso != null)
            {
                var respuesta = servicioPermisosDirectos.Agregar(permiso);
                if (respuesta == "Agregado correctamente.")
                {
                    this.frmUsuarios.cargarPermisos(permiso.IdUsuario);
                    MessageBox.Show(respuesta);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(respuesta);
                }
            }
        }
        public PermisoUsuario GetPermisoUsuario()
        {
            string IdUsuario = this.comboIdUsuario.SelectedItem.ToString();
            string IdPantalla = this.comboIdPantalla.SelectedItem.ToString();
            char Insertar = 'S';
            char Modificar = 'S';
            char Borrar = 'S';
            char Consultar = 'S';

            if (!this.checkInsertar.Checked)
            {
                Insertar = 'N';
            }
            if (!this.checkModificar.Checked)
            {
                Modificar = 'N';
            }
            if (!this.checkBorrar.Checked)
            {
                Modificar = 'N';
            }
            if (!this.checkConsultar.Checked)
            {
                Consultar = 'N';
            }

            return new PermisoUsuario
            {
                IdUsuario = int.Parse(IdUsuario),
                IdPantalla = int.Parse(IdPantalla),
                Insertar = Insertar,
                Modificar = Modificar,
                Borrar = Borrar,
                Consultar = Consultar,
                FechaCreacion = DateTime.Now
            };
        }
    }
}
