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
    public partial class ProductForm : Form
    {
        public bool edit = false;
        public ProductForm(int id)
        {
            InitializeComponent();
            product_idTextBox.Text = id.ToString();
        }
        
        public ProductForm(int id, string type):this(id)
        {
            edit = true;
            product_idTextBox.Text = id.ToString();
            comboBox1.SelectedItem = type.ToString();
            product_idTextBox.ReadOnly = true;
        }
        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petStoreDataSet);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.petStoreDataSet.Product);

        }

        private void product_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    productTableAdapter.UpdateQuery(Convert.ToInt32(product_idTextBox.Text), comboBox1.Text);
                    Close();
                }
                else
                {
                    var cheker = SQLCommandForAdmin.ForCheck();
                    if (!cheker.Contains(product_idTextBox.Text))
                    {
                        productTableAdapter.InsertQuery(Convert.ToInt32(product_idTextBox.Text), comboBox1.Text);
                        Close();
                    }
                    if (cheker.Contains(product_idTextBox.Text))
                    {
                        MessageBox.Show("Такий ID вже існує!", "Помилка");
                    }
                }
            }
        }
    }
}
