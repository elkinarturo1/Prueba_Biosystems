using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Clases
{
    public class clsPartido
    {
        int cantidadSets_a_Jugar = 0;
        int cantidadSet_a_Ganar = 0;       

        /// <summary>
        /// Devuelve el ganador del partido
        /// </summary>
        /// <returns></returns>
        public string jugar()
        {

            PlayerModel jugador1 = new PlayerModel();
            PlayerModel jugador2 = new PlayerModel();

            string ganador = "";
            string ganadorSet = "";

            ConfigurationModel configurationModel = new ConfigurationModel();
            configurationModel.ConfigInitial();

            cantidadSets_a_Jugar = configurationModel.cantidadSets_a_Jugar;
            cantidadSet_a_Ganar = configurationModel.cantidadSet_a_Ganar;

            for (int i = 0; i < cantidadSets_a_Jugar; i++)
            {

                int diferenciaVictorias = jugador1.setsWins - jugador2.setsWins;
                diferenciaVictorias = (diferenciaVictorias < 0) ? diferenciaVictorias * -1 : diferenciaVictorias;

                if (diferenciaVictorias < cantidadSet_a_Ganar)
                {
                    clsSet objGame = new clsSet(configurationModel);
                    ganadorSet = objGame.jugar();                    

                    if (ganadorSet == "jugador1")
                    {
                        jugador1.setsWins++;                      
                    }

                    if (ganadorSet == "jugador2")
                    {
                        jugador2.setsWins++;                        
                    }
                }
                else
                {
                    break;
                }
            }

            if (jugador1.setsWins > jugador2.setsWins)
            {
                ganador = "jugador1";
            }

            if (jugador2.setsWins > jugador1.setsWins)
            {
                ganador = "jugador2";
            }

            return ganador;

        }

    }
}
