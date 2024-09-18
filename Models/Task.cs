
namespace Proyecto_Administrador_de_tareas.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; } // Campo obligatorio
        public string Status { get; set; } // PENDIENTE, EN PROCESO, FINALIZADA
        public string Priority { get; set; } // ALTA, MEDIA, BAJA
        public DateTime DueDate { get; set; } // Fecha de Compromiso
        public string Notes { get; set; } // Opcional
    }
}
