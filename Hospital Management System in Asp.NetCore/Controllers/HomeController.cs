using Hospital_Management_System_in_Asp.NetCore.Models;
using Hospital_Management_System_in_Asp.NetCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System_in_Asp.NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IPatientService _patientService;


        //private readonly IPatientService _patientService;

        public HomeController(IPatientService patientService)
        {
            this._patientService = patientService;

            // _patientService = patientService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
        {
            var patients = await _patientService.GetPatientsAsync();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            var patient = await _patientService.GetPatientByIdAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        [HttpPost]
        public async Task<ActionResult<Patient>> AddPatient(Patient patient)
        {
            var addedPatient = await _patientService.AddPatientAsync(patient);
            return CreatedAtAction(nameof(GetPatient), new { id = addedPatient.Id }, addedPatient);
        }
    }
}
