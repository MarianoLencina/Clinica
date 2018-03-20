using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
   public class localidadNegocio


    {
        public IList<Localidad> buscarLocalidad( string campo, string criterio, string clave)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Localidad> lista = new List<Localidad>();
            string consulta = "select IDLOCALIDAD,LOCALIDAD ,CP,activo from LOCALIDADES where ACTIVO=1 and ";

            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog= medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;

                if (campo == "CODIGO POSTAL")
                    consulta = consulta + "CP";
                else
                    consulta = consulta + campo;

                switch (criterio)
                {
                    case "Mayor a":
                        consulta = consulta + " > " + clave;
                        break;
                    case "Menor a":
                        consulta = consulta + " < " + clave;
                        break;

                    case "Igual a":
                        consulta = consulta + " = " + clave;
                        break;
                    case "Comienza con":
                        consulta = consulta + " Like '" + clave + "%'";
                        break;
                    case "Contiene":
                        consulta = consulta + " Like '%" + clave + "%'";
                        break;
                    case "Termina con":
                        consulta = consulta + " Like '%" + clave + "'";
                        break;

                }
                comando.CommandText = consulta;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Localidad aux = new Localidad();
                    aux.Idlocalidad = lector.GetInt64(0);
                    aux.Localidades = lector.GetString(1);
                    aux.Cp = lector.GetInt64(2);
                    aux.Activo = lector.GetInt32(3);
                    lista.Add(aux);
                }


                return lista;

            }
            catch(Exception ex) { throw ex; }
            finally
            {

            }

        }

        public IList<Localidad> traerLocalidades()
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Localidad> lista = new List<Localidad>();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog= medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select IDLOCALIDAD,LOCALIDAD ,CP,activo from LOCALIDADES where ACTIVO=1";

                conexion.Open();
                lector = comando.ExecuteReader();
                while(lector.Read())
                {
                    Localidad aux = new Localidad();
                    aux.Idlocalidad = lector.GetInt64(0);
                    aux.Localidades = lector.GetString(1);
                    aux.Cp = lector.GetInt64(2);
                    aux.Activo = lector.GetInt32(3);
                    lista.Add(aux);
                }


                return lista;
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

        public void agregarLocalidad(Localidad nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "insert into localidades values ('"+ nuevo.Localidades + "','"+nuevo.Cp+"',1)";

                conexion.Open();
                comando.ExecuteNonQuery();

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

        public void eliminarLocalidad(Localidad loc)
        {
            SqlCommand comando = new SqlCommand ();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog = medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "update localidades set activo = 0 where idlocalidad =" + loc.Idlocalidad ;

                conexion.Open();
                comando.ExecuteNonQuery();
                

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

        public void modificarLocalidad(Localidad loca)
        {
            SqlCommand comando = new SqlCommand() ;
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "update localidades set localidad ='"+loca.Localidades +"',cp='"+loca.Cp+"' where idlocalidad =" +loca.Idlocalidad ;


                conexion.Open();
                comando.ExecuteNonQuery();


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

   

    }
}
