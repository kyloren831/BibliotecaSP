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

                
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscando roles del usuario" + ex.Message);
                return lista;
            }
        }

        public string Agregar(UsuarioRol usuarioRol)
        {
            if (usuarioRol == null) return "Rol invalido";
            var temp = _context.UsuarioRoles.FirstOrDefault(x => x.IdUsuario == usuarioRol.IdUsuario && x.IdRol == usuarioRol.IdRol);
            if (temp != null) return "Usuario con el rol asignado previamente";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.UsuarioRoles.Add(usuarioRol);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Agregado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al asignar rol" + ex.Message;
                }
            }
        }
        public string Eliminar(int IdUsuario, int IdRol)
        {
            var temp = _context.UsuarioRoles.FirstOrDefault(x => x.IdUsuario == IdUsuario && x.IdRol == IdRol);
            if (temp == null) return "El usuario no tiene este rol";
            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.UsuarioRoles.Remove(temp);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return  "Eliminado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al eliminar rol" + ex.Message;
                }
            }
        }
    }
}
