using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
   public class PacienteNegocio
    {
        public void eliminarPaciente(Paciente elim)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "update pacientes set activo=0 where idpaciente = " +elim.Idpaciente ;

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

        public void modificarPaciente(Paciente pacie)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "update pacientes set nombre ='"+pacie.Nombre +"',apellido='"+pacie.Apellido+"',dni='"+pacie.Dni+"',direccion ='"+pacie.Direccion+"',idlocalidad='"+pacie.Idlocalidad+"',celular='"+pacie.Celular+"',telefono='"+pacie.Telefono+"',email='"+pacie.Email+"', fecha_nacimiento='"+pacie.FechaNac.Month+"/"+pacie.FechaNac.Day +"/"+pacie.FechaNac.Year+"',sexo='"+pacie.Sexo+"'where idpaciente ="+pacie.Idpaciente ;

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

       

        public IList<Paciente> Buscar( string campo, string criterio,string clave )
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            IList<Paciente> lista = new List<Paciente>();
            string consulta = "SELECT p.IDPACIENTE,p.NOMBRE, p.APELLIDO ,p.DNI,p.DIRECCION,p.idlocalidad,l.CP,p.CELULAR,p.TELEFONO,p.EMAIL,p.FECHA_NACIMIENTO,P.SEXO ,p.ACTIVO from pacientes as p inner join LOCALIDADES as l on p.IDLOCALIDAD = l.IDLOCALIDAD WHERE p.ACTIVO = 1 and ";

            try
            {
                conexion.ConnectionString = "data source=(local); initial catalog=MEDICINA_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;

                if (campo == "DNI")
                    consulta = consulta + "p.DNI";
                else
                    consulta = consulta + campo;

                switch (criterio)
                {
                    case "Mayor a":
                        consulta = consulta + " > " + clave;
                        break;
                    case "Menor a":
                        consulta =consulta + " < " + clave;
                        break;
                       
                    case "Igual a":
                        consulta = consulta + " = " + clave;
                        break;
                    case "Comienza con":
                        consulta = consulta  + " Like '" + clave + "%'";
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
                    Paciente aux = new Paciente();
                    aux.Idpaciente = lector.GetInt64(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.Dni = lector.GetInt64(3);
                    aux.Direccion = lector.GetString(4);
                    aux.Idlocalidad = lector.GetInt64(5);
                    aux.Cp = lector.GetInt64(6);
                    aux.Celular = lector.GetInt64(7);
                    aux.Telefono = lector.GetInt64(8);
                    aux.Email = lector.GetString(9);
                    aux.FechaNac = lector.GetDateTime(10);
                    aux.Sexo = lector.GetString(11);
                    aux.Activo = lector.GetInt32(12);

                    lista.Add(aux);



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

        public void agregarPaciente(Paciente nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "data source= (local);initial catalog =medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "insert into pacientes values('" + nuevo.Nombre + "','" + nuevo.Apellido + "','" + nuevo.Dni + "','" + nuevo.Direccion + "','" + nuevo.Idlocalidad  + "','" + nuevo.Celular + "','" + nuevo.Telefono + "','" + nuevo.Email + "','" + nuevo.FechaNac.Month + "/" + nuevo.FechaNac.Day + "/" + nuevo.FechaNac.Year + "','" + nuevo.Sexo + "',1)";

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

        public IList<Paciente> traerTodos()
        {


            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Paciente> lista = new List<Paciente>();
            try
            {

                conexion.ConnectionString = "data source=(local); initial catalog=MEDICINA_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "SELECT p.IDPACIENTE,p.NOMBRE, p.APELLIDO ,p.DNI,p.DIRECCION,p.idlocalidad,l.CP,p.CELULAR,p.TELEFONO,p.EMAIL,p.FECHA_NACIMIENTO,P.SEXO ,p.ACTIVO from pacientes as p inner join LOCALIDADES as l on p.IDLOCALIDAD = l.IDLOCALIDAD WHERE p.ACTIVO = 1 ";

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Paciente aux = new Paciente();
                    aux.Idpaciente = lector.GetInt64(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.Dni = lector.GetInt64(3);
                    aux.Direccion = lector.GetString(4);
                    aux.Idlocalidad = lector.GetInt64(5);
                    aux.Cp = lector.GetInt64(6);
                    aux.Celular = lector.GetInt64(7);
                    aux.Telefono = lector.GetInt64(8);
                    aux.Email = lector.GetString(9);
                    aux.FechaNac = lector.GetDateTime(10);
                    aux.Sexo = lector.GetString(11);
                    aux.Activo = lector.GetInt32(12);

                    lista.Add(aux);



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


    }
}
