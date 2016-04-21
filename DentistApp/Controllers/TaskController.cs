using DentistApp.BLL.Services;
using DentistApp.Common.Models.DTO;
using DentistApp.DAL.Repositories.Patient;
using DentistApp.DAL.Repositories.Task;
//using DentistApp.DAL;
//using DentistApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DentistApp.DAL.Models.Entities;
using DentistApp.DAL.Repositories.Company;

namespace DentistApp.Controllers
{
    [RoutePrefix("tasks")]
    public class TaskController : ApiController
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly ICompanyRepository _companyRepository;
        public TaskController(ITaskRepository taskRepository, IPatientRepository patientRepository, ICompanyRepository companyRepository)
        {
            _taskRepository = taskRepository;
            _patientRepository = patientRepository;
            _companyRepository = companyRepository;
        }

        [HttpGet]
        [Route("getall")]
        public List<TaskDTO> GetAllTasks()
        {
            var taskService = new TaskService(_taskRepository);

            var tasks = taskService.GetAllTasks();

            var patientService = new PatientService(_patientRepository);
            var companyService = new CompanyService(_companyRepository);

            foreach(TaskDTO t in tasks)
            {
                var company = companyService.GetCompanyByID(t.CompanyID);
                var patient = patientService.GetPatientByID(t.PatientID);
             

                t.patient = patient;
                t.company = company;
            }

            return tasks;
        }

        [Route("{name}")]
        public TaskDTO GetTaskFromName(string name)
        {
            var taskService = new TaskService(_taskRepository);

            var task = taskService.GetTaskByName(name);

            var patientService = new PatientService(_patientRepository);
            var companyService = new CompanyService(_companyRepository);

            var company = companyService.GetCompanyByID(task.CompanyID);
            var patient = patientService.GetPatientByID(task.PatientID);

            task.patient = patient;
            task.company = company;

            return task;
        }

        //[Route("{id}")]
        //public TaskDTO GetTask(Guid id)
        //{
        //    var taskService = new TaskService(_taskRepository);

        //    var task = taskService.GetTaskByID(id);

        //    return task;
        //    //var name = db.Patients.FirstOrDefault((p) => p.PatientID == id);
        //    //if (name == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //return Ok(name);
        //}
        //private DentistContext db = new DentistContext();
        ////Task[] tasks = new Task[]
        ////{
        ////    new Task { Id = new Guid("1f16d56e-a5ca-4513-8b81-3899c0fa5217"), companyId = new Guid("d7840e6c-e892-4cc4-9a62-1fd4e85b9375"), patientId = new Guid("9da66d16-b9c0-4b7f-9842-5f818e320db3"), taskName = "Task 3", taskDate = new DateTime(2016,04,21)}
        ////};

        //[Route("getall")]
        //public IEnumerable<Task> GetAllTasks()
        //{
        //    var task = db.Tasks.ToList();
        //    foreach (Task t in task)
        //    {
        //        t.patient = GetPatient(t.PatientID);
        //        t.company = GetCompany(t.CompanyID);
        //    }
        //    return db.Tasks.ToList();
        //}

        //[Route("{name}")]
        //public IHttpActionResult GetTask(string name)
        //{
        //    var task = GetAllTasks().FirstOrDefault((t) => t.TaskName.ToLower() == name.ToLower());
        //    if (task == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        task.patient = GetPatient(task.PatientID);
        //        task.company = GetCompany(task.CompanyID);
        //        return Ok(task);
        //    }
        //}

        //[Route("getalltasks/{id}")]
        //public IHttpActionResult GetTaskAnother(Guid id)
        //{
        //    var task = GetAllTasks().FirstOrDefault((t) => t.CompanyID == id);
        //    if (task == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        task.patient = GetPatient(task.PatientID);
        //        task.company = GetCompany(task.CompanyID);
        //    }

        //    return Ok(task);
        //}

        ////[Route("patients/{id}")]
        //public Patient GetPatient(Guid id)
        //{
        //    var patient = db.Patients.FirstOrDefault((p) => p.PatientID == id);
        //    return patient;
        //    //var name = db.Patients.FirstOrDefault((p) => p.Id == id);
        //    //if (name == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //return Ok(name);
        //}

        //public Company GetCompany(Guid id)
        //{
        //    var company = db.Companys.FirstOrDefault((c) => c.CompanyID == id);
        //    return company;
        //}
    }
}
