using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientDev.Models.Repository
{
    public class Repository
    {
        private static Dictionary<int, Game> data = new Dictionary<int, Game>();

        public IEnumerable<Game> Games
        {
            get
            {
                return data.Values;
            }
        }

        public void SaveGame(Game Game)
        {
            data[Game.GameId] = Game;
        }

        public void DeleteGame(Game Game)
        {
            if (data.ContainsKey(Game.GameId))
            {
                data.Remove(Game.GameId);
            }
        }

        public void AddGame(Game Game)
        {
            Game.GameId = Games.Select(p => p.GameId).Max() + 1;
            SaveGame(Game);
        }

        static Repository()
        {
            Game[] dataArray = new Game[] {
                new Game { Name = "SimCity", Price = 1499, Category="Симулятор" },
                new Game { Name = "TITANFALL", Price=2299, Category="Шутер" },
                new Game { Name = "Battlefield 4", Price=899.4M, Category="Шутер" },
                new Game { Name = "The Sims 4", Price = 849, Category="Симулятор" },
                new Game { Name = "Dark Souls 2", Price=949, Category="RPG" },
                new Game { Name = "The Elder Scrolls V: Skyrim", Price=1399, Category="RPG" },
                new Game { Name = "FIFA 14", Price = 699, Category="Симулятор" },
                new Game { Name = "Need for Speed Rivals", Price=544, Category="Симулятор" },
                new Game { Name = "Crysis 3", Price=1899, Category="Шутер" },
                new Game { Name = "Dead Space 3", Price = 499, Category="Шутер" },
            };

            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i].GameId = i;
                data[i] = dataArray[i];
            }
        }
    }
}