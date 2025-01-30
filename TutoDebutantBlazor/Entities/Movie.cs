using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TutoDebutantBlazor.Entities;

public class Movie
{
    public int Id { get; set; }

    [Display(Name = "Titre")]
    [StringLength(60, MinimumLength = 3, ErrorMessage = "Le titre doit être compris entre 3 et 60 caratères")]
    [Required(ErrorMessage = "Le titre est requis")]
    public string? Title { get; set; }

    [Display(Name = "Date de sortie")]
    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }

    [Display(Name = "Genre")]
    [StringLength(40, ErrorMessage = "Le titre doit être inférieur à 40 caratères")]
    [RegularExpression(@"^[A-ZÀ-Ÿ]+[a-zA-ZÀ-ÿ\s]*$", ErrorMessage = "Le genre ne doit contenir que des caractères alphabétiques")]
    [Required(ErrorMessage = "Le genre est requis")]
    public string? Genre { get; set; }

    [Display(Name = "Prix")]
    [Range(1, 100, ErrorMessage = "Le prix doit être de 100 maximum")]
    [Required(ErrorMessage = "Le prix est requis")]
    public double Price { get; set; }

    [Display(Name = "Note")]
    [Range(0, 5, ErrorMessage = "La note doit etre comprise entre 0 et 5")]
    public int? Rating { get; set; }
}
