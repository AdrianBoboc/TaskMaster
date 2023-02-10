namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdDeleteTask = new System.Windows.Forms.Button();
            this.cmdUpdateTask = new System.Windows.Forms.Button();
            this.cmdCreateTask = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.laberStatus = new System.Windows.Forms.Label();
            this.LabelTextTask = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdDeleteTask);
            this.groupBox1.Controls.Add(this.cmdUpdateTask);
            this.groupBox1.Controls.Add(this.cmdCreateTask);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtTask);
            this.groupBox1.Controls.Add(this.labelDueDate);
            this.groupBox1.Controls.Add(this.laberStatus);
            this.groupBox1.Controls.Add(this.LabelTextTask);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(303, 102);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdDeleteTask
            // 
            this.cmdDeleteTask.Location = new System.Drawing.Point(384, 73);
            this.cmdDeleteTask.Name = "cmdDeleteTask";
            this.cmdDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteTask.TabIndex = 8;
            this.cmdDeleteTask.Text = "Delete";
            this.cmdDeleteTask.UseVisualStyleBackColor = true;
            this.cmdDeleteTask.Click += new System.EventHandler(this.cmdDeleteTask_Click);
            // 
            // cmdUpdateTask
            // 
            this.cmdUpdateTask.Location = new System.Drawing.Point(303, 73);
            this.cmdUpdateTask.Name = "cmdUpdateTask";
            this.cmdUpdateTask.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateTask.TabIndex = 7;
            this.cmdUpdateTask.Text = "Update";
            this.cmdUpdateTask.UseVisualStyleBackColor = true;
            this.cmdUpdateTask.Click += new System.EventHandler(this.cmdUpdateTask_Click);
            // 
            // cmdCreateTask
            // 
            this.cmdCreateTask.Location = new System.Drawing.Point(222, 73);
            this.cmdCreateTask.Name = "cmdCreateTask";
            this.cmdCreateTask.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateTask.TabIndex = 6;
            this.cmdCreateTask.Text = "Create";
            this.cmdCreateTask.UseVisualStyleBackColor = true;
            this.cmdCreateTask.Click += new System.EventHandler(this.cmdCreateTask_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(119, 75);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(97, 21);
            this.cboStatus.TabIndex = 5;
            this.cboStatus.Text = "Please select...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(630, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(118, 24);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(260, 20);
            this.txtTask.TabIndex = 3;
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(570, 23);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(54, 13);
            this.labelDueDate.TabIndex = 2;
            this.labelDueDate.Text = "Due date:";
            // 
            // laberStatus
            // 
            this.laberStatus.AutoSize = true;
            this.laberStatus.Location = new System.Drawing.Point(34, 78);
            this.laberStatus.Name = "laberStatus";
            this.laberStatus.Size = new System.Drawing.Size(40, 13);
            this.laberStatus.TabIndex = 1;
            this.laberStatus.Text = "Status:";
            // 
            // LabelTextTask
            // 
            this.LabelTextTask.AutoSize = true;
            this.LabelTextTask.Location = new System.Drawing.Point(34, 27);
            this.LabelTextTask.Name = "LabelTextTask";
            this.LabelTextTask.Size = new System.Drawing.Size(34, 13);
            this.LabelTextTask.TabIndex = 0;
            this.LabelTextTask.Text = "Task:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manaster";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdDeleteTask;
        private System.Windows.Forms.Button cmdUpdateTask;
        private System.Windows.Forms.Button cmdCreateTask;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label laberStatus;
        private System.Windows.Forms.Label LabelTextTask;
    }
}

