using System;

namespace EXAMEN_DE_POO_JAMILETH
{
    class Estudiante_primaria: Estudiante, IEstudiante
    {
        public int valor { set; get; }
        public Estudiante_primaria (int valor, string nombres_del_alumno, string apellidos_del_alumno, int cedula_de_identidad_del_alumno, string nombre_de_la_institucion_educativa) : base (nombres_del_alumno, apellidos_del_alumno, cedula_de_identidad_del_alumno, nombre_de_la_institucion_educativa)
        {
            this.valor = valor;
        }
        public void imprimir()
        {
            Console.writeLine("Datos del estudiante");
            Console.writeLine("Nombres y apellidos: " +nombre+ ""+apellido);
            Console.writeLine("Cedula de identidad: " +cedula_identidad);
            Console.writeLine("Nombre de la institucion: " +nombre_institucion);
        }
        public int calcular() 
        {
            Console.writeLine("El valor de la matricula es $" +Precio_fijo);
           return Precio_fijo;

        }     
    }   
}