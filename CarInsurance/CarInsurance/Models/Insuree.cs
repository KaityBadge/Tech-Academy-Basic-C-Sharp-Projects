using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public Guid Id { get; set; } //guid ensures uniqueness
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public int CarYear { get; set; } 
        public string CarMake { get; set; } 
        public string CarModel { get; set; } 
        public string DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public string CoverageType { get; set; }
        public decimal Quote { get; set; }

        
    }
}
