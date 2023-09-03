using Bussines.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Clases
{
    public class clsSet: IGame
    {
        int cantidadJuegos_a_Jugar = 0;
        int cantidadJuegos_a_Ganar = 0;
        public ConfigurationModel objConfigurationGame;

        public clsSet(ConfigurationModel objConfiguration)
        {
            objConfigurationGame = objConfiguration;
            cantidadJuegos_a_Jugar = objConfiguration.cantidadJuegos_a_Jugar;
            cantidadJuegos_a_Ganar = objConfiguration.cantidadJuegos_a_Ganar;
        }

        /// <summary>
        /// Devuelve el ganador del set
        /// </summary>
        /// <returns></returns>
        public string jugar()
        {
            PlayerModel jugador1 = new PlayerModel();
            PlayerModel jugador2 = new PlayerModel();

            string ganador = "";
            string ganadorJuego = "";

            for (int i = 0; i < this.cantidadJuegos_a_Jugar; i++)
            {
                int diferenciaVictorias = jugador1.gamesWins - jugador2.gamesWins;
                diferenciaVictorias = (diferenciaVictorias < 0) ? diferenciaVictorias * -1 : diferenciaVictorias;

                if (diferenciaVictorias < this.cantidadJuegos_a_Ganar)
                {
                    clsGame objGame = new clsGame(objConfigurationGame);
                    ganadorJuego = objGame.jugar();

                    if (ganadorJuego == "jugador1")
                    {
                        jugador1.gamesWins++;
                    }

                    if (ganadorJuego == "jugador2")
                    {
                        jugador2.gamesWins++;
                    }
                }
                else
                {
                    break;
                }
            }

            if (jugador1.gamesWins > jugador2.gamesWins)
            {
                ganador = "jugador1";
            }

            if (jugador2.gamesWins > jugador1.gamesWins)
            {
                ganador = "jugador2";
            }

            return ganador;
        }
        
    }
}
