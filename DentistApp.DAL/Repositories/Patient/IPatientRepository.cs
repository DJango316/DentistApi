using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Repositories.Patient
{
    public interface IPatientRepository
    {
        List<Models.Entities.Patient> GetAllPatients();
        Models.Entities.Patient GetPatientByID(Guid id);
        void AddPatient(Models.Entities.Patient patient);
    }
}
