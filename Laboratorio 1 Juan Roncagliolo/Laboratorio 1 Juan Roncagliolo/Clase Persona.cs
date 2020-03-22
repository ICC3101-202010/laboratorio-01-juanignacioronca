using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1_Juan_Roncagliolo
{
    class Clase_Persona
    {
        //Creacion de atributos
        public string Name;
        public string LastName;
        //Creacion metodo lanzar
        public int Lanzar()
        {
            Random rnd = new Random();
            int hand = rnd.Next(0,3);
            return hand;
        }

    }
}
