using DentistApp.Common.Models.DTO;
using DentistApp.DAL.Repositories.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistApp.Common.Extensions;

namespace DentistApp.BLL.Services
{
    public class CompanyService
    {
         private ICompanyRepository _companyRepository;

         public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public List<CompanyDTO> GetAllCompanies()
        {
            var company = _companyRepository.GetAllCompanies();

            return company.ToDTO<CompanyDTO>().ToList();
        }

        public CompanyDTO GetCompanyByID(Guid CompanyID)
        {
            var company = _companyRepository.GetCompanyByID(CompanyID);

            return company.ToDTO<CompanyDTO>();
        }

        public void AddCompany(CompanyDTO company)
        {
            var companyEntity = company.ToDTO<DentistApp.DAL.Models.Entities.Company>();

            _companyRepository.AddCompany(companyEntity);
        }
    }
}
