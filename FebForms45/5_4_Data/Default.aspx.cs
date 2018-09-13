﻿using Data.Models;
using Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data
{
    public class CategoryView
    {
        public string Name { get; set; }
        public string Selected { get; set; }
    }

    public partial class Default : System.Web.UI.Page
    {
        public IEnumerable<Game> GetGamesData([Form("filterSelect")] string filter)
        {
            var games = new Repository().Games;
            return (filter ?? "Все") == "Все" ? games :
                games.Where(game => game.Category == filter);
        }

        public IEnumerable<CategoryView> GetCategories([Form("filterSelect")] string filter)
        {
            return new string[] { "Все" }.Concat(new Repository().Games
                .Select(g => g.Category).Distinct().OrderBy(c => c))
                .Select(c => new CategoryView
                {
                    Name = c,
                    Selected = (c == (filter ?? "Все"))
                        ? "selected=\"selected\"" : null
                });
        }
    }
}