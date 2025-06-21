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
    public partial class FrmAddSistema : Form
    {
        private ServicioSistemas servicioSistemas { get; }

        public FrmSistemas FrmSistemas { get; }
        public Sistema? Sistema { get; set; }

        public FrmAddSistema(ServicioSistemas servicioSistemas, FrmSistemas frmSistemas, Sistema? sistema = null)
        {
            InitializeComponent();
            this.servicioSistemas = servicioSistemas;
            FrmSistemas = frmSistemas;
            Sistema = sistema;

            if(this.Sistema!= null)
            {
                this.lbEtiqueta.Text = "Editar Sistema";
                this.txtID.Text=Sistema.IdSistema.ToString();
                this.txtID.ReadOnly = true;
                this.txtNombre.Text=Sistema.Nombre.ToString();
                this.txtRuta.Text=Sistema.RutaEjecutable.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (this.Sistema == null)
                {
                    Agregar();
                }
                else
                {
                    Editar();
                }

            }
        }

        public void Agregar()
        {
           
            var sistema = this.GetSistema();
            if (sistema != null)
            {
                var respuesta = this.servicioSistemas.Agregar(sistema);
                if (respuesta == "Agregado correctamente.")
                {
                    this.FrmSistemas.cargarSistemas();
                    MessageBox.Show(respuesta);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(respuesta);
                }
            }
        }
        private void Editar()
        {
            var permisoEditado = this.GetSistema();
            var respuesta = this.servicioSistemas.Editar(permisoEditado);

            if (respuesta == "Editado correctamente.")
            {
                this.FrmSistemas.cargarSistemas();
                MessageBox.Show(respuesta);
                this.Close();
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }
        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(this.txtID.Text))
            {
                MessageBox.Show("Ingrese el ID");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre del sistema");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtRuta.Text))
            {
                MessageBox.Show("Ingrese la ruta del ejecutable...");
                return false;
            }
            return true;
        }
        private Sistema GetSistema()
        {
            
            return new Sistema
            {
                IdSistema=int.Parse(this.txtID.Text),
                Nombre=this.txtNombre.Text,
                RutaEjecutable=this.txtRuta.Text,
                FechaCreacion=DateTime.Now
            };
        }

       
    }
}
