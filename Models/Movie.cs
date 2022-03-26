using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
#nullable enable
    public class Movie
    {
        // DataType annotations are used to enhance the way fields are displayed
        // in the ui. They are not validators
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [
            // can be used separately or in one place like here
            DataType(DataType.Date),
            DisplayFormat(
                DataFormatString = "{0:dd/MM/yyyy}",
                ApplyFormatInEditMode = false)
        ]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string? Genre { get; set; }


        [DataType(DataType.Currency)]
        [Range(1, 100)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(5)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? Rating { get; set; }
    }
#nullable disable
}
