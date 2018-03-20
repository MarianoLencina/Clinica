using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Horarios
    {
        private Int64 idHorarios;
        private string turno;
        private Int64 hentrada;
        private Int64 hsalida;
        private Int64 activo;

        public Int64 IdHorarios
        {
            get { return idHorarios; }
            set { idHorarios = value; }
        }
        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        public Int64 HEntrada
        {
            get { return hentrada; }
            set { hentrada = value; }
        }
        public Int64 HSalida
        {
            get { return hsalida; }
            set { hsalida = value; }
        }
        public Int64 Activo
        {
            get { return activo; }
            set { activo = value; }
        }

    }
}
