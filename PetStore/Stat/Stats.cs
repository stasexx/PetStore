using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore.Stat
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQLForStats.SecondStats();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQLForStats.FirstStats();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQLForStats.ThirdStats();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQLForStats.FourthStats();
        }
    }
}
