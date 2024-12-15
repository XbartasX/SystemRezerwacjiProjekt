using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SystemRezerwacjiProjekt.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Imię może zawierać tylko litery.")]
        [StringLength(30, ErrorMessage = "Imię może mieć maksymalnie 30 znaków.")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Imię może zawierać tylko litery.")]
        [StringLength(30, ErrorMessage = "Imię może mieć maksymalnie 30 znaków.")]
        public string Surname { get; set; }

        public string? UserId {  get; set; }
        public IdentityUser? User { get; set; }
    }
}