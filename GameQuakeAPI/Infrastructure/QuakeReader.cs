using GameQuakeAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace GameQuakeAPI.Infrastructure
{
    public class QuakeReader
    {
        public List<Game> ProcessRows(StreamReader streamFile)
        {
            var game = new Game();
            var games = new List<Game>();
            var actions = new Regex("(InitGame|ClientConnect|ClientUserinfoChanged|Kill)");

            int gameId = 0;
            string row;

            while ((row = streamFile.ReadLine()) != null)
            {
                Match action = actions.Match(row);

                switch (action.Value)
                {
                    case "InitGame":
                        gameId++;
                        game = NewGame(games, gameId);
                        break;
                }
            }

            return games;
        }
        public Game NewGame(List<Game> games, int gameId)
        {
            Game game = new Game() { gameId = gameId };
            games.Add(game);
            return game;
        }
    }
}