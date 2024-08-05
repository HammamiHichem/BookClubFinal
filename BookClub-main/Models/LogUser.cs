#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace BookClubProject.Models;


public class LogUser
{
    [EmailAddress]
    [Required]
    public string LogEmail { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [MinLength(8)]
    public string LogPassword { get; set; }

}