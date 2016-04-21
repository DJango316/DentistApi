using DentistApp.DAL.DbFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Repositories.Company
{
    public class CompanyRepository: ICompanyRepository
    {
        private readonly IDbFactory _dbFactory;

        public CompanyRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public List<Models.Entities.Company> GetAllCompanies()
        {
            using (var db = _dbFactory.GetConnection())
            {
                return db.Fetch<Models.Entities.Company>();
            }
        }

        public Models.Entities.Company GetCompanyByID(Guid CompanyID)
        {
            using (var db = _dbFactory.GetConnection())
            {
                return db.SingleById<Models.Entities.Company>(CompanyID);
            }
        }

        public void AddCompany(Models.Entities.Company company)
        {
            using (var db = _dbFactory.GetConnection())
            {
                db.Insert<Models.Entities.Company>(company);
            }
        }
    }
}
