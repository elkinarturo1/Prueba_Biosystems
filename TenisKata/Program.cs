using Bussines.Clases;
using Bussines.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenisKata
{
    internal class Program
    {

        IGame game;

        static void Main(string[] args)
        { 
            clsPartido objGame = new clsPartido();
            string ganador = objGame.jugar();
            Console.WriteLine("Ganador: {0}", ganador);
            Console.ReadLine();
        }
    }
}
