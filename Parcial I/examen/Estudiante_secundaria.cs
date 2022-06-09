using System;
namespace EXAMEN_DE_POO_JAMILETH
{
    class Estudiante_secundaria : Estudiante, IEstudiante
    {
        public int Nivel { set; get; }
        public int Precio_fijo { set; get; }
        public Estudiante_secundaria (int Nivel, int Precio_fijo, string nombre, string apellido, int cedula_identidad, string nombre_institucion) : base (nombre, apellido, cedula_identidad, nombre_institucion)
        {
            this.Nivel = Nivel;
            this.Precio_fijo = Precio_fijo;
        }
        public override void imprimir()
        {
            Console.writeLine("Datos del estudiante");
            Console.writeLine("Nombres y apellidos: " +nombre+ ""+apellido);
            Console.writeLine("Cedula de identidad: " +cedula_identidad);
            Console.writeLine("Nombre de la institucion: " +nombre_institucion);
            Console.writeLine("Nivel: " +Nivel);
            Console.writeLine("Precio fijo: "+Precio_fijo);
        }
        public override void calcular() 
        {
            int total=0;
            total=Nivel_cursado*Precio_fijo;
            Console.writeLine("el valor de la matricula es: $"+total);
            return total;
        }
        
    }   
}