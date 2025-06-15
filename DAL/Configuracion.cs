using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class Configuracion
    {
        public static string StringConexion = "User Id=USUARIO_APLICACION;Password=AppUserPdIF5100;Data Source=127.0.0.1:1521/FREE";
        public static void Conectar()
        {
            using (OracleConnection conexion = new OracleConnection(StringConexion))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }
    }
}
