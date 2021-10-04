using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validar
    {
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
        public static bool IsSaldo(double saldo)
        {
            if(saldo>0)
            {
                return true;
            }
            return false;
        }
        public static bool IsSaldo(string saldo)
        {
            if (double.TryParse(saldo,out double saldoDouble))
            {
                if(saldoDouble > 0)
                return true;
            }
            return false;
        }
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
