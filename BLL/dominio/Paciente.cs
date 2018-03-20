using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Paciente : Persona
    {
        private Int64 idpaciente;
        public Int64 Idpaciente
        {
            get { return idpaciente; }
            set { idpaciente = value; }
        }

    }
}
