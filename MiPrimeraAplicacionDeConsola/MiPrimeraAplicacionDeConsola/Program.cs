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




            double nota1 = 0; 
            double promedio;


            for (int i = 1; i <= 4; i++)
            {

                Console.WriteLine("Ingrese la nota número: " + i.ToString());
                nota1 += Convert.ToDouble(Console.ReadLine());

            }


            promedio = (nota1) / 4;

            string mostrarPromedio = "";

            mostrarPromedio = "El promedio es: " + promedio;

            //Console.WriteLine("El promedio es: {0} - {2} {0} ", promedio, nota3 , nota4);
            Console.WriteLine(mostrarPromedio);

            Console.ReadKey();
        }
    }
}
