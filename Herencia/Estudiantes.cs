using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class Estudiantes:Humano
    {

        public string curso { get; set; }


        public Estudiantes(string Nombre, string Apellidos, int Id, string Estado_Civil, string curso) : base(Nombre, Apellidos, Id, Estado_Civil)
        {
            this.curso = curso;

        }
        public void imprimir()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Matriculacion de Estudiante");
            Console.WriteLine("");
            Console.WriteLine("El curso asignado es:  " + curso);
            Console.WriteLine("El nombre del estudiante es: " + Nombre + " " + Apellidos);
            Console.WriteLine("El numero de Identificacion: " + Id);
            Console.WriteLine("Su estado civil es de : " + Estado_Civil);
            opcioness();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");

        }
        public void opcioness()
        {
            string options;
            Console.WriteLine("Opciones alternas:");
            Console.WriteLine("Si desea cambiar el curso dijite: 1");
            Console.WriteLine("Si desea cambiar el Estado Civil dijite: 2");
            Console.WriteLine("Si desea salir escriba : salir ");
            options = Console.ReadLine();
            cambio(options);
        }
        public void cambio(string cambios)
        {

            switch (cambios.ToString())
            {
                case "1":
                    curso_nuevo();
                    break;
                case "2":
                    cambioEcivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void curso_nuevo()
        {
            string curso_new;
            Console.WriteLine("Ingrese el nuevo Curso");
            curso_new = Console.ReadLine();
            Console.WriteLine("Curso cambiado exitosamente");
            curso = curso_new;
        }
    }

}