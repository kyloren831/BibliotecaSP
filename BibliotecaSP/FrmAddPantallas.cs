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
    public partial class FrmAddPantallas : Form
    {
        public Sistema Sistema { get; }
        public ServicioPantallas ServicioPantallas { get; }
        public FrmSistemas FrmSistemas { get; }
        public Pantalla? Pantalla { get; }

        public FrmAddPantallas(Sistema sistema, ServicioPantallas servicioPantallas, FrmSistemas frmSistemas, Pantalla? pantalla = null)
        {
            InitializeComponent();
            Sistema = sistema;
            ServicioPantallas = servicioPantallas;
            FrmSistemas = frmSistemas;
            Pantalla = pantalla;
            this.lbVentana.Text = "Agregar Pantalla -- " + Sistema.Nombre;
            if(this.Pantalla!= null)
            {
                this.txtID.Text = Pantalla.IdPantalla.ToString();
                this.txtID.ReadOnly = true;
                this.txtNombre.Text = Pantalla.Nombre.ToString();
                this.lbVentana.Text = "Editar Pantalla -- " + Sistema.Nombre;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (this.Pantalla == null)
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

            var pantalla = this.GetPantalla();
            if (pantalla != null)
            {
                var respuesta = this.ServicioPantallas.Agregar(pantalla);
                if (respuesta == "Agregado correctamente.")
                {
                    this.FrmSistemas.cargarPantallas(Sistema.IdSistema);
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
            var pantallaEditada = this.GetPantalla();
            var respuesta = this.ServicioPantallas.Editar(pantallaEditada);

            if (respuesta == "Editado correctamente.")
            {
                this.FrmSistemas.cargarPantallas(Sistema.IdSistema);
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
                MessageBox.Show("Ingrese el Nombre de la pantalla");
                return false;
            }
            return true;
        }
        private Pantalla GetPantalla()
        {

            return new Pantalla
            {
                IdSistema = this.Sistema.IdSistema,
                IdPantalla = int.Parse(this.txtID.Text),
                Nombre = this.txtNombre.Text,
                FechaCreacion = DateTime.Now
            };
        }
    }
}
