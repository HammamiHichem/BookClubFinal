#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookClubProject.Models;


public class Association
{
    [Key]
    public int AssociationId {get;set;}

    public int UserId{get;set;}
    public int BookId{get;set;}

    public int Favorit {get;set;} = 0;

    public Book? Book { get; set; }    
    public User? User { get; set; }
}