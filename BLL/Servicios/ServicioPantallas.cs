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
    public class ServicioPantallas
    {
        private DbContextBiblioteca _context = null;

        public ServicioPantallas()
        {
            this._context = new DbContextBiblioteca();
        }
        public List<Pantalla> ListarPantallas()
        {
            var lista = _context.Pantallas.ToList();
            return lista;
        }
        public List<PantallaDTO> ListarPantallas(int idSistema)
        {
            var lista = new List<PantallaDTO>();
            try
            {
                var query = from p in _context.Pantallas
                            join s in _context.Sistemas on p.IdSistema equals s.IdSistema
                            where p.IdSistema == idSistema
                            select new PantallaDTO
                            {
                                IdSistema = p.IdSistema,
                                IdPantalla = p.IdPantalla,
                                NombrePantalla = p.Nombre,       
                                NombreSistema = s.Nombre,                 
                                FechaCreacion = p.FechaCreacion,
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

        public string Agregar(Pantalla Pantalla)
        {
            if (Pantalla == null) return "Pantalla invalido";
            var temp = _context.Pantallas.FirstOrDefault(x => x.IdPantalla == Pantalla.IdPantalla);
            if (temp != null) return "Ya existe una pantalla con este ID";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Pantallas.Add(Pantalla);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Agregado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al agregar Pantalla" + ex.Message;
                }
            }
        }

        public string Editar(Pantalla Pantalla)
        {
            if (Pantalla == null) return "pantalla invalida";
            var temp = _context.Pantallas.FirstOrDefault(x => x.IdPantalla == Pantalla.IdPantalla);
            if (temp == null) return "pantalla no encontrada";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    temp.Nombre = Pantalla.Nombre;

                    _context.Pantallas.Update(temp);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Editado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al editar pantalla" + ex.Message;
                }
            }
        }

        public string Eliminar(int id)
        {
            var temp = _context.Pantallas.FirstOrDefault(x => x.IdPantalla == id);
            if (temp == null) return "Pantalla no encontrada";
            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Pantallas.Remove(temp);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return "Eliminado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al eliminar usuario" + ex.Message;
                }
            }
        }

        public Pantalla Buscar(int id) {
           return _context.Pantallas.FirstOrDefault(x=> x.IdPantalla==id);
        }
    }
}
