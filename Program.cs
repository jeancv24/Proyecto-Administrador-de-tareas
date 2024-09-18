using Proyecto_Administrador_de_tareas.Data;
using Proyecto_Administrador_de_tareas.Models;
using Proyecto_Administrador_de_tareas.Views;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Lanzar el MainForm
        }
    }
}