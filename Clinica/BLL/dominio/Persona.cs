using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {

           
        private String nombre;
        private String apellido;
        private Int64 dni;
        private String direccion;
        private Int64 idlocalidad;
        private Int64 cp;
        private Int64  celular;
        private Int64 telefono;
        private String email;
        private DateTime fechaNac;
        private String sexo;
        private Int32  activo;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }
        public Int64 Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public Int64 Idlocalidad
        {
            get { return idlocalidad; }
            set { idlocalidad = value; }
        }
        public Int64 Cp
        {
            get { return cp;}
            set { cp = value;}
        }
        public Int64 Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public Int64  Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }

        }
        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public Int32  Activo
        {
            get { return activo; }
            set { activo = value; }
        }



    }

}

