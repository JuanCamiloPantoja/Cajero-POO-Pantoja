using System;

namespace InicioSesionCamilx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sea bienvenido al mejor cajero automático");
            if (InicioSesion())
            {
                Console.WriteLine("Su inicio de sesión fue un éxito. ");
                
            }
            else
            {
                Console.WriteLine("Su inicio de sesión fue un fracaso. ");
            }
        }

        static bool InicioSesion()
        {
            Console.Write("Por favor, digite su usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Inserte su clave: ");
            string clave = Console.ReadLine();
            return usuario == "Camile" && clave == "1033"; 
        }
    }
}
