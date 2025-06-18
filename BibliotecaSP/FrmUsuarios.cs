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
    public partial class FrmUsuarios : Form
    {
        private ServicioUsuarios servicioUsuarios;
        private List<Usuario> usuarios;
        public FrmUsuarios()
        {
            InitializeComponent();
            this.servicioUsuarios = new ServicioUsuarios();
            cargarUsuarios();
        }
        public void cargarUsuarios()
        {
            var listaUsuarios = servicioUsuarios.ListarUsuarios();
            if (listaUsuarios != null)
            {
                cargarGrid<Usuario>(this.dataGridUsuarios, listaUsuarios);
            }
        }
        private void cargarGrid<T>(DataGridView dataGrid, List<T> items)
        {
            dataGrid.Columns.Clear();
            var data = new BindingList<T>(items);
            dataGrid.DataSource = data;

            // Cambiar el color de fondo de todas las filas
            dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Color para filas alternas
            dataGrid.DefaultCellStyle.ForeColor = Color.Black;  // Color de texto predeterminado
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUsuarios frm = new FrmAddUsuarios(this);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dataGridUsuarios.SelectedRows[0];
                    var idUsuario = filaSeleccionada.Cells[0].Value.ToString();
                    if (idUsuario != null)
                    {


                        var usuario = this.servicioUsuarios.Buscar(int.Parse(idUsuario));
                            if (usuario != null)
                            {
                                FrmAddUsuarios frm = new FrmAddUsuarios(this, usuario);
                                frm.ShowDialog();
                            }
                        
                        
                    }
                    
                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
