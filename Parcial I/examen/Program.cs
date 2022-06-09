using System;

namespace EXAMEN_DE_POO_JAMILETH
{
    class Program
    {
        static void Main (string[]args)
        {
        Estudiante_primaria estudiante_primaria = new Estudiante_primaria(100, "Meredith Elizabeth","Vazquez Alcivar","Francizco Muñoz", 12435678385);
        Estudiante_primaria. imprimir();
        Estudiante_primaria. calcular();

        Estudiante_secundaria estudiante_secundaria = new Estudiante_secundaria(10, 25, "Fabricio Alejandro","Cedeño Garcia","Olmedo", 12435678385);
        Estudiante_secundaria. imprimir();
        Estudiante_secundaria. calcular();

        Estudiante_universitario estudiante_universitario = new Estudiante_universitario(20, 12, "Yared Michael","Mero Bailon","Uleam", 12435678385);
        Estudiante_universitario. imprimir();
        Estudiante_universitario. calcular();
        }

    }
}