using DentistApp.DAL.DbFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistApp.DAL.Models.Entities;

namespace DentistApp.DAL.Repositories.Patient
{
    public class PatientRepository: IPatientRepository
    {
        private readonly IDbFactory _dbFactory;

        public PatientRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public List<Models.Entities.Patient> GetAllPatients()
        {
            using (var db = _dbFactory.GetConnection())
            {
                return db.Fetch<Models.Entities.Patient>();
            }
        }

        public Models.Entities.Patient GetPatientByID(Guid PatientID)
        {
            using (var db = _dbFactory.GetConnection())
            {
                return db.SingleById<Models.Entities.Patient>(PatientID);
            }
        }

        public void AddPatient(Models.Entities.Patient patient)
        {
            using (var db = _dbFactory.GetConnection())
            {
                db.Insert<Models.Entities.Patient>(patient);
            }
        }
    }
}
