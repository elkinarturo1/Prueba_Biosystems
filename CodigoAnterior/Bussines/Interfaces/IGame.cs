using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IGame
    {

        public void configurationGame(ConfigurationModel configurationModel);
        public void startGame(GameModel gameModel);
        public void stopGame(GameModel gameModel);
        public void startSet(SetModel setModel);
        public void stopSet(SetModel setModel);
        public void addPoint(GameModel gameModel);



    }
}
