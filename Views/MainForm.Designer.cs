namespace Proyecto_Administrador_de_tareas.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskDataGridView = new DataGridView();
            txtDescription = new TextBox();
            cmbStatus = new ComboBox();
            cmbPriority = new ComboBox();
            dtpDueDate = new DateTimePicker();
            txtNotes = new TextBox();
            BtnAddTask = new Button();
            BtnEditTask = new Button();
            BtnDeleteTask = new Button();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).BeginInit();
            SuspendLayout();
            // 
            // taskDataGridView
            // 
            taskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskDataGridView.Location = new Point(409, 92);
            taskDataGridView.Name = "taskDataGridView";
            taskDataGridView.RowHeadersWidth = 51;
            taskDataGridView.Size = new Size(568, 227);
            taskDataGridView.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(124, 52);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(112, 103);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 2;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(112, 159);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(151, 28);
            cmbPriority.TabIndex = 3;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(72, 222);
            dtpDueDate.MinDate = new DateTime(2024, 9, 17, 0, 0, 0, 0);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 4;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(124, 282);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(125, 27);
            txtNotes.TabIndex = 5;
            // 
            // BtnAddTask
            // 
            BtnAddTask.Location = new Point(99, 372);
            BtnAddTask.Name = "BtnAddTask";
            BtnAddTask.Size = new Size(94, 29);
            BtnAddTask.TabIndex = 6;
            BtnAddTask.Text = "Agregar";
            BtnAddTask.UseVisualStyleBackColor = true;
            BtnAddTask.Click += BtnAddTask_Click;
            // 
            // BtnEditTask
            // 
            BtnEditTask.Location = new Point(262, 372);
            BtnEditTask.Name = "BtnEditTask";
            BtnEditTask.Size = new Size(94, 29);
            BtnEditTask.TabIndex = 7;
            BtnEditTask.Text = "Editar";
            BtnEditTask.UseVisualStyleBackColor = true;
            BtnEditTask.Click += BtnEditTask_Click;
            // 
            // BtnDeleteTask
            // 
            BtnDeleteTask.Location = new Point(409, 372);
            BtnDeleteTask.Name = "BtnDeleteTask";
            BtnDeleteTask.Size = new Size(94, 29);
            BtnDeleteTask.TabIndex = 8;
            BtnDeleteTask.Text = "Eliminar";
            BtnDeleteTask.UseVisualStyleBackColor = true;
            BtnDeleteTask.Click += BtnDeleteTask_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 554);
            Controls.Add(BtnDeleteTask);
            Controls.Add(BtnEditTask);
            Controls.Add(BtnAddTask);
            Controls.Add(txtNotes);
            Controls.Add(dtpDueDate);
            Controls.Add(cmbPriority);
            Controls.Add(cmbStatus);
            Controls.Add(txtDescription);
            Controls.Add(taskDataGridView);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView taskDataGridView;
        private TextBox txtDescription;
        private ComboBox cmbStatus;
        private ComboBox cmbPriority;
        private DateTimePicker dtpDueDate;
        private TextBox txtNotes;
        private Button BtnAddTask;
        private Button BtnEditTask;
        private Button BtnDeleteTask;
    }
}