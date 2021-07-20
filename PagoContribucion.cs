using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{

    //Se procedió a crear una clase que se enfoca solo en otra responsabilidad
    //Por lo tanto, cada clase ahora tiene solo una responsabilidad.
    //En este caso se encuentra Calcular y Pago de Contribucion//

    class PagoContribucion
    {
        public static double CalcularContribucion(Empleado empleado)
        {

            return empleado.Sueldo * 0.20;
        }

        public static void PagarContribucion(Empleado empleado)
        {
            double total = CalcularContribucion(empleado);
            Console.WriteLine("El empleado aporta con $" +total  + " como contibución al IESS");
        }

    }
}


//La finalidad de aplicar este principio es para que al momento una modificación este a nuestro alcance realizarla
//de tal manera que al momento de aplicar cambios sabemos unicamente en donde debemos modificar.
