using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Repositories.Company
{
    public interface ICompanyRepository
    {
        List<Models.Entities.Company> GetAllCompanies();
        Models.Entities.Company GetCompanyByID(Guid CompanyID);
        void AddCompany(Models.Entities.Company company);
    }
}
