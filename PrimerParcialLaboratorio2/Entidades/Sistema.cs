using System.Collections.Generic;


namespace Entidades
{
    public static class Sistema
    {
        private static List<Empleado> listaEmpleados;
        private static List<Cliente> listaClientes;
        private static List<Producto> listaProductos;
        private static List<Venta> listaVentas;
        //public static List<Empleado> listaEmpleados

        static Sistema()
        {
            Producto prod1 = new Producto("Huesito de Plastico", 50, "Pequenio hueso masticable para que tu perro disfrute!", Tipos.Juguete, 3);
            Producto prod2 = new Producto("Leon de Peluche", 860, "Peluche mediano en forma de leon para que tu mascota juegue sin limite!", Tipos.Juguete, 20);
            Producto prod3 = new Producto("Sabrositos Pqt 1KG", 200, "Bolsa de 1KG de comida para tu mascota.", Tipos.Comida, 20);
            Producto prod4 = new Producto("Golosina sabor Carne", 125, "Golosina masticable con sabor a carne.", Tipos.Comida, 20);
            Stack<Producto> stackProd = new Stack<Producto>();
            stackProd.Push(prod1);
            stackProd.Push(prod2);
            stackProd.Push(prod3);
            stackProd.Push(prod4);
            Cliente client1 = new Cliente("Patricio", "Orce", "38877543", 5000);
            Cliente client2 = new Cliente("Roberto", "Figueroa", "49847542", 5000);
            Cliente client3 = new Cliente("Carla", "Martinari", "29574936", 5000);
            listaEmpleados = new List<Empleado>()
            {
                new Administrador("Carlos", "Araya", "43388647", "CarlosAraya", "Penniways123"),
                new Administrador("Esteban", "Quito", "44324123", "EstebanCARP", "Ardilla123"),
                new Empleado("Margarita", "Flores", "39324133", "Margotta", "AguanteLaRengaPerro123"),
                new Empleado("Pedro", "Lemus", "29326745", "Lemmus45", "987654321pp")
            };
            listaClientes = new List<Cliente>()
            {
                client1,client2,client3,
                new Cliente("Monica","Caeiro","37465937",5000),
                new Cliente("Nicolas","Rodriguez","41302716",5000),
                new Cliente("Fernando","Estocolmo","19478542",5000)
            };
            listaProductos = new List<Producto>()
            {
                prod1, prod2, prod3,prod4,
                new Producto("Cama Multi-Usos",1200,"Cama con tamanio ajustable para todo tipo de mascotas!",Tipos.Comodidad,20),
                new Producto("Shampoo AntiPulgas",260,"Shampoo para mascotas que elimina por completo las pulgas!.",Tipos.Cuidado,20),
                new Producto("Tarrito de alimentos",80,"Tarrito para comida y agua! !",Tipos.Comodidad,20),
                new Producto("Correa",300,"Correa ajustable para todo tipo de mascotas!",Tipos.Cuidado,20)
            };
            listaVentas = new List<Venta>()
            {
                new Venta(client1, stackProd),
                new Venta(client2, stackProd),
                new Venta(client3, stackProd)
            };
        }

        public static List<Empleado> ListaEmpleados
        {
            get { return listaEmpleados; }
            set
            {
                if (value is not null)
                    listaEmpleados = value;
            }
        }

        public static List<Cliente> ListaClientes
        {
            get { return listaClientes; }
            set
            {
                if (value is not null)
                    listaClientes = value;
            }
        }

        public static List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set
            {
                if (value is not null)
                    listaProductos = value;
            }
        }
        public static List<Venta> ListaVentas
        {
            get { return listaVentas; }
            set
            {
                if (value is not null)
                    listaVentas = value;
            }
        }

        public static Empleado FindByDNI(List<Empleado> lista, string dni)
        {
            if (!(lista is null && dni is null))
            {
                foreach (Empleado persona in lista)
                {
                    if (persona.DNI.Equals(dni))
                    {
                        return persona;
                    }
                }
            }
            return null;
        }

        public static Cliente FindByDNI(List<Cliente> lista, string dni)
        {
            if (!(lista is null && dni is null))
            {
                foreach (Cliente persona in lista)
                {
                    if (persona.DNI.Equals(dni))
                    {
                        return persona;
                    }
                }
            }
            return null;
        }

        public static Producto FindProductByID(List<Producto> listaProductos, int id)
        {
            if (!(listaProductos is null))
            {
                foreach (Producto producto in listaProductos)
                {
                    if (producto.Id == id)
                    {
                        return producto;
                    }
                }
            }
            return null;
        }


    }
}
