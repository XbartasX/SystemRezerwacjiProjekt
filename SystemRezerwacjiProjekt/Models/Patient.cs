using System.Collections.Generic;

namespace SystemRezerwacjiProjekt.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}