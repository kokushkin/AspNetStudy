using ClientDev.Models;
using ClientDev.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientDev
{
    public class GameView
    {
        public GameView() { }

        public GameView(Game Game)
        {
            this.GameId = Game.GameId;
            this.Name = Game.Name;
            this.Price = Game.Price;
            this.Category = Game.Category;
        }

        public int GameId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Game ToGame()
        {
            return new Game
            {
                GameId = this.GameId,
                Name = this.Name,
                Price = this.Price,
                Category = this.Category
            };
        }
    }

    public class GameController : ApiController
    {
        public IEnumerable<GameView> Get()
        {
            return new Repository().Games
                .Select(g => new GameView(g));
        }

        public GameView Get(int id)
        {
            return new Repository().Games.Where(game => game.GameId == id)
                .Select(g => new GameView(g)).FirstOrDefault();
        }

        public void Post([FromBody] GameView value)
        {
            new Repository().AddGame(value.ToGame());
        }

        public void Put(int id, [FromBody] GameView value)
        {
            Repository repository = new Repository();
            Game game = repository.Games
                .Where(g => g.GameId == id).FirstOrDefault();

            if (game != null)
            {
                game.Name = value.Name;
                game.Price = value.Price;
                game.Category = value.Category;
            }

            repository.SaveGame(game);
        }

        public void Delete(int id)
        {
            Repository repository = new Repository();
            Game game = repository.Games
                .Where(g => g.GameId == id).FirstOrDefault();
            if (game != null)
                repository.DeleteGame(game);
        }
    }
}