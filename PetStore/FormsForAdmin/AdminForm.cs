using PetStore.FormsForAdmin;
using PetStore.FormsWithInformation;
using PetStore.PetStoreDataSetTableAdapters;
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
using static PetStore.PetStoreDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetStore
{
    public partial class AdminForm : Form
    {
        private SqlConnection Connection = Program.SqlConnection;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            }
        }
        private void LoadComboBox()
        {
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
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Selling". При необходимости она может быть перемещена или удалена.
            this.sellingTableAdapter.Fill(this.petStoreDataSet.Selling);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.petStoreDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.GroupOfAnimal". При необходимости она может быть перемещена или удалена.
            this.groupOfAnimalTableAdapter.Fill(this.petStoreDataSet.GroupOfAnimal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.petStoreDataSet.Supply);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Cage". При необходимости она может быть перемещена или удалена.
            this.cageTableAdapter.Fill(this.petStoreDataSet.Cage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.petStoreDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Feed". При необходимости она может быть перемещена или удалена.
            this.feedTableAdapter.Fill(this.petStoreDataSet.Feed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.petStoreDataSet.Animal);
            LoadComboBox();
        }

        private void Filter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = SQLCommandForAdmin.Searching(textBox1.Text, comboBoxForTable.Text, comboBoxForCoulmn.Text);
            dataGridView1.DataSource = dt;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = comboBoxForTable.Text;
            FormForCreatingOrEditingAnimal formForCreatingOrEditingAnimal = new FormForCreatingOrEditingAnimal();
            formForCreatingOrEditingAnimal.ShowDialog();
            AdminForm_Load(sender, e);
            comboBoxForTable.Text = "Animal";

        }

        private void animalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new PetStoreDataSet.AnimalDataTable();
                animalTableAdapter.Fill(st);
                object[] row = st.Rows[ind].ItemArray;
                var edt = new FormForCreatingOrEditingAnimal
                    (
                        Convert.ToInt32(row[0]),
                        row[1].ToString(),
                        Convert.ToInt32(row[2]),
                        Convert.ToDouble(row[3]),
                        Convert.ToDateTime(row[4]),
                        row[5].ToString(),
                        row[6].ToString(),
                        row[7].ToString(),
                        Convert.ToInt32(row[8]),
                        Convert.ToInt32(row[9]),
                        Convert.ToDouble(row[10]),
                        Convert.ToInt32(row[11]),
                        Convert.ToInt32(row[12])
                    );
                edt.ShowDialog();
                animalTableAdapter.Fill(petStoreDataSet.Animal);
                petStoreDataSet.AcceptChanges();
                comboBoxForTable.SelectedItem = "Animal";
                var table = comboBoxForTable.Text;
                Show();
                AdminForm_Load(sender, e);
                comboBoxForTable.Text = table;
                dataGridView1.Rows[ind].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void feedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = comboBoxForTable.Text;
            FormForCreatingOrEditingFeed feed = new FormForCreatingOrEditingFeed();
            feed.ShowDialog();
            AdminForm_Load(sender, e);
            comboBoxForTable.Text = "Feed";
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void feedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new PetStoreDataSet.FeedDataTable();
                feedTableAdapter.Fill(st);
                object[] row = st.Rows[ind].ItemArray;
                var edt = new FormForCreatingOrEditingFeed
                                        (
                        Convert.ToInt32(row[0]),
                        row[1].ToString(),
                        Convert.ToDouble(row[2]),
                        row[3].ToString(),
                        row[4].ToString(),
                        Convert.ToInt32(row[5]),
                        Convert.ToInt32(row[6])
                    );
                edt.ShowDialog();
                feedTableAdapter.Fill(petStoreDataSet.Feed);
                petStoreDataSet.AcceptChanges();
                comboBoxForTable.SelectedItem = "Feed";
                var table = comboBoxForTable.Text;
                Show();
                AdminForm_Load(sender, e);
                comboBoxForTable.Text = table;
                dataGridView1.Rows[ind].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void cageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.CurrentCell.RowIndex;
            var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var st = new PetStoreDataSet.CageDataTable();
            cageTableAdapter.Fill(st);
            object[] row = st.Rows[ind].ItemArray;
            var edt = new CageForm
                (
                    Convert.ToInt32(row[0]),
                    Convert.ToInt32(row[1]),
                    Convert.ToInt32(row[2])

                );
            edt.ShowDialog();
            cageTableAdapter.Fill(petStoreDataSet.Cage);
            petStoreDataSet.AcceptChanges();
            comboBoxForTable.SelectedItem = "Cage";
            var table = comboBoxForTable.Text;
            Show();
            AdminForm_Load(sender, e);
            comboBoxForTable.Text = table;
            dataGridView1.Rows[ind].Selected = true;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new PetStoreDataSet.ProductDataTable();
                productTableAdapter.Fill(st);
                object[] row = st.Rows[ind].ItemArray;
                var edt = new ProductForm
                    (
                        Convert.ToInt32(row[0]),
                        row[1].ToString()

                    );
                edt.ShowDialog();
                productTableAdapter.Fill(petStoreDataSet.Product);
                petStoreDataSet.AcceptChanges();
                comboBoxForTable.SelectedItem = "Product";
                var table = comboBoxForTable.Text;
                Show();
                AdminForm_Load(sender, e);
                comboBoxForTable.Text = table;
                dataGridView1.Rows[ind].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var table = comboBoxForTable.Text;
            ProductForm productForm = new ProductForm(SQLCommandForAdmin.IdSelect()+1);
            productForm.ShowDialog();
            AdminForm_Load(sender, e);
            comboBoxForTable.Text = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int variation = 0;
            if (textBoxForCaloric1.Text != "" && textBoxForCaloric2.Text == "")
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
            if (textBoxAge1.Text == "" && textBoxAge2.Text == "" && comboBoxForKindAnimal.SelectedValue != null)
            {
                variation = 4;
            }
            if (textBoxAge1.Text != "" && textBoxAge2.Text == "" && comboBoxForKindAnimal.SelectedValue != null)
            {
                variation = 5;
            }
            if (textBoxAge1.Text == "" && textBoxAge2.Text != "" && comboBoxForKindAnimal.SelectedValue != null)
            {
                variation = 6;
            }
            if (textBoxAge1.Text != "" && textBoxAge2.Text != "" && comboBoxForKindAnimal.SelectedValue != null)
            {
                variation = 7;
            }
            dataGridView1.DataSource = SQLCommandForInformation.FilterForAnimal(variation, textBoxAge1.Text, textBoxAge2.Text, comboBoxForKindAnimal.Text);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити цю інформацію?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                SQLCommandForAdmin.Delete(comboBoxForTable.Text, stb);
                var table = comboBoxForTable.Text;
                AdminForm_Load(sender, e);
                comboBoxForTable.Text = table;
            }
        }

        private void sellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm(SQLCommandForAdmin.IdSelectForProduct()+1);
            sellingForm.ShowDialog();
            AdminForm_Load(sender, e);
            comboBoxForTable.Text = "Selling";
        }

        private void cageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = comboBoxForTable.Text;
            CageForm cageForm = new CageForm(SQLCommandForAdmin.IdSelectForCage()+1);
            cageForm.ShowDialog();
            AdminForm_Load(sender, e);
            comboBoxForTable.Text = "Cage";
        }

        private void groupOfAnimalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new PetStoreDataSet.GroupOfAnimalDataTable();
                groupOfAnimalTableAdapter.Fill(st);
                object[] row = st.Rows[ind].ItemArray;
                var edt = new GroupOfAnimalForm
                    (
                        Convert.ToInt32(row[0]),
                        row[1].ToString(),
                        row[2].ToString()
                    );
                edt.ShowDialog();
                groupOfAnimalTableAdapter.Fill(petStoreDataSet.GroupOfAnimal);
                petStoreDataSet.AcceptChanges();
                comboBoxForTable.SelectedItem = "GroupOfAnimal";
                var table = comboBoxForTable.Text;
                Show();
                AdminForm_Load(sender, e);
                comboBoxForTable.Text = table;
                dataGridView1.Rows[ind].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void groupOfAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = comboBoxForTable.Text;
            GroupOfAnimalForm group = new GroupOfAnimalForm(SQLCommandForAdmin.IdSelectForGroup() + 1);
            group.ShowDialog();
            AdminForm_Load(sender, e);
            comboBoxForTable.Text = table;
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = comboBoxForTable.Text;
            ClientForm productForm = new ClientForm(SQLCommandForAdmin.IdSelectForClient() + 1);
            productForm.ShowDialog();
            AdminForm_Load(sender, e);
            comboBoxForTable.Text = table;
        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new PetStoreDataSet.ClientDataTable();
                clientTableAdapter.Fill(st);
                object[] row = st.Rows[ind].ItemArray;
                var edt = new ClientForm
                    (
                        Convert.ToInt32(row[0]),
                        row[1].ToString(),
                        row[2].ToString(),
                        Convert.ToInt32(row[3]),
                        row[4].ToString()
                    );
                edt.ShowDialog();
                clientTableAdapter.Fill(petStoreDataSet.Client);
                petStoreDataSet.AcceptChanges();
                comboBoxForTable.SelectedItem = "Client";
                var table = comboBoxForTable.Text;
                AdminForm_Load(sender, e);
                comboBoxForTable.Text = table;
                dataGridView1.Rows[ind].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void supplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = comboBoxForTable.Text;
            Supply productForm = new Supply(SQLCommandForAdmin.IdSelectForSupply() + 1);
            productForm.ShowDialog();
            AdminForm_Load(sender, e);
            comboBoxForTable.Text = "Supply";
        }

        private void supplyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new PetStoreDataSet.SupplyDataTable();
                supplyTableAdapter.Fill(st);
                object[] row = st.Rows[ind].ItemArray;
                var edt = new Supply
                    (
                        Convert.ToInt32(row[0]),
                        Convert.ToDateTime(row[1]),
                        Convert.ToDateTime(row[2]),
                        Convert.ToDouble(row[3]),
                        Convert.ToInt32(row[4])
                    );
                edt.ShowDialog();
                supplyTableAdapter.Fill(petStoreDataSet.Supply);
                petStoreDataSet.AcceptChanges();
                comboBoxForTable.SelectedItem = "Supply";
                var table = comboBoxForTable.Text;
                AdminForm_Load(sender, e);
                comboBoxForTable.Text = table;
                dataGridView1.Rows[ind].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void sellingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new PetStoreDataSet.SellingDataTable();
                sellingTableAdapter.Fill(st);
                object[] row = st.Rows[ind].ItemArray;
                var edt = new SellingForm
                    (
                        Convert.ToInt32(row[0]),
                        Convert.ToDateTime(row[1]),
                        Convert.ToDouble(row[2]),
                        Convert.ToInt32(row[3]),
                        Convert.ToInt32(row[4])
                    );
                edt.ShowDialog();
                sellingTableAdapter.Fill(petStoreDataSet.Selling);
                petStoreDataSet.AcceptChanges();
                comboBoxForTable.SelectedItem = "Selling";
                var table = comboBoxForTable.Text;
                AdminForm_Load(sender, e);
                comboBoxForTable.Text = table;
                dataGridView1.Rows[ind].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }
    }
}
