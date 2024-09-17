using Proyecto_Administrador_de_tareas.Data;
using Proyecto_Administrador_de_tareas.Models;
using Task = Proyecto_Administrador_de_tareas.Models.Task;

namespace Proyecto_Administrador_de_tareas
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new TaskDbContext())
            {
                db.Database.EnsureCreated(); // Crea la base de datos si no existe

                // Insertar una tarea de ejemplo
                db.Tasks.Add(new Task { Description = "Nueva Tarea", Status = "PENDIENTE", Priority = "ALTA", DueDate = DateTime.Now.AddDays(7), Notes = "Se debe bañar al perro" });
                db.SaveChanges();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}