using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            ClockForm form = new ClockForm();
            form.ShowDialog();
            Close();
        }
    }
}
