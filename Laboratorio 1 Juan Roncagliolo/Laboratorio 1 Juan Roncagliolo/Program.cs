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
                Console.WriteLine("------------Parte 1:------------\n");
                Console.WriteLine("Nombre jugador: " + Clase_Persona.Name_1 + " " + Clase_Persona.LastName_1 + "\n");

                // Asignar, convertir e imprimir jugada del jugador 1: 

                Clase_Persona persona1 = new Clase_Persona("Juan", "Roncagliolo");
                int jugada_1 = persona1.Lanzar();
                string conv_jugada_1;
                if (jugada_1 == 0)
                {
                    conv_jugada_1 = "Piedra";
                }
                else if (jugada_1 == 1)
                {
                    conv_jugada_1 = "Papel";
                }
                else
                {
                    conv_jugada_1 = "Tijera";
                }
                Console.WriteLine("Valor jugada: (" + jugada_1 + ") = " + conv_jugada_1);
                Console.WriteLine("\n----------Fin parte 1-----------\n\nPresione 'Enter' para continuar: \n");
                Console.ReadKey();
            }

            //Parte 2:

            //Utilizacion del contructor:
            {
                Console.WriteLine("------------Parte 2:------------\n");
                Clase_Persona persona2 = new Clase_Persona("Bob", "Kunga");
                Console.WriteLine("\nNombre jugador: " + persona2.Name + " " + persona2.LastName + "\n");
                int jugada_2 = persona2.Lanzar();
                string conv_jugada_2;
                if (jugada_2 == 0)
                {
                    conv_jugada_2 = "Piedra";
                }
                else if (jugada_2 == 1)
                {
                    conv_jugada_2 = "Papel";
                }
                else
                {
                    conv_jugada_2 = "Tijera";
                }
                Console.WriteLine("Valor jugada: (" + jugada_2 + ") = " + conv_jugada_2);
                Console.WriteLine("\n----------Fin parte 2-----------\n\nPresione 'Enter' para salir: \n");
                Console.ReadKey();
            }

        }
    }
}
