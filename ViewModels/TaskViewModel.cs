using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Proyecto_Administrador_de_tareas.Data;
using Proyecto_Administrador_de_tareas.Models;
using Task = Proyecto_Administrador_de_tareas.Models.Task;

namespace Proyecto_Administrador_de_tareas.ViewModels
{
    public class TaskViewModel
    {
        // Colección observable de tareas (para representar en la vista)
        public ObservableCollection<Task> Tasks { get; set; }
        private TaskDbContext _dbContext;

        // Constructor
        public TaskViewModel()
        {
            _dbContext = new TaskDbContext();
            Tasks = new ObservableCollection<Task>(_dbContext.Tasks.ToList());
        }

        // Métodos para agregar, editar y eliminar tareas
        public void AddTask(Task task)
        {
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
            Tasks.Add(task);
        }

        public void EditTask(int taskId, Task updatedTask)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                task.Description = updatedTask.Description;
                task.Status = updatedTask.Status;
                task.Priority = updatedTask.Priority;
                task.DueDate = updatedTask.DueDate;
                task.Notes = updatedTask.Notes;
            }
        }

        public void DeleteTask(int taskId)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null && task.Status != "EN PROCESO")
            {
                Tasks.Remove(task);
            }
        }
    }
}
