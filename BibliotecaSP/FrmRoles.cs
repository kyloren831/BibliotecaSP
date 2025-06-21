using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.DTOs;
using BLL.Servicios;
using DAL.Models;

namespace BibliotecaSP
{
    public partial class FrmRoles : Form
    {
        private ServicioRoles servicioRoles;
        private ServicioPermisosRol servicioPermisosRol;
        private ServicioPantallas ServicioPantallas;
        public FrmRoles()
        {
            InitializeComponent();
            this.servicioRoles = new ServicioRoles();
            this.servicioPermisosRol = new ServicioPermisosRol();
            this.ServicioPantallas = new ServicioPantallas();
            cargarRoles();
        }
        public void cargarRoles()
        {
            var lista = this.servicioRoles.Listar();
            cargarGrid<Rol>(this.dataGridRoles, lista);
        }
        private void cargarGrid<T>(DataGridView dataGrid, List<T> items, List<string> columnasAOcultar = null)
        {
            dataGrid.Columns.Clear();
            var data = new BindingList<T>(items);
            dataGrid.DataSource = data;

            // Cambiar el color de fondo de todas las filas
            dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Color para filas alternas
            dataGrid.DefaultCellStyle.ForeColor = Color.Black;  // Color de texto predeterminado

            if (columnasAOcultar != null)
            {
                foreach (var columna in columnasAOcultar)
                {
                    if (dataGrid.Columns.Contains(columna))
                    {
                        dataGrid.Columns[columna].Visible = false;
                    }
                }
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddRol frm = new FrmAddRol(this.servicioRoles, this);
            frm.ShowDialog();
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dataGridRoles.SelectedRows.Count == 1)
                {
                    DataGridViewRow filaSeleccionada = dataGridRoles.SelectedRows[0];
                    var idRol = filaSeleccionada.Cells[0].Value.ToString();
                    if (idRol != null)
                    {
                        var result = MessageBox.Show("Tambien eliminará relaciones", "¿Desea eliminar el sistema?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            var respuesta = this.servicioRoles.Eliminar(int.Parse(idRol));
                            if (respuesta == "Eliminado correctamente.")
                            {
                                cargarRoles();
                                //cargarPantallas(0);
                                MessageBox.Show(respuesta);
                            }
                            else
                            {
                                MessageBox.Show(respuesta);
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila...");
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {

            if (this.dataGridRoles.SelectedRows.Count == 1)
            {

                var IdRol = dataGridRoles.SelectedRows[0].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(IdRol))
                {

                    var rol = servicioRoles.Buscar(int.Parse(IdRol));
                    if (rol != null)
                    {
                        FrmAddRol frm = new FrmAddRol(servicioRoles, this, rol);
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Pantalla");
            }
        }
        public void cargarPermisos(int id)
        {
            var lista = this.servicioPermisosRol.Listar(id);
            if (lista != null)
            {
                cargarGrid<PermisosRolDTO>(this.dataGridPermisos, lista, new List<string> { "IdRol", "IdPantalla" });
            }
        }

        private void dataGridRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si hay filas seleccionadas
            if (dataGridRoles.SelectedRows.Count == 1)
            {
                // Obtener el valor de la primera columna de la fila seleccionada
                var idRol = dataGridRoles.SelectedRows[0].Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(idRol))
                {
                    cargarPermisos(int.Parse(idRol));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var pantallas = ServicioPantallas.ListarPantallas();
                if (pantallas != null)
                {
                    if (this.dataGridRoles.SelectedRows.Count == 1)
                    {

                        List<string> idsPantallas = new List<string>();

                        var IdRol = dataGridRoles.SelectedRows[0].Cells[0].Value.ToString();

                        if (!string.IsNullOrEmpty(IdRol))
                        {
                            foreach (var item in pantallas)
                            {
                                idsPantallas.Add(item.IdPantalla.ToString());
                            }
                            FrmPermisoRol frm = new FrmPermisoRol(this, this.servicioPermisosRol, idsPantallas, IdRol);
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un rol");
                    }
                }
                else
                {
                    MessageBox.Show("No hay roles o pantallas disponibles");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminarPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridPermisos.SelectedRows.Count == 1 && this.dataGridRoles.SelectedRows.Count == 1)
                {
                    DataGridViewRow filaSeleccionada = dataGridPermisos.SelectedRows[0];
                    var idPantalla = filaSeleccionada.Cells[1].Value.ToString();
                    DataGridViewRow filaSeleccionadaS = dataGridRoles.SelectedRows[0];
                    var idRol = filaSeleccionadaS.Cells[0].Value.ToString();
                    if (idPantalla != null && idRol != null)
                    {
                        var result = MessageBox.Show("Se eliminaran los permisos asociados", "¿Desea eliminar esta permiso?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            var respuesta = this.servicioPermisosRol.Eliminar(int.Parse(idRol), int.Parse(idPantalla));
                            if (respuesta == "Eliminado correctamente.")
                            {
                                cargarPermisos(int.Parse(idRol));
                                MessageBox.Show(respuesta);
                            }
                            else
                            {
                                MessageBox.Show(respuesta);
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila...");
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEditarPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridRoles.SelectedRows.Count ==1 && this.dataGridPermisos.SelectedRows.Count ==1)
                {
                    DataGridViewRow filaSeleccionada = dataGridPermisos.SelectedRows[0];
                    var idRol = filaSeleccionada.Cells[0].Value.ToString();
                    var idPantalla = filaSeleccionada.Cells[1].Value.ToString();
                    if (idRol != null && idPantalla != null)
                    {
                        var respuesta = this.servicioPermisosRol.Buscar(int.Parse(idPantalla), int.Parse(idRol));
                        if (respuesta != null)
                        {
                            List<string> idsPantallas = new List<string>();

                            idsPantallas.Add(respuesta.IdPantalla.ToString());

                            FrmPermisoRol frm = new FrmPermisoRol(this, this.servicioPermisosRol, idsPantallas, respuesta);
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Permiso no encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila...");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
