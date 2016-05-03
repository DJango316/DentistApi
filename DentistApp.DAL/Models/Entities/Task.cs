using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Models.Entities
{
    [TableName("Task")]
    [PrimaryKey("TaskID")]
    public class Task
    {
        [Column("TaskID")]
        public Guid TaskID { get; set; }
       // public Patient patients { get; set; }
        [Column("PatientID")]
        public Guid PatientID { get; set; }
       // public Company company { get; set; }
      
        [Column("CompanyID")]
        public Guid CompanyID { get; set; }
        [Column("TaskName")]
        public string TaskName { get; set; }
        [Column("TaskDate")]
        public DateTime TaskDate { get; set; }
    }

    //[TableName("Patient")]
    //[PrimaryKey("PatientID")]
    //public partial class Patient
    //{
    //    [Column("PatientID")]
    //    public Guid PatientID { get; set; }
    //    [Column("FirstName")]
    //    public string FirstName { get; set; }
    //    [Column("LastName")]
    //    public string LastName { get; set; }
    //}

    //[TableName("Company")]
    //[PrimaryKey("CompanyID")]
    //public partial class Company
    //{
    //    [Column("CompanyID")]
    //    public Guid CompanyID { get; set; }
    //    [Column("Name")]
    //    public string Name { get; set; }
    //}
}
