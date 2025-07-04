﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using BLL.Servicios;
using DAL.Models;

namespace BibliotecaSP
{
    public partial class FrmPermisoUsuario : Form
    {
        private ServicioPermisosDirectos servicioPermisosDirectos;

        private FrmRoles FrmRoles { get; }
        private ServicioPermisosRol servicioPermisosRol { get; }

        private FrmUsuarios frmUsuarios;
        private string ID;
        private List<string> idsPantallas;
        private PermisoUsuario? PermisoUsuario;

        public PermisoRol? PermisoRol { get; }

        public FrmPermisoUsuario(FrmUsuarios frmUsuarios,ServicioPermisosDirectos servicioPermisosDirectos, List<string> idsPantallas, string idsUsuarios)
        {
            InitializeComponent();
            this.servicioPermisosDirectos = servicioPermisosDirectos;
            this.idsPantallas = idsPantallas;
            this.ID = idsUsuarios;
            this.frmUsuarios = frmUsuarios;
            aparienciaCheks();
        }
        public FrmPermisoUsuario(FrmUsuarios frmUsuarios, ServicioPermisosDirectos servicioPermisosDirectos, List<string> idsPantallas, PermisoUsuario permisoUsuario )
        {
            InitializeComponent();
            this.lbTitulo.Text = "Editar permisos";
            this.servicioPermisosDirectos = servicioPermisosDirectos;
            this.idsPantallas = idsPantallas;
            this.PermisoUsuario = permisoUsuario;
            this.frmUsuarios = frmUsuarios;
            aparienciaCheks();
            cargarPermisos();
        }

        

