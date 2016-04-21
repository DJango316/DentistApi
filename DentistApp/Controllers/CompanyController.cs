//using DentistApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DentistApp.Controllers
{
    [RoutePrefix("company")]
    public class CompanyController : ApiController
    {
        //private DentistContext db = new DentistContext();
        //[Route("{id}")]
        //public IHttpActionResult GetCompany(Guid id)
        //{
        //    var company = db.Companys.FirstOrDefault((c) => c.CompanyID == id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(company);
        //}
    }
}
