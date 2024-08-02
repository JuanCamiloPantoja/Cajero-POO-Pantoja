using System;

namespace BaseCajeroAPP
{
    class Cajero
    {
        public void Iniciar()
        {
            Console.WriteLine("Un gusto, en este momento estás utilizando el mejor cajero automático existente.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cajero cajero = new Cajero();

            cajero.Iniciar();
            Console.ReadKey();
        }
    }
}
