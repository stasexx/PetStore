namespace PetStore.FormsForAdmin
{
    partial class CageForm
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
            System.Windows.Forms.Label cage_idLabel;
            System.Windows.Forms.Label capacityLabel;
            System.Windows.Forms.Label group_of_animal_idLabel;
            this.cage_idTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.cageTableAdapter = new PetStore.PetStoreDataSetTableAdapters.CageTableAdapter();
            this.tableAdapterManager = new PetStore.PetStoreDataSetTableAdapters.TableAdapterManager();
            this.comboBoxForGroup = new System.Windows.Forms.ComboBox();
            this.groupOfAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupOfAnimalTableAdapter = new PetStore.PetStoreDataSetTableAdapters.GroupOfAnimalTableAdapter();
            cage_idLabel = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            group_of_animal_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cage_idLabel
            // 
            cage_idLabel.AutoSize = true;
            cage_idLabel.Location = new System.Drawing.Point(44, 88);
            cage_idLabel.Name = "cage_idLabel";
            cage_idLabel.Size = new System.Drawing.Size(46, 13);
            cage_idLabel.TabIndex = 1;
            cage_idLabel.Text = "Cage id:";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new System.Drawing.Point(44, 114);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(51, 13);
            capacityLabel.TabIndex = 3;
            capacityLabel.Text = "Capacity:";
            // 
            // group_of_animal_idLabel
            // 
            group_of_animal_idLabel.AutoSize = true;
            group_of_animal_idLabel.Location = new System.Drawing.Point(44, 140);
            group_of_animal_idLabel.Name = "group_of_animal_idLabel";
            group_of_animal_idLabel.Size = new System.Drawing.Size(95, 13);
            group_of_animal_idLabel.TabIndex = 5;
            group_of_animal_idLabel.Text = "Group of animal id:";
            // 
            // cage_idTextBox
            // 
            this.cage_idTextBox.Location = new System.Drawing.Point(145, 85);
            this.cage_idTextBox.Name = "cage_idTextBox";
            this.cage_idTextBox.ReadOnly = true;
            this.cage_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.cage_idTextBox.TabIndex = 2;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(145, 111);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacityTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "ЗБЕРЕГТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cageBindingSource
            // 
            this.cageBindingSource.DataMember = "Cage";
            this.cageBindingSource.DataSource = this.petStoreDataSet;
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cageTableAdapter
            // 
            this.cageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CageTableAdapter = this.cageTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FeedTableAdapter = null;
            this.tableAdapterManager.GroupOfAnimalTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SellingTableAdapter = null;
            this.tableAdapterManager.SupplyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetStore.PetStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBoxForGroup
            // 
            this.comboBoxForGroup.DataSource = this.groupOfAnimalBindingSource;
            this.comboBoxForGroup.DisplayMember = "Group_name";
            this.comboBoxForGroup.FormattingEnabled = true;
            this.comboBoxForGroup.Location = new System.Drawing.Point(145, 137);
            this.comboBoxForGroup.Name = "comboBoxForGroup";
            this.comboBoxForGroup.Size = new System.Drawing.Size(100, 21);
            this.comboBoxForGroup.TabIndex = 9;
            this.comboBoxForGroup.ValueMember = "Group_of_animal_id";
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
            // CageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(310, 239);
            this.Controls.Add(this.comboBoxForGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(cage_idLabel);
            this.Controls.Add(this.cage_idTextBox);
            this.Controls.Add(capacityLabel);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(group_of_animal_idLabel);
            this.Name = "CageForm";
            this.Text = "CageForm";
            this.Load += new System.EventHandler(this.CageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOfAnimalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource cageBindingSource;
        private PetStoreDataSetTableAdapters.CageTableAdapter cageTableAdapter;
        private PetStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cage_idTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxForGroup;
        private System.Windows.Forms.BindingSource groupOfAnimalBindingSource;
        private PetStoreDataSetTableAdapters.GroupOfAnimalTableAdapter groupOfAnimalTableAdapter;
    }
}