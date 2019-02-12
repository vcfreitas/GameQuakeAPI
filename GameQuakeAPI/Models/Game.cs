using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameQuakeAPI.Models
{
    public class Game
    {
        public int gameId { get; set; }
        public int total_kills { get; set; }
        public virtual List<Player> players { get; set; }
        public virtual List<Dead> kills { get; set; }
    }
}