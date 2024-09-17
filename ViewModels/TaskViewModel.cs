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
            // Inicializar la base de datos y cargar las tareas desde la base de datos a la colección
            _dbContext = new TaskDbContext();
            _dbContext.Database.EnsureCreated(); // Asegurarse de que la base de datos esté creada
            LoadTasks();
        }

        // Cargar las tareas desde la base de datos en la colección observable
        private void LoadTasks()
        {
            var tasksFromDb = _dbContext.Tasks.ToList();
            Tasks = new ObservableCollection<Task>(tasksFromDb);
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
            // Buscar la tarea en la base de datos
            var task = _dbContext.Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                // Actualizar los datos de la tarea
                task.Description = updatedTask.Description;
                task.Status = updatedTask.Status;
                task.Priority = updatedTask.Priority;
                task.DueDate = updatedTask.DueDate;
                task.Notes = updatedTask.Notes;

                // Guardar los cambios en la base de datos
                _dbContext.SaveChanges();

                // Actualizar la colección observable para reflejar los cambios en la vista
                var taskInCollection = Tasks.FirstOrDefault(t => t.Id == taskId);
                if (taskInCollection != null)
                {
                    taskInCollection.Description = updatedTask.Description;
                    taskInCollection.Status = updatedTask.Status;
                    taskInCollection.Priority = updatedTask.Priority;
                    taskInCollection.DueDate = updatedTask.DueDate;
                    taskInCollection.Notes = updatedTask.Notes;
                }
            }
        }

        public void DeleteTask(int taskId)
        {
            // Buscar la tarea en la base de datos
            var task = _dbContext.Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null && task.Status != "EN PROCESO") // Solo eliminar si no está en estado "EN PROCESO"
            {
                // Eliminar la tarea de la base de datos
                _dbContext.Tasks.Remove(task);
                _dbContext.SaveChanges();

                // Eliminar la tarea de la colección observable para que se refleje en la vista
                var taskInCollection = Tasks.FirstOrDefault(t => t.Id == taskId);
                if (taskInCollection != null)
                {
                    Tasks.Remove(taskInCollection);
                }
            }
        }
    }
}
