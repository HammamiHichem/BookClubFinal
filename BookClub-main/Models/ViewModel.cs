#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace BookClubProject.Models;

public class ViewModel
{
    
    public Book? Book{get;set;}
    public List<Book>? Books{get;set;} = new();
    public Association? Association{get;set;}
    public int FavoritCount { get; set; }
    public decimal Favorit { get; set; }
}