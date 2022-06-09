using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {   //listas para ingresar los objetos creados
            List<cuadrado> arrayCuadrado = new List<cuadrado>();
            List<circulo> arrayCirculo = new List<circulo>();
            List<rectangulo> arrayRectangulo = new List<rectangulo>();

            //objetos cuadrados
            cuadrado cuadrado1 = new cuadrado(5.35, "Cuadrado", "Azul");
            cuadrado cuadrado2 = new cuadrado(6.75, "Cuadrado2", "Rojo");

            //objetos circulos
            circulo circulo1 = new circulo(4.75, "Circulo1", "Rojo");
            circulo circulo2 = new circulo(7.75, "Cirtulo2", "negro");

            //objetos rectanguo
            rectangulo rectangulo1 = new rectangulo(8.45, 10, "retangulo1", "amarillo");
            rectangulo rectangulo2 = new rectangulo(9.76, 13, "retangulo2", "celeste");
            rectangulo rectangulo3 = new rectangulo(9, 11, "retangulo3", "blanco");


            //Añade cada objeto a la listas creadas para cada uno.

            //add para cuadrados en las lista de List<cuadrado>
            arrayCuadrado.Add(cuadrado1);
            arrayCuadrado.Add(cuadrado2);
            //add para circulos en lista de List<circulo>
            arrayCirculo.Add(circulo1);
            arrayCirculo.Add(circulo2);
            //add para rectangulos en lista de List<rectangulo>
            arrayRectangulo.Add(rectangulo1);
            arrayRectangulo.Add(rectangulo2);
            arrayRectangulo.Add(rectangulo3);


            Console.WriteLine("|||||||||||||||||||||FIGURAS|||||||||||||||||||");
            foreach (var item in arrayCuadrado)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine(item.nombre);
                Console.WriteLine(item.color);
                Console.WriteLine(item.calculoDeArea());
            }

            foreach (var item in arrayCirculo)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine(item.nombre);
                Console.WriteLine(item.color);
                Console.WriteLine(item.calculoDeArea());
            }

            foreach (var item in arrayRectangulo)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine(item.nombre);
                Console.WriteLine(item.color);
                Console.WriteLine(item.calculoDeArea());
            }

            Console.ReadKey();
        }


    }
}
