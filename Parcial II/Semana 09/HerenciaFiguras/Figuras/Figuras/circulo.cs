using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class circulo : figura, Interfaces.IFigura
    {

        public Double radio { set; get; }
        public circulo(Double radio, string nombre, string color) : base(nombre, color)
        {
            this.radio = radio;
        }
        public Double calculoDeArea()
        {
            Double area;
            area = Math.PI * Math.Pow(radio, 2);
            return area;
        }

        public new void imprimir()
        {
            Console.WriteLine("--------Circulo---------");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Area: "+ calculoDeArea());
        }


    }
}
