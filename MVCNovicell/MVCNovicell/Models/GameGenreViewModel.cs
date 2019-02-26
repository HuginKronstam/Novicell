using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCNovicell.Models
{
    public class GameGenreViewModel
    {
        public List<Game> Games;
        public SelectList Genres;
        public string GameGenre { get; set; }
        public string SearchString { get; set; }
    }
}
