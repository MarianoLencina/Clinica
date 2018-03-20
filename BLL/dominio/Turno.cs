using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Turno
    {


        private Int64 Idturno;
        private Int64 Idpaciente;
        private string Nombre;
        private Int64 Idmedico;
        private string NomDoctor;
        private Int64 Idespecialidad;
        private string Especialidad;
        private DateTime FechaTurno;
        private Int64 HoraTurno;
        private string Observaciones;
        private Int32 Activo;

        public Int64  idturno
        {
            get { return Idturno; }
            set { Idturno = value; }
        }
        public Int64 idpaciente
        {
            get { return Idpaciente; }
            set { Idpaciente = value; }
        }
        public string Paciente
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public Int64 idmedico
        {
            get { return Idmedico; }
            set { Idmedico = value; }
                    }
        public string Doctor
        {
            get { return NomDoctor; }
            set { NomDoctor = value; }
        }
        public Int64 idEspecialidades
        {
            get { return Idespecialidad; }
            set { Idespecialidad = value; }
        }
        public string especialidad
        {
            get { return Especialidad; }
            set { Especialidad = value; }
        }
        public DateTime fechaTurno
        {
            get { return FechaTurno; }
            set { FechaTurno = value; }
        }
        public Int64 horaTurno
        {
            get { return HoraTurno; }
            set { HoraTurno = value; }

        }
        public string observaciones
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }
        public Int32 activo
        {
            get { return Activo; }
            set { Activo = value; }
        }





    }
}
