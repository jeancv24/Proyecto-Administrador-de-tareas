using System.Collections.ObjectModel;
using Proyecto_Administrador_de_tareas.Data;
using Task = Proyecto_Administrador_de_tareas.Models.Task;

namespace Proyecto_Administrador_de_tareas.ViewModels
{
    public class TaskViewModel
    {
        public ObservableCollection<Task> Tasks { get; set; }
        private TaskDbContext _dbContext;

        // Constructor
        public TaskViewModel()
        {
            // Inicializar la base de datos y cargar las tareas
            _dbContext = new TaskDbContext();
            _dbContext.Database.EnsureCreated(); // Base de datos esta creada
            LoadTasks();
        }

        // Cargar las tareas desde la base de datos
        public void LoadTasks()
        {
            var tasksFromDb = _dbContext.Tasks.OrderBy(t => t.DueDate).ToList();

            Tasks = new ObservableCollection<Task>(tasksFromDb);
        }

        // Obtener tarea por Id
        public Task GetTaskById(int taskId)
        {
            return Tasks.FirstOrDefault(t => t.Id == taskId);
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
            // Buscar en la base de datos
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
            }
        }
    }
}
