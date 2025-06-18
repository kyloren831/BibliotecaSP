using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var lista = new List<Pantalla>();
            try
            {
                lista = _context.Pantallas.ToList();
            }
            catch (Exception ex)
            {
                lista = null;
            }

            return lista;
        }
    }
}
