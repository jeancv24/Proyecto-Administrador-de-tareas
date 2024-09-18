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
        private bool isEditing = false;
        private int editingTaskId = -1; // Para almacenar el ID de la tarea que se está editando


        public MainForm()
        {
            InitializeComponent();
            _viewModel = new TaskViewModel();
            BindData();
            SetupBindings();
        }

        private void BindData()
        {
            // Recargar las tareas desde la base de datos
            _viewModel.LoadTasks();

            // Volver a asignar la fuente de datos al DataGridView para reflejar los cambios
            taskDataGridView.DataSource = null; // Desvincular la fuente de datos anterior
            taskDataGridView.DataSource = _viewModel.Tasks;
            taskDataGridView.Columns["Id"].Visible = false; // Ocultar el ID
            cmbStatus.SelectedItem = "PENDIENTE";

            taskDataGridView.Columns["Id"].Visible = false; // Ocultar el ID

            taskDataGridView.Columns["Description"].HeaderText = "Descripción";
            taskDataGridView.Columns["Status"].HeaderText = "Estado";
            taskDataGridView.Columns["Priority"].HeaderText = "Prioridad";
            taskDataGridView.Columns["DueDate"].HeaderText = "Fecha";
            taskDataGridView.Columns["Notes"].HeaderText = "Notas";
        }

        // Configurar bindings entre los controles y el ViewModel
        private void SetupBindings()
        {
            cmbStatus.Items.AddRange(new string[] { "PENDIENTE", "EN PROCESO", "FINALIZADA" });
            cmbPriority.Items.AddRange(new string[] { "ALTA", "MEDIA", "BAJA" });

            cmbStatus.SelectedItem = "PENDIENTE";
            dtpDueDate.MinDate = DateTime.Today;
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("La descripción es obligatoria.");
                return;
            }else if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("El estatus es obligatorio.");
                return;
            }else if (cmbPriority.SelectedItem == null)
            {
                MessageBox.Show("La prioridad es obligatoria.");
                return;
            }
            try
            {
                var newTask = new Task
                {
                    Description = txtDescription.Text,
                    Status = cmbStatus.SelectedItem.ToString(),
                    Priority = cmbPriority.SelectedItem.ToString(),
                    DueDate = dtpDueDate.Value.Date,
                    Notes = txtNotes.Text
                };

                _viewModel.AddTask(newTask);
                ClearFields(); // Limpiar los campos después de agregar

                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
            }
        }

        // Método para editar una tarea
        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            if (taskDataGridView.SelectedRows[0].Cells["Status"].Value.ToString() == "PENDIENTE" || taskDataGridView.SelectedRows[0].Cells["Status"].Value.ToString() == "EN PROCESO")
            {
                // Si no estamos en modo de edición
                if (!isEditing)
                {
                    if (taskDataGridView.SelectedRows.Count > 0)
                    {
                        // Obtener el ID de la tarea seleccionada
                        editingTaskId = (int)taskDataGridView.SelectedRows[0].Cells["Id"].Value;

                        // Obtener la tarea seleccionada desde el ViewModel
                        var taskToEdit = _viewModel.GetTaskById(editingTaskId);

                        dtpDueDate.MinDate = taskToEdit.DueDate;

                        // Llenar los campos con los datos de la tarea seleccionada
                        txtDescription.Text = taskToEdit.Description;
                        cmbStatus.SelectedItem = taskToEdit.Status;
                        cmbPriority.SelectedItem = taskToEdit.Priority;
                        dtpDueDate.Value = taskToEdit.DueDate;
                        txtNotes.Text = taskToEdit.Notes;

                        // Cambiar el texto del botón a "Guardar"
                        BtnEditTask.Text = "Guardar";

                        // Cambiar el estado a modo edición
                        isEditing = true;

                        BtnAddTask.Enabled = false;
                        BtnDeleteTask.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona una tarea para editar.");
                    }
                }
                // Si estamos en modo de edición (segunda vez que se presiona el botón)
                else
                {
                    try
                    {
                        // Crear una nueva tarea con los datos actualizados
                        var updatedTask = new Task
                        {
                            Description = txtDescription.Text,
                            Status = cmbStatus.SelectedItem.ToString(),
                            Priority = cmbPriority.SelectedItem.ToString(),
                            DueDate = dtpDueDate.Value.Date,
                            Notes = txtNotes.Text
                        };

                        // Llamar al ViewModel para guardar los cambios
                        _viewModel.EditTask(editingTaskId, updatedTask);
                        ClearFields(); // Limpiar los campos después de guardar

                        // Volver a cargar los datos desde la base de datos
                        BindData();

                        // Cambiar el estado a no edición
                        isEditing = false;

                        // Cambiar el texto del botón de nuevo a "Editar"
                        BtnEditTask.Text = "Editar";

                        BtnAddTask.Enabled = true;
                        BtnDeleteTask.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los cambios: " + ex.Message);
                    }
                }
            }else
            {
                MessageBox.Show("No se pueden editar tareas Finalizadas");
            }

        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
    if (taskDataGridView.SelectedRows.Count > 0)
    {
        // Obtener la tarea seleccionada del DataGridView
        var selectedRow = taskDataGridView.SelectedRows[0];
        var selectedTask = (Task)selectedRow.DataBoundItem;

        // Verificar si la tarea está en estado "EN PROCESO"
        if (selectedTask.Status == "EN PROCESO")
        {
            // Mostrar mensaje de advertencia
            MessageBox.Show("No se puede eliminar una tarea en estado 'EN PROCESO'.", "Eliminación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            // Mostrar un mensaje de confirmación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta tarea?", 
                                                "Confirmar eliminación", 
                                                MessageBoxButtons.YesNo, 
                                                MessageBoxIcon.Question);
            
            if (confirmResult == DialogResult.Yes)
            {
                // Llamar al ViewModel para eliminar la tarea
                _viewModel.DeleteTask(selectedTask.Id);
                
                // Refrescar la lista de tareas
                BindData();
                
                MessageBox.Show("La tarea ha sido eliminada.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    else
    {
        MessageBox.Show("Por favor, selecciona una tarea para eliminar.");
    }
        }

        // Método para limpiar los campos del formulario
        private void ClearFields()
        {
            txtDescription.Clear();
            cmbStatus.SelectedItem = "PENDIENTE";
            cmbStatus.SelectedIndex = -1;
            cmbPriority.SelectedIndex = -1;
            dtpDueDate.Value = DateTime.Now;
            txtNotes.Clear();
        }
    }
}
