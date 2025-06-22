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
    public partial class FrmSistemas : Form
    {
        private ServicioSistemas servicioSistemas;
        private ServicioPantallas servicioPantallas;
        private List<Sistema> sistemaList;
        public FrmSistemas()
        {
            InitializeComponent();
            this.servicioSistemas = new ServicioSistemas();
            this.servicioPantallas = new ServicioPantallas();
            cargarSistemas();
        }


        public void cargarSistemas()
        {
            this.sistemaList = servicioSistemas.Listar();
            if (sistemaList != null)
            {
                cargarGrid<Sistema>(this.dataGridSistemas, sistemaList);
            }
        }

        private void dataGridSistemas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridSistemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si hay filas seleccionadas
            if (dataGridSistemas.SelectedRows.Count == 1)
            {
                // Obtener el valor de la primera columna de la fila seleccionada
                var idSistema = dataGridSistemas.SelectedRows[0].Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(idSistema))
                {
                    cargarPantallas(int.Parse(idSistema));
                }
            }
        }

        public void cargarPantallas(int idSistema)
        {
            var lista = this.servicioPantallas.ListarPantallas(idSistema);
            cargarGrid<PantallaDTO>(this.dataGridPantallas, lista);
        }

        private void EditarSistema_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridSistemas.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dataGridSistemas.SelectedRows[0];
                    var idSistema = filaSeleccionada.Cells[0].Value.ToString();
                    if (idSistema != null)
                    {
                        var sistema = this.servicioSistemas.Buscar(int.Parse(idSistema));
                        if (sistema != null)
                        {
                            FrmAddSistema frm = new FrmAddSistema(this.servicioSistemas, this, sistema);
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

        private void EliminarSistema_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridSistemas.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dataGridSistemas.SelectedRows[0];
                    var idSistema = filaSeleccionada.Cells[0].Value.ToString();
                    if (idSistema != null)
                    {
                        var result = MessageBox.Show("Se eliminaran las pantallas relacionadas", "¿Desea eliminar el sistema?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            var respuesta = this.servicioSistemas.Eliminar(int.Parse(idSistema));
                            if (respuesta == "Eliminado correctamente.")
                            {
                                cargarSistemas();
                                cargarPantallas(0);
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

        private void btnAddSistema_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddSistema frm = new FrmAddSistema(this.servicioSistemas, this);
                frm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPantallas_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridSistemas.SelectedRows.Count == 1)
                {

                    var idSistema = dataGridSistemas.SelectedRows[0].Cells[0].Value.ToString();

                    if (!string.IsNullOrEmpty(idSistema))
                    {

                        var sistema = servicioSistemas.Buscar(int.Parse(idSistema));
                        if (sistema != null)
                        {

                            FrmAddPantallas frm = new FrmAddPantallas(sistema, this.servicioPantallas, this);
                            frm.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un sistema");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEditarPantalla_Click(object sender, EventArgs e)
        {

            if (this.dataGridPantallas.SelectedRows.Count == 1 && this.dataGridSistemas.SelectedRows.Count == 1)
            {

                var idSistema = dataGridSistemas.SelectedRows[0].Cells[0].Value.ToString();
                var idPantalla = dataGridPantallas.SelectedRows[0].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(idSistema) && !string.IsNullOrEmpty(idPantalla))
                {

                    var sistema = servicioSistemas.Buscar(int.Parse(idSistema));
                    var pantalla = servicioPantallas.Buscar(int.Parse(idPantalla));
                    if (sistema != null && pantalla != null)
                    {
                        FrmAddPantallas frm = new FrmAddPantallas(sistema, this.servicioPantallas, this, pantalla);
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Pantalla");
            }
        }

        private void btnEliminarPantalla_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridPantallas.SelectedRows.Count == 1 && this.dataGridSistemas.SelectedRows.Count == 1)
                {
                    DataGridViewRow filaSeleccionada = dataGridPantallas.SelectedRows[0];
                    var idPantalla = filaSeleccionada.Cells[0].Value.ToString();
                    DataGridViewRow filaSeleccionadaS = dataGridSistemas.SelectedRows[0];
                    var idSistema = filaSeleccionadaS.Cells[0].Value.ToString();
                    if (idPantalla != null && idSistema != null)
                    {
                        var result = MessageBox.Show("Se eliminaran los permisos asociados", "¿Desea eliminar esta pantalla?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            var respuesta = this.servicioPantallas.Eliminar(int.Parse(idPantalla));
                            if (respuesta == "Eliminado correctamente.")
                            {
                                cargarPantallas(int.Parse(idSistema));
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

        private void FrmSistemas_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtFiltro.Text.ToLower();
            var Filtrados = new List<Sistema>();// Obtener el texto de búsqueda

            if (string.IsNullOrEmpty(searchValue))
            {
                // Si no hay texto, mostrar todos los registros
                Filtrados = this.sistemaList.ToList();
                cargarGrid<Sistema>(this.dataGridSistemas, Filtrados);
            }
            else
            {
                if (searchValue != "Buscar por Nombre o por ID".ToLower())
                {
                    Filtrados = this.sistemaList.Where(c => c.Nombre.Contains(searchValue) ||
                                          c.IdSistema.ToString().Contains(searchValue)).ToList();

                    cargarGrid<Sistema>(this.dataGridSistemas, Filtrados);
                }

            }
        }

        private void txtFiltroSistema_leave(object sender, EventArgs e)
        {
            this.txtFiltro.Text = "Buscar por Nombre o por ID";
        }

        private void txtFiltroPantalla_Changed(object sender, EventArgs e)
        {

        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            this.txtFiltro.Text = "";
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
    }
}
