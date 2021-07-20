using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class Empleado
    {


        //Propiedades u características de la clase Empleado//
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Cedula { get; set; }
        public int NumeroTelefono { get; set; }
        public string Oficio { get; set; }
        public double Sueldo { get; set; }
        public int AñosAportados { get; set; }

        public Empleado()
        {
        }

        // Método de Mostrar Datos aplicado a esta clase//
        public string MostrarDatos()
        {
            return this.Nombres+"\n"+this.Apellidos+"\n"+this.Cedula+"\n"+this.NumeroTelefono+"\n"+this.Oficio+"\n"+this.Sueldo+"\n"+this.AñosAportados+"\n";
        }



        //A simple viste se deduce que los dos métodos incorporados se incluyen en la clase empleado.
        //Sin embargo, al momento en que cambie el procentaje para calcular el pago al IESS se encontraría
        //un problema puesto de que habría que modificar el proceso de cálculo.
      
        // Metodos empleados//
        //public double CalcularContribucion()
        //{
        //    return Sueldo * 0.20;
        //}
        //public void PagarContribucion()
        //{
        //    double total = CalcularContribucion();
        //    Console.WriteLine("El empleado", Nombres, Apellidos, "aporta con", total, "como contibución al IESS");
        //}
        //
    }
}
