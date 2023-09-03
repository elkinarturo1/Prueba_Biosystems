using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ConfigurationModel
    {

        public void ConfigInitial()
        {

            List<int> reglaPuntaje = new List<int>();

            try
            {
                Console.WriteLine("Por favor configure las reglas de juego!");

                Console.WriteLine("Digite la cantidad de puntos por Juego!");
                int cantItems = int.Parse(Console.ReadLine());

                for (int i = 0; i < cantItems; i++)
                {
                    Console.WriteLine("Digite el punto que se añadira a la lista de puntos del Juego!");
                    reglaPuntaje.Add(int.Parse(Console.ReadLine()));
                }

                this.reglaPuntaje = reglaPuntaje;

                Console.WriteLine("Por favor digite la cantidad de juegos a jugar por Set!");
                this.cantidadJuegos_a_Jugar = int.Parse(Console.ReadLine());

                Console.WriteLine("Por favor digite la cantidad de juegos a ganar para ganar un Set!");
                this.cantidadJuegos_a_Ganar = int.Parse(Console.ReadLine());

                Console.WriteLine("Por favor digite la cantidad de sets a jugar por Partido!");
                this.cantidadSets_a_Jugar = int.Parse(Console.ReadLine());

                Console.WriteLine("Por favor digite la cantidad de sets a ganar para ganar un Partido!");
                this.cantidadSet_a_Ganar = int.Parse(Console.ReadLine());
          
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<int> reglaPuntaje { get; set; }
        public int cantidadJuegos_a_Jugar { get; set; }
        public int cantidadJuegos_a_Ganar { get; set; }
        public int cantidadSets_a_Jugar { get; set; }
        public int cantidadSet_a_Ganar { get; set; }

    }
}
