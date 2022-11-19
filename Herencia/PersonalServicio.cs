using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class PersonalServicio:Humano
    {
        public string SeccionAsignado { get; set; }


        public PersonalServicio(string SeccionAsignado, string Nombre, string Apellidos, int Id, string Estado_Civil)
            : base(Nombre, Apellidos, Id, Estado_Civil)
        {

            this.SeccionAsignado = SeccionAsignado;
        }

        public void imprimir()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("    Personal del trabajo");
            Console.WriteLine("");
            Console.WriteLine("Seccion Asignada: " + SeccionAsignado);
            Console.WriteLine("");
            Console.WriteLine("NOMBRE:  " + Nombre + " " + Apellidos);
            Console.WriteLine("Numero de Identificacion: " + Id);
            Console.WriteLine("Estado civil es de : " + Estado_Civil);
            Console.WriteLine("");
            opcioness();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");


        }
        public void opcioness()
        {
            String options;
            Console.WriteLine("Opciones alternas:");
            Console.WriteLine("Si quiere trasladar de seccion  Ingrese: 1");
            Console.WriteLine("Si quiere cambiar el Estado Civil Ingrese: 2");
            Console.WriteLine("Si quiere salir utilize: salir ");
            options = Console.ReadLine();
            cambio(options);
        }
        public void cambio(String cambios)
        {

            switch (cambios.ToString())
            {
                case "1":
                    cambiopersonal();
                    break;
                case "2":
                    cambioEcivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void cambiopersonal()
        {
            String translado_nuevo;
            Console.WriteLine("Ingrese el nuevo translado de seccion");
            translado_nuevo = Console.ReadLine();
            Console.WriteLine("seccion cambiado exitosamente");
            SeccionAsignado = translado_nuevo;
        }
    }

}



   