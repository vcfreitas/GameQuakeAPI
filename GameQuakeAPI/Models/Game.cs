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
        public Game()
        {
            players = new List<Player>();
            kills = new List<Dead>();
        }

        //ADICIONAR NOVO JOGADOR
        public void AddPlayer(Player player)
        {
            var exists = players.FirstOrDefault(x => x.playerId == player.playerId);
            if (exists == null)
            {
                players.Add(player);
            }
        }
    }
}