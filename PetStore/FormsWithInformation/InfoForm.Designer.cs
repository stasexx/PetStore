namespace PetStore.FormsWithInformation
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxForCaloric1 = new System.Windows.Forms.TextBox();
            this.textBoxForCaloric2 = new System.Windows.Forms.TextBox();
            this.textBoxAge2 = new System.Windows.Forms.TextBox();
            this.textBoxAge1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxForKind = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxForKindAnimal = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.petStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new PetStore.PetStoreDataSetTableAdapters.AnimalTableAdapter();
            this.groupOfAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupOfAnimalTableAdapter = new PetStore.PetStoreDataSetTableAdapters.GroupOfAnimalTableAdapter();
            this.comboBoxForTable = new System.Windows.Forms.ComboBox();
            this.comboBoxForCoulmn = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "ПОШУК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблиця";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(204, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пошук";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(562, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фільтр";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBoxForCaloric1
            // 
            this.textBoxForCaloric1.Location = new System.Drawing.Point(434, 83);
            this.textBoxForCaloric1.Name = "textBoxForCaloric1";
            this.textBoxForCaloric1.Size = new System.Drawing.Size(56, 20);
            this.textBoxForCaloric1.TabIndex = 6;
            // 
            // textBoxForCaloric2
            // 
            this.textBoxForCaloric2.Location = new System.Drawing.Point(521, 83);
            this.textBoxForCaloric2.Name = "textBoxForCaloric2";
            this.textBoxForCaloric2.Size = new System.Drawing.Size(56, 20);
            this.textBoxForCaloric2.TabIndex = 7;
            // 
            // textBoxAge2
            // 
            this.textBoxAge2.Location = new System.Drawing.Point(706, 83);
            this.textBoxAge2.Name = "textBoxAge2";
            this.textBoxAge2.Size = new System.Drawing.Size(56, 20);
            this.textBoxAge2.TabIndex = 8;
            // 
            // textBoxAge1
            // 
            this.textBoxAge1.Location = new System.Drawing.Point(628, 83);
            this.textBoxAge1.Name = "textBoxAge1";
            this.textBoxAge1.Size = new System.Drawing.Size(56, 20);
            this.textBoxAge1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "від";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "до";
            // 
            // comboBoxForKind
            // 
            this.comboBoxForKind.FormattingEnabled = true;
            this.comboBoxForKind.Items.AddRange(new object[] {
            "М`ясо ",
            "Трава"});
            this.comboBoxForKind.Location = new System.Drawing.Point(445, 128);
            this.comboBoxForKind.Name = "comboBoxForKind";
            this.comboBoxForKind.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForKind.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Калорійність";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Вид";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "ЗАСТОСУВАТИ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "від";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(690, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "до";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(687, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Вік";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(685, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Вид";
            // 
            // comboBoxForKindAnimal
            // 
            this.comboBoxForKindAnimal.DataSource = this.groupOfAnimalBindingSource;
            this.comboBoxForKindAnimal.DisplayMember = "Group_name";
            this.comboBoxForKindAnimal.FormattingEnabled = true;
            this.comboBoxForKindAnimal.Location = new System.Drawing.Point(641, 128);
            this.comboBoxForKindAnimal.Name = "comboBoxForKindAnimal";
            this.comboBoxForKindAnimal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForKindAnimal.TabIndex = 24;
            this.comboBoxForKindAnimal.ValueMember = "Group_of_animal_id";
            this.comboBoxForKindAnimal.SelectedIndexChanged += new System.EventHandler(this.comboBoxForKindAnimal_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(641, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 26);
            this.button3.TabIndex = 26;
            this.button3.Text = "ЗАСТОСУВАТИ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petStoreDataSetBindingSource
            // 
            this.petStoreDataSetBindingSource.DataSource = this.petStoreDataSet;
            this.petStoreDataSetBindingSource.Position = 0;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.petStoreDataSetBindingSource;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // groupOfAnimalBindingSource
            // 
            this.groupOfAnimalBindingSource.DataMember = "GroupOfAnimal";
            this.groupOfAnimalBindingSource.DataSource = this.petStoreDataSetBindingSource;
            // 
            // groupOfAnimalTableAdapter
            // 
            this.groupOfAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxForTable
            // 
            this.comboBoxForTable.FormattingEnabled = true;
            this.comboBoxForTable.Location = new System.Drawing.Point(12, 64);
            this.comboBoxForTable.Name = "comboBoxForTable";
            this.comboBoxForTable.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForTable.TabIndex = 27;
            this.comboBoxForTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxForTable_SelectedIndexChanged);
            // 
            // comboBoxForCoulmn
            // 
            this.comboBoxForCoulmn.FormattingEnabled = true;
            this.comboBoxForCoulmn.Location = new System.Drawing.Point(174, 64);
            this.comboBoxForCoulmn.Name = "comboBoxForCoulmn";
            this.comboBoxForCoulmn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForCoulmn.TabIndex = 28;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.comboBoxForCoulmn);
            this.Controls.Add(this.comboBoxForTable);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxForKindAnimal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxForKind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAge1);
            this.Controls.Add(this.textBoxAge2);
            this.Controls.Add(this.textBoxForCaloric2);
            this.Controls.Add(this.textBoxForCaloric1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxForCaloric1;
        private System.Windows.Forms.TextBox textBoxForCaloric2;
        private System.Windows.Forms.TextBox textBoxAge2;
        private System.Windows.Forms.TextBox textBoxAge1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxForKind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxForKindAnimal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource petStoreDataSetBindingSource;
        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private PetStoreDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource groupOfAnimalBindingSource;
        private PetStoreDataSetTableAdapters.GroupOfAnimalTableAdapter groupOfAnimalTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxForTable;
        private System.Windows.Forms.ComboBox comboBoxForCoulmn;
    }
}