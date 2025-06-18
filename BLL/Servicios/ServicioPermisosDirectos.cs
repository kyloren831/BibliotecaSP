using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BLL.DTOs;
using DAL;
using DAL.Models;

namespace BLL.Servicios
{
    public class ServicioPermisosDirectos
    {
        private DbContextBiblioteca _context = null;

        public ServicioPermisosDirectos()
        {
            this._context = new DbContextBiblioteca();
        }

        public List<PermisosUsuarioDTO> Listar(int id)
        {
            var lista = new List<PermisosUsuarioDTO>();
            try
            {
                var query = from up in _context.PermisosUsuarios
                            join u in _context.Usuarios on up.IdUsuario equals u.IdUsuario
                            join p in _context.Pantallas on up.IdPantalla equals p.IdPantalla
                            where up.IdUsuario == id
                            select new PermisosUsuarioDTO
                            {
                                IdUsuario= up.IdUsuario,
                                IdPantalla= up.IdPantalla,
                                Usuario = u.Nombre,       // Nombre del usuario
                                Pantalla = p.Nombre,     // Nombre de la pantalla
                                Insertar = up.Insertar,                   // Permiso de insertar
                                Modificar = up.Modificar,                  // Permiso de modificar
                                Borrar= up.Borrar,                     // Permiso de borrar
                                Consultar = up.Consultar                   // Permiso de consultar
                            };

                lista = query.ToList();

                if (lista.Count == 0) {
                    MessageBox.Show("Este usuario aun no tiene permisos asignados");
                    return lista;
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscando permisos del usuario" + ex.Message);
                return lista;
            }
        }

        public string Agregar(PermisoUsuario permisoUsuario)
        {
            if (permisoUsuario == null) return "Permisos invalido";
            var temp = _context.PermisosUsuarios.FirstOrDefault(x => x.IdUsuario == permisoUsuario.IdUsuario && x.IdPantalla == permisoUsuario.IdPantalla);
            if (temp != null) return "Usuario con permisos existentes en esta pantalla. Intente modificarlo...";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.PermisosUsuarios.Add(permisoUsuario);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Agregado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al agregar " + ex.Message;
                }
            }
        }
    }
}
