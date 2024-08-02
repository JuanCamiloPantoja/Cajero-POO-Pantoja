using System;

namespace TrnasferenciaCajeroCamilx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sea usted bienvenido al mejor cajero automático. ");
            if (InicioSesion())
            {
                Console.WriteLine("Su inicio de sesión en un éxito. ");
                TransferenciaCam();
            }
            else
            {
                Console.WriteLine("Su intentó de inicio sesión fracasó. ");
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

        static void TransferenciaCam()
        {
            Console.Write("¿Qué monto desea transferir? ");
            decimal monto = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Por favor, inserte el número de cuenta que le pertenezca al destinario: ");
            string NumCuenta = Console.ReadLine();
            Console.WriteLine($"Usted ha pasado {monto:C} a la cuenta {NumCuenta}.");
        }
    }
}
