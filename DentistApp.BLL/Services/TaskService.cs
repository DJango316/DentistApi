using DentistApp.Common.Models.DTO;
using DentistApp.Common.Extensions;
using DentistApp.DAL.Repositories.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentistApp.DAL.Models.Entities;


namespace DentistApp.BLL.Services
{
    public class TaskService
    {
         private ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<TaskDTO> GetAllTasks()
        {
            var task = _taskRepository.GetAllTasks();

            return task.ToDTO<TaskDTO>().ToList();
        }

        public TaskDTO GetTaskByName(string TaskName)
        {
            var task = _taskRepository.GetTaskByName(TaskName);

            return task.ToDTO<TaskDTO>();
        }

        public TaskDTO GetTaskByID(Guid id)
        {
            var task = _taskRepository.GetTaskByID(id);

            return task.ToDTO<TaskDTO>();
        }

        public void AddTask(TaskDTO task)
        {
            var taskEntity = task.ToDTO<Task>();

            _taskRepository.AddTask(taskEntity);
        }
    }
}
