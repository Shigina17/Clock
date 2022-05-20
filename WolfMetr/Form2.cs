using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mimimimetr
{
    public partial class Form2 : Form
    {
        private List<string[]> listElementFromDataBase;
        private WorkWithDataBase workWithDataBase = new WorkWithDataBase();
        public Form2()
        {
            InitializeComponent();
            listElementFromDataBase = workWithDataBase.GetListOfElementFromDataBase("SELECT * FROM PathToImg");
        }
        private void Form2_Data_Load(object sender, EventArgs e)
        {
            foreach (string[] s in listElementFromDataBase)
                dataGridView1.Rows.Add(s);
        }


    }
}
