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
            set
            {
                if (value > 0)
                    saldo = value;
            }
        }
        /// <summary>
        /// Muestra las capacidades del cliente.
        /// </summary>
        /// <returns>Devuelve una cadena con la informacion</returns>
        public new string Help()
        {
            string text = "Un Cliente unicamente puede: \n" +
              "Realizar compras si hay stock disponible\n" +
             "y si cuenta con suficiente dinero.\n" +
             "Cuenta con un atributo extra que es Saldo\n";
            return text;
        }
        /// <summary>
        /// Muestra los datos de una persona.
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Devuelve una cadena con la informacion</returns>
        public override string Mostrar(Persona client)
        {
            Cliente auxCliente = (Cliente)client;
            string datos = $"Nombre: {client.Nombre} | Apellido: {client.Apellido} | DNI:{client.DNI}";
            return datos;
        }

    }
}
