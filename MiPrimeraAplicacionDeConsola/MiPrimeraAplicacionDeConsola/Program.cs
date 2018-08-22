using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escribimos en la consola...
            //Console.WriteLine("Hola mundo!!");


            //Desde la línea de abajo... comentamos varias líneas...
            /*
            
            Console.WriteLine("Cual es tu nombre?");

            string nombre = "";

            nombre = Console.ReadLine();

            */



            //Leer de consola.
            //Console.ReadLine();

            


            double nota1, nota2, nota3, nota4;
            double promedio;

            Console.Write("Ingrese nota 1: ");

            nota1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Ingrese nota 2: ");

            nota2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Ingrese nota 3: ");

            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese nota 4: ");

            nota4 = Convert.ToDouble(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            string mostrarPromedio = "";

            mostrarPromedio = "El promedio es: " + promedio + " cuyas notas fueron: " + nota1 + " " + nota2 + " " + nota3 + " " + nota4 ;

            //Console.WriteLine("El promedio es: {0} - {2} {0} ", promedio, nota3 , nota4);
            Console.WriteLine(mostrarPromedio);

            Console.ReadKey();
        }
    }
}
