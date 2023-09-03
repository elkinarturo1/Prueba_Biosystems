using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ConfigurationModel
    {

        public ConfigurationModel()
        {
            Console.WriteLine("Por favor configure las reglas de juego!");

            ConfigurationModel configurationModel = new ConfigurationModel();

            Console.WriteLine("Por favor configure la puntuacion reguerida para ganar!");
            configurationModel.punctuationRequiredForWin = int.Parse(Console.ReadLine());

            Console.WriteLine("Defina la cantidad de puntos por Juego!");
            int cantItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantItems; i++)
            {
                Console.WriteLine("Defina el punto que añadira al Juego!");
                int point = int.Parse(Console.ReadLine());
            }

            configurationModel.punctuationInitial = int.Parse(Console.ReadLine());


            Console.WriteLine("Por favor configure la puntuacion reguerida para ganar!");
            configurationModel.punctuationRequiredForWin = int.Parse(Console.ReadLine());

            Console.Read();
        }

        public int punctuationRequiredForWin { get; set; }
        public int punctuationInitial { get; set; }
        List<int> punctuationListOfGame { get; set; }
        public int pontsDifference { get; set; }
        public int gamesDifference { get; set; }
        public int setsDifference { get; set; }

    }
}
