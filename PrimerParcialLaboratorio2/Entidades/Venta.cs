using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        int id;
        static int lastID;
        double ganancia;
        Cliente cliente;
        Stack<Producto> productos;
        public Venta(Cliente cliente, Stack<Producto> productos) :this()
        {
            this.cliente = cliente;
            this.productos = productos;
            CalcularGanancias();
        }
        static Venta()
        {
            lastID = 0;
        }
        private Venta()
        {
            lastID += 1;
            this.id = lastID;
        }

        public Cliente Comprador
        {
            get
            {
                return this.cliente;
            }
            set
            {
                this.cliente = value;
            }
        }
        public Stack<Producto> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }

        public StringBuilder Information(Stack<Producto> productos)
        {
            StringBuilder datos = new StringBuilder();
            foreach (Producto item in productos)
            {
                datos.AppendLine("------------------------------------------");
                datos.AppendLine("Producto: " + item.Nombre);
                datos.AppendLine("Descripcion:" + item.Descripcion);
                datos.AppendLine("Precio: " + item.Precio);
                datos.AppendLine("ID: " + item.Id);
                datos.AppendLine("------------------------------------------");
            }
            return datos;
        }
        private void CalcularGanancias()
        {
            if (this.productos is not null)
            {
                foreach (Producto item in productos)
                {
                    if(item.Precio > 0)
                    {
                        this.ganancia += item.Precio;
                    }
                }
            }
        }
    }
}
