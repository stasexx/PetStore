namespace PetStore
{
    partial class AdminForm
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
            this.Searching = new System.Windows.Forms.Label();
            this.TableLable = new System.Windows.Forms.Label();
            this.comboBoxForTable = new System.Windows.Forms.ComboBox();
            this.comboBoxForSearch = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.feedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupOfAnimalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupOfAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.feedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new PetStore.PetStoreDataSetTableAdapters.AnimalTableAdapter();
            this.feedTableAdapter = new PetStore.PetStoreDataSetTableAdapters.FeedTableAdapter();
            this.feedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new PetStore.PetStoreDataSetTableAdapters.ProductTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxForKindAnimal = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxForKind = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAge1 = new System.Windows.Forms.TextBox();
            this.textBoxAge2 = new System.Windows.Forms.TextBox();
            this.textBoxForCaloric2 = new System.Windows.Forms.TextBox();
            this.textBoxForCaloric1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // Searching
            // 
            this.Searching.AutoSize = true;
            this.Searching.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searching.Location = new System.Drawing.Point(298, 24);
            this.Searching.Name = "Searching";
            this.Searching.Size = new System.Drawing.Size(71, 24);
            this.Searching.TabIndex = 1;
            this.Searching.Text = "Пошук";
            // 
            // TableLable
            // 
            this.TableLable.AutoSize = true;
            this.TableLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableLable.Location = new System.Drawing.Point(45, 24);
            this.TableLable.Name = "TableLable";
            this.TableLable.Size = new System.Drawing.Size(92, 24);
            this.TableLable.TabIndex = 3;
            this.TableLable.Text = "Таблиця";
            // 
            // comboBoxForTable
            // 
            this.comboBoxForTable.FormattingEnabled = true;
            this.comboBoxForTable.Location = new System.Drawing.Point(12, 57);
            this.comboBoxForTable.Name = "comboBoxForTable";
            this.comboBoxForTable.Size = new System.Drawing.Size(153, 21);
            this.comboBoxForTable.TabIndex = 4;
            this.comboBoxForTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxForSearch
            // 
            this.comboBoxForSearch.FormattingEnabled = true;
            this.comboBoxForSearch.Location = new System.Drawing.Point(273, 57);
            this.comboBoxForSearch.Name = "comboBoxForSearch";
            this.comboBoxForSearch.Size = new System.Drawing.Size(118, 21);
            this.comboBoxForSearch.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.createToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalToolStripMenuItem1,
            this.feedToolStripMenuItem1,
            this.productToolStripMenuItem,
            this.clientToolStripMenuItem1,
            this.cageToolStripMenuItem1,
            this.groupOfAnimalToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // animalToolStripMenuItem1
            // 
            this.animalToolStripMenuItem1.Name = "animalToolStripMenuItem1";
            this.animalToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.animalToolStripMenuItem1.Text = "Animal";
            this.animalToolStripMenuItem1.Click += new System.EventHandler(this.animalToolStripMenuItem1_Click);
            // 
            // feedToolStripMenuItem1
            // 
            this.feedToolStripMenuItem1.Name = "feedToolStripMenuItem1";
            this.feedToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.feedToolStripMenuItem1.Text = "Feed";
            this.feedToolStripMenuItem1.Click += new System.EventHandler(this.feedToolStripMenuItem1_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.clientToolStripMenuItem1.Text = "Client";
            // 
            // cageToolStripMenuItem1
            // 
            this.cageToolStripMenuItem1.Name = "cageToolStripMenuItem1";
            this.cageToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.cageToolStripMenuItem1.Text = "Cage";
            this.cageToolStripMenuItem1.Click += new System.EventHandler(this.cageToolStripMenuItem1_Click);
            // 
            // groupOfAnimalToolStripMenuItem1
            // 
            this.groupOfAnimalToolStripMenuItem1.Name = "groupOfAnimalToolStripMenuItem1";
            this.groupOfAnimalToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.groupOfAnimalToolStripMenuItem1.Text = "GroupOfAnimal";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalToolStripMenuItem,
            this.feedToolStripMenuItem,
            this.productToolStripMenuItem1,
            this.cageToolStripMenuItem,
            this.groupOfAnimalToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.sellingToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // animalToolStripMenuItem
            // 
            this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            this.animalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animalToolStripMenuItem.Text = "Animal";
            this.animalToolStripMenuItem.Click += new System.EventHandler(this.animalToolStripMenuItem_Click);
            // 
            // feedToolStripMenuItem
            // 
            this.feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            this.feedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feedToolStripMenuItem.Text = "Feed";
            this.feedToolStripMenuItem.Click += new System.EventHandler(this.feedToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem1
            // 
            this.productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            this.productToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem1.Text = "Product";
            this.productToolStripMenuItem1.Click += new System.EventHandler(this.productToolStripMenuItem1_Click);
            // 
            // cageToolStripMenuItem
            // 
            this.cageToolStripMenuItem.Name = "cageToolStripMenuItem";
            this.cageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cageToolStripMenuItem.Text = "Cage";
            // 
            // groupOfAnimalToolStripMenuItem
            // 
            this.groupOfAnimalToolStripMenuItem.Name = "groupOfAnimalToolStripMenuItem";
            this.groupOfAnimalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupOfAnimalToolStripMenuItem.Text = "GroupOfAnimal";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "ПОШУК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.petStoreDataSetBindingSource;
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
            // feedBindingSource
            // 
            this.feedBindingSource.DataMember = "Feed";
            this.feedBindingSource.DataSource = this.petStoreDataSetBindingSource;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // feedTableAdapter
            // 
            this.feedTableAdapter.ClearBeforeFill = true;
            // 
            // feedBindingSource1
            // 
            this.feedBindingSource1.DataMember = "Feed";
            this.feedBindingSource1.DataSource = this.petStoreDataSetBindingSource;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.petStoreDataSetBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(682, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 26);
            this.button3.TabIndex = 43;
            this.button3.Text = "ЗАСТОСУВАТИ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(726, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Вид";
            // 
            // comboBoxForKindAnimal
            // 
            this.comboBoxForKindAnimal.DisplayMember = "Group_name";
            this.comboBoxForKindAnimal.FormattingEnabled = true;
            this.comboBoxForKindAnimal.Location = new System.Drawing.Point(682, 126);
            this.comboBoxForKindAnimal.Name = "comboBoxForKindAnimal";
            this.comboBoxForKindAnimal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForKindAnimal.TabIndex = 41;
            this.comboBoxForKindAnimal.ValueMember = "Group_of_animal_id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(728, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Вік";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(731, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "до";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "від";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 26);
            this.button2.TabIndex = 37;
            this.button2.Text = "ЗАСТОСУВАТИ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Вид";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Калорійність";
            // 
            // comboBoxForKind
            // 
            this.comboBoxForKind.FormattingEnabled = true;
            this.comboBoxForKind.Items.AddRange(new object[] {
            "М`ясо ",
            "Трава"});
            this.comboBoxForKind.Location = new System.Drawing.Point(486, 126);
            this.comboBoxForKind.Name = "comboBoxForKind";
            this.comboBoxForKind.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForKind.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "від";
            // 
            // textBoxAge1
            // 
            this.textBoxAge1.Location = new System.Drawing.Point(669, 81);
            this.textBoxAge1.Name = "textBoxAge1";
            this.textBoxAge1.Size = new System.Drawing.Size(56, 20);
            this.textBoxAge1.TabIndex = 31;
            // 
            // textBoxAge2
            // 
            this.textBoxAge2.Location = new System.Drawing.Point(747, 81);
            this.textBoxAge2.Name = "textBoxAge2";
            this.textBoxAge2.Size = new System.Drawing.Size(56, 20);
            this.textBoxAge2.TabIndex = 30;
            // 
            // textBoxForCaloric2
            // 
            this.textBoxForCaloric2.Location = new System.Drawing.Point(562, 81);
            this.textBoxForCaloric2.Name = "textBoxForCaloric2";
            this.textBoxForCaloric2.Size = new System.Drawing.Size(56, 20);
            this.textBoxForCaloric2.TabIndex = 29;
            // 
            // textBoxForCaloric1
            // 
            this.textBoxForCaloric1.Location = new System.Drawing.Point(475, 81);
            this.textBoxForCaloric1.Name = "textBoxForCaloric1";
            this.textBoxForCaloric1.Size = new System.Drawing.Size(56, 20);
            this.textBoxForCaloric1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(603, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Фільтр";
            // 
            // sellingToolStripMenuItem
            // 
            this.sellingToolStripMenuItem.Name = "sellingToolStripMenuItem";
            this.sellingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellingToolStripMenuItem.Text = "Selling";
            this.sellingToolStripMenuItem.Click += new System.EventHandler(this.sellingToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxForSearch);
            this.Controls.Add(this.comboBoxForTable);
            this.Controls.Add(this.TableLable);
            this.Controls.Add(this.Searching);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Searching;
        private System.Windows.Forms.Label TableLable;
        private System.Windows.Forms.ComboBox comboBoxForTable;
        private System.Windows.Forms.ComboBox comboBoxForSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem animalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupOfAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem feedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groupOfAnimalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem1;
        private System.Windows.Forms.BindingSource petStoreDataSetBindingSource;
        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private PetStoreDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource feedBindingSource;
        private PetStoreDataSetTableAdapters.FeedTableAdapter feedTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem1;
        private System.Windows.Forms.BindingSource feedBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private PetStoreDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxForKindAnimal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxForKind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAge1;
        private System.Windows.Forms.TextBox textBoxAge2;
        private System.Windows.Forms.TextBox textBoxForCaloric2;
        private System.Windows.Forms.TextBox textBoxForCaloric1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem sellingToolStripMenuItem;
    }
}