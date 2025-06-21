using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL.Servicios
{
    public class ServicioSistemas
    {
        private DbContextBiblioteca _context = null;
        private ServicioPantallas servicioPantallas;
        public ServicioSistemas()
        {
            this._context = new DbContextBiblioteca();
            this.servicioPantallas= new ServicioPantallas();
        }

        public List<Sistema> Listar()
        {
            var lista = new List<Sistema>();
            try
            {
                lista = _context.Sistemas.ToList();
            }
            catch (Exception ex)
            {
                lista = null;
            }

            return lista;
        }

        public string Agregar(Sistema sistema)
        {
            if (sistema == null) return "Sistema invalido";
            var temp = _context.Sistemas.FirstOrDefault(x => x.IdSistema == sistema.IdSistema);
            if (temp != null) return "Ya existe un sistema con este Id";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Sistemas.Add(sistema);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Agregado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al agregar sistema" + ex.Message;
                }
            }
        }
        public Sistema Buscar(int id)
        {
            var temp = _context.Sistemas.FirstOrDefault(x => x.IdSistema == id);
            if (temp == null) return null;
            return temp;
        }
        public string Editar(Sistema sistema)
        {
            if (sistema == null) return "sistema invalido";
            var temp = _context.Sistemas.FirstOrDefault(x => x.IdSistema == sistema.IdSistema);
            if (temp == null) return "sistema no encontrado";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    temp.IdSistema = sistema.IdSistema;
                    temp.Nombre = sistema.Nombre;
                    temp.RutaEjecutable = sistema.RutaEjecutable;
                    temp.FechaCreacion = sistema.FechaCreacion;

                    _context.Sistemas.Update(temp);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Editado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al editar usuario" + ex.Message;
                }
            }
        }

        public string Eliminar(int id)
        {
            var temp = _context.Sistemas.FirstOrDefault(x => x.IdSistema == id);
            if (temp == null) return "sistema no encontrado";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Sistemas.Remove(temp);
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
