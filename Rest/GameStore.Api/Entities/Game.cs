using System.ComponentModel.DataAnnotations;
namespace GameStore.Api.Entities;

public class Game
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Name is requires ")]
    [StringLength(50)]
    public required string Name { get; set; }
    [Required(ErrorMessage = "Genries is Reqires ")]
    [StringLength(20)]
    public required string Genre { get; set; }
    [Required(ErrorMessage = "Genries is requires ")]
    // [StringLength(50)] 
    [Range(1,100)]
    public decimal Price { get; set; }
    [StringLength(100)]
    [Url]
    public  required string ImageUri {get;set;}
    public DateTime ReleaseDate { set; get; }
    
}