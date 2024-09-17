using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Proyecto_Administrador_de_tareas.Models;

namespace Proyecto_Administrador_de_tareas.ViewModels
{
    public class TaskViewModel
    {
        // Colección observable de tareas (para representar en la vista)
        public ObservableCollection<Task> Tasks { get; set; }

        // Constructor
        public TaskViewModel()
        {
            Tasks = new ObservableCollection<Task>();
        }

        // Métodos para agregar, editar y eliminar tareas
        public void AddTask(Task task)
        {
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
