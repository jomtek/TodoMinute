using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoMinute.Task
{
    public partial class CreateTaskForm : Form
    {
        public string Title { get; private set; }
        public string Description { get; private set; }

        public CreateTaskForm()
        {
            InitializeComponent();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            Title = titleTB.Text;
            Description = descRTB.Text;
        }
    }
}