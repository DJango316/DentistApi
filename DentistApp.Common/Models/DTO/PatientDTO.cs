using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.Common.Models.DTO
{
    public class PatientDTO
    {
        public Guid PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
