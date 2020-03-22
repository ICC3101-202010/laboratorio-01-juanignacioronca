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

            //Asignar e imprimir nombre del jugador 1:

            Console.WriteLine("Parte 1: \n");
            Clase_Persona persona1 = new Clase_Persona();
            string Name_1 = persona1.Name = "Juan";
            string LastName_1 = persona1.LastName = "Roncagliolo";
            Console.WriteLine("Nombre jugador: " + Name_1 + " " + LastName_1+"\n");

            // Asignar, convertir e imprimir jugada del jugador 1: 

            Console.WriteLine("Presione cualquier tecla para hacer el lanzamiento: ");
            Console.ReadKey();
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
            Console.WriteLine("Valor jugada: ("+jugada_1+") = "+ conv_jugada_1);
            Console.ReadKey();
        }
    }
}
