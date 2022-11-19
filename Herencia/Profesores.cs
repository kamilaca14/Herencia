using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Profesores:Humano
    {


        public string Departemanto { get; set; }




        public Profesores(string Departemanto, string Nombre, string Apellidos, int Id, string Estado_Civil) : base(Nombre, Apellidos, Id, Estado_Civil)
        {

            this.Departemanto = Departemanto;
        }


        public void imprimir()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("    Personal de Profesores");
            Console.WriteLine("");
            Console.WriteLine("Departamento Asignado: " + Departemanto);
            Console.WriteLine("");
            Console.WriteLine("NOMBRE:  " + Nombre + " " + Apellidos);
            Console.WriteLine("Numero de Identificacion: " + Id);
            Console.WriteLine("Estado civil es de : " + Estado_Civil);

            Console.WriteLine("");
            opcioness();
            Console.WriteLine("");

            Console.WriteLine("*******************************************");

        }

        public void opcioness()
        {
            String options;
            Console.WriteLine("Opciones alternas:");
            Console.WriteLine("Si desea cambiar el personal utilize Ingrese: 1");
            Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
            Console.WriteLine("Si desea salir utilize: salir ");
            options = Console.ReadLine();
            cambio(options);
        }
        public void cambio(String cambios)
        {

            switch (cambios.ToString())
            {
                case "1":
                    cambio_de_departamento();
                    break;
                case "2":
                    cambioEcivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void cambio_de_departamento()
        {
            String departmento_nuevo;
            Console.WriteLine("Ingrese el nuevo departamento");
            departmento_nuevo = Console.ReadLine();
            Console.WriteLine("Departamento cambiado exitosamente");
            Departemanto = departmento_nuevo;
        }
    }
}








    
