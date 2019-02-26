using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Model controller for games klassen

namespace MVCNovicell.Models
{
    public class Game
    {
        public int Id { get; set; }

        [StringLength(35, MinimumLength =1)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[\w\d\s\.\\\*]*$"), StringLength(20)]
        [Required]
        public String Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)"), StringLength(5)]
        [Required]
        public decimal Score { get; set; }

        [Column(TypeName = "decimal(18, 2)"), StringLength(5)]
        public decimal UserScore { get; set; }
        // public string imgURL { get; set; }
    }
}
