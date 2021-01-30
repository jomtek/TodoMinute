using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoMinute.Theme;

namespace TodoMinute.Task
{
    public partial class EditTaskForm : Form
    {
        public string NewTitle { get; private set; }
        public string NewDescription { get; private set; }

        public EditTaskForm(TaskDescription desc)
        {
            InitializeComponent();
            titleTB.Text = desc.Title;
            descRTB.Text = desc.Description;
        }

        private void EditTaskForm_Shown(object sender, EventArgs e)
        {
            saveBTN.Focus();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            NewTitle = titleTB.Text;
            NewDescription = descRTB.Text;
        }
    }
}
