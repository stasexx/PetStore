using PetStore.PetStoreDataSetTableAdapters;
using PetStore.Reports;
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
        public static bool cheker = false;
        public static int feed_id = 0;
        public static int client_id = 0;
        public SellingForm(int id)
        {
            InitializeComponent();
            selling_idTextBox.Text = id.ToString();
        }

        public SellingForm(bool rep, int id)
        {
            InitializeComponent();
            report = rep;
            selling_idTextBox.Text = id.ToString();
        }

        public SellingForm(int id, DateTime date, double totalPrice, int product, int client):this(id)
        {
            edit = true;
            selling_idTextBox.Text = id.ToString();
            selling_dateDateTimePicker.Value = date;
            total_priceTextBox.Text = totalPrice.ToString();
            comboBoxForProduct.Text = product.ToString();
            comboBoxForClient.Text = client.ToString();
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
                feed_id = Convert.ToInt32(comboBoxForProduct.Text);
                client_id = Convert.ToInt32(comboBoxForClient.Text);
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
                    cheker = true;
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
                        string sqlForCost2 = $"SELECT Cost * 1" +
    $"\r\nFROM Animal" +
    $"\r\nWhere Animal_id = {comboBoxForProduct.Text}";
                        using (SqlCommand command2 = new SqlCommand(sqlForCost2, Connection))
                        {
                            command1.CommandType = CommandType.Text;
                            DataTable dt2 = new DataTable();
                            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

                            adapter1.Fill(dt2);
                            total_priceTextBox.Text = dt2.Rows[0].ItemArray[1].ToString();
                        }
                    }
                }
                if (dt.Rows.Count != 0)
                {
                    string sqlForCost2 = $"SELECT Cost * 1n " +
    $"\r\nFROM Feed" +
    $"\r\nWhere Feed_id = {comboBoxForProduct.Text}";
                    using (SqlCommand command1 = new SqlCommand(sqlForCost2, Connection))
                    {
                        command1.CommandType = CommandType.Text;
                        DataTable dt1 = new DataTable();
                        SqlDataAdapter adapter1 = new SqlDataAdapter(command1);

                        adapter1.Fill(dt1);
                        total_priceTextBox.Text = dt1.Rows[0].ItemArray[0].ToString();
                    }
                    textBox1.Text = dt.Rows[0].ItemArray[0].ToString();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxForProduct.Items.Clear();
            var list = SQLCommandForAdmin.ComboForProduct(comboBox1.Text);
            foreach (var item in list)
            {
                comboBoxForProduct.Items.Add(item);
            }

        }
    }
}

