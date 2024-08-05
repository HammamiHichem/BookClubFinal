#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
// Add this using statement to access NotMapped
using System.ComponentModel.DataAnnotations.Schema;
namespace BookClubProject.Models;
public class Rating
{
    [Key]        
    public int RatingId { get; set; }

    //* ===========  rating validation ===============
    
    [Required ]
    [Range(1,5)]    
    public int RatingService { get; set; }     

    //* ===========  suggestion validation ===============
    [MinLength(20,ErrorMessage ="Your suggestion should be more than 20 characters ")]
    public string Suggestion { get; set; }  

     [Required(ErrorMessage = "First name is required.")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required.")]
    public string? LastName { get; set; }

    




    //* ======= Created & Updated validation ============
    public DateTime CreatedAt {get;set;} = DateTime.Now;        
    public DateTime UpdatedAt {get;set;} = DateTime.Now;



    
    //* ===========  Navigation property ===============
    //public User? UserWhoRated {get;set;}
    public List<User> UserWhoRated { get; set; }

}