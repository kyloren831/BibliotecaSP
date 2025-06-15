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

namespace BibliotecaSP
{
    public partial class Login : Form
    {
        private ServicioUsuarios servicioUsuarios;
        public Login()
        {
            InitializeComponent();
            this.servicioUsuarios = new ServicioUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea salir del sistema?", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtPass.Text)) 
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                var correo = this.txtCorreo.Text;
                var clave = this.txtPass.Text;
                var response = servicioUsuarios.Autenticar(correo,clave);

                switch (response)
                {
                    case -1:
                        MessageBox.Show("Correo no encontrado");
                        break;
                    case 0:
                        MessageBox.Show("Credenciales no validas");
                        break;
                    case 1:
                        MessageBox.Show("Autenticado");
                        break;
                }
            }
                
        }
    }
}
