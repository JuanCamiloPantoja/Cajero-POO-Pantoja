using System;

namespace RetiroCajeroCamilx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sea usted bienvenido al mejor cajero automático. ");
            if (InicioSesion())
            {
                Console.WriteLine("Su inicio de sesión en un éxito. ");
                Retiro();
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

        static void Retiro()
        {
            Console.Write("¿Qué monto desea sacar?");
            decimal Cantidad = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Usted ha sacado:  ${Cantidad:C}.");
        }
    }
}
