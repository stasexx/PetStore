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
    public partial class FormForCreatingOrEditingFeed : Form
    {
        public bool edit = false;
        public int FeedId;
        public FormForCreatingOrEditingFeed()
        {
            InitializeComponent();

            var listForFeedId = SQLCommandForAdmin.SelectorTypeFeed();
            foreach(var item in listForFeedId)
            {
                comboBoxForIdFeed.Items.Add(item);
            }
            var listFeedKind = SQLCommandForAdmin.SelectForFeedPurpose();
            foreach(var item in listFeedKind)
            {
                comboBoxPurpose.Items.Add(item);
            }
        }

        public FormForCreatingOrEditingFeed(int id, string name, double caloric, string kind, string purpose,
            DateTime date, int cost
            ):this()
        {
            edit = true;
            FeedId = id; 
            comboBoxForIdFeed.Items.Add(id.ToString());
            comboBoxForIdFeed.SelectedItem = id.ToString();
            feed_nameTextBox.Text = name;
            caloricTextBox.Text = caloric.ToString();
            comboBoxForKind.Text = kind;
            comboBoxPurpose.Text = purpose;
            costTextBox.Text = cost.ToString();

        }

        private void feedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petStoreDataSet);

        }

        private void FormForCreatingOrEditingFeed_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Feed". При необходимости она может быть перемещена или удалена.
            this.feedTableAdapter.Fill(this.petStoreDataSet.Feed);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    feedTableAdapter.UpdateQuery(Convert.ToInt32(FeedId.ToString()), feed_nameTextBox.Text, Convert.ToDouble(caloricTextBox.Text),
                        comboBoxForKind.Text, comboBoxPurpose.Text, Convert.ToDouble(costTextBox.Text)
                        );
                    Close();
                }
                else
                {
                    feedTableAdapter.InsertQuery(Convert.ToInt32(comboBoxForIdFeed.Text), feed_nameTextBox.Text, Convert.ToDouble(caloricTextBox.Text),
                        comboBoxForKind.Text, comboBoxPurpose.Text, Convert.ToDouble(costTextBox.Text)
                        );
                    Close();
                }
            }
        }
    }
}
