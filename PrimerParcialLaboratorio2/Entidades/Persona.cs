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
                if (!string.IsNullOrWhiteSpace(value))
                    this.nombre = value;
                else
                    this.nombre = " ";
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
                if (!string.IsNullOrWhiteSpace(value))
                    this.apellido = value;
                else
                    this.apellido = " ";
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
        /// <summary>
        /// Metodo abstracto para mostrar datos de personas.
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>Devuelve una cadena con la informacion.</returns>
        public abstract string Mostrar(Persona persona);
        /// <summary>
        /// Muestra las capacidades de una persona.
        /// </summary>
        /// <returns>Devuelve una cadena con la informacion.</returns>
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
