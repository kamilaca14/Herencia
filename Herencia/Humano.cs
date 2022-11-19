using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class Humano
    {


        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public int Id { set; get; }
        public string Estado_Civil { set; get; }


        public Humano(string Nombre, string Apellidos, int Id, string Estado_Civil)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Id = Id;
            this.Estado_Civil = Estado_Civil;
        }
        public void cambioEcivil()
        {
            string Estadocivil;
            do
            {
                Console.WriteLine("Ingrese el nuevo Estado Civil");
                Console.WriteLine("- Soltero ");
                Console.WriteLine("- Casado ");
                Console.WriteLine("- Viudo ");

                Estadocivil = Console.ReadLine();

                if (Estadocivil == "Soltero" || Estadocivil == "soltero")
                {
                    Estado_Civil = Estadocivil;
                    Console.WriteLine("El cambio se realizo con exito");
                }
                else if (Estadocivil == "Casado" || Estadocivil == "casado")
                {
                    Estado_Civil = Estadocivil;
                    Console.WriteLine("El cambio se realizo con exito");
                }
                else if (Estadocivil == "Viudo" || Estadocivil== "viudo")
                {
                    Estado_Civil = Estadocivil;
                    Console.WriteLine("El cambio se realizo con exito");
                }
                else
                {
                    Console.WriteLine("El estado civil ingresado es  Incorrecto");
                    Console.WriteLine("Digite el nuevo Estado Civil");
                    Console.WriteLine("- Soltero ");
                    Console.WriteLine("- Casado ");
                    Console.WriteLine("- Viudo ");
                    Estadocivil = Console.ReadLine();
                    Console.WriteLine("Su estado civil a sido cambiado ");

                }
            } while (Estadocivil != null && Estadocivil == "Soltero" && Estadocivil == "Casado" && Estadocivil == "Viudo");
        }

    }
}

    
