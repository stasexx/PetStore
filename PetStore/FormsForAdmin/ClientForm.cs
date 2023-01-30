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
    public partial class ClientForm : Form
    {
        bool edit = false;
        public ClientForm(int id)
        {
            InitializeComponent();
            client_idTextBox.Text = id.ToString();
        }

        public ClientForm(int id, string name, string email, int number, string addess):this(id)
        {
            edit = true;
            client_idTextBox.Text = id.ToString();
            full_nameTextBox.Text = name;
            emailTextBox.Text = email;
            phone_numberTextBox.Text = number.ToString();
            addressTextBox.Text = addess;
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petStoreDataSet);

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.petStoreDataSet.Client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    clientTableAdapter.UpdateQuery(Convert.ToInt32(client_idTextBox.Text), full_nameTextBox.Text, emailTextBox.Text, Convert.ToInt32(phone_numberTextBox.Text), addressTextBox.Text);
                    Close();
                }
                else
                {
                    clientTableAdapter.InsertQuery(Convert.ToInt32(client_idTextBox.Text), full_nameTextBox.Text, emailTextBox.Text, Convert.ToInt32(phone_numberTextBox.Text), addressTextBox.Text);
                    Close();
                }
            }
        }
    }
}
