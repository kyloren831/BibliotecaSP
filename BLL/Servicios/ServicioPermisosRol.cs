using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using DAL;
using System.Windows;
using DAL.Models;

namespace BLL.Servicios
{
    public class ServicioPermisosRol
    {
        private DbContextBiblioteca _context = null;

        public ServicioPermisosRol()
        {
            this._context = new DbContextBiblioteca();
        }

        public List<PermisosRolDTO> Listar(int id)
        {
            var lista = new List<PermisosRolDTO>();
            try
            {
                var query = from pr in _context.PermisosRoles
                            join p in _context.Pantallas on pr.IdPantalla equals p.IdPantalla
                            join r in _context.Roles on pr.IdRol equals r.IdRol
                            where pr.IdRol == id
                            select new PermisosRolDTO
                            {
                                IdPantalla = pr.IdPantalla,
                                IdRol = pr.IdRol,
                                Rol = r.NombreRol,       
                                Pantalla = p.Nombre,
                                Insertar = pr.Insertar,
                                Modificar = pr.Modificar,
                                Borrar = pr.Borrar,
                                Consultar = pr.Consultar,
                                FechaCreacion=pr.FechaCreacion
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

        public string Agregar(PermisoRol permisoRol)
        {
            if (permisoRol == null) return "Permisos invalido";
            var temp = _context.PermisosRoles.FirstOrDefault(x => x.IdRol == permisoRol.IdRol && x.IdPantalla == permisoRol.IdPantalla);
            if (temp != null) return "Rol con permisos existentes en esta pantalla. Intente modificarlo...";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.PermisosRoles.Add(permisoRol);
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
        public string Editar(PermisoRol permiso)
        {
            if (permiso == null) return "Permiso invalido";
            var temp = _context.PermisosRoles.FirstOrDefault(x => x.IdRol == permiso.IdRol && x.IdPantalla == permiso.IdPantalla);
            if (temp == null) return "Permiso no encontrado. Intenge Agregarlo...";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    temp.IdPantalla = permiso.IdPantalla;
                    temp.IdRol = permiso.IdRol;
                    temp.Insertar = permiso.Insertar;
                    temp.Modificar = permiso.Modificar;
                    temp.Borrar = permiso.Borrar;
                    temp.Consultar = permiso.Consultar;

                    _context.PermisosRoles.Update(temp);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Editado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al editar permisos" + ex.Message;
                }
            }
        }
        public PermisoRol Buscar(int idRol,int idPantalla)
        {
            return _context.PermisosRoles.FirstOrDefault(x => x.IdRol == idRol && x.IdPantalla == idPantalla);
        }
        public string Eliminar(int IdRol, int IdPantalla)
        {
            var temp = _context.PermisosRoles.FirstOrDefault(x => x.IdRol == IdRol && x.IdPantalla == IdPantalla);
            if (temp == null) return "Permisos no encontrados";
            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.PermisosRoles.Remove(temp);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Eliminado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al eliminar permisos" + ex.Message;
                }
            }
        }

    }
}
