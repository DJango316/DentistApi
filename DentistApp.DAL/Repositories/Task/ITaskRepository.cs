using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Repositories.Task
{
    public interface ITaskRepository
    {
        List<Models.Entities.Task> GetAllTasks();
        Models.Entities.Task GetTaskByName(string name);
        Models.Entities.Task GetTaskByID(Guid id);
        void AddTask(Models.Entities.Task task);
    }
}
