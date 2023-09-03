using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class GameModel
    {
        public ConfigurationModel Configuration { get; set; }

        List<PlayerModel> playerModels = new List<PlayerModel>();
        List<int> puntuacion { get; set; } = new List<int>()
        {
            0,
            15,
            30,
            40
        };      

    }
}
