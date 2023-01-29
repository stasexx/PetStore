using PetStore.AutoDiscount;
using PetStore.FormsWithInformation;
using PetStore.Reports;
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
using Microsoft.VisualBasic;

namespace PetStore
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            string password = Microsoft.VisualBasic.Interaction.InputBox("Введіть пароль:");
            if (password != "admin")
            {
                MessageBox.Show("Неправильний пароль!");
            }
            else
            {
                adminForm.ShowDialog();
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }
    }
}
