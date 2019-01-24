using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaJava
{
    class Ruleta
    {
        //Crea el array ruleta con los valores en las distintas posiciones.
        private int[] ruleta = { 0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };

        private int numPremio;
        private String color;

        public Ruleta()
        {
            NumPremio = 0;
            Color = "Verde";
        }
        //get set del objeto ruleta
        public int NumPremio { get => numPremio; set => numPremio = value; }
        public string Color { get => color; set => color = value; }

        //Funcion que genera tirada
        public int GenerarTirada()
        {
            Random rnd = new Random();
            int GetRandomInt(int min, int max)
            {
                return rnd.Next(min, max);
            }

            int myInt = GetRandomInt(0, 37);

            numPremio = ruleta[myInt];
            return myInt;
        }
    }
}
