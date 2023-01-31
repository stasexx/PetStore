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
            if (textBoxForCaloric1.Text == "" && textBoxForCaloric2.Text == "" && comboBoxForKindCaloric.Text != "")
            {
                variation = 4;
            }
            if (textBoxForCaloric1.Text != "" && textBoxForCaloric2.Text == "" && comboBoxForKindCaloric.Text != "")
            {
                variation = 5;
            }
            if (textBoxForCaloric1.Text == "" && textBoxForCaloric2.Text != "" && comboBoxForKindCaloric.Text != "")
            {
                variation = 6;
            }
            if (textBoxForCaloric1.Text != "" && textBoxForCaloric2.Text != "" && comboBoxForKindCaloric.Text != "")
            {
                variation = 7;
            }
            dataGridView1.DataSource = SQLCommandForInformation.Filter(variation, textBoxForCaloric1.Text, textBoxForCaloric2.Text, comboBoxForKindCaloric.Text);
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
            comboBoxForCoulmn.Text = "";
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
                if (comboBoxForTable.Text == "Feed")
                {
                    labelForCalc1.Show();
                    labelForCalc2.Show();
                    labelForCalc3.Show();
                    labelForCalc4.Show();
                    textBoxForCaloric1.Show();
                    textBoxForCaloric2.Show();
                    comboBoxForKindCaloric.Show();
                    buttonForCaloric.Show();

                    labelForAnimal1.Hide();
                    labelForAnimal2.Hide();
                    labelForAnimal3.Hide();
                    labelForAnimal4.Hide();
                    textBoxAge1.Hide();
                    textBoxAge2.Hide();
                    comboBoxForKindAnimal.Hide();
                    buttonForAnimal.Hide();

                }
                if (comboBoxForTable.Text == "Animal")
                {
                    string sqlForAnimal = $"SELECT * FROM AnimalForView";
                    using (SqlCommand command = new SqlCommand(sqlForAnimal, Connection))
                    {
                        command.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                    labelForCalc1.Hide();
                    labelForCalc2.Hide();
                    labelForCalc3.Hide();
                    labelForCalc4.Hide();
                    textBoxForCaloric1.Hide();
                    textBoxForCaloric2.Hide();
                    comboBoxForKindCaloric.Hide();
                    buttonForCaloric.Hide();

                    labelForAnimal1.Show();
                    labelForAnimal2.Show();
                    labelForAnimal3.Show();
                    labelForAnimal4.Show();
                    textBoxAge1.Show();
                    textBoxAge2.Show();
                    comboBoxForKindAnimal.Show();
                    buttonForAnimal.Show();

                }
                if (comboBoxForTable.Text != "Animal" && comboBoxForTable.Text != "Feed")
                {
                    labelForCalc1.Hide();
                    labelForCalc2.Hide();
                    labelForCalc3.Hide();
                    labelForCalc4.Hide();
                    textBoxForCaloric1.Hide();
                    textBoxForCaloric2.Hide();
                    comboBoxForKindCaloric.Hide();
                    buttonForCaloric.Hide();

                    labelForAnimal1.Hide();
                    labelForAnimal2.Hide();
                    labelForAnimal3.Hide();
                    labelForAnimal4.Hide();
                    textBoxAge1.Hide();
                    textBoxAge2.Hide();
                    comboBoxForKindAnimal.Hide();
                    buttonForAnimal.Hide();
                }

                if (comboBoxForTable.Text == "Cage")
                {
                    string sqlForAnimal = $"SELECT * FROM CageForView";
                    using (SqlCommand command = new SqlCommand(sqlForAnimal, Connection))
                    {
                        command.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBoxForTable.Text == "Supply")
                {
                    string sqlForAnimal = $"SELECT * FROM SupplyForView";
                    using (SqlCommand command = new SqlCommand(sqlForAnimal, Connection))
                    {
                        command.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InfoForm_Load(sender, e);
            textBox1.Clear();
            textBoxAge1.Clear();
            textBoxAge2.Clear();
            textBoxForCaloric1.Clear();
            textBoxForCaloric2.Clear();
            comboBoxForCoulmn.Text = "";
            comboBoxForKindAnimal.Text = "";
            comboBoxForKindCaloric.Text = "";

        }
    }
}
