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
    public partial class FrmAsignarRol : Form
    {
        public FrmUsuarios FrmUsuarios { get; }
        private ServicioUsuarioRol ServicioUsuarioRol { get; }
        private ServicioRoles servicioRoles;
        private List<Rol> roles = null;

        public FrmAsignarRol(FrmUsuarios frmUsuarios, string idUsuario, ServicioUsuarioRol servicioUsuarioRol)
        {
            InitializeComponent();
            this.lbIdUsuario.Text = idUsuario;
            this.servicioRoles = new ServicioRoles();
            cargarComboRoles();
            this.comboIdPantalla.SelectedIndex = 0;
            FrmUsuarios = frmUsuarios;
            ServicioUsuarioRol = servicioUsuarioRol;
        }

        private void btnCancelar_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cargarComboRoles()
        {
            roles = new List<Rol>();
            roles = servicioRoles.Listar();
            if (roles.Count == 0)
            {
                MessageBox.Show("Error buscando roles...");
            }

            var i = 0;
            foreach (var item in roles)
            {
                this.comboIdPantalla.Items.Add(item.NombreRol);
                i++;
            }
        }
        private void FrmAsignarRol_Load(object sender, EventArgs e)
        {

        }

        public UsuarioRol getUsuarioRol()
        {
            return new UsuarioRol { IdRol = int.Parse(this.lbIdRol.Text), IdUsuario = int.Parse(this.lbIdUsuario.Text) };
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var UsuarioRol = getUsuarioRol();
            var respuesta = this.ServicioUsuarioRol.Agregar(UsuarioRol);
            if (respuesta == "Agregado correctamente.") 
            {
                this.FrmUsuarios.cargarRoles(UsuarioRol.IdUsuario);
                MessageBox.Show(respuesta);
                this.Close();
            }
            else
            {
                MessageBox.Show(respuesta);
            }

        }

        private void comboRoles_Changed(object sender, EventArgs e)
        {
            foreach (var item in roles)
            {
                if (item.NombreRol == this.comboIdPantalla.SelectedItem.ToString())
                {
                    lbIdRol.Text = item.IdRol.ToString();
                }
            }
        }
    }
}
