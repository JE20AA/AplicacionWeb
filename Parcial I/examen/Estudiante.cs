
USING SYSTEN;

internal partial class Program
{
    private class NewBaseType
    {
        public string nombresA { set; get; }
        public string apellidosA { set; get; }
        public int cedula_I_A { set; get; }
        public string nombrede_Institucion { set; get; }
    }

    class Estudiante : NewBaseType
    {
        public Estudiante(string nombres_del_alumno, string apellidos_del_alumno, int cedula_de_identidad_del_alumno, string nombre_de_la_institucion_educativa)
    {
        this.nombresA = nombres_del_alumno;
        this.apellidosA= apellidos_del_alumno;
        this.cedula_I_A = cedula_de_identidad_del_alumno;
        this.nombrede_Institucion = nombre_de_la_institucion_educativa; 
    }
}


