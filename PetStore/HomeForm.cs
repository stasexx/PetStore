using PetStore.AutoDiscount;
using PetStore.FormsWithInformation;
using PetStore.Stat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            auto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            stats.ShowDialog();
        }
    }
}
