using System;

namespace DepositoCajeroCamilx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sea usted bienvenido al mejor cajero automático. ");
            if (InicioSesion())
            {
                Console.WriteLine("Su inicio de sesión fué todo un éxito. ");
                Depositar();
            }
            else
            {
                Console.WriteLine("Su intento de inicio de sesión ha fracasado. ");
            }
        }

        static bool InicioSesion()
        {
            Console.Write("Digite su usuario por favor:  ");
            string usuario = Console.ReadLine();
            Console.Write("Por favor, ingrese su clave ");
            string clave = Console.ReadLine();
            return usuario == "Camile" && clave == "1033";
        }

        static void Depositar()
        {
            Console.Write("Ingrese el monto que desea depositar por favor: ");
            decimal deposite = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Usted ha depositado correctamente:  ${deposite:C}.");
        }
    }
}
