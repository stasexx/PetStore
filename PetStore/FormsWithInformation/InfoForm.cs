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

namespace PetStore.FormsWithInformation
{
    public partial class InfoForm : Form
    {
        public static SqlConnection Connection = Program.SqlConnection;
        public InfoForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int variation = 0;
            if(textBoxForCaloric1.Text != "" && textBoxForCaloric2.Text == "")
            {
                variation = 1;
            }
            if (textBoxForCaloric1.Text == "" && textBoxForCaloric2.Text != "")
            {
                variation = 2;
            }
            if (textBoxForCaloric1.Text != "" && textBoxForCaloric2.Text != "")
            {
                variation = 3;
            }
            if (textBoxForCaloric1.Text == "" && textBoxForCaloric2.Text == "" && comboBoxForKind.Text != "")
            {
                variation = 4;
            }
            if (textBoxForCaloric1.Text != "" && textBoxForCaloric2.Text == "" && comboBoxForKind.Text != "")
            {
                variation = 5;
            }
            if (textBoxForCaloric1.Text == "" && textBoxForCaloric2.Text != "" && comboBoxForKind.Text != "")
            {
                variation = 6;
            }
            if (textBoxForCaloric1.Text != "" && textBoxForCaloric2.Text != "" && comboBoxForKind.Text != "")
            {
                variation = 7;
            }
            dataGridView1.DataSource = SQLCommandForInformation.Filter(variation, textBoxForCaloric1.Text, textBoxForCaloric2.Text, comboBoxForKind.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int variation = 0;
            if (textBoxAge1.Text != "" && textBoxAge2.Text == "")
            {
                variation = 1;
            }
            if (textBoxAge1.Text == "" && textBoxAge2.Text != "")
            {
                variation = 2;
            }
            if (textBoxAge1.Text != "" && textBoxAge2.Text != "")
            {
                variation = 3;
            }
            if (textBoxAge1.Text == "" && textBoxAge2.Text == "" && comboBoxForKindAnimal.Text != null)
            {
                variation = 4;
            }
            if (textBoxAge1.Text != "" && textBoxAge2.Text == "" && comboBoxForKindAnimal.Text != null)
            {
                variation = 5;
            }
            if (textBoxAge1.Text == "" && textBoxAge2.Text != "" && comboBoxForKindAnimal.Text != null)
            {
                variation = 6;
            }
            if (textBoxAge1.Text != "" && textBoxAge2.Text != "" && comboBoxForKindAnimal.Text != null)
            {
                variation = 7;
            }
            dataGridView1.DataSource = SQLCommandForInformation.FilterForAnimal(variation, textBoxAge1.Text, textBoxAge2.Text, comboBoxForKindAnimal.Text);
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.GroupOfAnimal". При необходимости она может быть перемещена или удалена.
            this.groupOfAnimalTableAdapter.Fill(this.petStoreDataSet.GroupOfAnimal);
            //  TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.petStoreDataSet.Animal);
            string sql = "SELECT name\r\nFROM sys.objects\r\nWHERE type_desc = 'USER_TABLE'";
            using (SqlCommand command = new SqlCommand(sql, Connection))
            {
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                comboBoxForTable.DataSource = dt;
                comboBoxForTable.DisplayMember = "Name";
                comboBoxForTable.ValueMember = "Name";
            }

            string sql1 = "SELECT Group_name\r\nFROM GroupOfAnimal";
            using (SqlCommand command = new SqlCommand(sql1, Connection))
            {
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        comboBoxForKindAnimal.Items.Add(item.ToString());
                    }
                }
            }
        }

        private void comboBoxForKindAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = SQLCommandForAdmin.Searching(textBox1.Text, comboBoxForTable.Text, comboBoxForCoulmn.Text);
            dataGridView1.DataSource = dt;
        }

        private void comboBoxForTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TableName = comboBoxForTable.Text;
            comboBoxForCoulmn.Items.Clear();
            if (TableName == "System.Data.DataRowView")
            {
                Console.WriteLine("ex");
            }
            else
            {
                string sql = $"SELECT * FROM {TableName}";
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                string sql2 = $"SELECT * FROM {TableName}";
                using (SqlCommand command = new SqlCommand(sql2, Connection))
                {
                    command.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                var items = SQLCommandForAdmin.Combo(TableName);
                foreach (var i in items)
                {
                    comboBoxForCoulmn.Items.Add(i);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxAge1.Text = "";
            textBoxAge2.Text = "";
            textBoxForCaloric1.Text = "";
            textBoxForCaloric2.Text = "";
            comboBoxForKind.Text = "";
            comboBoxForKindAnimal.Text = "";
        }
    }
}
