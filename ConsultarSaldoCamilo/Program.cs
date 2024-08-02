using System;

namespace ConsultarSaldoCamilx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sea bienvenido al mejor cajero automático");
            if (InicioSesion())
            {
                Console.WriteLine("Su inicio de sesión fue un éxito. ");
                ConsultarSaldo();
            }
            else
            {
                Console.WriteLine("Su intento de inicio de sesión fue un fracaso. ");
            }
        }

        static bool InicioSesion()
        {
            Console.Write("Por favor, inserte su Usuario.  ");
            string usuario = Console.ReadLine();
            Console.Write("Digite su clave:  ");
            string clave = Console.ReadLine();
            return usuario == "Camile" && clave == "1033";
        }

        static void ConsultarSaldo()
        {
            decimal saldo = 4000.00m; 
            Console.WriteLine($"Su saldo actual es de: ${saldo:C}.");
        }
    }
}
