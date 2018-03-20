using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Usuario
    {
        private string user;
        private string contrasenia;
        private Int32 activo;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public Int32 Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    }
}
