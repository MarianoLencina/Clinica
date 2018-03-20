using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Especialidad


    {
        private Int64 idespecialidad;
        private string especialidad;
        private Int32 activo;

        public Int64 Idespecialidad
        {
            get { return idespecialidad; }
            set { idespecialidad = value; }
        }

        public string Especialida

        {
            get { return especialidad;}
            set { especialidad = value;}

        }

        public Int32 Activo
        {
            get { return activo;}
            set { activo = value;}
        }
    }
}
