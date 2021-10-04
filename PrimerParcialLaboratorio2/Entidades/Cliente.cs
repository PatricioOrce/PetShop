using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        double saldo;

        public Cliente(string nombre, string apellido, string dni, double saldo) : base(nombre, apellido, dni)
        {
            this.saldo = saldo;
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public new string Help()
        {
            string text = "Un Cliente unicamente puede: \n" +
              "Realizar compras si hay stock disponible\n" +
             "y si cuenta con suficiente dinero.\n" +
             "Cuenta con un atributo extra que es Saldo\n";
            return text;
        }
        public override string Mostrar(Persona client)
        {
            Cliente auxCliente = (Cliente)client;
            string datos = $"Nombre: {client.Nombre} | Apellido: {client.Apellido} | DNI:{client.DNI}";
            return datos;
        }

    }
}