        private void cargarPermisos()
        {
            if (PermisoUsuario != null ) {

                if (PermisoUsuario.Insertar == 'S')
                {
                    this.checkInsertar.Checked = true;
                    this.checkInsertar.Text = "Activado";
                    this.checkInsertar.BackColor = Color.Green;
                }
                else 
                {
                    this.checkInsertar.Text = "Desactivado";
                    this.checkInsertar.BackColor = Color.Gray;
                }
                if (PermisoUsuario.Modificar == 'S')
                {
                    this.checkModificar.Checked = true;
                    this.checkInsertar.Text = "Activado";
                    this.checkModificar.BackColor = Color.Green;
                }
                else 
                {
                    this.checkModificar.Text = "Desactivado";
                    this.checkModificar.BackColor = Color.Gray;
                }
                if (PermisoUsuario.Borrar == 'S' )
                {
                    this.checkBorrar.Checked = true; 
                    this.checkBorrar.Text = "Activado";
                    this.checkBorrar.BackColor = Color.Green;
                }
                else 
                {
                    this.checkBorrar.Text = "Desactivado";
                    this.checkBorrar.BackColor = Color.Gray;
                }
                if (PermisoUsuario.Consultar == 'S' )
                {
                    this.checkConsultar.Checked = true;
                    this.checkConsultar.Text = "Activado";
                    this.checkConsultar.BackColor = Color.Green;
                }
                else 
                {
                    this.checkConsultar.Text = "Desactivado";
                    this.checkConsultar.BackColor = Color.Gray;
                }

            }

        }
        private void cargarCombos()
        {
            if(this.PermisoUsuario!= null)
            {
                this.ID = PermisoUsuario.IdUsuario.ToString();
                this.lbID.Text = "ID Usuario";
            }
            
            this.lbIdUsuario.Text= ID;
            
            foreach (var item in idsPantallas)
            {
                this.comboIdPantalla.Items.Add(item);
            }
            comboIdPantalla.SelectedIndex = 0;
        }
        private void FrmPermisoUsuario_Load(object sender, EventArgs e)
        {
            cargarCombos();
            eventoCheks();
        }
        public void aparienciaCheks()
        {
            this.checkInsertar.Appearance = Appearance.Button;
            this.checkInsertar.Text = "Desactivado";
            this.checkInsertar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkInsertar.Size = new Size(100, 30);

            //Estilo para check box modificar 
            this.checkModificar.Appearance = Appearance.Button;
            this.checkModificar.Text = "Desactivado";
            this.checkModificar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkModificar.Size = new Size(100, 30);


            //Estilo para check box consultar 
            this.checkConsultar.Appearance = Appearance.Button;
            this.checkConsultar.Text = "Desactivado";
            this.checkConsultar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkConsultar.Size = new Size(100, 30);


            //Estilo para check box Eliminar 
            this.checkBorrar.Appearance = Appearance.Button;
            this.checkBorrar.Text = "Desactivado";
            this.checkBorrar.TextAlign = ContentAlignment.MiddleCenter;
            this.checkBorrar.Size = new Size(100, 30);
        }
        private void eventoCheks()
        {
            
            this.checkInsertar.CheckedChanged += (s, ev) =>
            {
                if (this.checkInsertar.Checked)
                {
                    this.checkInsertar.Text = "Activado";
                    this.checkInsertar.BackColor = Color.Green;
                }
                else
                {
                    this.checkInsertar.Text = "Desactivado";
                    this.checkInsertar.BackColor = Color.Gray;
                }
            };
           
            this.checkModificar.CheckedChanged += (s, ev) =>
            {
                if (this.checkModificar.Checked)
                {
                    this.checkModificar.Text = "Activado";
                    this.checkModificar.BackColor = Color.Green;
                }
                else
                {
                    this.checkModificar.Text = "Desactivado";
                    this.checkModificar.BackColor = Color.Gray;
                }
            };

            this.checkConsultar.CheckedChanged += (s, ev) =>
            {
                if (this.checkConsultar.Checked)
                {
                    this.checkConsultar.Text = "Activado";
                    this.checkConsultar.BackColor = Color.Green;
                }
                else
                {
                    this.checkConsultar.Text = "Desactivado";
                    this.checkConsultar.BackColor = Color.Gray;
                }
            };

            this.checkBorrar.CheckedChanged += (s, ev) =>
            {
                if (this.checkBorrar.Checked)
                {
                    this.checkBorrar.Text = "Activado";
                    this.checkBorrar.BackColor = Color.Green;
                }
                else
                {
                    this.checkBorrar.Text = "Desactivado";
                    this.checkBorrar.BackColor = Color.Gray;
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if(this.PermisoUsuario == null && this.frmUsuarios != null)
            {
                Agregar();
            }
            else if(this.PermisoUsuario != null && this.frmUsuarios != null)
            {
                Editar();
            } 
        }

       

        public void Agregar()
        {
            var permiso =(PermisoUsuario) this.GetPermisoUsuario();
            if (permiso != null)
            {
                var respuesta = servicioPermisosDirectos.Agregar(permiso);
                if (respuesta == "Agregado correctamente.")
                {
                    this.frmUsuarios.cargarPermisos(permiso.IdUsuario);
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
            var permisoEditado =  this.GetPermisoUsuario();
            var respuesta = this.servicioPermisosDirectos.Editar(permisoEditado);

            if (respuesta == "Editado correctamente.")
            {
                this.frmUsuarios.cargarPermisos(permisoEditado.IdUsuario);
                MessageBox.Show(respuesta);
                this.Close();
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }
        public PermisoUsuario GetPermisoUsuario()
        {
            string Id = this.lbIdUsuario.Text;
            string IdPantalla = this.comboIdPantalla.SelectedItem.ToString();
            char Insertar = 'S';
            char Modificar = 'S';
            char Borrar = 'S';
            char Consultar = 'S';

            if (!this.checkInsertar.Checked)
            {
                Insertar = 'N';
            }
            if (!this.checkModificar.Checked)
            {
                Modificar = 'N';
            }
            if (!this.checkBorrar.Checked)
            {
                Borrar = 'N';
            }
            if (!this.checkConsultar.Checked)
            {
                Consultar = 'N';
            }
                return new PermisoUsuario
                {
                    IdUsuario = int.Parse(Id),
                    IdPantalla = int.Parse(IdPantalla),
                    Insertar = Insertar,
                    Modificar = Modificar,
                    Borrar = Borrar,
                    Consultar = Consultar,
                    FechaCreacion = DateTime.Now
                };
           
           
        }
    }
}
