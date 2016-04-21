using DentistApp.BLL.Services;
using DentistApp.Common.Models.DTO;
using DentistApp.DAL.Repositories.Patient;
//using DentistApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DentistApp.Controllers
{
    [RoutePrefix("patient")]
    public class PatientController : ApiController
    {
        //private DentistContext db = new DentistContext();
        private readonly IPatientRepository _patientRespository;

        public PatientController(IPatientRepository patientRepository)
        {
            _patientRespository = patientRepository;
        }

        [HttpGet]
        [Route("")]
        public List<PatientDTO> GetAllPatients()
        {
            var studentService = new PatientService(_patientRespository);

            var students = studentService.GetAllPatients();

            return students;
        }

        [Route("{id}")]
        public PatientDTO GetPatient(Guid id)
        {
            var patientService = new PatientService(_patientRespository);

            var patient = patientService.GetPatientByID(id);

            return patient;
            //var name = db.Patients.FirstOrDefault((p) => p.PatientID == id);
            //if (name == null)
            //{
            //    return NotFound();
            //}
            //return Ok(name);
        }
    }
}
