using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Medico : Persona
    {
        private Int64 idmedico;
        private Int64 idhorario;
        private  Horarios hora;
        private IList<Especialidad> listaEspecialidad;

        public IList<Especialidad > ListaEspecialidad
        {
            get { return listaEspecialidad; }
            set { listaEspecialidad = value; }
        }

        public Int64 Idmedico
        {
            get { return idmedico; }
            set { idmedico = value; }
        }

        public Int64 Idhorario
        {
            get { return idhorario; }
            set { idhorario = value; }
        }

        public  Horarios Hora
        {
            get { return hora ; }
            set { hora  = value; }
        } 

         

    }

}
