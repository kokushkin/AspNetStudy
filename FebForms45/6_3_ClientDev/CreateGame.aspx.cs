using ClientDev.Models;
using ClientDev.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientDev
{
    public partial class CreateGame : System.Web.UI.Page
    {
        List<Game> CreatedGames;

        protected void Page_Load(object sender, EventArgs e)
        {
            CreatedGames = (List<Game>)ViewState["data"] ?? new List<Game>();
            if (IsPostBack)
            {
                Game newGame = new Game();
                TryUpdateModel<Game>(newGame,
                    new FormValueProvider(ModelBindingExecutionContext));
                if (ModelState.IsValid)
                {
                    new Repository().AddGame(newGame);
                    CreatedGames.Add(newGame);
                    ViewState["data"] = CreatedGames;
                    DataBind();
                }
            }
        }

        public IEnumerable<Game> GetCreated()
        {
            return CreatedGames;
        }
    }
}