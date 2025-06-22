using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSP
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void ShowLogin()
        {
            try
            {   //se crea una instancia del formulario
                Login frmlog = new Login();

                //se muestra el formulario
                frmlog.ShowDialog();
                //se cierra
                frmlog.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del sistema", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        public void AbrirFormulario(Form frm)
        {
            try
            {
                // Limpiar el panel antes de agregar el nuevo formulario
                panelContenido1.Controls.Clear();

                // Establecer el formulario como un control dentro del panel
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                // Agregar el formulario al panel
                panelContenido1.Controls.Add(frm);

                // Mostrar el formulario
                frm.Show();

                // Forzar un refresco del panel para asegurarse de que se redibuje correctamente
                panelContenido.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message);
            }
        }

        private void btnUsuarios_Enter(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = Color.FromArgb(224, 218, 143);
        }

        private void btnUsuarios_Leave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            //frm.Show();
            this.AbrirFormulario(frm);
        }

        private void btnSistemas_Enter(object sender, EventArgs e)
        {
            btnSistemas.BackColor = Color.FromArgb(224, 218, 143);
        }

        private void btnSistemas_Leave(object sender, EventArgs e)
        {
            btnSistemas.BackColor = Color.FromArgb(255, 255, 192);
        }



        private void btnRoles_Enter(object sender, EventArgs e)
        {
            btnRoles.BackColor = Color.FromArgb(224, 218, 143);
        }
        private void btnRoles_Leave(object sender, EventArgs e)
        {
            btnRoles.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void btnSistemas_Click(object sender, EventArgs e)
        {
            FrmSistemas frm = new FrmSistemas();
            //frm.Show();
            this.AbrirFormulario(frm);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRoles frm = new FrmRoles();
            //frm.Show();
            this.AbrirFormulario(frm);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
