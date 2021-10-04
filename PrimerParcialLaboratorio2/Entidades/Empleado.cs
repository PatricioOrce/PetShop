using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        string usuario;
        string contrasenia;
        
        public Empleado(string nombre, string apellido, string dni, string usuario, string contrasenia) : base(nombre,apellido,dni)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }
        public string Usuario
        {
            get
            {
                return this.usuario;
            }
        }
        public string Contrasenia
        {
            get
            {
                return this.contrasenia;
            }
        }
        public override string Help()
        {
            StringBuilder infoAyuda = new StringBuilder();
            infoAyuda.AppendLine("Un Empleado abarca a : ");
            infoAyuda.AppendLine("Empleados y Administradores ");
            infoAyuda.AppendLine("Esta clase posee mas atributos como:");
            infoAyuda.AppendLine("Usuario y Clave, este rol en concreto ");
            infoAyuda.AppendLine("Permite realizar ventas y crear Clientes.");
            return infoAyuda.ToString();
        }
        public override string Mostrar(Persona employee)
        {
            Empleado auxEmpleado = (Empleado)employee;
            string datos = $"Nombre: {employee.Nombre} | Apellido: {employee.Apellido} | DNI:{employee.DNI}";
            return datos;
        }

    }
}
