using PetStore.FormsForAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore.Reports
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Selling". При необходимости она может быть перемещена или удалена.
            this.sellingTableAdapter.Fill(this.petStoreDataSet.Selling);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.petStoreDataSet.Product);

        }

        private void buttonForNew_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm(true);
            selling.ShowDialog();
        }
    }
}
