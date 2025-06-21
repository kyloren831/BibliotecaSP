using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using BLL.Servicios;
using DAL.Models;

namespace BibliotecaSP
{
    public partial class FrmAddUsuarios : Form
    {
        private ServicioUsuarios servicioUsuarios;
        private FrmUsuarios frmUsuarios;
        private Usuario? usuario;
        public FrmAddUsuarios(FrmUsuarios frmUsuarios)
        {
            InitializeComponent();
            this.servicioUsuarios = new ServicioUsuarios();
            comboActivo.SelectedIndex = 0;
            this.frmUsuarios = frmUsuarios;

        }
        public FrmAddUsuarios(FrmUsuarios frmUsuarios, Usuario usuario)
        {
            InitializeComponent();
            this.servicioUsuarios = new ServicioUsuarios();
            comboActivo.SelectedIndex = 0;
            this.frmUsuarios = frmUsuarios;
            this.usuario = usuario;
            this.lbTitulo.Text = "Editar Usuario";
            this.txtID.ReadOnly = true;
            setUsuario(this.usuario);
        }
        public bool validInputs()
        {
            if (string.IsNullOrEmpty(this.txtID.Text))
            {
                MessageBox.Show("Debe ingresar un id para el Usuario");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el Nombre del Usuario");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtCorreo.Text))
            {
                MessageBox.Show("Debe ingresar el correo del Usuario");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe ingresar la clave del Usuario");
                return false;
            }
            return true;
        }
        public void setUsuario(Usuario usuario)
        {
            this.txtID.Text = usuario.IdUsuario.ToString();
            this.txtNombre.Text = usuario.Nombre;
            this.txtCorreo.Text = usuario.Correo;
            this.txtClave.Text = usuario.Clave;
            if (usuario.Activo.ToString() == "N") comboActivo.SelectedIndex = 1;
        }
        private Usuario getUsuario()
        {
            if (validInputs())
            {
                var selectedIndex = this.comboActivo.SelectedItem.ToString();
                var activo = "N";
                if (selectedIndex == "Si")
                {
                    activo = "S";
                }
                var usuario = new Usuario
                {
                    IdUsuario = int.Parse(this.txtID.Text),
                    Nombre = this.txtNombre.Text,
                    Correo = this.txtCorreo.Text,
                    Clave = this.txtClave.Text,
                    Activo = char.Parse(activo),
                    FechaCreacion = DateTime.Now
                };
                return usuario;
            }
            else
            {
                return null;
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
            if (this.usuario == null)
            {
                var usuario = this.getUsuario();
                if (usuario != null)
                {
                    var respuesta = servicioUsuarios.Agregar(usuario);
                    if (respuesta == "Agregado correctamente.")
                    {
                        this.frmUsuarios.cargarUsuarios();
                        MessageBox.Show(respuesta);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(respuesta);
                    }
                }
            }
            else
            {
                var usuarioEditado = this.getUsuario();
                if (usuarioEditado != null)
                {
                    this.usuario.Nombre = usuarioEditado.Nombre;
                    this.usuario.Correo = usuarioEditado.Correo;
                    this.usuario.Clave = usuarioEditado.Clave;
                    this.usuario.Activo = usuarioEditado.Activo;
                    var respuesta = servicioUsuarios.Editar(usuario);
                    if (respuesta == "Editado correctamente.")
                    {
                        this.frmUsuarios.cargarUsuarios();
                        MessageBox.Show(respuesta);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(respuesta);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
