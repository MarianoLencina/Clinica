using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BLL
{
    public class medicosNegocio
    {
        public IList<Medico > buscarMedico(string campo, string criterio, string clave)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            IList<Medico> lista = new List<Medico>();
            string consulta = "SELECT p.IDMEDICO,p.IDHORARIO, p.NOMBRE, p.APELLIDO ,p.DNI,p.DIRECCION,p.idlocalidad,l.CP,p.CELULAR,p.TELEFONO,p.EMAIL,p.FECHA_NACIMIENTO,P.SEXO ,p.ACTIVO from MEDICOS  as p inner join LOCALIDADES as l on p.IDLOCALIDAD = l.IDLOCALIDAD inner join HORARIOS as h on h.IDHORARIO =p.IDHORARIO  WHERE p.ACTIVO = 1 and ";

            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
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
                        consulta = consulta + " < " + clave;
                        break;

                    case "Igual a":
                        consulta = consulta + " = " + clave;
                        break;
                    case "Comienza con":
                        consulta = consulta + " Like '" + clave + "%'";
                        break;
                    case "Contiene...":
                        consulta = consulta + " Like '%" + clave + "%'";
                        break;
                    case "Termina...":
                        consulta = consulta + " Like '%" + clave + "'";
                        break;

                }




                comando.CommandText = consulta;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Medico nue = new Medico();
                    nue.Idmedico = lector.GetInt64(0);
                    nue.Idhorario = lector.GetInt64(1);
                    nue.Nombre = lector.GetString(2);
                    nue.Apellido = lector.GetString(3);
                    nue.Dni = lector.GetInt64(4);
                    nue.Direccion = lector.GetString(5);
                    nue.Idlocalidad = lector.GetInt64(6);
                    nue.Cp = lector.GetInt64(7);
                    nue.Celular = lector.GetInt64(8);
                    nue.Telefono = lector.GetInt64(9);
                    nue.Email = lector.GetString(10);
                    nue.FechaNac = lector.GetDateTime(11);
                    nue.Sexo = lector.GetString(12);
                    nue.Activo = lector.GetInt32(13);

                    lista.Add(nue);


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
        public IList<Medico> traerMedicos()
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            IList<Medico> lista = new List<Medico>();
            especialidadesNegocio lisEsp = new especialidadesNegocio();
            horarioServicio horaser = new horarioServicio();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "SELECT p.IDMEDICO,p.IDHORARIO, p.NOMBRE, p.APELLIDO ,p.DNI,p.DIRECCION,p.idlocalidad,l.CP,p.CELULAR,p.TELEFONO,p.EMAIL,p.FECHA_NACIMIENTO,P.SEXO ,p.ACTIVO,h.TURNO,h.HORAENTRADA,h.HORASALIDA  from MEDICOS  as p inner join LOCALIDADES as l on p.IDLOCALIDAD = l.IDLOCALIDAD inner join HORARIOS as h on h.IDHORARIO =p.IDHORARIO  WHERE p.ACTIVO = 1";
                //comando.CommandText = "SELECT p.IDMEDICO,p.IDHORARIO, p.NOMBRE, p.APELLIDO ,p.DNI,p.DIRECCION,p.idlocalidad,l.CP,p.CELULAR,p.TELEFONO,p.EMAIL,p.FECHA_NACIMIENTO,P.SEXO ,p.ACTIVO from MEDICOS  as p inner join LOCALIDADES as l on p.IDLOCALIDAD = l.IDLOCALIDAD inner join HORARIOS as h on h.IDHORARIO =p.IDHORARIO  WHERE p.ACTIVO = 1 and p.idmedico =  " + idmedico;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Medico nue =new  Medico();
                    nue.Idmedico = lector.GetInt64(0);
                    nue.Idhorario = lector.GetInt64(1);
                    nue.Nombre = lector.GetString(2);
                    nue.Apellido = lector.GetString(3);
                    nue.Dni = lector.GetInt64(4);
                    nue.Direccion = lector.GetString(5);
                    nue.Idlocalidad = lector.GetInt64(6);
                    nue.Cp = lector.GetInt64(7);
                    nue.Celular = lector.GetInt64(8);
                    nue.Telefono = lector.GetInt64(9);
                    nue.Email = lector.GetString(10);
                    nue.FechaNac = lector.GetDateTime(11);
                    nue.Sexo = lector.GetString(12);
                    nue.Activo = lector.GetInt32(13);
                    nue.ListaEspecialidad = lisEsp.traerEspecialidadPorId(nue.Idmedico);
                    //nue.Hora = new Horarios();
                    //nue.Hora.Turno = lector.GetString(14);
                    //nue.Hora.HEntrada = lector.GetInt64(15);
                    //nue.Hora.HSalida = lector.GetInt64(16);
                    

                    lista.Add(nue);

                    
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

        public Medico traerMedicosPorEspeciliadad(Int64 idmed)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            Medico lista = new Medico();
            especialidadesNegocio lisEsp = new especialidadesNegocio();
            horarioServicio horaser = new horarioServicio();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                //comando.CommandText = "SELECT p.IDMEDICO,p.IDHORARIO, p.NOMBRE, p.APELLIDO ,p.DNI,p.DIRECCION,p.idlocalidad,l.CP,p.CELULAR,p.TELEFONO,p.EMAIL,p.FECHA_NACIMIENTO,P.SEXO ,p.ACTIVO from MEDICOS  as p inner join LOCALIDADES as l on p.IDLOCALIDAD = l.IDLOCALIDAD inner join HORARIOS as h on h.IDHORARIO =p.IDHORARIO  WHERE p.ACTIVO = 1 and p.idmedico =  " + idmedico ;
                comando.CommandText = "SELECT p.IDMEDICO,p.IDHORARIO, p.NOMBRE, p.APELLIDO ,p.DNI,p.DIRECCION,p.idlocalidad,l.CP,p.CELULAR,p.TELEFONO,p.EMAIL,p.FECHA_NACIMIENTO,P.SEXO ,p.ACTIVO,h.TURNO,h.HORAENTRADA,h.HORASALIDA  from MEDICOS  as p inner join LOCALIDADES as l on p.IDLOCALIDAD = l.IDLOCALIDAD inner join HORARIOS as h on h.IDHORARIO =p.IDHORARIO  WHERE p.ACTIVO = 1 and p.idmedico  = " + idmed    ;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Medico nue = new Medico();
                    nue.Idmedico = lector.GetInt64(0);
                    nue.Idhorario = lector.GetInt64(1);
                    nue.Nombre = lector.GetString(2);
                    nue.Apellido = lector.GetString(3);
                    nue.Dni = lector.GetInt64(4);
                    nue.Direccion = lector.GetString(5);
                    nue.Idlocalidad = lector.GetInt64(6);
                    nue.Cp = lector.GetInt64(7);
                    nue.Celular = lector.GetInt64(8);
                    nue.Telefono = lector.GetInt64(9);
                    nue.Email = lector.GetString(10);
                    nue.FechaNac = lector.GetDateTime(11);
                    nue.Sexo = lector.GetString(12);
                    nue.Activo = lector.GetInt32(13);
                   // nue.ListaEspecialidad = lisEsp.traerEspecialidadPorId(especi);
                    nue.Hora = new Horarios();
                    nue.Hora.Turno = lector.GetString(14);
                    nue.Hora.HEntrada = lector.GetInt64(15);
                    nue.Hora.HSalida = lector.GetInt64(16);


                    lista=nue;


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

        public void agregarMedico(Medico nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "data source= (local);initial catalog =medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "insert into medicos values('"+nuevo.Idhorario+"','" + nuevo.Nombre + "','" + nuevo.Apellido + "','" + nuevo.Dni + "','" + nuevo.Direccion + "','" + nuevo.Idlocalidad + "','" + nuevo.Celular + "','" + nuevo.Telefono + "','" + nuevo.Email + "','" + nuevo.FechaNac.Month + "/" + nuevo.FechaNac.Day + "/" + nuevo.FechaNac.Year + "','" + nuevo.Sexo + "',1)";
                

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

        public void eliminarMedico(Medico elim)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "update medicos set activo=0 where idmedico = " + elim.Idmedico;

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

        public void modificarMedico(Medico med)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "update medicos set idhorario ='"+med.Idhorario + "', nombre='" + med.Nombre + "',apellido='" + med.Apellido + "',dni='" + med.Dni + "',direccion ='" + med.Direccion + "',idlocalidad='" + med.Idlocalidad + "',celular='" + med.Celular + "',telefono='" + med.Telefono + "',email='" + med.Email + "', fecha_nacimiento='" + med.FechaNac.Month + "/" + med.FechaNac.Day + "/" + med.FechaNac.Year + "',sexo='" + med.Sexo + "'where idmedico =" + med.Idmedico;

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
