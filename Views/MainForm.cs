using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proyecto_Administrador_de_tareas.ViewModels;
using Task = Proyecto_Administrador_de_tareas.Models.Task;

namespace Proyecto_Administrador_de_tareas.Views
{
    public partial class MainForm : Form
    {
        private TaskViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new TaskViewModel();
            BindData();
        }

        private void BindData()
        {
            // Conectar el DataGridView a la colección de tareas del ViewModel
            taskDataGridView.DataSource = _viewModel.Tasks;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Crear una nueva tarea y añadirla usando el ViewModel
            Task newTask = new Task
            {
                Id = _viewModel.Tasks.Count + 1,
                Description = txtDescription.Text,
                Status = cmbStatus.SelectedItem.ToString(),
                Priority = cmbPriority.SelectedItem.ToString(),
                DueDate = dtpDueDate.Value,
                Notes = txtNotes.Text
            };

            _viewModel.AddTask(newTask);
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            // Eliminar la tarea seleccionada usando el ViewModel
            if (taskDataGridView.SelectedRows.Count > 0)
            {
                int taskId = (int)taskDataGridView.SelectedRows[0].Cells["Id"].Value;
                _viewModel.DeleteTask(taskId);
            }
        }
    }
}
