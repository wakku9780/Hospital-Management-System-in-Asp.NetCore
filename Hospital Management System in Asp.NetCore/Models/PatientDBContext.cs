using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_System_in_Asp.NetCore.Models
{
    public class PatientDBContext:DbContext
    {
        public PatientDBContext(DbContextOptions options): base(options)
        {

                
        }
        public DbSet<Patient> Patients { get; set; }
    }
}
