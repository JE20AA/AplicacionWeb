using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class figura
    {
        //Metodos set y get (ingreso de datos, y visualizacion de datos)
        public String nombre { set; get; }

        public String color { set; get; }

        //constructor de la clase figura.
        public figura(String nombre, String color)
        {
            this.nombre = nombre;
            this.color = color;
        }

        //metodo o funcion para imprimir los datos.

        public void imprimir()
        {
            Console.WriteLine("--------Figura---------");
            Console.WriteLine("Nombre: "+ this.nombre);
            Console.WriteLine("Color: " + this.color);
        }



    }
}
