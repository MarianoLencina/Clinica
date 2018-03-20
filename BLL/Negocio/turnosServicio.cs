using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class turnosServicio
    {
        public IList<Int64 > traerlista(Int64 entr,Int64 sali)
        {
            Int64 a = entr ;
            Int64 b=sali ;
            
            
            IList<Int64 > lista = new List<Int64 >();

            for (Int64  i = a; i <= b; i=i+100)
            {
                lista.Add(i);

            }
            return lista;
        }

        public IList<Turno > traerTodos()
        {


            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Turno > lista = new List<Turno>();
            try
            {

                conexion.ConnectionString = "data source=(local); initial catalog=MEDICINA_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                // comando.CommandText = "SELECT p.IDPACIENTE,p.NOMBRE, p.APELLIDO ,p.DNI,p.DIRECCION,p.idlocalidad,l.CP,p.CELULAR,p.TELEFONO,p.EMAIL,p.FECHA_NACIMIENTO,P.SEXO ,p.ACTIVO from pacientes as p inner join LOCALIDADES as l on p.IDLOCALIDAD = l.IDLOCALIDAD WHERE p.ACTIVO = 1 ";
                comando.CommandText = "select t.IDTURNO,p.IDPACIENTE , p.NOMBRE + ' ' + p.APELLIDO as Paciente ,m.IDMEDICO, m.APELLIDO as Medico,e.IDESPECIALIDAD, e.ESPECIALIDAD,t.FECHATURNO , t.HORATURNO,t.OBSERVACIONES,t.ACTIVO from TURNOS t inner join PACIENTES as p on p.IDPACIENTE = t.IDPACIENTE inner join MEDICOS as m on m.IDMEDICO = t.IDMEDICO inner join ESPECIALIDADES as e on e.IDESPECIALIDAD = t.IDESPECIALIDAD where t.ACTIVO = 1 and m.activo=1";


                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Turno  aux = new Turno();
                    aux.idturno = lector.GetInt64(0);
                    aux.idpaciente  = lector.GetInt64(1);
                    aux.Paciente = lector.GetString(2);
                    aux.idmedico = lector.GetInt64(3);
                    aux.Doctor = lector.GetString(4);
                    aux.idEspecialidades  = lector.GetInt64(5);
                    aux.especialidad = lector.GetString(6);
                    aux.fechaTurno = lector.GetDateTime(7);
                    aux.horaTurno = lector.GetInt64(8);
                    aux.observaciones = lector.GetString(9);
                    aux.activo = lector.GetInt32(10);

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

        public IList<Turno> traerTurnosPorMedicos(string medico)
        {


            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Turno> lista = new List<Turno>();
            try
            {

                conexion.ConnectionString = "data source=(local); initial catalog=MEDICINA_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                // comando.CommandText = "SELECT p.IDPACIENTE,p.NOMBRE, p.APELLIDO ,p.DNI,p.DIRECCION,p.idlocalidad,l.CP,p.CELULAR,p.TELEFONO,p.EMAIL,p.FECHA_NACIMIENTO,P.SEXO ,p.ACTIVO from pacientes as p inner join LOCALIDADES as l on p.IDLOCALIDAD = l.IDLOCALIDAD WHERE p.ACTIVO = 1 ";
                comando.CommandText = "select t.IDTURNO,p.IDPACIENTE , p.NOMBRE + ' ' + p.APELLIDO as Paciente ,m.IDMEDICO, m.APELLIDO as Medico,e.IDESPECIALIDAD, e.ESPECIALIDAD,t.FECHATURNO , t.HORATURNO,t.OBSERVACIONES,t.ACTIVO from TURNOS t inner join PACIENTES as p on p.IDPACIENTE = t.IDPACIENTE inner join MEDICOS as m on m.IDMEDICO = t.IDMEDICO inner join ESPECIALIDADES as e on e.IDESPECIALIDAD = t.IDESPECIALIDAD where t.ACTIVO = 1 and m.activo=1 and M.apellido='"+medico+"'" ;


                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Turno aux = new Turno();
                    aux.idturno = lector.GetInt64(0);
                    aux.idpaciente = lector.GetInt64(1);
                    aux.Paciente = lector.GetString(2);
                    aux.idmedico = lector.GetInt64(3);
                    aux.Doctor = lector.GetString(4);
                    aux.idEspecialidades = lector.GetInt64(5);
                    aux.especialidad = lector.GetString(6);
                    aux.fechaTurno = lector.GetDateTime(7);
                    aux.horaTurno = lector.GetInt64(8);
                    aux.observaciones = lector.GetString(9);
                    aux.activo = lector.GetInt32(10);

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

        public void agregarTurno(Turno  nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "data source= (local);initial catalog =medicina_db;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "insert into turnos values('" + nuevo.idpaciente + "','" + nuevo.idEspecialidades + "','" + nuevo.idmedico  + "','" + nuevo.fechaTurno.Month + "/" + nuevo.fechaTurno.Day + "/" + nuevo.fechaTurno.Year + "','" + nuevo.horaTurno  + "','" + nuevo.observaciones  + "',1)";

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

