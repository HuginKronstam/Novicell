using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Model controller for games klassen

namespace MVCNovicell.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Display(Name = "Title", ResourceType = typeof(Resources.language))]
        [StringLength(35, MinimumLength =1)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "ReleaseDate", ResourceType = typeof(Resources.language))]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Genre", ResourceType = typeof(Resources.language))]
        [RegularExpression(@"^[\w\d\s\.\\\*]*$"), StringLength(20)]
        [Required]
        public String Genre { get; set; }

        [Display(Name = "Score", ResourceType = typeof(Resources.language))]
        [Column(TypeName = "decimal(18, 2)"), StringLength(5)]
        [Required]
        public decimal Score { get; set; }

        [RegularExpression(@"^[\w\d\s\.\\\*]*$"), StringLength(20)]
        public String ImgUrl { get; set; }
    }
}
