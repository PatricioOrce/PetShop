using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validar
    {
        /// <summary>
        /// Verifica que el nombre sea valido.
        /// </summary>
        /// <param name="nombreIngresado"></param>
        /// <returns>Devuelve True si es valido, de lo contrario devuelve false.</returns>
        public static bool IsNombre(string nombreIngresado)
        {
            string nombre = nombreIngresado.Trim();
            int espacios = 0;
            int barras = 0;
            if (nombre.Length > 1 && nombre.Length < 41)
            {
                foreach (char character in nombre)
                {
                    if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z') || (character == ' ' || character == '-'))
                    {
                        if (character == ' ')
                        {
                            espacios += 1;
                        }
                        if (character == '-')
                        {
                            barras += 1;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                if (espacios < 2 && barras < 2)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Verifica que el nombre de usuario sea valido.
        /// </summary>
        /// <param name="usernameIngresado"></param>
        /// <returns>Devuelve True si es valido, de lo contrario devuelve false.</returns>
        public static bool IsUsername(string usernameIngresado)
        {
            string nombre = usernameIngresado.Trim();
            int espacios = 0;
            int barras = 0;
            if (nombre.Length > 1 && nombre.Length < 41)
            {
                foreach (char character in nombre)
                {
                    if (    (character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z') 
                            || (character == ' ' || character == '-') || (character >= '0' && character <= '9'))
                    {
                        if (character == ' ')
                        {
                            espacios += 1;
                        }
                        if (character == '-')
                        {
                            barras += 1;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                if (espacios < 2 && barras < 2)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Verifica que la clave sea valida.
        /// </summary>
        /// <param name="passwordIngresado"></param>
        /// <returns>Devuelve True si es valido, de lo contrario devuelve false.</returns>
        public static bool IsPassword(string passwordIngresado)
        {
            string nombre = passwordIngresado.Trim();
            int espacios = 0;
            int barras = 0;
            if (nombre.Length > 1 && nombre.Length < 41)
            {
                foreach (char character in nombre)
                {
                    if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z')
                            || (character == ' ' || character == '-') || (character >= '0' && character <= '9'))
                    {
                        if (character == ' ')
                        {
                            espacios += 1;
                        }
                        if (character == '-')
                        {
                            barras += 1;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                if (espacios < 2 && barras < 2)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Verifica que el DNI sea valido.
        /// </summary>
        /// <param name="dniIngresado"></param>
        /// <returns>Devuelve True si es valido, de lo contrario devuelve false.</returns>
        public static bool IsDNI(string dniIngresado)
        {
            if(dniIngresado.Length>=5 && dniIngresado.Length <= 9)
            {
                foreach (char character in dniIngresado)
                {
                    if (!(character >= '0' && character <= '9'))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Verifica que el saldo sea valido.
        /// </summary>
        /// <param name="saldo"></param>
        /// <returns>Devuelve True si es valido, de lo contrario devuelve false.</returns>
        public static bool IsSaldo(double saldo)
        {
            if(saldo>0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica que el saldo sea valido.
        /// </summary>
        /// <param name="saldo"></param>
        /// <returns>Devuelve True si es valido, de lo contrario devuelve false.</returns>
        public static bool IsSaldo(string saldo)
        {
            if (double.TryParse(saldo,out double saldoDouble))
            {
                if(saldoDouble > 0)
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica la existencia de un empleado por su DNI.
        /// </summary>
        /// <param name="listaEmpleados"></param>
        /// <param name="dni"></param>
        /// <returns>Devuelve True si existe, de lo contrario devuelve false.</returns>
        public static bool ExistingDNI(List<Empleado> listaEmpleados, string dni)
        {
            foreach (Empleado item in listaEmpleados)
            {
                if(item.DNI.Equals(dni))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Verifica la existencia de un cliente por su DNI.
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="dni"></param>
        /// <returns>Devuelve True si es existe, de lo contrario devuelve false.</returns>
        public static bool ExistingDNI(List<Cliente> listaClientes, string dni)
        {
            foreach (Cliente item in listaClientes)
            {
                if (item.DNI.Equals(dni))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
