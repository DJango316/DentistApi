using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace DentistApp.Common.Models.DTO
{
    public class TaskDTO
    {
        public Guid TaskID { get; set; }
        public Guid PatientID { get; set; }
       
        public CompanyDTO company { get; set; }
    
        public PatientDTO patient { get; set; }
        public Guid CompanyID { get; set; }
        public string TaskName { get; set; }
        
        public DateTime TaskDate { get; set; }
    }


}
