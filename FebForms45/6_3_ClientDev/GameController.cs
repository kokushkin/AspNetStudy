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

        public IEnumerable<GameView> Get([System.Web.ModelBinding.Form] string categoryFilter)
        {
            if (categoryFilter == null || categoryFilter == "Все")
            {
                return Get();
            }
            else
            {
                return new Repository().Games
                    .Where(p => p.Category == categoryFilter)
                    .Select(p => new GameView(p));
            }
        }

        public void Post([FromBody] GameView value)
        {
            new Repository().AddGame(value.ToGame());
        }

        public HttpResponseMessage Put(int id, [FromBody] GameView value)
        {
            if (ModelState.IsValid)
            {
                Repository repository = new Repository();
                Game game = repository.Games
                    .Where(p => p.GameId == id).FirstOrDefault();
                if (game != null)
                {
                    game.Name = value.Name;
                    game.Price = value.Price;
                    game.Category = value.Category;
                }
                repository.SaveGame(game);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                List<string> errors = new List<string>();
                foreach (var state in ModelState)
                    foreach (var error in state.Value.Errors)
                        errors.Add(error.ErrorMessage);

                return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
            }
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