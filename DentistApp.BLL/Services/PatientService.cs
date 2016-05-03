using DentistApp.Common.Models.DTO;
using DentistApp.DAL.Models.Entities;
using DentistApp.DAL.Repositories.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistApp.Common.Extensions;

namespace DentistApp.BLL.Services
{
    public class PatientService
    {
         private IPatientRepository _patientRepository;

         public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public List<PatientDTO> GetAllPatients()
        {
            var patient = _patientRepository.GetAllPatients();

            return patient.ToDTO<PatientDTO>().ToList();
        }

        public PatientDTO GetPatientByID(Guid id)
        {
            var patient = _patientRepository.GetPatientByID(id);

            return patient.ToDTO<PatientDTO>();
        }

        public void AddPatient(PatientDTO patient)
        {
            var patientEntity = patient.ToDTO<DentistApp.DAL.Models.Entities.Patient>();

            _patientRepository.AddPatient(patientEntity);
        }
    }
}
