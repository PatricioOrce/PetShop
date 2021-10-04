using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        string apellido;
        string dni;
        
        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public abstract string Mostrar(Persona persona);
        public virtual string Help()
        {
            StringBuilder infoAyuda = new StringBuilder();
            infoAyuda.AppendLine("Una Persona abarca a : ");
            infoAyuda.AppendLine("Clientes, Empleados y Administradores ");
            infoAyuda.AppendLine("Esta clase de por si no puede realizar ninguna accion.");
            return infoAyuda.ToString();
        }
    }
}
