using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientDev.Models
{
    [Serializable]
    public class Game
    {
        public int GameId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }
    }
}