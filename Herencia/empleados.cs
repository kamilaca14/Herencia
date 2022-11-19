using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
   
        class Empleados : Humano
        {

            public string Num_despacho { set; get; }
            public int año { set; get; }


            public Empleados(string Num_despacho, int año, string Nombre, string Apellidos, int Id, string Estado_Civil) : base(Nombre, Apellidos, Id, Estado_Civil)
            {
                this.Num_despacho = Num_despacho;
                this.año = año;
            }
            public void imprimir()
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("Empleados");
                Console.WriteLine("");
                Console.WriteLine("Num de Despacho: " + Num_despacho);
                Console.WriteLine("");
                Console.WriteLine("Año de incorporacion: " + año);
                Console.WriteLine("NOMBRE:  " + Nombre + " " + Apellidos);
                Console.WriteLine("Num de Identificacion: " + Id);
                Console.WriteLine("Estado civil es de : " + Estado_Civil);
                Console.WriteLine("");
                opcioness();
                Console.WriteLine("");
                Console.WriteLine("*************++**************************");
            }

            public void opcioness()
            {
                String options;
                Console.WriteLine("Otras opciones:");
                Console.WriteLine("En caso de cambiar el despacho  Ingrese: 1");
                Console.WriteLine("En caso de cambiar el Estado Civil Ingrese: 2");
                Console.WriteLine("Si desea salir utilize: salir ");
                options = Console.ReadLine();
                cambio(options);
            }
            public void cambio(string cambios)
            {

                switch (cambios.ToString())
                {
                    case "1":
                        cambio_despacho();
                        break;
                    case "2":
                        cambioEcivil();
                        break;
                    case "salir":
                        Console.WriteLine("....");
                        break;

                }

            }
            public void cambio_despacho()
            {
                string despacho_new;
                Console.WriteLine("Ingrese el nuevo espacho");
                despacho_new = Console.ReadLine();
                Console.WriteLine("Despacho cambiado exitosamente");
                Num_despacho = despacho_new;
            }
        }

    }


