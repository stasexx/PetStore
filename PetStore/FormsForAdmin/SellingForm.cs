using PetStore.PetStoreDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetStore.FormsForAdmin
{
    public partial class SellingForm : Form
    {
        public static SqlConnection Connection = Program.SqlConnection;
        public bool report = false;
        public bool edit = false;
        public SellingForm(int id)
        {
            InitializeComponent();
            selling_idTextBox.Text = id.ToString();
        }

        public SellingForm(bool rep)
        {
            InitializeComponent();
            report = rep;
        }

        private void sellingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sellingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petStoreDataSet);

        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Selling". При необходимости она может быть перемещена или удалена.
            this.sellingTableAdapter.Fill(this.petStoreDataSet.Selling);
            LoadComboboxs();

        }

        public void LoadComboboxs()
        {
            string sqlForClient = "SELECT Client_id " +
                "\r\nFROM Client";
            using (SqlCommand command = new SqlCommand(sqlForClient, Connection))
            {
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        comboBoxForClient.Items.Add(item.ToString());
                    }
                }
            }

            string sqlForProduct = "SELECT DISTINCT Product.Product_id FROM Product, Feed, Animal WHERE Animal.Animal_id = Product.Product_id OR Feed.Feed_id = Product.Product_id";
            using (SqlCommand command = new SqlCommand(sqlForProduct, Connection))
            {
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        comboBoxForProduct.Items.Add(item.ToString());
                    }
                }
            }
        }

        private void buttonForPrintAndSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    sellingTableAdapter.InsertQuery(Convert.ToInt32(selling_idTextBox.Text), selling_dateDateTimePicker.Value.ToString(), Convert.ToDouble(total_priceTextBox.Text),
                        Convert.ToInt32(comboBoxForProduct.Text), Convert.ToInt32(comboBoxForClient.Text));
                Close();
            }
        }

        private void comboBoxForClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlForClient = $"SELECT Full_name\r\nFROM Client\r\nWHERE Client_id = {comboBoxForClient.Text}";
            using (SqlCommand command = new SqlCommand(sqlForClient, Connection))
            {
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                textBoxForFullName.Text = dt.Rows[0].ItemArray[0].ToString();
            }
        }

        private void comboBoxForProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlForFeed = $"SELECT Feed_name, Cost" +
                $"\r\nFROM Feed, Product" +
                $"\r\nWHERE Feed_id = {comboBoxForProduct.Text} AND Feed.Feed_id = Product.Product_id";
            using (SqlCommand command = new SqlCommand(sqlForFeed, Connection))
            {
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    string sqlForAnimal = $"SELECT Animal_name, Cost" +
                $"\r\nFROM Animal, Product" +
                $"\r\nWHERE Animal_id = {comboBoxForProduct.Text} AND Animal.Animal_id = Product.Product_id";
                    using (SqlCommand command1 = new SqlCommand(sqlForAnimal, Connection))
                    {
                        command1.CommandType = CommandType.Text;
                        DataTable dt1 = new DataTable();
                        SqlDataAdapter adapter1 = new SqlDataAdapter(command1);

                        adapter1.Fill(dt1);
                        textBox1.Text = dt1.Rows[0].ItemArray[0].ToString();
                        total_priceTextBox.Text = dt1.Rows[0].ItemArray[1].ToString();
                    }
                }
                if (dt.Rows.Count != 0)
                {
                    textBox1.Text = dt.Rows[0].ItemArray[0].ToString();
                    total_priceTextBox.Text = dt.Rows[0].ItemArray[1].ToString();
                }
            }
        }

        private void buttonForSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    sellingTableAdapter.UpdateQuery(Convert.ToInt32(selling_idTextBox.Text), selling_dateDateTimePicker.Value.ToString(), Convert.ToDouble(total_priceTextBox.Text),
                        Convert.ToInt32(comboBoxForProduct.Text), Convert.ToInt32(comboBoxForClient.Text));
                    Close();
                }
                else
                    sellingTableAdapter.InsertQuery(Convert.ToInt32(selling_idTextBox.Text), selling_dateDateTimePicker.Value.ToString(), Convert.ToDouble(total_priceTextBox.Text),
                        Convert.ToInt32(comboBoxForProduct.Text), Convert.ToInt32(comboBoxForClient.Text));
                Close();
            }
        }
    }
}

