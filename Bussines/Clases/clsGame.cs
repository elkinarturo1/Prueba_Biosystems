using Bussines.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Clases
{
    public class clsGame: IGame
    {
        int puntosJugador1;
        int puntosJugador2;      
        string estadoJugador1 = "";
        string estadoJugador2 = "";
        List<int> reglaPuntaje = new List<int> { 0, 15, 30, 40 };

        public clsGame(ConfigurationModel objConfiguration)
        {
            if(objConfiguration.reglaPuntaje.Count > 0)
            {
                reglaPuntaje = objConfiguration.reglaPuntaje;
            }
            
        }


        /// <summary>
        /// Devuelve el ganador del juego
        /// </summary>
        /// <param name="jugador1"></param>
        /// <param name="jugador2"></param>
        /// <returns></returns>
        public string jugar()
        {
            string ganador = "";

            while ((this.estadoJugador1 != "gano") && (this.estadoJugador2 != "gano"))
            {

                int punto;

                Console.WriteLine("Digite 1 para asignar punto al jugador 1");
                Console.WriteLine("Digite 2 para asignar punto al jugador 2");
                punto = int.Parse(Console.ReadLine());
                puntuar(punto);

                if (this.estadoJugador1 == "gano")
                {
                    ganador = "jugador1";
                }

                if (this.estadoJugador2 == "gano")
                {
                    ganador = "jugador2";
                }

            }

            return ganador;
        }
     

        public void puntuar(int punto)
        {

            //Asigno el siguiente puntaje al jugador
            if (punto == 1)
            {
                if (this.puntosJugador1 < reglaPuntaje.Last())
                {
                    this.puntosJugador1 = reglaPuntaje[reglaPuntaje.IndexOf(this.puntosJugador1) + 1];
                }
                else if (this.puntosJugador2 < reglaPuntaje.Last())
                {
                    this.estadoJugador1 = "gano";
                }
            }


            if (punto == 2)
            {
                if (this.puntosJugador2 < reglaPuntaje.Last())
                {
                    //Asigno el siguiente puntaje al jugador
                    this.puntosJugador2 = reglaPuntaje[reglaPuntaje.IndexOf(this.puntosJugador1) + 1];
                }
                else if (this.puntosJugador1 < reglaPuntaje.Last())
                {
                    this.estadoJugador2 = "gano";
                }
            }

            if ((this.puntosJugador1 == reglaPuntaje.Last()) && (this.puntosJugador2 == reglaPuntaje.Last()))
            {
                definir_Ganador_x_Empate(punto);
            }
        }


        public void definir_Ganador_x_Empate(int jugadorQueAnoto)
        {

            if (this.estadoJugador1 == "igualados")
            {
                if (jugadorQueAnoto == 1)
                {
                    this.estadoJugador1 = "ventaja";
                }
                else
                {
                    this.estadoJugador2 = "ventaja";
                }
            }
            else if (this.estadoJugador1 == "ventaja")
            {
                if (jugadorQueAnoto == 1)
                {
                    this.estadoJugador1 = "gano";
                }
                else
                {
                    this.estadoJugador1 = "igualados";
                    this.estadoJugador2 = "igualados";
                }
            }
            else if (this.estadoJugador2 == "ventaja")
            {
                if (jugadorQueAnoto == 2)
                {
                    this.estadoJugador2 = "gano";
                }
                else
                {
                    this.estadoJugador1 = "igualados";
                    this.estadoJugador2 = "igualados";
                }
            }

        }
       
    }
}
