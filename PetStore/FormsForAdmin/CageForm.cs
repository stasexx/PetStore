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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetStore.FormsForAdmin
{
    public partial class CageForm : Form
    {
        bool edit = false;
        public CageForm(int id)
        {
            InitializeComponent();
            cage_idTextBox.Text = id.ToString();
        }

        public CageForm(int id, int capa, int group) : this(id)
        {
            edit = true;
            cage_idTextBox.Text = id.ToString();
            capacityTextBox.Text = capa.ToString();
            comboBoxForGroup.SelectedItem = group;
        }

        private void cageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petStoreDataSet);

        }

        private void CageForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.GroupOfAnimal". При необходимости она может быть перемещена или удалена.
            this.groupOfAnimalTableAdapter.Fill(this.petStoreDataSet.GroupOfAnimal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Cage". При необходимости она может быть перемещена или удалена.
            this.cageTableAdapter.Fill(this.petStoreDataSet.Cage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    cageTableAdapter.UpdateQuery(Convert.ToInt32(cage_idTextBox.Text), (Convert.ToInt32(capacityTextBox.Text)), Convert.ToInt32(comboBoxForGroup.SelectedValue));
                    Close();
                }
                else
                {
                    cageTableAdapter.InsertQuery(Convert.ToInt32(cage_idTextBox.Text), (Convert.ToInt32(capacityTextBox.Text)), Convert.ToInt32(comboBoxForGroup.SelectedValue));
                    Close();
                }
            }
        }
    }
}
