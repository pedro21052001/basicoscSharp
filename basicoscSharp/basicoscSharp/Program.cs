using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicoscSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PEDRO");
            int añoActual = Convert.ToInt32("2019");
            double numeroPI = 3.141592;
            Console.WriteLine("Valores:{0} -- {1}", añoActual, numeroPI);
            decimal montoFactura = 94593.34m + 0.07m;
            float impuestoVenta = 9239.04f;
            Console.WriteLine("Valores:{0} -- {1}", montoFactura, impuestoVenta);
            char letraInicial = 'p';
            string nombreCurso = letraInicial + "rogramacion II";
            Console.WriteLine("Este es el curso {0}", nombreCurso);
            bool boolVerdadero = true;
            bool boolFalso = false;
            Console.WriteLine("Variables boleanas: {0} y {1}", boolVerdadero, boolFalso);
            Console.ReadLine();


        }
    }
}
