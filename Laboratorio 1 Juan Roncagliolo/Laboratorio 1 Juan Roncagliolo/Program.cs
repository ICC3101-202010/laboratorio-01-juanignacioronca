using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1_Juan_Roncagliolo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa parte 1:

            //Imprimir nombre del jugador 1:
            {
                // Asignar e imprimir jugada del jugador 1: 

                Clase_Persona persona1 = new Clase_Persona("Juan", "Roncagliolo");
                int jugada_1 = persona1.Lanzar();
                Console.WriteLine(jugada_1);
            }
            //Parte 2:

            //Utilizacion del contructor:
            {
                Clase_Persona persona2 = new Clase_Persona("Bob", "Kunga");
                Console.WriteLine(persona2.Name + " " + persona2.LastName + "\n");
                Console.WriteLine("Presione 'Enter' para salir:");
                Console.ReadKey();
            }

        }
    }
}
