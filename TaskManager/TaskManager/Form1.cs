using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Model;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private tmDBContext tmContext;
        public Form1()
        {
            InitializeComponent();
            tmContext = new tmDBContext();
            var statuses = tmContext.Statuses.ToList();
            foreach (Status status in statuses)
            {
                cboStatus.Items.Add(status);
            }
            refreshData();
        }

        private void refreshData()
        {
            BindingSource bindingSource = new BindingSource();

            var query = from task in tmContext.Tasks
                        orderby task.DueDate
                        select new { TaskId = task.Id, TaskName = task.Name, StatusName = task.Status.Name, DueDate = task.DueDate };
            
            bindingSource.DataSource = query.ToList();

            dataGridView1.DataSource = bindingSource;
            dataGridView1.Refresh();
        }

        private void cmdCreateTask_Click(object sender, EventArgs e)
        {
            if (cboStatus.SelectedItem != null && txtTask.Text != string.Empty)
            {
                /*var newTask = new Model.Task
                {
                    Name = txtTask.Text,
                    StatusId = (cboStatus.SelectedItem as Model.Status).Id,
                    DueDate = dateTimePicker1.Value
                };
                Este bloque comentado es lo mismo que el bloque de código de abajo
                 */
                var newTask = new Model.Task();
                newTask.Name = txtTask.Text;
                newTask.StatusId = (cboStatus.SelectedItem as Model.Status).Id;
                newTask.DueDate = dateTimePicker1.Value;

                tmContext.Tasks.Add(newTask);

                tmContext.SaveChanges();
                refreshData();
            }
            else
            {
                MessageBox.Show("Please make sue all data has been entered");
            }
        }

        private void cmdDeleteTask_Click(object sender, EventArgs e)
        {
            var task = tmContext.Tasks.Find(dataGridView1.SelectedCells[0].Value);

            tmContext.Tasks.Remove(task);
            tmContext.SaveChanges();
            refreshData();
        }

        private void cmdUpdateTask_Click(object sender, EventArgs e)
        {
            if(cmdUpdateTask.Text == "Update")
            {
                txtTask.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedCells[3].Value;
                foreach (Status status in cboStatus.Items)
                {
                    if (status.Name == dataGridView1.SelectedCells[2].Value.ToString())
                    {
                        cboStatus.SelectedItem = status;
                    }
                }
                cmdUpdateTask.Text = "Save";
            }
            else if (cmdUpdateTask.Text == "Save")
            {
                var task = tmContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);

                task.Name = txtTask.Text;
                task.StatusId = (cboStatus.SelectedItem as Status).Id;
                task.DueDate = dateTimePicker1.Value;

                tmContext.SaveChanges();
                refreshData();
                
                cmdUpdateTask.Text = "Update";
                txtTask.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                cboStatus.Text = "Please select...";
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            cmdUpdateTask.Text = "Update";
            txtTask.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            cboStatus.Text = "Please select...";
        }
    }
}
