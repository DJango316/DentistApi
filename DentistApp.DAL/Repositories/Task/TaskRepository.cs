using DentistApp.DAL.DbFactory;
using DentistApp.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Repositories.Task
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IDbFactory _dbFactory;

        public TaskRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public List<Models.Entities.Task> GetAllTasks()
        {
            NPoco.Sql sql;
            
            using (var db = _dbFactory.GetConnection())
            {
                sql = NPoco.Sql.Builder
                    .Append("SELECT *")
                    .Append("FROM Task")
                    .Append("INNER JOIN Company ON Task.CompanyID = Company.CompanyID")
                    .Append("INNER JOIN Patient ON Task.PatientID = Patient.PatientID");
           

                return db.Fetch<Models.Entities.Task>(sql);
            }
        }

        public Models.Entities.Task GetTaskByName(string TaskName)
        {
            NPoco.Sql sql;
            using (var db = _dbFactory.GetConnection())
            {
                sql = NPoco.Sql.Builder
                  .Append("SELECT *")
                  .Append("FROM Task")
                  .Append("WHERE Task.TaskName = '" + TaskName + "'");

                return db.Fetch<Models.Entities.Task>(sql).FirstOrDefault();
            }
        }

        public Models.Entities.Task GetTaskByID(Guid id)
        {
            using (var db = _dbFactory.GetConnection())
            {
                return db.SingleById<Models.Entities.Task>(id);
            }
        }

        public void AddTask(Models.Entities.Task task)
        {
            using (var db = _dbFactory.GetConnection())
            {
                db.Insert<Models.Entities.Task>(task);
            }
        }
    }
}
