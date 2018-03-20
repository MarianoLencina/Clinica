using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
   public class usuariosService
    {
        public string  Login(Usuario usuario)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog= medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "SELECT TOP 1 USUARIO, CONTRASENIA FROM USUARIOS WHERE USUARIO = '"+usuario.User  +"' AND CONTRASENIA = '" + usuario.Contrasenia +"'";
                conexion.Open();
                lector = comando.ExecuteReader();

                if (lector.Read())
                    return usuario.User ;
                else
                    return "acceso denegado";

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
    }
}
