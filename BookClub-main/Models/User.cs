#pragma warning disable CS8618
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace BookClubProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Le prénom doit comporter au moins 2 caractères")]
        [Display(Name = "Prénom")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Le nom doit comporter au moins 2 caractères")]
        [Display(Name = "Nom")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [UniqueEmail(ErrorMessage = "Cette adresse e-mail est déjà utilisée")]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Le mot de passe doit comporter au moins 8 caractères")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Relation One-to-Many
        public List<Book> BooksWritten { get; set; } = new();

        // Relation One-to-Many

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmation du mot de passe")]
        [Compare("Password", ErrorMessage = "Le mot de passe et la confirmation ne correspondent pas.")]
        public string PasswordConfirm { get; set; }
        
    }

    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is not string email)
            {
                return new ValidationResult("La valeur fournie n'est pas une adresse e-mail valide.");
            }

            var dbContext = validationContext.GetService(typeof(MyContext)) as MyContext;
            if (dbContext == null)
            {
                return new ValidationResult("Erreur interne du serveur lors de la validation de l'e-mail.");
            }

            var existingUser = dbContext.Users.FirstOrDefault(u => u.Email == email);
            if (existingUser != null)
            {
                return new ValidationResult(ErrorMessage);
            }

#pragma warning disable CS8603 // Possible null reference return.
            return ValidationResult.Success;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
