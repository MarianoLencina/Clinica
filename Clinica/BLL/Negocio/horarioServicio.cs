using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BLL
{
  public class horarioServicio
    {
        public IList<Horarios> traerHorarios()

        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            IList<Horarios> lista = new List<Horarios>();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select IDHORARIO,TURNO,HORAENTRADA,HORASALIDA,ACTIVO from HORARIOS where ACTIVO=1";

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read()) 
                {
                    Horarios traerHora = new Horarios();
                    traerHora.IdHorarios = lector.GetInt64(0);
                    traerHora.Turno = lector.GetString(1);
                    traerHora.HEntrada = lector.GetInt64(2);
                    traerHora.HSalida = lector.GetInt64(3);
                    traerHora .Activo = lector.GetInt32(4);
                    lista.Add(traerHora);
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

        public IList<Horarios> traerListaHorariosPorMedico(Int64 idHo)

        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            IList<Horarios> lista = new List<Horarios>();
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select IDHORARIO,TURNO,HORAENTRADA,HORASALIDA,ACTIVO from HORARIOS where ACTIVO=1 and IDHORARIO = " + idHo;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Horarios traerHora = new Horarios();
                    traerHora.IdHorarios = lector.GetInt64(0);
                    traerHora.Turno = lector.GetString(1);
                    traerHora.HEntrada = lector.GetInt64(2);
                    traerHora.HSalida = lector.GetInt64(3);
                    traerHora.Activo = lector.GetInt32(4);
                    lista.Add(traerHora);
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


        public Horarios  HorariostraerHorariosPorMedico(Int64 idHo)

        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            Horarios lista = new Horarios(); 
            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select IDHORARIO,TURNO,HORAENTRADA,HORASALIDA,ACTIVO from HORARIOS where ACTIVO=1 and IDHORARIO = " + idHo ;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Horarios traerHora = new Horarios();
                    traerHora.IdHorarios = lector.GetInt64(0);
                    traerHora.Turno = lector.GetString(1);
                    traerHora.HEntrada = lector.GetInt64(2);
                    traerHora.HSalida = lector.GetInt64(3);
                    traerHora.Activo = lector.GetInt32(4);
                    lista=traerHora;
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
