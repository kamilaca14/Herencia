using Herencia;
using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Estudiantes stu = new Estudiantes("Harold Steveen", "Acosta Patiño", 1702020202, "casado", "3C");
            stu.imprimir();


            Empleados empleados = new Empleados("Despacho#10 ", 2018, "Camila", "Intriago", 1764876378, "Soltera");
            empleados.imprimir();



            PersonalServicio pers = new PersonalServicio("Decanatosalir", "Meybili", "Olivares", 1315478954, "Casada");
            pers.imprimir();




            Profesores profesores = new Profesores("Arquitectura ", "Italia", "Arauz", 137673, "soltera");
            profesores.imprimir();






        }
    }
}
