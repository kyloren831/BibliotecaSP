using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Servicios;
using DAL.Models;

namespace BibliotecaSP
{
    public partial class FrmPermisoRol : Form
    {

        private ServicioPermisosRol servicioPermisosRol { get; }
        private FrmRoles frmRoles;
        private string ID;
        private List<string> idsPantallas;
        private PermisoRol? PermisoRol;


        public FrmPermisoRol(FrmRoles frmRoles, ServicioPermisosRol servicioPermisosRol, List<string> idsPantallas, string IdRol)
        {
            InitializeComponent();
            this.servicioPermisosRol = servicioPermisosRol;
            this.idsPantallas = idsPantallas;
            this.ID = IdRol;
            this.frmRoles = frmRoles;
            aparienciaCheks();
        }
        public FrmPermisoRol(FrmRoles frmRoles, ServicioPermisosRol servicioPermisosRol, List<string> idsPantallas, PermisoRol PermisoRol)
        {
            InitializeComponent();
            this.lbTitulo.Text = "Editar permisos";
            this.servicioPermisosRol = servicioPermisosRol;
            this.idsPantallas = idsPantallas;
            this.PermisoRol = PermisoRol;
            this.frmRoles = frmRoles;
            aparienciaCheks();
            cargarPermisos();
        }
        private void cargarPermisos()
        {
            if (PermisoRol != null)
            {

                if (PermisoRol.Insertar == 'S')
                {
                    this.checkInsertar.Checked = true;
                    this.checkInsertar.Text = "Activado";
                    this.checkInsertar.BackColor = Color.Green;
                }
                else
                {
                    this.checkInsertar.Text = "Desactivado";
                    this.checkInsertar.BackColor = Color.Gray;
                }
                if (PermisoRol.Modificar == 'S')
                {
                    this.checkModificar.Checked = true;
                    this.checkInsertar.Text = "Activado";
                    this.checkModificar.BackColor = Color.Green;
                }
                else
                {
                    this.checkModificar.Text = "Desactivado";
                    this.checkModificar.BackColor = Color.Gray;
                }
                if (PermisoRol.Borrar == 'S')
                {
                    this.checkBorrar.Checked = true;
                    this.checkBorrar.Text = "Activado";
                    this.checkBorrar.BackColor = Color.Green;
                }
                else
                {
                    this.checkBorrar.Text = "Desactivado";
                    this.checkBorrar.BackColor = Color.Gray;
                }
                if (PermisoRol.Consultar == 'S')
                {
                    this.checkConsultar.Checked = true;
                    this.checkConsultar.Text = "Activado";
                    this.checkConsultar.BackColor = Color.Green;
                }
                else
                {
                    this.checkConsultar.Text = "Desactivado";
                    this.checkConsultar.BackColor = Color.Gray;
                }

            }

        }
        private void cargarCombos()
        {
            if (this.PermisoRol != null)
            {
                this.ID = PermisoRol.IdRol.ToString();
                this.lbID.Text = "ID Rol: ";

            }

            this.lbIdUsuario.Text = ID;

            foreach (var item in idsPantallas)
            {
                this.comboIdPantalla.Items.Add(item);
            }
            comboIdPantalla.SelectedIndex = 0;
        }
        private void FrmPermisoRol_Load(object sender, EventArgs e)
        {
            cargarCombos();
            eventoCheks();
        }
        public void aparienciaCheks()
        {
            this.checkInsertar.Appearance = Appearance.Button;
            this.checkInsertar.Text = "Desactivado";
            this.checkInsertar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkInsertar.Size = new Size(100, 30);

            //Estilo para check box modificar 
            this.checkModificar.Appearance = Appearance.Button;
            this.checkModificar.Text = "Desactivado";
            this.checkModificar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkModificar.Size = new Size(100, 30);


            //Estilo para check box consultar 
            this.checkConsultar.Appearance = Appearance.Button;
            this.checkConsultar.Text = "Desactivado";
            this.checkConsultar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkConsultar.Size = new Size(100, 30);


            //Estilo para check box Eliminar 
            this.checkBorrar.Appearance = Appearance.Button;
            this.checkBorrar.Text = "Desactivado";
            this.checkBorrar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkBorrar.Size = new Size(100, 30);
        }
        private void eventoCheks()
        {

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

        private void AgregarPermisoRol()
        {
            var permiso = this.GetPermisos();
            if (permiso != null)
            {
                var respuesta = servicioPermisosRol.Agregar(permiso);
                if (respuesta == "Agregado correctamente.")
                {
                    this.frmRoles.cargarPermisos(permiso.IdRol);
                    MessageBox.Show(respuesta);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(respuesta);
                }
            }
        }

        private void EditarPermisoRol()
        {
            var permisoEditado = this.GetPermisos();
            var respuesta = this.servicioPermisosRol.Editar(permisoEditado);

            if (respuesta == "Editado correctamente.")
            {
                this.frmRoles.cargarPermisos(permisoEditado.IdRol);
                MessageBox.Show(respuesta);
                this.Close();
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }
        public PermisoRol GetPermisos()
        {
            string Id = this.lbIdUsuario.Text;
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
                Borrar = 'N';
            }
            if (!this.checkConsultar.Checked)
            {
                Consultar = 'N';
            }
            return new PermisoRol
            {
                IdRol = int.Parse(Id),
                IdPantalla = int.Parse(IdPantalla),
                Insertar = Insertar,
                Modificar = Modificar,
                Borrar = Borrar,
                Consultar = Consultar,
                FechaCreacion = DateTime.Now
            };


        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.PermisoRol == null)
            {
                AgregarPermisoRol();
            }
            else
            {
                EditarPermisoRol();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
