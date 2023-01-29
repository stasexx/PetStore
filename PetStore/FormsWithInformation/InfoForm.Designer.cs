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
            this.labelForCalc2 = new System.Windows.Forms.Label();
            this.labelForCalc3 = new System.Windows.Forms.Label();
            this.comboBoxForKindCaloric = new System.Windows.Forms.ComboBox();
            this.labelForCalc1 = new System.Windows.Forms.Label();
            this.labelForCalc4 = new System.Windows.Forms.Label();
            this.buttonForCaloric = new System.Windows.Forms.Button();
            this.labelForAnimal2 = new System.Windows.Forms.Label();
            this.labelForAnimal3 = new System.Windows.Forms.Label();
            this.labelForAnimal1 = new System.Windows.Forms.Label();
            this.labelForAnimal4 = new System.Windows.Forms.Label();
            this.comboBoxForKindAnimal = new System.Windows.Forms.ComboBox();
            this.groupOfAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.buttonForAnimal = new System.Windows.Forms.Button();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new PetStore.PetStoreDataSetTableAdapters.AnimalTableAdapter();
            this.groupOfAnimalTableAdapter = new PetStore.PetStoreDataSetTableAdapters.GroupOfAnimalTableAdapter();
            this.comboBoxForTable = new System.Windows.Forms.ComboBox();
            this.comboBoxForCoulmn = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
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
            this.textBoxAge2.Location = new System.Drawing.Point(712, 83);
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
            // labelForCalc2
            // 
            this.labelForCalc2.AutoSize = true;
            this.labelForCalc2.Location = new System.Drawing.Point(407, 90);
            this.labelForCalc2.Name = "labelForCalc2";
            this.labelForCalc2.Size = new System.Drawing.Size(21, 13);
            this.labelForCalc2.TabIndex = 11;
            this.labelForCalc2.Text = "від";
            // 
            // labelForCalc3
            // 
            this.labelForCalc3.AutoSize = true;
            this.labelForCalc3.Location = new System.Drawing.Point(496, 90);
            this.labelForCalc3.Name = "labelForCalc3";
            this.labelForCalc3.Size = new System.Drawing.Size(19, 13);
            this.labelForCalc3.TabIndex = 12;
            this.labelForCalc3.Text = "до";
            // 
            // comboBoxForKindCaloric
            // 
            this.comboBoxForKindCaloric.FormattingEnabled = true;
            this.comboBoxForKindCaloric.Items.AddRange(new object[] {
            "М`ясоїд",
            "Травоїд"});
            this.comboBoxForKindCaloric.Location = new System.Drawing.Point(445, 128);
            this.comboBoxForKindCaloric.Name = "comboBoxForKindCaloric";
            this.comboBoxForKindCaloric.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForKindCaloric.TabIndex = 13;
            // 
            // labelForCalc1
            // 
            this.labelForCalc1.AutoSize = true;
            this.labelForCalc1.Location = new System.Drawing.Point(466, 67);
            this.labelForCalc1.Name = "labelForCalc1";
            this.labelForCalc1.Size = new System.Drawing.Size(71, 13);
            this.labelForCalc1.TabIndex = 14;
            this.labelForCalc1.Text = "Калорійність";
            // 
            // labelForCalc4
            // 
            this.labelForCalc4.AutoSize = true;
            this.labelForCalc4.Location = new System.Drawing.Point(489, 112);
            this.labelForCalc4.Name = "labelForCalc4";
            this.labelForCalc4.Size = new System.Drawing.Size(26, 13);
            this.labelForCalc4.TabIndex = 15;
            this.labelForCalc4.Text = "Вид";
            // 
            // buttonForCaloric
            // 
            this.buttonForCaloric.Location = new System.Drawing.Point(445, 155);
            this.buttonForCaloric.Name = "buttonForCaloric";
            this.buttonForCaloric.Size = new System.Drawing.Size(121, 26);
            this.buttonForCaloric.TabIndex = 16;
            this.buttonForCaloric.Text = "ЗАСТОСУВАТИ";
            this.buttonForCaloric.UseVisualStyleBackColor = true;
            this.buttonForCaloric.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelForAnimal2
            // 
            this.labelForAnimal2.AutoSize = true;
            this.labelForAnimal2.Location = new System.Drawing.Point(601, 90);
            this.labelForAnimal2.Name = "labelForAnimal2";
            this.labelForAnimal2.Size = new System.Drawing.Size(21, 13);
            this.labelForAnimal2.TabIndex = 19;
            this.labelForAnimal2.Text = "від";
            // 
            // labelForAnimal3
            // 
            this.labelForAnimal3.AutoSize = true;
            this.labelForAnimal3.Location = new System.Drawing.Point(690, 90);
            this.labelForAnimal3.Name = "labelForAnimal3";
            this.labelForAnimal3.Size = new System.Drawing.Size(19, 13);
            this.labelForAnimal3.TabIndex = 20;
            this.labelForAnimal3.Text = "до";
            // 
            // labelForAnimal1
            // 
            this.labelForAnimal1.AutoSize = true;
            this.labelForAnimal1.Location = new System.Drawing.Point(687, 67);
            this.labelForAnimal1.Name = "labelForAnimal1";
            this.labelForAnimal1.Size = new System.Drawing.Size(22, 13);
            this.labelForAnimal1.TabIndex = 23;
            this.labelForAnimal1.Text = "Вік";
            // 
            // labelForAnimal4
            // 
            this.labelForAnimal4.AutoSize = true;
            this.labelForAnimal4.Location = new System.Drawing.Point(685, 112);
            this.labelForAnimal4.Name = "labelForAnimal4";
            this.labelForAnimal4.Size = new System.Drawing.Size(26, 13);
            this.labelForAnimal4.TabIndex = 25;
            this.labelForAnimal4.Text = "Вид";
            // 
            // comboBoxForKindAnimal
            // 
            this.comboBoxForKindAnimal.FormattingEnabled = true;
            this.comboBoxForKindAnimal.Location = new System.Drawing.Point(641, 128);
            this.comboBoxForKindAnimal.Name = "comboBoxForKindAnimal";
            this.comboBoxForKindAnimal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForKindAnimal.TabIndex = 24;
            this.comboBoxForKindAnimal.SelectedIndexChanged += new System.EventHandler(this.comboBoxForKindAnimal_SelectedIndexChanged);
            // 
            // groupOfAnimalBindingSource
            // 
            this.groupOfAnimalBindingSource.DataMember = "GroupOfAnimal";
            this.groupOfAnimalBindingSource.DataSource = this.petStoreDataSetBindingSource;
            // 
            // petStoreDataSetBindingSource
            // 
            this.petStoreDataSetBindingSource.DataSource = this.petStoreDataSet;
            this.petStoreDataSetBindingSource.Position = 0;
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonForAnimal
            // 
            this.buttonForAnimal.Location = new System.Drawing.Point(641, 155);
            this.buttonForAnimal.Name = "buttonForAnimal";
            this.buttonForAnimal.Size = new System.Drawing.Size(121, 26);
            this.buttonForAnimal.TabIndex = 26;
            this.buttonForAnimal.Text = "ЗАСТОСУВАТИ";
            this.buttonForAnimal.UseVisualStyleBackColor = true;
            this.buttonForAnimal.Click += new System.EventHandler(this.button3_Click);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(647, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 26);
            this.button4.TabIndex = 29;
            this.button4.Text = "Скинути";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBoxForCoulmn);
            this.Controls.Add(this.comboBoxForTable);
            this.Controls.Add(this.buttonForAnimal);
            this.Controls.Add(this.labelForAnimal4);
            this.Controls.Add(this.comboBoxForKindAnimal);
            this.Controls.Add(this.labelForAnimal1);
            this.Controls.Add(this.labelForAnimal3);
            this.Controls.Add(this.labelForAnimal2);
            this.Controls.Add(this.buttonForCaloric);
            this.Controls.Add(this.labelForCalc4);
            this.Controls.Add(this.labelForCalc1);
            this.Controls.Add(this.comboBoxForKindCaloric);
            this.Controls.Add(this.labelForCalc3);
            this.Controls.Add(this.labelForCalc2);
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
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
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
        private System.Windows.Forms.Label labelForCalc2;
        private System.Windows.Forms.Label labelForCalc3;
        private System.Windows.Forms.ComboBox comboBoxForKindCaloric;
        private System.Windows.Forms.Label labelForCalc1;
        private System.Windows.Forms.Label labelForCalc4;
        private System.Windows.Forms.Button buttonForCaloric;
        private System.Windows.Forms.Label labelForAnimal2;
        private System.Windows.Forms.Label labelForAnimal3;
        private System.Windows.Forms.Label labelForAnimal1;
        private System.Windows.Forms.Label labelForAnimal4;
        private System.Windows.Forms.ComboBox comboBoxForKindAnimal;
        private System.Windows.Forms.Button buttonForAnimal;
        private System.Windows.Forms.BindingSource petStoreDataSetBindingSource;
        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private PetStoreDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource groupOfAnimalBindingSource;
        private PetStoreDataSetTableAdapters.GroupOfAnimalTableAdapter groupOfAnimalTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxForTable;
        private System.Windows.Forms.ComboBox comboBoxForCoulmn;
        private System.Windows.Forms.Button button4;
    }
}