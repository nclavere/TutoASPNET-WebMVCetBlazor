using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TutoDebutantWebMVC.Entities;

public class Movie
{
    public int Id { get; set; }

    [Display(Name = "Titre")]
    [StringLength(60, MinimumLength = 3, ErrorMessage ="Le titre doit être compris entre 3 et 60 caratères")]
    [Required(ErrorMessage ="Le titre est requis")]
    public required string Title { get; set; } 

    [Display(Name = "Date de sortie")]
    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }

    [Display(Name = "Genre")]
    [StringLength(40, ErrorMessage = "Le titre doit être inférieur à 40 caratères")]
    [RegularExpression(@"^[A-ZÀ-Ÿ]+[a-zA-ZÀ-ÿ\s]*$", ErrorMessage = "Le genre ne doit contenir que des caractères alphabétiques")]
    [Required(ErrorMessage = "Le genre est requis")]
    public required string Genre { get; set; } 

    [Display(Name = "Prix")]
    [Column(TypeName = "decimal(18, 2)")]
    [Range(1, 100, ErrorMessage ="Le prix doit être de 100 maximum")]
    [Required(ErrorMessage = "Le prix est requis")]
    public decimal Price { get; set; }

    [Display(Name = "Note")]
    [Range(0, 5, ErrorMessage = "La note doit etre comprise entre 0 et 5")]
    public int? Rating { get; set; }
}
