﻿using System;
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
    public partial class FrmUsuarios : Form
    {
        //Servicios
        private ServicioUsuarios servicioUsuarios;
        private ServicioPermisosDirectos servicioPermisosDirectos;
        private ServicioPantallas servicioPantallas;
        private ServicioUsuarioRol servicioUsuarioRol;

        //
        private List<Usuario> listaUsuarios = null;
        public FrmUsuarios()
        {
            InitializeComponent();
            this.servicioUsuarios = new ServicioUsuarios();
            this.servicioPantallas = new ServicioPantallas();
            this.servicioPermisosDirectos = new ServicioPermisosDirectos();
            this.servicioUsuarioRol = new ServicioUsuarioRol();
            cargarUsuarios();
        }
        public void cargarUsuarios()
        {
            this.listaUsuarios = servicioUsuarios.ListarUsuarios();
            if (listaUsuarios != null)
            {
                cargarGrid<Usuario>(this.dataGridUsuarios, listaUsuarios);
            }
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
        public void cargarPermisos(int id)
        {
            var lista = this.servicioPermisosDirectos.Listar(id);
            if (lista != null)
            {
                cargarGrid<PermisosUsuarioDTO>(this.dataGridPermisos, lista, new List<string> { "IdUsuario", "IdPantalla" });
            }
        }
        public void cargarRoles(int id)
        {
            var lista = this.servicioUsuarioRol.Listar(id);
            if (lista != null)
            {
                cargarGrid<UsuarioRolDTO>(this.dataGridRoles, lista, new List<string> { "IdUsuario", "IdRol" });
            }
        }
        private void girUsrs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si hay filas seleccionadas
            if (dataGridUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el valor de la primera columna de la fila seleccionada
                var idUsuario = dataGridUsuarios.SelectedRows[0].Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(idUsuario))
                {
                    cargarPermisos(int.Parse(idUsuario));
                    cargarRoles(int.Parse(idUsuario));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var pantallas = servicioPantallas.ListarPantallas();
                if (pantallas != null)
                {
                    if (this.dataGridUsuarios.SelectedRows.Count > 0)
                    {
                        List<string> idsPantallas = new List<string>();

                        var idUsuario = dataGridUsuarios.SelectedRows[0].Cells[0].Value.ToString();

                        if (!string.IsNullOrEmpty(idUsuario))
                        {

                            foreach (var item in pantallas)
                            {
                                idsPantallas.Add(item.IdPantalla.ToString());
                            }
                            FrmPermisoUsuario frm = new FrmPermisoUsuario(this, this.servicioPermisosDirectos, idsPantallas, idUsuario);
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un usuario");
                    }

                }
                else
                {
                    MessageBox.Show("No hay usuarios o pantallas disponibles");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtFiltro.Text.ToLower();
            var usuariosFiltrados = new List<Usuario>();// Obtener el texto de búsqueda

            if (string.IsNullOrEmpty(searchValue))
            {
                // Si no hay texto, mostrar todos los registros
                usuariosFiltrados = this.listaUsuarios.ToList();
                cargarGrid<Usuario>(this.dataGridUsuarios, usuariosFiltrados);
            }
            else
            {
                if (searchValue != "Buscar por correo o por nombre".ToLower())
                {
                    usuariosFiltrados = this.listaUsuarios.Where(c => c.Nombre.Contains(searchValue) ||
                                          c.Correo.ToString().Contains(searchValue)).ToList();

                    cargarGrid<Usuario>(this.dataGridUsuarios, usuariosFiltrados);
                }

            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            this.txtFiltro.Text = "";
        }

        private void btnFiltrar_Leave(object sender, EventArgs e)
        {

            this.txtFiltro.Text = "Buscar por correo o por nombre";
        }

        private void eliminarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridUsuarios.SelectedRows.Count > 0 && this.dataGridRoles.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dataGridRoles.SelectedRows[0];
                    var idUsuario = filaSeleccionada.Cells[0].Value.ToString();
                    var idRol = filaSeleccionada.Cells[1].Value.ToString();
                    if (idUsuario != null && idRol != null)
                    {
                        var respuesta = this.servicioUsuarioRol.Eliminar(int.Parse(idUsuario), int.Parse(idRol));
                        if (respuesta == "Eliminado correctamente.")
                        {
                            cargarRoles(int.Parse(idUsuario));
                            MessageBox.Show(respuesta);
                        }
                        else
                        {
                            MessageBox.Show(respuesta);
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

        private void editarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridUsuarios.SelectedRows.Count > 0 && this.dataGridPermisos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dataGridPermisos.SelectedRows[0];
                    var idUsuario = filaSeleccionada.Cells[0].Value.ToString();
                    var idPantalla = filaSeleccionada.Cells[1].Value.ToString();
                    if (idUsuario != null && idPantalla != null)
                    {
                        var respuesta = this.servicioPermisosDirectos.Buscar(int.Parse(idPantalla), int.Parse(idUsuario));
                        if (respuesta != null)
                        {
                            List<string> idsPantallas = new List<string>();

                            idsPantallas.Add(respuesta.IdPantalla.ToString());

                            FrmPermisoUsuario frm = new FrmPermisoUsuario(this, this.servicioPermisosDirectos, idsPantallas, respuesta);
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
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

        private void eliminarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridUsuarios.SelectedRows.Count > 0 && this.dataGridPermisos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dataGridPermisos.SelectedRows[0];
                    var idUsuario = filaSeleccionada.Cells[0].Value.ToString();
                    var idPantalla = filaSeleccionada.Cells[1].Value.ToString();
                    if (idUsuario != null && idPantalla != null)
                    {
                        if (MessageBox.Show("¿Desea eliminar los permisos de la pantalla " + idPantalla + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            var respuesta = this.servicioPermisosDirectos.Eliminar(int.Parse(idUsuario), int.Parse(idPantalla));
                            if (respuesta == "Eliminado correctamente.")
                            {
                                cargarPermisos(int.Parse(idUsuario));
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridUsuarios.SelectedRows.Count > 0 )
                {
                    DataGridViewRow filaSeleccionada = dataGridUsuarios.SelectedRows[0];
                    var idUsuario = filaSeleccionada.Cells[0].Value.ToString();
                    if (idUsuario != null)
                    {
                            FrmAsignarRol frm = new FrmAsignarRol(this,idUsuario, this.servicioUsuarioRol);
                            frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila...");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
