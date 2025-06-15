using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL.Servicios
{
    public class ServicioUsuarios
    {
        private DbContextBiblioteca _context = null;

        public ServicioUsuarios()
        {
            this._context = new DbContextBiblioteca();
        }

        public List<Usuario> ListarUsuarios()
        {
            var lista = _context.Usuarios.ToList();
            return lista;
        }

        public string Agregar(Usuario usuario)
        {
            if (usuario == null) return "Usuario invalido";
            var temp = _context.Usuarios.FirstOrDefault(x => x.Correo.Trim().ToLower() == usuario.Correo.Trim().ToLower());
            if (temp != null) return "Ya existe un usuario con este correo";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Usuarios.Add(usuario);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return usuario.Nombre + " agregado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al agregar usuario" + ex.Message;
                }
            }
        }

        public string Editar(Usuario usuario)
        {
            if (usuario == null) return "Usuario invalido";
            var temp = _context.Usuarios.FirstOrDefault(x => x.IdUsuario == usuario.IdUsuario);
            if (temp == null) return "Usuario no encontrado";

            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Usuarios.Update(usuario);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return usuario.Nombre + " editado correctamente.";
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
            var temp = _context.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
            if (temp == null) return "Usuario no encontrado";
            using (var transaccion = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Usuarios.Remove(temp);
                    _context.SaveChanges();
                    transaccion.Commit();
                    return temp.Nombre + " eliminado correctamente.";
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return "Error al eliminar usuario" + ex.Message;
                }
            }
        }

        public Usuario Buscar(int id)
        {
            var temp = _context.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
            if (temp == null) return null;
            return temp;
        }

        public int Autenticar(string correo, string contraseña)
        {
            var temp = _context.Usuarios.FirstOrDefault(x => x.Correo.Trim().ToLower() == correo.Trim().ToLower());
            if (temp == null) return -1; //"Usuario no existente";
            if (temp.Clave == contraseña) return 1; //"Usuario autenticado";
            return 0; //"Credenciales invalidas";
        }

    }
}
