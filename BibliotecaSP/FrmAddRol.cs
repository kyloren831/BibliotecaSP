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
    public partial class FrmAddRol : Form
    {
        private ServicioRoles servicioRoles;

        public FrmRoles FrmRoles { get; }
        public Rol? Rol { get; }

        public FrmAddRol(ServicioRoles servicioRoles, FrmRoles FrmRoles, Rol? rol =null)
        {
            InitializeComponent();
            this.servicioRoles = servicioRoles;
            this.FrmRoles = FrmRoles;
            Rol = rol;
            cargarDatos();
        }

        public void cargarDatos()
        {
            if (Rol != null)
            {
                this.txtId.Text=Rol.IdRol.ToString();
                this.txtId.ReadOnly = true;
                this.txtNombre.Text=Rol.NombreRol.ToString();
            }
        }
        private void btnCancelar_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txtId.Text))
            {
                MessageBox.Show("Debe agregar un ID");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Debe agregar un nombre");
                return false;
            }
            return true;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (Rol != null)
                {
                    Editar();
                }
                else
                {
                    Agregar();
                }
            }
        }
        public void Agregar()
        {
            Rol rol = new Rol { IdRol = int.Parse(this.txtId.Text), NombreRol = this.txtNombre.Text };
            var respuesta = servicioRoles.Agregar(rol);

            if (respuesta == "Agregado correctamente.")
            {
                MessageBox.Show(respuesta);
                this.FrmRoles.cargarRoles();
                this.Close();
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }
        public void Editar()
        {
            Rol rol = new Rol { IdRol = int.Parse(this.txtId.Text), NombreRol = this.txtNombre.Text };
            var respuesta = servicioRoles.Editar(rol);

            if (respuesta == "Editado correctamente.")
            {
                MessageBox.Show(respuesta);
                this.FrmRoles.cargarRoles();
                this.Close();
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }
    }
}
