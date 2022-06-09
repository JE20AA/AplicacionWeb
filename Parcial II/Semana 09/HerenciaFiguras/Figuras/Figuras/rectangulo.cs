using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class rectangulo : figura, Interfaces.IFigura
    {
        
        public Double basee { set; get; }

        public Double altura { set; get; }

        public rectangulo(Double basee, Double altura, string nombre, string color) : base(nombre, color)
        {
            this.basee = basee;
            this.altura = altura;

        }

        public double calculoDeArea()
        {
            Double area;
            area = basee * altura;
            return area;
        }

        //metodo o funcion para imprimir los datos.

        public new void imprimir()
        {
            Console.WriteLine("--------Rectangulo---------");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Area: " + calculoDeArea());
        }

    }
}
