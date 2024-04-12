using Hospital_Management_System_in_Asp.NetCore.Models;

namespace Hospital_Management_System_in_Asp.NetCore.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetPatientsAsync();
        Task<Patient> GetPatientByIdAsync(int id);
        Task<Patient> AddPatientAsync(Patient patient);
    }
}
