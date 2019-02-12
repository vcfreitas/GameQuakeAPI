using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameQuakeAPI.Models
{
    public class Dead
    {
        public int playerId { get; set; }
        public string playerName { get; set; }
        public int playerDeaths { get; set; }
    }
}