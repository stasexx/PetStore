namespace PetStore.FormsForAdmin
{
    partial class FormForCreatingOrEditingAnimal
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
            System.Windows.Forms.Label animal_idLabel;
            System.Windows.Forms.Label animal_nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label weight_of_animalLabel;
            System.Windows.Forms.Label date_addLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label vaccinationLabel;
            System.Windows.Forms.Label documentsLabel;
            System.Windows.Forms.Label group_of_animal_idLabel;
            System.Windows.Forms.Label cage_idLabel;
            System.Windows.Forms.Label calories_per_dayLabel;
            System.Windows.Forms.Label costLabel;
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new PetStore.PetStoreDataSetTableAdapters.AnimalTableAdapter();
            this.tableAdapterManager = new PetStore.PetStoreDataSetTableAdapters.TableAdapterManager();
            this.animal_nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.weight_of_animalTextBox = new System.Windows.Forms.TextBox();
            this.date_addDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calories_per_dayTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxForVac = new System.Windows.Forms.ComboBox();
            this.comboBoxForDoc = new System.Windows.Forms.ComboBox();
            this.comboBoxForGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxForCage = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxForId = new System.Windows.Forms.ComboBox();
            animal_idLabel = new System.Windows.Forms.Label();
            animal_nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            weight_of_animalLabel = new System.Windows.Forms.Label();
            date_addLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            vaccinationLabel = new System.Windows.Forms.Label();
            documentsLabel = new System.Windows.Forms.Label();
            group_of_animal_idLabel = new System.Windows.Forms.Label();
            cage_idLabel = new System.Windows.Forms.Label();
            calories_per_dayLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // animal_idLabel
            // 
            animal_idLabel.AutoSize = true;
            animal_idLabel.Location = new System.Drawing.Point(15, 69);
            animal_idLabel.Name = "animal_idLabel";
            animal_idLabel.Size = new System.Drawing.Size(52, 13);
            animal_idLabel.TabIndex = 1;
            animal_idLabel.Text = "Animal id:";
            // 
            // animal_nameLabel
            // 
            animal_nameLabel.AutoSize = true;
            animal_nameLabel.Location = new System.Drawing.Point(15, 95);
            animal_nameLabel.Name = "animal_nameLabel";
            animal_nameLabel.Size = new System.Drawing.Size(70, 13);
            animal_nameLabel.TabIndex = 3;
            animal_nameLabel.Text = "Animal name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(15, 121);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age:";
            // 
            // weight_of_animalLabel
            // 
            weight_of_animalLabel.AutoSize = true;
            weight_of_animalLabel.Location = new System.Drawing.Point(15, 147);
            weight_of_animalLabel.Name = "weight_of_animalLabel";
            weight_of_animalLabel.Size = new System.Drawing.Size(89, 13);
            weight_of_animalLabel.TabIndex = 7;
            weight_of_animalLabel.Text = "Weight of animal:";
            // 
            // date_addLabel
            // 
            date_addLabel.AutoSize = true;
            date_addLabel.Location = new System.Drawing.Point(15, 174);
            date_addLabel.Name = "date_addLabel";
            date_addLabel.Size = new System.Drawing.Size(54, 13);
            date_addLabel.TabIndex = 9;
            date_addLabel.Text = "Date add:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(15, 199);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 11;
            sexLabel.Text = "Sex:";
            // 
            // vaccinationLabel
            // 
            vaccinationLabel.AutoSize = true;
            vaccinationLabel.Location = new System.Drawing.Point(15, 225);
            vaccinationLabel.Name = "vaccinationLabel";
            vaccinationLabel.Size = new System.Drawing.Size(66, 13);
            vaccinationLabel.TabIndex = 13;
            vaccinationLabel.Text = "Vaccination:";
            // 
            // documentsLabel
            // 
            documentsLabel.AutoSize = true;
            documentsLabel.Location = new System.Drawing.Point(15, 251);
            documentsLabel.Name = "documentsLabel";
            documentsLabel.Size = new System.Drawing.Size(64, 13);
            documentsLabel.TabIndex = 15;
            documentsLabel.Text = "Documents:";
            // 
            // group_of_animal_idLabel
            // 
            group_of_animal_idLabel.AutoSize = true;
            group_of_animal_idLabel.Location = new System.Drawing.Point(15, 277);
            group_of_animal_idLabel.Name = "group_of_animal_idLabel";
            group_of_animal_idLabel.Size = new System.Drawing.Size(95, 13);
            group_of_animal_idLabel.TabIndex = 17;
            group_of_animal_idLabel.Text = "Group of animal id:";
            // 
            // cage_idLabel
            // 
            cage_idLabel.AutoSize = true;
            cage_idLabel.Location = new System.Drawing.Point(15, 303);
            cage_idLabel.Name = "cage_idLabel";
            cage_idLabel.Size = new System.Drawing.Size(46, 13);
            cage_idLabel.TabIndex = 19;
            cage_idLabel.Text = "Cage id:";
            // 
            // calories_per_dayLabel
            // 
            calories_per_dayLabel.AutoSize = true;
            calories_per_dayLabel.Location = new System.Drawing.Point(15, 329);
            calories_per_dayLabel.Name = "calories_per_dayLabel";
            calories_per_dayLabel.Size = new System.Drawing.Size(85, 13);
            calories_per_dayLabel.TabIndex = 21;
            calories_per_dayLabel.Text = "Calories per day:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(15, 355);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 23;
            costLabel.Text = "Cost:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CageTableAdapter = null;
            this.tableAdapterManager.FeedTableAdapter = null;
            this.tableAdapterManager.GroupOfAnimalTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetStore.PetStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // animal_nameTextBox
            // 
            this.animal_nameTextBox.Location = new System.Drawing.Point(116, 92);
            this.animal_nameTextBox.Name = "animal_nameTextBox";
            this.animal_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.animal_nameTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(116, 118);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 20);
            this.ageTextBox.TabIndex = 6;
            // 
            // weight_of_animalTextBox
            // 
            this.weight_of_animalTextBox.Location = new System.Drawing.Point(116, 144);
            this.weight_of_animalTextBox.Name = "weight_of_animalTextBox";
            this.weight_of_animalTextBox.Size = new System.Drawing.Size(200, 20);
            this.weight_of_animalTextBox.TabIndex = 8;
            // 
            // date_addDateTimePicker
            // 
            this.date_addDateTimePicker.Location = new System.Drawing.Point(116, 170);
            this.date_addDateTimePicker.Name = "date_addDateTimePicker";
            this.date_addDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_addDateTimePicker.TabIndex = 10;
            // 
            // calories_per_dayTextBox
            // 
            this.calories_per_dayTextBox.Location = new System.Drawing.Point(116, 330);
            this.calories_per_dayTextBox.Name = "calories_per_dayTextBox";
            this.calories_per_dayTextBox.Size = new System.Drawing.Size(200, 20);
            this.calories_per_dayTextBox.TabIndex = 22;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(116, 356);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 20);
            this.costTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Animal";
            // 
            // comboBoxForVac
            // 
            this.comboBoxForVac.FormattingEnabled = true;
            this.comboBoxForVac.Items.AddRange(new object[] {
            "Вакцинована",
            "Не вакцинована"});
            this.comboBoxForVac.Location = new System.Drawing.Point(116, 224);
            this.comboBoxForVac.Name = "comboBoxForVac";
            this.comboBoxForVac.Size = new System.Drawing.Size(200, 21);
            this.comboBoxForVac.TabIndex = 26;
            this.comboBoxForVac.SelectedIndexChanged += new System.EventHandler(this.comboBoxForVac_SelectedIndexChanged);
            // 
            // comboBoxForDoc
            // 
            this.comboBoxForDoc.FormattingEnabled = true;
            this.comboBoxForDoc.Items.AddRange(new object[] {
            "Є документи",
            "Немає документів"});
            this.comboBoxForDoc.Location = new System.Drawing.Point(116, 251);
            this.comboBoxForDoc.Name = "comboBoxForDoc";
            this.comboBoxForDoc.Size = new System.Drawing.Size(200, 21);
            this.comboBoxForDoc.TabIndex = 27;
            this.comboBoxForDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxForDoc_SelectedIndexChanged);
            // 
            // comboBoxForGroup
            // 
            this.comboBoxForGroup.FormattingEnabled = true;
            this.comboBoxForGroup.Location = new System.Drawing.Point(116, 278);
            this.comboBoxForGroup.Name = "comboBoxForGroup";
            this.comboBoxForGroup.Size = new System.Drawing.Size(200, 21);
            this.comboBoxForGroup.TabIndex = 28;
            this.comboBoxForGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBoxForCage
            // 
            this.comboBoxForCage.FormattingEnabled = true;
            this.comboBoxForCage.Location = new System.Drawing.Point(116, 303);
            this.comboBoxForCage.Name = "comboBoxForCage";
            this.comboBoxForCage.Size = new System.Drawing.Size(200, 21);
            this.comboBoxForCage.TabIndex = 29;
            this.comboBoxForCage.SelectedIndexChanged += new System.EventHandler(this.comboBoxForCage_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.comboBox1.Location = new System.Drawing.Point(116, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(30, 395);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(270, 52);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "ЗБЕРЕГТИ";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxForId
            // 
            this.comboBoxForId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForId.Location = new System.Drawing.Point(116, 66);
            this.comboBoxForId.Name = "comboBoxForId";
            this.comboBoxForId.Size = new System.Drawing.Size(200, 21);
            this.comboBoxForId.TabIndex = 32;
            // 
            // FormForCreatingOrEditingAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 479);
            this.Controls.Add(this.comboBoxForId);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxForCage);
            this.Controls.Add(this.comboBoxForGroup);
            this.Controls.Add(this.comboBoxForDoc);
            this.Controls.Add(this.comboBoxForVac);
            this.Controls.Add(this.label1);
            this.Controls.Add(animal_idLabel);
            this.Controls.Add(animal_nameLabel);
            this.Controls.Add(this.animal_nameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(weight_of_animalLabel);
            this.Controls.Add(this.weight_of_animalTextBox);
            this.Controls.Add(date_addLabel);
            this.Controls.Add(this.date_addDateTimePicker);
            this.Controls.Add(sexLabel);
            this.Controls.Add(vaccinationLabel);
            this.Controls.Add(documentsLabel);
            this.Controls.Add(group_of_animal_idLabel);
            this.Controls.Add(cage_idLabel);
            this.Controls.Add(calories_per_dayLabel);
            this.Controls.Add(this.calories_per_dayTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Name = "FormForCreatingOrEditingAnimal";
            this.Text = "FormForCreatinOrEditingAnimal";
            this.Load += new System.EventHandler(this.FormForCreatinOrEditingAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private PetStoreDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private PetStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox animal_nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox weight_of_animalTextBox;
        private System.Windows.Forms.DateTimePicker date_addDateTimePicker;
        private System.Windows.Forms.TextBox calories_per_dayTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxForVac;
        private System.Windows.Forms.ComboBox comboBoxForDoc;
        private System.Windows.Forms.ComboBox comboBoxForGroup;
        private System.Windows.Forms.ComboBox comboBoxForCage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxForId;
    }
}