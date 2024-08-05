#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace BookClubProject.Models;

public class MyContext : DbContext 
{     
    public MyContext(DbContextOptions options) : base(options) { }   

    public DbSet<User> Users { get; set; } 
    public DbSet<Book> Books {get;set;}
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Association> Associationss { get; set; } 
}
