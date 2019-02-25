using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Model controller for games klassen

namespace MVCNovicell.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public String Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Score { get; set; }
       // public string imgURL { get; set; }
    }
}
