#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using BookClubProject.Models;
namespace BookClubProject.Models
{
    public class RatingViewModel
    {
        [Required(ErrorMessage = "Rating is required.")]
        [Range(1, 5, ErrorMessage = "Rating should be between 1 and 5.")]
        public int RatingService { get; set; }
        [MinLength(20, ErrorMessage = "Your suggestion should be more than 20 characters.")]
        public string Suggestion { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
    }
}
