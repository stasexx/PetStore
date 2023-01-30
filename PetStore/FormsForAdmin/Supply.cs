using PetStore.PetStoreDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore.FormsForAdmin
{
    public partial class Supply : Form
    {
        bool edit = false;
        public Supply(int id)
        {
            InitializeComponent();
            supply_idTextBox.Text = id.ToString();
        }

        public Supply(int id, DateTime date1, DateTime date2, double amount, int feed_id ):this(id)
        {
            edit = true;
            supply_idTextBox.Text=id.ToString();
            date_of_deliveryDateTimePicker.Text=date1.ToString();
            expiry_dateDateTimePicker.Text=date2.ToString();
            amountTextBox.Text=amount.ToString();
            comboBox1.Text = feed_id.ToString();
        }

        private void supplyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petStoreDataSet);

        }

        private void Supply_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Feed". При необходимости она может быть перемещена или удалена.
            this.feedTableAdapter.Fill(this.petStoreDataSet.Feed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.petStoreDataSet.Supply);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    supplyTableAdapter.UpdateQuery(Convert.ToInt32(supply_idTextBox.Text), date_of_deliveryDateTimePicker.Value.ToString(), expiry_dateDateTimePicker.Value.ToString(), Convert.ToDouble(amountTextBox.Text), Convert.ToInt32(comboBox1.SelectedValue));
                    Close();
                }
                else
                {
                    supplyTableAdapter.InsertQuery(Convert.ToInt32(supply_idTextBox.Text), date_of_deliveryDateTimePicker.Value.ToString(), expiry_dateDateTimePicker.Value.ToString(), Convert.ToDouble(amountTextBox.Text), Convert.ToInt32(comboBox1.SelectedValue));
                    Close();
                }
            }
        }
    }
}
