using System;

namespace TransferenciaCajeroCamilx
{
    class Program
    {
        static void Main(string[] args)
        {
            CajeroAutomatico cajero = new CajeroAutomatico();
            cajero.Iniciar();
        }
    }

    public class CajeroAutomatico
    {
        private Usuario usuario;

        public void Iniciar()
        {
            Console.WriteLine("Sea usted bienvenido al mejor cajero automático.");
            if (InicioSesion())
            {
                Console.WriteLine("Su inicio de sesión fue un éxito.");
                Transferencia transferencia = new Transferencia();
                transferencia.RealizarTransferencia();
            }
            else
            {
                Console.WriteLine("Su intento de inicio sesión fracasó.");
            }
        }

        private bool InicioSesion()
        {
            Console.Write("Por favor, inserte su Usuario: ");
            string nombreUsuario = Console.ReadLine();
            Console.Write("Digite su clave: ");
            string claveUsuario = Console.ReadLine();
            usuario = new Usuario(nombreUsuario, claveUsuario);
            return usuario.Validar();
        }
    }

    public class Usuario
    {
        private string NombreUsuario { get; }
        private string ClaveUsuario { get; }

        public Usuario(string nombreUsuario, string claveUsuario)
        {
            NombreUsuario = nombreUsuario;
            ClaveUsuario = claveUsuario;
        }

        public bool Validar()
        {
            return NombreUsuario == "Camile" && ClaveUsuario == "1033";
        }
    }

    public class Transferencia
    {
        public void RealizarTransferencia()
        {
            Console.Write("¿Qué monto desea transferir? ");
            decimal monto = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Por favor, inserte el número de cuenta que le pertenezca al destinatario: ");
            string numeroCuenta = Console.ReadLine();
            Console.WriteLine($"Usted ha transferido {monto:C} a la cuenta {numeroCuenta}.");
            Console.ReadKey();
        }
    }
}
