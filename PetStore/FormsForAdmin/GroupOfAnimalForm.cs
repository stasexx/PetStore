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
    public partial class GroupOfAnimalForm : Form
    {
        bool edit = false;
        public GroupOfAnimalForm(int id)
        {
            InitializeComponent();
            group_of_animal_idTextBox.Text = id.ToString();
        }

        public GroupOfAnimalForm(int id, string name, string method):this(id)
        {
            edit = true;
            group_of_animal_idTextBox.Text = id.ToString();
            group_nameTextBox.Text = name;
            comboBox1.Text = method;
        }

        private void groupOfAnimalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupOfAnimalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petStoreDataSet);
        }

        private void GroupOfAnimalForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.GroupOfAnimal". При необходимости она может быть перемещена или удалена.
            this.groupOfAnimalTableAdapter.Fill(this.petStoreDataSet.GroupOfAnimal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    groupOfAnimalTableAdapter.UpdateQuery(Convert.ToInt32(group_of_animal_idTextBox.Text), group_nameTextBox.Text, comboBox1.Text);
                    Close();
                }
                else
                {
                    groupOfAnimalTableAdapter.InsertQuery(Convert.ToInt32(group_of_animal_idTextBox.Text), group_nameTextBox.Text, comboBox1.Text);
                    Close();
                }
            }
        }
    }
}
