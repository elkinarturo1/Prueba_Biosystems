using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class PlayerModel
    {
        public string name { get; set; }
        public string state { get; set; }
        public int gamesWins { get; set; }
        public int setsWins { get; set; }
        public int totalPuntation { get; set; }
        public List<int> puntation { get; set; }
    }
}
