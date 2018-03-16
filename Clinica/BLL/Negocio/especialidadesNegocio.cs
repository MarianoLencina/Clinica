using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class especialidadesNegocio
    {
        public IList<Especialidad > traerEspecialidadPorId(Int64 id)
        {

            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            IList<Especialidad> lista = new List<Especialidad>();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog =medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select IDESPECIALIDAD,ESPECIALIDAD,ACTIVO from ESPECIALIDADES where activo=1 and IDESPECIALIDAD =" + id ;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Especialidad traer = new Especialidad();
                    traer.Idespecialidad = lector.GetInt64(0);
                    traer.Especialida = lector.GetString(1);
                    traer.Activo = lector.GetInt32(2);
                    lista.Add(traer);


                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }

        }

        public IList <Especialidad> traerEspecialidades()
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection ();
            SqlDataReader lector;
            IList<Especialidad> lista = new List<Especialidad>();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog =medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select IDESPECIALIDAD,ESPECIALIDAD,ACTIVO from ESPECIALIDADES where activo=1";

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read()) 
                {
                    Especialidad traer = new Especialidad();
                    traer.Idespecialidad = lector.GetInt64(0);
                    traer.Especialida = lector.GetString(1);
                    traer.Activo = lector.GetInt32(2);
                    lista.Add(traer);


                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }
        }

        public void agregarEspecialidad(Especialidad nueva)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "altaEspecialidad";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@especialidad ", nueva.Especialida);

                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }
        }

        public void eliminarEspecialidad (Especialidad elim)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "update especialidades set activo=0 where idespecialidad="+elim.Idespecialidad;

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }
        }


   
    }
}
