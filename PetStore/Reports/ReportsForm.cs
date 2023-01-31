using PetStore.FormsForAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore.Reports
{
    public partial class ReportsForm : Form
    {
        public static SqlConnection Connection = Program.SqlConnection;
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
            SellingForm selling = new SellingForm(true, SQLCommandForAdmin.IdSelectForProduct() + 1);
            selling.ShowDialog();
            ReportsForm_Load(sender, e);
            Docker.DockerForSelling(SellingForm.feed_id, SellingForm.client_id, SellingForm.cheker);

        }

        private void buttonForOld_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlForFeed = $"SELECT DISTINCT Client.Email, Client.Phone_number, Client.Full_name," +
                $"\r\nSelling.Selling_date, Feed_name, Feed.Cost, Feed.Discount" +
                $"\r\nFROM Client, Feed, Selling, Product" +
                $"\r\nWHERE Selling.Selling_id ={comboBox1.Text} AND Client.Client_id = Selling.Client_id" +
                $"\r\nAND Product.Product_id = Feed.Feed_id AND Product.Product_id = Selling.Product_id";
                using (SqlCommand command = new SqlCommand(sqlForFeed, Connection))
                {
                    command.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        string sqlForAnimal = $"SELECT DISTINCT Client.Email, Client.Phone_number, Client.Full_name, Selling.Selling_date, Animal_name, Animal.Cost, Animal.Discount FROM Client, Animal, Selling, Product WHERE Selling.Selling_id = {comboBox1.Text} AND Client.Client_id = Selling.Client_id AND Product.Product_id = Animal.Animal_id AND Product.Product_id = Selling.Product_id";
                        using (SqlCommand command1 = new SqlCommand(sqlForAnimal, Connection))
                        {
                            command1.CommandType = CommandType.Text;
                            DataTable dt1 = new DataTable();
                            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                            adapter1.Fill(dt1);
                            Docker.DockerForSellingTable(dt1);
                        }
                    }
                    if (dt.Rows.Count != 0)
                    {
                        Docker.DockerForSellingTable(dt);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Спочатку обертіь номер продажу!!!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var list = SQLCommandsForReport.ReportBySeasonsRevolution(Convert.ToInt32(textBox1.Text));
            Docker.SelectorForSeasons(list[0], list[1], list[2], list[3]);
        }
    }
}
