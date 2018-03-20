using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public class MedicoXespecil
    {


        private Int64 Idgeneral;
        private string Apellido;
        private Int64 Idmedico;
        private string Especialidad;
        private Int64 Idespecialidad;
        private Int64 Entrada;
        private Int64 Salida;
        private Int32 Activo;
        private IList<Horarios> hora;

        public Int64 idgeneral
        {
            get { return Idgeneral; }
            set { Idgeneral = value; }
        }

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
                    }

        public Int64 idmedico
        {
            get { return Idmedico; }
            set { Idmedico = value; }
        }

        public string especialidad
        {
            get { return Especialidad; }
            set { Especialidad = value; }
        }

        public Int64 idespecialidad
        {
            get { return Idespecialidad; }
            set { Idespecialidad = value; }
        }


        public Int64 entrada
        {
            get { return Entrada; }
            set { Entrada = value; }
        }

        public Int64 salida
        {
            get { return Salida; }
            set { Salida = value; }
        }

        public Int32 activo
        {
            get { return Activo; }
            set { Activo = value; }
        }

        public IList<Horarios> Hora
        {
            get { return hora; }
            set { hora = value; }
        }









    }
}
