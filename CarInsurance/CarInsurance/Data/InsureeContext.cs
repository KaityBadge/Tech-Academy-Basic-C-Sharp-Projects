using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

namespace CarInsurance.Data
{
    public class InsureeContext : DbContext     //inherits from the installed EFCore package, allows EF to access Db
    {
        //creates a CONSTRUCTOR
        //the parameter named: "options" provides the location of where DB info will be passed to
        public InsureeContext(DbContextOptions<InsureeContext> options) : base(options) 
        {
            
        }
        
        public DbSet<Insuree> Insuree { get; set; } //This is the data we are interacting with 
    }
}
