using PetStore.FormsWithInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore.AutoDiscount
{
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool update = false;
            dataGridView2.Rows.Clear();
            List<string> ids = new List<string>();
            List<string> names = new List<string>();
            var binding = new BindingSource();
            dataGridView1.DataSource = SQLForAuto.TableCalc();
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                string discount = "0%";
                if((Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)/Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)) < 0.05)
                {
                    discount = "0%";
                    if (comboBox1.Text.ToString() == "Так")
                    {
                        SQLForAuto.UpdateDiscountForAnimal(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), 0);  
                    }
                }
                if ((Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)) >= 0.05 &&
                    (Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)) <= 0.2)
                {
                    discount = "5%";
                    if (comboBox1.Text.ToString() == "Так")
                    {
                        SQLForAuto.UpdateDiscountForAnimal(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), 5);
                    }
                }
                if ((Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)) >= 0.2 &&
    (Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)) <= 0.4)
                {
                    discount = "10%";
                    if (comboBox1.Text.ToString() == "Так")
                    {
                        SQLForAuto.UpdateDiscountForAnimal(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), 10);
                    }
                }
                if ((Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)) >= 0.4 &&
(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)) <= 0.6)
                {
                    discount = "15%";
                    if (comboBox1.Text == "Так")
                    {
                        SQLForAuto.UpdateDiscountForAnimal(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), 15);
                    }
                }
                if ((Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)) > 1)
                {
                    discount = "20%";
                    if (comboBox1.Text == "Так")
                    {
                        SQLForAuto.UpdateDiscountForAnimal(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), 20);
                    }
                }
                ids.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                names.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                dataGridView2.Rows.Add(ids[i], names[i], discount);
            }
        }

        private void Auto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Feed". При необходимости она может быть перемещена или удалена.
            this.feedTableAdapter.Fill(this.petStoreDataSet.Feed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petStoreDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.petStoreDataSet.Animal);
            /*dataGridView1.AutoGenerateColumns = true;
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Название"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "name"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Цена";
            column2.Name = "price";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Остаток";
            column3.Name = "count";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);

            dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView1.Rows.Add("Пример 1, Товар " + i, i * 1000, i);
            }

            //А теперь простой пройдемся циклом по всем ячейкам
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                {
                    //Значения ячеек хряняться в типе object
                    //это позволяет хранить любые данные в таблице
                    object o = dataGridView1[j, i].Value;
                }
            }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
