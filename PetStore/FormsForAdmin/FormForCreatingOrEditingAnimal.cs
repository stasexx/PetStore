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
    public partial class FormForCreatingOrEditingAnimal : Form
    {
        private bool edit = false;
        public FormForCreatingOrEditingAnimal()
        {
            InitializeComponent();
            var itemsForGroupOfAnimalCombo = SQLCommandForAdmin.SelectForGroup();
            foreach(var item in itemsForGroupOfAnimalCombo)
            {
                comboBoxForGroup.Items.Add(item);
            }
            var itemsForId = SQLCommandForAdmin.SelectorTypeAnimal();

            foreach (var item in itemsForId)
            {
                comboBoxForId.Items.Add(item);
            }
        }

        public FormForCreatingOrEditingAnimal(int id, string animalName, double age, double weight, DateTime dateAdd, string sex, 
            string Vaccination, string Doc, int group_of_animal_id, int cageId, double calories, int cost):this()
        {
            comboBoxForId.Items.Add(id.ToString());
            comboBoxForId.SelectedItem = id.ToString();
            animal_nameTextBox.Text = animalName;
            ageTextBox.Text = age.ToString();
            weight_of_animalTextBox.Text = weight.ToString();
            date_addDateTimePicker.Value = dateAdd;
            comboBox1.Text = sex;
            comboBoxForVac.Text = Vaccination;
            comboBoxForDoc.Text = Doc;
            comboBoxForGroup.Text = SQLCommandForAdmin.GroupSelectorNameWithId(group_of_animal_id);
            comboBoxForCage.Text = cageId.ToString();
            calories_per_dayTextBox.Text = calories.ToString();
            costTextBox.Text = cost.ToString();
            edit = true;
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petStoreDataSet);

        }

        private void animalBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petStoreDataSet);

        }

        private void FormForCreatinOrEditingAnimal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.petStoreDataSet.Animal);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = SQLCommandForAdmin.SelectorForCageInAnimalEdit(comboBoxForGroup.Text);
            comboBoxForCage.Items.Clear();
            foreach (var item in items)
            {
                comboBoxForCage.Items.Add(item);
            }
        }

        private void comboBoxForDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxForCage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void comboBoxForVac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    int idGroup = SQLCommandForAdmin.GroupIdSelector(comboBoxForGroup.Text);
                    animalTableAdapter.UpdateQuery(Convert.ToInt32(comboBoxForId.Text), animal_nameTextBox.Text, (float?)Convert.ToDouble(ageTextBox.Text),
                        (float?)Convert.ToDouble(weight_of_animalTextBox.Text), date_addDateTimePicker.Value.ToString(), comboBox1.Text, comboBoxForVac.Text, comboBoxForDoc.Text,
                        idGroup, Convert.ToInt32(comboBoxForCage.Text), Convert.ToDouble(calories_per_dayTextBox.Text), Convert.ToInt32(costTextBox.Text));
                    Close();
                }
                else
                {
                    int idGroup = SQLCommandForAdmin.GroupIdSelector(comboBoxForGroup.Text);
                    animalTableAdapter.InsertQuery(Convert.ToInt32(comboBoxForId.Text), animal_nameTextBox.Text, Convert.ToInt32(ageTextBox.Text),
                        Convert.ToInt32(weight_of_animalTextBox.Text), date_addDateTimePicker.Value.ToString(), comboBox1.Text, comboBoxForVac.Text, comboBoxForDoc.Text,
                        idGroup, Convert.ToInt32(comboBoxForCage.Text), Convert.ToDouble(calories_per_dayTextBox.Text), Convert.ToInt32(costTextBox.Text));
                    Close();
                }
            }
        }
    }
}
