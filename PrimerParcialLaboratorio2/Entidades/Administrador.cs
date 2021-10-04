using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, string apellido, string dni, string usuario, string contrasenia) : base(nombre,apellido,dni,usuario,contrasenia)
        {

        }

        public override string Help()
        {
            StringBuilder infoAyuda = new StringBuilder();
            infoAyuda.AppendLine("Un Administrador puede realizar");
            infoAyuda.AppendLine("las mismas actividades que un empleado");
            infoAyuda.AppendLine("y a su vez puede ver, modificar y eliminar");
            infoAyuda.AppendLine("productos, clientes y empleados.");
            infoAyuda.AppendLine("Ademas puede cunsultar la facturacion total.");
            return infoAyuda.ToString();
        }
    }
}
