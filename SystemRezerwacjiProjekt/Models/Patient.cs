using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SystemRezerwacjiProjekt.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? UserId {  get; set; }
        public IdentityUser? User { get; set; }
    }
}