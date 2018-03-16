using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace BLL 
{
  public  class Localidad
    {
       

        private Int64 idlocalidad ;
        private String localidad;
        private Int64 cp;
        private Int32 activo;

        public Int64 Idlocalidad
        {
            get { return idlocalidad; }
            set {idlocalidad=value ; }
        }

        public String Localidades
        {
            get { return localidad; }
            set { localidad =value ; }
        }

        public Int64 Cp
        {
            get { return cp ; }
            set { cp=value  ; }
        }

        public Int32 Activo
        {
            get { return activo; }
            set { activo = value; }
        }

    }


}
