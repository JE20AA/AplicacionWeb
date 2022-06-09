using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{   //clase hijo
    internal class cuadrado : figura, Interfaces.IFigura//relaciamos con la clase padre(figura), e integramos la interface creada (Interfaces.IFigura)
    {
        public Double lados { set; get; }


        public cuadrado(Double lados, string nombre, string color) : base(nombre, color)
        {
            this.lados = lados;
        }


        public Double calculoDeArea()
        {
            Double resultado;
            resultado = this.lados * this.lados;
            return resultado;

        }

        public new void imprimir()
        {
            Console.WriteLine("--------Cuadrado---------");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Area: "+ calculoDeArea());

        }

        
    }
}
