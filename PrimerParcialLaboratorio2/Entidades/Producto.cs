using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Tipos
    {
        Comida, Juguete, Cuidado, Comodidad
    }
    public class Producto
    {
        string nombre;
        int id;
        static int lastID;
        double precio;
        string descripcion;
        Tipos tipo;
        int cantidad;

        static Producto()
        {
            lastID = 0;
        }
        private Producto()
        {
            lastID += 1;
            this.id = lastID;
        }
        public Producto(string nombre, double precio, string descripcion, Tipos tipo, int cantidad) : this()
        {
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.cantidad = cantidad;
        }
        public Producto(string nombre, double precio, string descripcion, string tipo, int cantidad) : this()
        {
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.Tipo = tipo;
            this.cantidad = cantidad;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (Validar.IsNombre(value))
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "CustomName";
                }
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public  double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (value > 0)
                    this.precio = value;
                else
                    this.precio = 1;
            }
        }
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }
        public int Cantidad
        {
            get
            {
                if (this.cantidad >= 0)
                    return this.cantidad;
                else
                    return 0;
            }
            set
            {
                if (value >= 0)
                    this.cantidad = value;
                else
                    this.cantidad = 0;
            }
        }
        public string Tipo
        {
            get
            {
                return this.tipo.ToString();
            }
            set
            {
                if (value.ToString().ToLower().Equals(Tipos.Comida.ToString().ToLower()))
                {
                    this.tipo = Tipos.Comida;
                }
                else if (value.ToString().ToLower().Equals(Tipos.Comodidad.ToString().ToLower()))
                {
                    this.tipo = Tipos.Comodidad;
                }
                else if (value.ToString().ToLower().Equals(Tipos.Cuidado.ToString().ToLower()))
                {
                    this.tipo = Tipos.Cuidado;
                }
                else if (value.ToString().ToLower().Equals(Tipos.Juguete.ToString().ToLower()))
                {
                    this.tipo = Tipos.Juguete;
                }
                else
                {
                    this.tipo = Tipos.Comida;
                }
            }
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1 is not null && p2 is not null && p1.Id == p2.Id);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return (p1 is not null && p2 is not null && p1.Id != p2.Id);
        }

        public static explicit operator double(Producto product)
        {
            return product.Precio;
        }

    }
}
