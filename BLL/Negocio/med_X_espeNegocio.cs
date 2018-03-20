using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
      public class med_X_espeNegocio
    {
        public IList<MedicoXespecil> TraerTodoMedXespe()
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            IList<MedicoXespecil> lista = new List<MedicoXespecil>();

            try
            {

                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "select me.idgeneral,m.apellido,m.idmedico,e.especialidad,e.idespecialidad,me.entrada,me.salida,E.activo from ESPECIALIDADES_X_MEDICO as me inner join MEDICOS as m on me.IDMEDICO=m.IDMEDICO inner join ESPECIALIDADES as e on me.IDESPECIALIDAD=e.IDESPECIALIDAD WHERE me.activo=1 and m.activo=1 AND E.ACTIVO=1  ORDER BY ESPECIALIDAD asc";

                conexion.Open();
                lector = comando.ExecuteReader();
                while(lector.Read())
                    {
                    MedicoXespecil aux = new MedicoXespecil();
                    aux.idgeneral = lector.GetInt64(0);
                    aux.apellido = lector.GetString(1);
                    aux.idmedico = lector.GetInt64(2);
                    aux.especialidad = lector.GetString(3);
                    aux.idespecialidad = lector.GetInt64(4);
                    aux.entrada = lector.GetInt64(5);
                    aux.salida = lector.GetInt64(6);
                    aux.activo = lector.GetInt32(7);
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

        public IList<MedicoXespecil > traerEspeciXmedico(Int64 idesp)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            IList<MedicoXespecil> lista = new List<MedicoXespecil>();
            horarioServicio horaser = new horarioServicio();
            try
            {

                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = " select me.idgeneral,m.apellido,m.idmedico,e.especialidad,e.idespecialidad,me.entrada,me.salida,me.activo from ESPECIALIDADES_X_MEDICO as me inner join MEDICOS as m on me.IDMEDICO=m.IDMEDICO inner join ESPECIALIDADES as e on me.IDESPECIALIDAD=e.IDESPECIALIDAD WHERE me.activo=1 and m.activo=1 AND E.ACTIVO=1 and e.idespecialidad =  " + idesp  ;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    MedicoXespecil aux = new MedicoXespecil();
                    aux.idgeneral = lector.GetInt64(0);
                    aux.apellido = lector.GetString(1);
                    aux.idmedico = lector.GetInt64(2);
                    aux.especialidad = lector.GetString(3);
                    aux.idespecialidad = lector.GetInt64(4);
                    aux.entrada = lector.GetInt64(5);
                    aux.salida = lector.GetInt64(6);
                    aux.activo = lector.GetInt32(7);
                   // aux.Hora = horaser.traerHorariosPorMedico(aux.idhorario);

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

        public IList<MedicoXespecil> TraerSoloMedXespe(MedicoXespecil med)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;
            IList<MedicoXespecil> lista = new List<MedicoXespecil>();

            try
            {

                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = " select me.idgeneral,m.apellido,m.idmedico,e.especialidad,e.idespecialidad,me.entrada,me.salida,me.activo from ESPECIALIDADES_X_MEDICO as me inner join MEDICOS as m on me.IDMEDICO=m.IDMEDICO inner join ESPECIALIDADES as e on me.IDESPECIALIDAD=e.IDESPECIALIDAD WHERE me.activo=1 and m.activo=1 AND E.ACTIVO=1 and M.IDMEDICO=  " +med.idmedico ;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    MedicoXespecil aux = new MedicoXespecil();
                    aux.idgeneral = lector.GetInt64(0);
                    aux.apellido = lector.GetString(1);
                    aux.idmedico = lector.GetInt64(2);
                    aux.especialidad = lector.GetString(3);
                    aux.idespecialidad = lector.GetInt64(4);
                    aux.entrada = lector.GetInt64(5);
                    aux.salida = lector.GetInt64(6);
                    aux.activo = lector.GetInt32(7);
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

        public void eliminarEspecialidadXmedico(MedicoXespecil eli)
        {

            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "update ESPECIALIDADES_X_MEDICO set  activo=0 where idgeneral =" +eli.idgeneral ;
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

        public void agregarMedicoXespecialidad(MedicoXespecil nuevo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source=(local);initial catalog=medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "insert into ESPECIALIDADES_X_MEDICO values('"+nuevo.idmedico+"','"+nuevo.idespecialidad+"','"+nuevo.entrada+"','"+nuevo.salida+"',1)";
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
