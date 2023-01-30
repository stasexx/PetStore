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
            this.comboBoxForCoulmn = new System.Windows.Forms.ComboBox();
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
            this.sellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.buttonForAnimal = new System.Windows.Forms.Button();
            this.labelForAnimal4 = new System.Windows.Forms.Label();
            this.comboBoxForKindAnimal = new System.Windows.Forms.ComboBox();
            this.labelForAnimal1 = new System.Windows.Forms.Label();
            this.labelForAnimal3 = new System.Windows.Forms.Label();
            this.labelForAnimal2 = new System.Windows.Forms.Label();
            this.buttonForCaloric = new System.Windows.Forms.Button();
            this.labelForCalc4 = new System.Windows.Forms.Label();
            this.labelForCalc1 = new System.Windows.Forms.Label();
            this.comboBoxForKindCaloric = new System.Windows.Forms.ComboBox();
            this.labelForCalc3 = new System.Windows.Forms.Label();
            this.labelForCalc2 = new System.Windows.Forms.Label();
            this.textBoxAge1 = new System.Windows.Forms.TextBox();
            this.textBoxAge2 = new System.Windows.Forms.TextBox();
            this.textBoxForCaloric2 = new System.Windows.Forms.TextBox();
            this.textBoxForCaloric1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.supplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // comboBoxForCoulmn
            // 
            this.comboBoxForCoulmn.FormattingEnabled = true;
            this.comboBoxForCoulmn.Location = new System.Drawing.Point(273, 57);
            this.comboBoxForCoulmn.Name = "comboBoxForCoulmn";
            this.comboBoxForCoulmn.Size = new System.Drawing.Size(118, 21);
            this.comboBoxForCoulmn.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createToolStripMenuItem,
            this.editToolStripMenuItem,
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
            this.animalToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.animalToolStripMenuItem1.Text = "Animal";
            this.animalToolStripMenuItem1.Click += new System.EventHandler(this.animalToolStripMenuItem1_Click);
            // 
            // feedToolStripMenuItem1
            // 
            this.feedToolStripMenuItem1.Name = "feedToolStripMenuItem1";
            this.feedToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.feedToolStripMenuItem1.Text = "Feed";
            this.feedToolStripMenuItem1.Click += new System.EventHandler(this.feedToolStripMenuItem1_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem1.Text = "Client";
            // 
            // cageToolStripMenuItem1
            // 
            this.cageToolStripMenuItem1.Name = "cageToolStripMenuItem1";
            this.cageToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cageToolStripMenuItem1.Text = "Cage";
            this.cageToolStripMenuItem1.Click += new System.EventHandler(this.cageToolStripMenuItem1_Click);
            // 
            // groupOfAnimalToolStripMenuItem1
            // 
            this.groupOfAnimalToolStripMenuItem1.Name = "groupOfAnimalToolStripMenuItem1";
            this.groupOfAnimalToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
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
            this.sellingToolStripMenuItem,
            this.supplyToolStripMenuItem});
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
            // sellingToolStripMenuItem
            // 
            this.sellingToolStripMenuItem.Name = "sellingToolStripMenuItem";
            this.sellingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellingToolStripMenuItem.Text = "Selling";
            this.sellingToolStripMenuItem.Click += new System.EventHandler(this.sellingToolStripMenuItem_Click);
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
            // buttonForAnimal
            // 
            this.buttonForAnimal.Location = new System.Drawing.Point(682, 153);
            this.buttonForAnimal.Name = "buttonForAnimal";
            this.buttonForAnimal.Size = new System.Drawing.Size(121, 26);
            this.buttonForAnimal.TabIndex = 43;
            this.buttonForAnimal.Text = "ЗАСТОСУВАТИ";
            this.buttonForAnimal.UseVisualStyleBackColor = true;
            this.buttonForAnimal.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelForAnimal4
            // 
            this.labelForAnimal4.AutoSize = true;
            this.labelForAnimal4.Location = new System.Drawing.Point(726, 110);
            this.labelForAnimal4.Name = "labelForAnimal4";
            this.labelForAnimal4.Size = new System.Drawing.Size(26, 13);
            this.labelForAnimal4.TabIndex = 42;
            this.labelForAnimal4.Text = "Вид";
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
            // labelForAnimal1
            // 
            this.labelForAnimal1.AutoSize = true;
            this.labelForAnimal1.Location = new System.Drawing.Point(728, 65);
            this.labelForAnimal1.Name = "labelForAnimal1";
            this.labelForAnimal1.Size = new System.Drawing.Size(22, 13);
            this.labelForAnimal1.TabIndex = 40;
            this.labelForAnimal1.Text = "Вік";
            // 
            // labelForAnimal3
            // 
            this.labelForAnimal3.AutoSize = true;
            this.labelForAnimal3.Location = new System.Drawing.Point(731, 88);
            this.labelForAnimal3.Name = "labelForAnimal3";
            this.labelForAnimal3.Size = new System.Drawing.Size(19, 13);
            this.labelForAnimal3.TabIndex = 39;
            this.labelForAnimal3.Text = "до";
            // 
            // labelForAnimal2
            // 
            this.labelForAnimal2.AutoSize = true;
            this.labelForAnimal2.Location = new System.Drawing.Point(642, 88);
            this.labelForAnimal2.Name = "labelForAnimal2";
            this.labelForAnimal2.Size = new System.Drawing.Size(21, 13);
            this.labelForAnimal2.TabIndex = 38;
            this.labelForAnimal2.Text = "від";
            // 
            // buttonForCaloric
            // 
            this.buttonForCaloric.Location = new System.Drawing.Point(486, 153);
            this.buttonForCaloric.Name = "buttonForCaloric";
            this.buttonForCaloric.Size = new System.Drawing.Size(121, 26);
            this.buttonForCaloric.TabIndex = 37;
            this.buttonForCaloric.Text = "ЗАСТОСУВАТИ";
            this.buttonForCaloric.UseVisualStyleBackColor = true;
            this.buttonForCaloric.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelForCalc4
            // 
            this.labelForCalc4.AutoSize = true;
            this.labelForCalc4.Location = new System.Drawing.Point(530, 110);
            this.labelForCalc4.Name = "labelForCalc4";
            this.labelForCalc4.Size = new System.Drawing.Size(26, 13);
            this.labelForCalc4.TabIndex = 36;
            this.labelForCalc4.Text = "Вид";
            // 
            // labelForCalc1
            // 
            this.labelForCalc1.AutoSize = true;
            this.labelForCalc1.Location = new System.Drawing.Point(507, 65);
            this.labelForCalc1.Name = "labelForCalc1";
            this.labelForCalc1.Size = new System.Drawing.Size(71, 13);
            this.labelForCalc1.TabIndex = 35;
            this.labelForCalc1.Text = "Калорійність";
            // 
            // comboBoxForKindCaloric
            // 
            this.comboBoxForKindCaloric.FormattingEnabled = true;
            this.comboBoxForKindCaloric.Items.AddRange(new object[] {
            "М`ясо ",
            "Трава"});
            this.comboBoxForKindCaloric.Location = new System.Drawing.Point(486, 126);
            this.comboBoxForKindCaloric.Name = "comboBoxForKindCaloric";
            this.comboBoxForKindCaloric.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForKindCaloric.TabIndex = 34;
            // 
            // labelForCalc3
            // 
            this.labelForCalc3.AutoSize = true;
            this.labelForCalc3.Location = new System.Drawing.Point(537, 88);
            this.labelForCalc3.Name = "labelForCalc3";
            this.labelForCalc3.Size = new System.Drawing.Size(19, 13);
            this.labelForCalc3.TabIndex = 33;
            this.labelForCalc3.Text = "до";
            // 
            // labelForCalc2
            // 
            this.labelForCalc2.AutoSize = true;
            this.labelForCalc2.Location = new System.Drawing.Point(448, 88);
            this.labelForCalc2.Name = "labelForCalc2";
            this.labelForCalc2.Size = new System.Drawing.Size(21, 13);
            this.labelForCalc2.TabIndex = 32;
            this.labelForCalc2.Text = "від";
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
            this.textBoxAge2.Location = new System.Drawing.Point(756, 81);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(743, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 25);
            this.button4.TabIndex = 44;
            this.button4.Text = "Скинути";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // supplyToolStripMenuItem
            // 
            this.supplyToolStripMenuItem.Name = "supplyToolStripMenuItem";
            this.supplyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supplyToolStripMenuItem.Text = "Supply";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button4);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxForCoulmn);
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
        private System.Windows.Forms.ComboBox comboBoxForCoulmn;
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
        private System.Windows.Forms.Button buttonForAnimal;
        private System.Windows.Forms.Label labelForAnimal4;
        private System.Windows.Forms.ComboBox comboBoxForKindAnimal;
        private System.Windows.Forms.Label labelForAnimal1;
        private System.Windows.Forms.Label labelForAnimal3;
        private System.Windows.Forms.Label labelForAnimal2;
        private System.Windows.Forms.Button buttonForCaloric;
        private System.Windows.Forms.Label labelForCalc4;
        private System.Windows.Forms.Label labelForCalc1;
        private System.Windows.Forms.ComboBox comboBoxForKindCaloric;
        private System.Windows.Forms.Label labelForCalc3;
        private System.Windows.Forms.Label labelForCalc2;
        private System.Windows.Forms.TextBox textBoxAge1;
        private System.Windows.Forms.TextBox textBoxAge2;
        private System.Windows.Forms.TextBox textBoxForCaloric2;
        private System.Windows.Forms.TextBox textBoxForCaloric1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem sellingToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem supplyToolStripMenuItem;
    }
}