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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            taskDataGridView = new DataGridView();
            cmbFilterStatus = new ComboBox();
            cmbFilterPriority = new ComboBox();
            cmbFilterDueDate = new ComboBox();
            BtnAddTask = new DevExpress.XtraEditors.SimpleButton();
            BtnEditTask = new DevExpress.XtraEditors.SimpleButton();
            BtnDeleteTask = new DevExpress.XtraEditors.SimpleButton();
            txtNotes = new DevExpress.XtraEditors.TextEdit();
            cmbStatus = new ComboBox();
            cmbPriority = new ComboBox();
            dtpDueDate = new DateTimePicker();
            LbNewTask = new Label();
            LbDescription = new Label();
            txtDescription = new DevExpress.XtraEditors.TextEdit();
            LbStatus = new Label();
            LbPriority = new Label();
            label1 = new Label();
            LbNotes = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNotes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            SuspendLayout();
            // 
            // taskDataGridView
            // 
            taskDataGridView.AllowUserToAddRows = false;
            taskDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            taskDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            taskDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskDataGridView.BackgroundColor = Color.FromArgb(41, 72, 97);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            taskDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            taskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            taskDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            taskDataGridView.GridColor = Color.Black;
            taskDataGridView.Location = new Point(701, 104);
            taskDataGridView.MultiSelect = false;
            taskDataGridView.Name = "taskDataGridView";
            taskDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            taskDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            taskDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            taskDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            taskDataGridView.Size = new Size(720, 520);
            taskDataGridView.TabIndex = 0;
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.BackColor = Color.WhiteSmoke;
            cmbFilterStatus.Font = new Font("Segoe UI", 10.2F);
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Location = new Point(1221, 66);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(200, 31);
            cmbFilterStatus.TabIndex = 9;
            cmbFilterStatus.SelectedValueChanged += ApplyFilters;
            // 
            // cmbFilterPriority
            // 
            cmbFilterPriority.BackColor = Color.WhiteSmoke;
            cmbFilterPriority.Font = new Font("Segoe UI", 10.2F);
            cmbFilterPriority.FormattingEnabled = true;
            cmbFilterPriority.Location = new Point(1015, 66);
            cmbFilterPriority.Name = "cmbFilterPriority";
            cmbFilterPriority.Size = new Size(200, 31);
            cmbFilterPriority.TabIndex = 10;
            cmbFilterPriority.SelectedValueChanged += ApplyFilters;
            // 
            // cmbFilterDueDate
            // 
            cmbFilterDueDate.BackColor = Color.WhiteSmoke;
            cmbFilterDueDate.Font = new Font("Segoe UI", 10.2F);
            cmbFilterDueDate.FormattingEnabled = true;
            cmbFilterDueDate.Location = new Point(809, 66);
            cmbFilterDueDate.Name = "cmbFilterDueDate";
            cmbFilterDueDate.Size = new Size(200, 31);
            cmbFilterDueDate.TabIndex = 11;
            cmbFilterDueDate.SelectedValueChanged += ApplyFilters;
            // 
            // BtnAddTask
            // 
            BtnAddTask.Appearance.Font = new Font("Tahoma", 12F);
            BtnAddTask.Appearance.ForeColor = SystemColors.ActiveCaptionText;
            BtnAddTask.Appearance.Options.UseFont = true;
            BtnAddTask.Appearance.Options.UseForeColor = true;
            BtnAddTask.Location = new Point(137, 587);
            BtnAddTask.Name = "BtnAddTask";
            BtnAddTask.Size = new Size(118, 37);
            BtnAddTask.TabIndex = 12;
            BtnAddTask.Text = "Agregar";
            BtnAddTask.Click += BtnAddTask_Click;
            // 
            // BtnEditTask
            // 
            BtnEditTask.Appearance.Font = new Font("Tahoma", 12F);
            BtnEditTask.Appearance.ForeColor = SystemColors.ActiveCaptionText;
            BtnEditTask.Appearance.Options.UseFont = true;
            BtnEditTask.Appearance.Options.UseForeColor = true;
            BtnEditTask.Location = new Point(294, 587);
            BtnEditTask.Name = "BtnEditTask";
            BtnEditTask.Size = new Size(118, 37);
            BtnEditTask.TabIndex = 13;
            BtnEditTask.Text = "Editar";
            BtnEditTask.Click += BtnEditTask_Click;
            // 
            // BtnDeleteTask
            // 
            BtnDeleteTask.Appearance.Font = new Font("Tahoma", 12F);
            BtnDeleteTask.Appearance.ForeColor = SystemColors.ActiveCaptionText;
            BtnDeleteTask.Appearance.Options.UseFont = true;
            BtnDeleteTask.Appearance.Options.UseForeColor = true;
            BtnDeleteTask.Location = new Point(439, 587);
            BtnDeleteTask.Name = "BtnDeleteTask";
            BtnDeleteTask.Size = new Size(118, 37);
            BtnDeleteTask.TabIndex = 14;
            BtnDeleteTask.Text = "Eliminar";
            BtnDeleteTask.Click += BtnDeleteTask_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(216, 418);
            txtNotes.Name = "txtNotes";
            txtNotes.Properties.Appearance.BackColor = Color.WhiteSmoke;
            txtNotes.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtNotes.Properties.Appearance.Options.UseBackColor = true;
            txtNotes.Properties.Appearance.Options.UseFont = true;
            txtNotes.Size = new Size(383, 28);
            txtNotes.TabIndex = 16;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.WhiteSmoke;
            cmbStatus.Font = new Font("Microsoft Sans Serif", 10.8F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(216, 214);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(383, 30);
            cmbStatus.TabIndex = 20;
            // 
            // cmbPriority
            // 
            cmbPriority.BackColor = Color.WhiteSmoke;
            cmbPriority.Font = new Font("Microsoft Sans Serif", 10.8F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(216, 287);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(383, 30);
            cmbPriority.TabIndex = 21;
            // 
            // dtpDueDate
            // 
            dtpDueDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpDueDate.Font = new Font("Microsoft Sans Serif", 10.8F);
            dtpDueDate.Location = new Point(216, 349);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(383, 28);
            dtpDueDate.TabIndex = 22;
            // 
            // LbNewTask
            // 
            LbNewTask.AutoSize = true;
            LbNewTask.BackColor = Color.Transparent;
            LbNewTask.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbNewTask.ForeColor = Color.White;
            LbNewTask.Location = new Point(206, 67);
            LbNewTask.Name = "LbNewTask";
            LbNewTask.Size = new Size(223, 34);
            LbNewTask.TabIndex = 23;
            LbNewTask.Text = "Agregar tarea";
            // 
            // LbDescription
            // 
            LbDescription.AutoSize = true;
            LbDescription.BackColor = Color.Transparent;
            LbDescription.Font = new Font("Candara", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbDescription.ForeColor = Color.White;
            LbDescription.Location = new Point(58, 142);
            LbDescription.Name = "LbDescription";
            LbDescription.Size = new Size(125, 28);
            LbDescription.TabIndex = 24;
            LbDescription.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(216, 148);
            txtDescription.Name = "txtDescription";
            txtDescription.Properties.Appearance.BackColor = Color.WhiteSmoke;
            txtDescription.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtDescription.Properties.Appearance.Options.UseBackColor = true;
            txtDescription.Properties.Appearance.Options.UseFont = true;
            txtDescription.Size = new Size(383, 28);
            txtDescription.TabIndex = 15;
            // 
            // LbStatus
            // 
            LbStatus.AutoSize = true;
            LbStatus.BackColor = Color.Transparent;
            LbStatus.Font = new Font("Candara", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbStatus.ForeColor = Color.White;
            LbStatus.Location = new Point(58, 214);
            LbStatus.Name = "LbStatus";
            LbStatus.Size = new Size(79, 28);
            LbStatus.TabIndex = 25;
            LbStatus.Text = "Estado";
            // 
            // LbPriority
            // 
            LbPriority.AutoSize = true;
            LbPriority.BackColor = Color.Transparent;
            LbPriority.Font = new Font("Candara", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbPriority.ForeColor = Color.White;
            LbPriority.Location = new Point(58, 287);
            LbPriority.Name = "LbPriority";
            LbPriority.Size = new Size(101, 28);
            LbPriority.TabIndex = 26;
            LbPriority.Text = "Prioridad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 348);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 27;
            label1.Text = "Fecha limite";
            // 
            // LbNotes
            // 
            LbNotes.AutoSize = true;
            LbNotes.BackColor = Color.Transparent;
            LbNotes.Font = new Font("Candara", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbNotes.ForeColor = Color.White;
            LbNotes.Location = new Point(58, 417);
            LbNotes.Name = "LbNotes";
            LbNotes.Size = new Size(70, 28);
            LbNotes.TabIndex = 28;
            LbNotes.Text = "Notas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1004, 21);
            label2.Name = "label2";
            label2.Size = new Size(117, 34);
            label2.TabIndex = 29;
            label2.Text = "Tareas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(701, 67);
            label3.Name = "label3";
            label3.Size = new Size(82, 27);
            label3.TabIndex = 30;
            label3.Text = "Filtros";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(41, 72, 97);
            ClientSize = new Size(1447, 668);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LbNotes);
            Controls.Add(label1);
            Controls.Add(LbPriority);
            Controls.Add(LbStatus);
            Controls.Add(LbDescription);
            Controls.Add(LbNewTask);
            Controls.Add(dtpDueDate);
            Controls.Add(cmbPriority);
            Controls.Add(cmbStatus);
            Controls.Add(txtNotes);
            Controls.Add(txtDescription);
            Controls.Add(BtnDeleteTask);
            Controls.Add(BtnEditTask);
            Controls.Add(BtnAddTask);
            Controls.Add(cmbFilterDueDate);
            Controls.Add(cmbFilterPriority);
            Controls.Add(cmbFilterStatus);
            Controls.Add(taskDataGridView);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador de tareas";
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNotes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnDeleteTask_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView taskDataGridView;
        private ComboBox cmbFilterStatus;
        private ComboBox cmbFilterPriority;
        private ComboBox cmbFilterDueDate;
        private DevExpress.XtraEditors.SimpleButton BtnAddTask;
        private DevExpress.XtraEditors.SimpleButton BtnEditTask;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteTask;
        private DevExpress.XtraEditors.TextEdit txtNotes;
        private ComboBox cmbStatus;
        private ComboBox cmbPriority;
        private DateTimePicker dtpDueDate;
        private Label LbNewTask;
        private Label LbDescription;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private Label LbStatus;
        private Label LbPriority;
        private Label label1;
        private Label LbNotes;
        private Label label2;
        private Label label3;
    }
}