using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Sistema de Contribución al IESS");
            Console.WriteLine("Datos personales:");

            Empleado empleado = new Empleado();
            empleado.Nombres = "Pablo Cam";
            empleado.Apellidos = "Paz Alcívar";
            empleado.Cedula = 1318883804;
            empleado.NumeroTelefono = 293923342;
            empleado.Oficio = "Arquitecto";
            empleado.Sueldo = 19000;
            empleado.AñosAportados = 5;

            Console.WriteLine(empleado.MostrarDatos());

            Console.WriteLine(PagoContribucion.CalcularContribucion(empleado));
            PagoContribucion.PagarContribucion(empleado);
            
        }
    }
}
