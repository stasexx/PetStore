namespace PetStore.FormsForAdmin
{
    partial class GroupOfAnimalForm
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
            System.Windows.Forms.Label group_of_animal_idLabel;
            System.Windows.Forms.Label group_nameLabel;
            System.Windows.Forms.Label food_methodLabel;
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.groupOfAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupOfAnimalTableAdapter = new PetStore.PetStoreDataSetTableAdapters.GroupOfAnimalTableAdapter();
            this.tableAdapterManager = new PetStore.PetStoreDataSetTableAdapters.TableAdapterManager();
            this.group_of_animal_idTextBox = new System.Windows.Forms.TextBox();
            this.group_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            group_of_animal_idLabel = new System.Windows.Forms.Label();
            group_nameLabel = new System.Windows.Forms.Label();
            food_methodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupOfAnimalBindingSource
            // 
            this.groupOfAnimalBindingSource.DataMember = "GroupOfAnimal";
            this.groupOfAnimalBindingSource.DataSource = this.petStoreDataSet;
            // 
            // groupOfAnimalTableAdapter
            // 
            this.groupOfAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CageTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FeedTableAdapter = null;
            this.tableAdapterManager.GroupOfAnimalTableAdapter = this.groupOfAnimalTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SellingTableAdapter = null;
            this.tableAdapterManager.SupplyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetStore.PetStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // group_of_animal_idLabel
            // 
            group_of_animal_idLabel.AutoSize = true;
            group_of_animal_idLabel.Location = new System.Drawing.Point(67, 88);
            group_of_animal_idLabel.Name = "group_of_animal_idLabel";
            group_of_animal_idLabel.Size = new System.Drawing.Size(95, 13);
            group_of_animal_idLabel.TabIndex = 1;
            group_of_animal_idLabel.Text = "Group of animal id:";
            // 
            // group_of_animal_idTextBox
            // 
            this.group_of_animal_idTextBox.Location = new System.Drawing.Point(168, 85);
            this.group_of_animal_idTextBox.Name = "group_of_animal_idTextBox";
            this.group_of_animal_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.group_of_animal_idTextBox.TabIndex = 2;
            // 
            // group_nameLabel
            // 
            group_nameLabel.AutoSize = true;
            group_nameLabel.Location = new System.Drawing.Point(67, 114);
            group_nameLabel.Name = "group_nameLabel";
            group_nameLabel.Size = new System.Drawing.Size(68, 13);
            group_nameLabel.TabIndex = 3;
            group_nameLabel.Text = "Group name:";
            // 
            // group_nameTextBox
            // 
            this.group_nameTextBox.Location = new System.Drawing.Point(168, 111);
            this.group_nameTextBox.Name = "group_nameTextBox";
            this.group_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.group_nameTextBox.TabIndex = 4;
            // 
            // food_methodLabel
            // 
            food_methodLabel.AutoSize = true;
            food_methodLabel.Location = new System.Drawing.Point(67, 140);
            food_methodLabel.Name = "food_methodLabel";
            food_methodLabel.Size = new System.Drawing.Size(72, 13);
            food_methodLabel.TabIndex = 5;
            food_methodLabel.Text = "Food method:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "GroupOfAnimal";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "М`ясоїд",
            "Травоїд"});
            this.comboBox1.Location = new System.Drawing.Point(168, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(70, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "ЗБЕРЕГТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupOfAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(352, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(group_of_animal_idLabel);
            this.Controls.Add(this.group_of_animal_idTextBox);
            this.Controls.Add(group_nameLabel);
            this.Controls.Add(this.group_nameTextBox);
            this.Controls.Add(food_methodLabel);
            this.Name = "GroupOfAnimalForm";
            this.Text = "GroupOfAnimalForm";
            this.Load += new System.EventHandler(this.GroupOfAnimalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource groupOfAnimalBindingSource;
        private PetStoreDataSetTableAdapters.GroupOfAnimalTableAdapter groupOfAnimalTableAdapter;
        private PetStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox group_of_animal_idTextBox;
        private System.Windows.Forms.TextBox group_nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}