using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using System.Windows;
using DAL;
using DAL.Models;

namespace BLL.Servicios
{
    public class ServicioUsuarioRol
    {
        private DbContextBiblioteca _context = null;

        public ServicioUsuarioRol()
        {
            this._context = new DbContextBiblioteca();
        }

        public List <UsuarioRolDTO> Listar(int id)
        {
            var lista = new List<UsuarioRolDTO>();
            try
            {
                var query = from up in _context.UsuarioRoles
                            join u in _context.Usuarios on up.IdUsuario equals u.IdUsuario
                            join p in _context.Roles on up.IdRol equals p.IdRol
                            where up.IdUsuario == id
                            select new UsuarioRolDTO
                            {
                                IdUsuario = up.IdUsuario,
                                IdRol = up.IdRol,
                                Usuario = u.Nombre,       // Nombre del usuario
                                Rol = p.NombreRol                 // Permiso de consultar
                            };

                lista = query.ToList();

                if (lista.Count == 0)
                {
                    MessageBox.Show("Este usuario aun no tiene roles asignados");
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
    }
}
