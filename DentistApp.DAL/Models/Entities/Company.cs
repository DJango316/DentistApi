using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Models.Entities
{
    [TableName("Company")]
    [PrimaryKey("CompanyID")]
    public class Company
    {
        [Column("CompanyID")]
        public Guid CompanyID { get; set; }
        [Column("Name")]
        public string Name { get; set; }
    }
}
