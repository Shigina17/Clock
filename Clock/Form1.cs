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
    public partial class ClockForm : Form
    {
        Timer timer01 = new Timer();
        bool b = false;
        public ClockForm()
        {
            InitializeComponent();
        }


        private void ClockForm_Load(object sender, EventArgs e)
        {
            timer01.Interval = 1000;
            timer01.Start();        
        }

    }
}
