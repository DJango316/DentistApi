using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Models.Entities
{
    [TableName("Patient")]
    [PrimaryKey("PatientID")]
    public class Patient
    {
        [Column("PatientID")]
        public Guid PatientID { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
    }
}
