namespace PetStore.AutoDiscount
{
    partial class Auto
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new PetStore.PetStoreDataSetTableAdapters.AnimalTableAdapter();
            this.feedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedTableAdapter = new PetStore.PetStoreDataSetTableAdapters.FeedTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightofanimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateaddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupofanimalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesperdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(19, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "РОЗРАХУВАТИ ЗНИЖКУ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(235, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(553, 209);
            this.dataGridView2.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Тварини";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ім\'я тварини";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Скидка";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Утворення скидок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "< 5% \r\nвід вартості тварини = 0%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "5% - 20% \r\nвід вартості тварини = 5%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "20% - 40% \r\nвід вартості тварини = 10%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "40% - 60% \r\nвід вартості тварини = 15%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "> 60 \r\nвід вартості тварини = 20%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(0, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Встановити скидки на товари в БД ?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Так",
            "Ні"});
            this.comboBox1.Location = new System.Drawing.Point(21, 404);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.petStoreDataSet;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // feedBindingSource
            // 
            this.feedBindingSource.DataMember = "Feed";
            this.feedBindingSource.DataSource = this.petStoreDataSet;
            // 
            // feedTableAdapter
            // 
            this.feedTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalidDataGridViewTextBoxColumn,
            this.animalnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.weightofanimalDataGridViewTextBoxColumn,
            this.dateaddDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.vaccinationDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn,
            this.groupofanimalidDataGridViewTextBoxColumn,
            this.cageidDataGridViewTextBoxColumn,
            this.caloriesperdayDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(235, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 185);
            this.dataGridView1.TabIndex = 13;
            // 
            // animalidDataGridViewTextBoxColumn
            // 
            this.animalidDataGridViewTextBoxColumn.DataPropertyName = "Animal_id";
            this.animalidDataGridViewTextBoxColumn.HeaderText = "Animal_id";
            this.animalidDataGridViewTextBoxColumn.Name = "animalidDataGridViewTextBoxColumn";
            // 
            // animalnameDataGridViewTextBoxColumn
            // 
            this.animalnameDataGridViewTextBoxColumn.DataPropertyName = "Animal_name";
            this.animalnameDataGridViewTextBoxColumn.HeaderText = "Animal_name";
            this.animalnameDataGridViewTextBoxColumn.Name = "animalnameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // weightofanimalDataGridViewTextBoxColumn
            // 
            this.weightofanimalDataGridViewTextBoxColumn.DataPropertyName = "Weight_of_animal";
            this.weightofanimalDataGridViewTextBoxColumn.HeaderText = "Weight_of_animal";
            this.weightofanimalDataGridViewTextBoxColumn.Name = "weightofanimalDataGridViewTextBoxColumn";
            // 
            // dateaddDataGridViewTextBoxColumn
            // 
            this.dateaddDataGridViewTextBoxColumn.DataPropertyName = "Date_add";
            this.dateaddDataGridViewTextBoxColumn.HeaderText = "Date_add";
            this.dateaddDataGridViewTextBoxColumn.Name = "dateaddDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // vaccinationDataGridViewTextBoxColumn
            // 
            this.vaccinationDataGridViewTextBoxColumn.DataPropertyName = "Vaccination";
            this.vaccinationDataGridViewTextBoxColumn.HeaderText = "Vaccination";
            this.vaccinationDataGridViewTextBoxColumn.Name = "vaccinationDataGridViewTextBoxColumn";
            // 
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "Documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "Documents";
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
            // 
            // groupofanimalidDataGridViewTextBoxColumn
            // 
            this.groupofanimalidDataGridViewTextBoxColumn.DataPropertyName = "Group_of_animal_id";
            this.groupofanimalidDataGridViewTextBoxColumn.HeaderText = "Group_of_animal_id";
            this.groupofanimalidDataGridViewTextBoxColumn.Name = "groupofanimalidDataGridViewTextBoxColumn";
            // 
            // cageidDataGridViewTextBoxColumn
            // 
            this.cageidDataGridViewTextBoxColumn.DataPropertyName = "Cage_id";
            this.cageidDataGridViewTextBoxColumn.HeaderText = "Cage_id";
            this.cageidDataGridViewTextBoxColumn.Name = "cageidDataGridViewTextBoxColumn";
            // 
            // caloriesperdayDataGridViewTextBoxColumn
            // 
            this.caloriesperdayDataGridViewTextBoxColumn.DataPropertyName = "Calories_per_day";
            this.caloriesperdayDataGridViewTextBoxColumn.HeaderText = "Calories_per_day";
            this.caloriesperdayDataGridViewTextBoxColumn.Name = "caloriesperdayDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Name = "Auto";
            this.Text = "Auto";
            this.Load += new System.EventHandler(this.Auto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private PetStoreDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource feedBindingSource;
        private PetStoreDataSetTableAdapters.FeedTableAdapter feedTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightofanimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupofanimalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesperdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}