using System;
namespace EXAMEN_DE_POO_JAMILETH
{
    class Estudiante_universitario : Estudiante, IEstudiante
    {
        public int creditos { set; get; }
        public int valor_creditos { set; get; }
        public Estudiante_universitario (int creditos, int valor_creditos,string nombre, string apellido, int cedula_identidad, string nombre_institucion) : base (nombre, apellido, cedula_identidad, nombre_institucion)
        {
            this.creditos = creditos;
            this.valor_creditos = valor_creditos;
        }
        public override void imprimir()
        {
            Console.writeLine("Datos del estudiante");
            Console.writeLine("Nombres y apellidos: " +nombre+ ""+apellido);
            Console.writeLine("Cedula de identidad: " +cedula_identidad);
            Console.writeLine("Nombre de la institucion: " +nombre_institucion);
            Console.writeLine("creditos: " +creditos);
            Console.writeLine("valor de creditos: "+Precio_fijo);

        }
        public override void calcular() 
        {
            int total=0;
            total=creditos*valor_creditos;
            Console.writeLine("el valor de la matricula es: $"+total);
            return total;
        }
    }
}