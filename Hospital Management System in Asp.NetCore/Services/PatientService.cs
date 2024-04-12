using Hospital_Management_System_in_Asp.NetCore.Models;

namespace Hospital_Management_System_in_Asp.NetCore.Services
{
    public class PatientService : IPatientService
    {
        private readonly List<Patient> _patients = new List<Patient>();

        public async Task<IEnumerable<Patient>> GetPatientsAsync()
        {
            return await Task.FromResult(_patients);
        }

        public async Task<Patient> GetPatientByIdAsync(int id)
        {
            return await Task.FromResult(_patients.FirstOrDefault(p => p.Id == id));
        }

        public async Task<Patient> AddPatientAsync(Patient patient)
        {
            patient.Id = _patients.Count + 1;
            _patients.Add(patient);
            return await Task.FromResult(patient);
        }

    }
}
