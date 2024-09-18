using Proyecto_Administrador_de_tareas.ViewModels;
using Task = Proyecto_Administrador_de_tareas.Models.Task;

namespace Proyecto_Administrador_de_tareas.Views
{
    public partial class MainForm : Form
    {
        private TaskViewModel _viewModel;
        private bool isEditing = false;
        private int editingTaskId = -1; // Almacena el ID de la tarea que se está editando

        // Contructor
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

            // Reflejar los cambios en en DataGridView
            taskDataGridView.DataSource = null;
            taskDataGridView.DataSource = _viewModel.Tasks;
            taskDataGridView.Columns["Id"].Visible = false; // Ocultar el ID
            cmbStatus.SelectedItem = "PENDIENTE"; // Estado por defecto

            taskDataGridView.Columns["Description"].HeaderText = "Descripción";
            taskDataGridView.Columns["Status"].HeaderText = "Estado";
            taskDataGridView.Columns["Priority"].HeaderText = "Prioridad";
            taskDataGridView.Columns["DueDate"].HeaderText = "Fecha";
            taskDataGridView.Columns["Notes"].HeaderText = "Notas";
        }

        // Configuraracion entre los controles y el ViewModel
        private void SetupBindings()
        {
            cmbStatus.Items.AddRange(new string[] { "PENDIENTE", "EN PROCESO", "FINALIZADA" });
            cmbPriority.Items.AddRange(new string[] { "ALTA", "MEDIA", "BAJA" });

            cmbStatus.SelectedItem = "PENDIENTE";
            dtpDueDate.MinDate = DateTime.Today;
        }

        // Metodos Agregar, Editar y Eliminar
        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("La descripción es obligatoria.", "Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("El estatus es obligatorio.", "Estatus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (cmbPriority.SelectedItem == null)
            {
                MessageBox.Show("La prioridad es obligatoria.", "Prioridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                var newTask = new Task // Se crea la nueva tarea
                {
                    Description = txtDescription.Text,
                    Status = cmbStatus.SelectedItem.ToString(),
                    Priority = cmbPriority.SelectedItem.ToString(),
                    DueDate = dtpDueDate.Value.Date,
                    Notes = txtNotes.Text
                };

                _viewModel.AddTask(newTask); // Se envia al ViewModel
                ClearFields(); // Limpiar los campos

                BindData(); // Se recargan los datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
            }
        }

        // Editar una tarea
        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            // No se puede editar si esta "FINALIZADA"
            if (taskDataGridView.SelectedRows[0].Cells["Status"].Value.ToString() == "PENDIENTE" || taskDataGridView.SelectedRows[0].Cells["Status"].Value.ToString() == "EN PROCESO")
            {
                // Si modo de edición
                if (!isEditing)
                {
                    if (taskDataGridView.SelectedRows.Count > 0)
                    {
                        // Obtener el ID de la tarea seleccionada
                        editingTaskId = (int)taskDataGridView.SelectedRows[0].Cells["Id"].Value;

                        // Obtener la tarea seleccionada desde el ViewModel
                        var taskToEdit = _viewModel.GetTaskById(editingTaskId);

                        // Se cambia el MinDate en caso de ser menor a la fecha actual
                        if (taskToEdit.DueDate < DateTime.Now.Date)
                        {
                            dtpDueDate.MinDate = taskToEdit.DueDate;
                        }
                        
                        // Llenar los campos con los datos de la tarea seleccionada
                        txtDescription.Text = taskToEdit.Description;
                        cmbStatus.SelectedItem = taskToEdit.Status;
                        cmbPriority.SelectedItem = taskToEdit.Priority;
                        dtpDueDate.Value = taskToEdit.DueDate;
                        txtNotes.Text = taskToEdit.Notes;

                        // Cambiar el texto del botón a "Guardar"
                        BtnEditTask.Text = "Guardar";

                        // Cambiar el estado a modo edicion
                        isEditing = true;

                        // Botones inabilitados en edicion
                        BtnAddTask.Enabled = false;
                        BtnDeleteTask.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona una tarea para editar.");
                    }
                }
                // Si modo edicion
                else
                {
                    try
                    {
                        // Nueva tarea actualizada
                        var updatedTask = new Task
                        {
                            Description = txtDescription.Text,
                            Status = cmbStatus.SelectedItem.ToString(),
                            Priority = cmbPriority.SelectedItem.ToString(),
                            DueDate = dtpDueDate.Value.Date,
                            Notes = txtNotes.Text
                        };

                        // Guardar los cambios
                        _viewModel.EditTask(editingTaskId, updatedTask);

                        ClearFields(); // Limpiar los campos

                        // Cargar los datos
                        BindData();

                        // Estado a no edición
                        isEditing = false;

                        // Se restablece botón de a "Editar"
                        BtnEditTask.Text = "Editar";

                        // Se restablece el MinDate
                        dtpDueDate.MinDate = DateTime.Now;

                        // Se habilitan los botones
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

        // Eliminar tarea
        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            if (taskDataGridView.SelectedRows.Count > 0)
            {
                // Tarea seleccionada del DataGridView
                var selectedRow = taskDataGridView.SelectedRows[0];
                var selectedTask = (Task)selectedRow.DataBoundItem;

                // Si la tarea esta en estado "EN PROCESO"
                if (selectedTask.Status == "EN PROCESO")
                {
                    // Mostrar mensaje de advertencia
                    MessageBox.Show("No se puede eliminar una tarea en estado 'EN PROCESO'.", "Eliminación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Mensaje de confirmacion
                    var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta tarea?", 
                                                    "Confirmar eliminación", 
                                                    MessageBoxButtons.YesNo, 
                                                    MessageBoxIcon.Question);
            
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Eliminar la tarea
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

        // Limpiar los campos del formulario
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
