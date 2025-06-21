using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using DAL;

namespace BLL.Servicios
{
    public class ServicioRoles
    {
        private DbContextBiblioteca _context = null;

        public ServicioRoles()
        {
            this._context = new DbContextBiblioteca();
        }
        public List<Rol> Listar()
        {
            var lista = new List<Rol>();
            try
            {
                lista = _context.Roles.ToList();
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscando lista de roles" + ex.Message);
                return lista;
            }
        }
        public Rol Buscar (int id)
        {
            var rol = _context.Roles.FirstOrDefault(x=> x.IdRol == id);
            return rol;
        }
        public string Agregar(Rol rol)
        {
            if (rol == null) return "Rol invalido";
            var temp = _context.Roles.FirstOrDefault(x => x.IdRol == rol.IdRol || x.NombreRol == rol.NombreRol);
            if (temp != null) return "Ya existe un rol con este Id o con este nombre";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Roles.Add(rol);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Agregado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al agregar Rol" + ex.Message;
                }
            }
        }
        public string Editar(Rol rol)
        {
            if (rol == null) return "Rol invalido";
            var temp = _context.Roles.FirstOrDefault(x => x.IdRol == rol.IdRol);
            if (temp == null) return "Rol no encontrado";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    temp.NombreRol = rol.NombreRol;
                    _context.Roles.Update(temp);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Editado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al editar Roles" + ex.Message;
                }
            }
        }
        public string Eliminar(int id)
        {
            var temp = _context.Roles.FirstOrDefault(x => x.IdRol == id);
            if (temp == null) return "Rol no encontrado";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Roles.Remove(temp);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Eliminado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al editar usuario" + ex.Message;
                }
            }

        }

    }
     
}
