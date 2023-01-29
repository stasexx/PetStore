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
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.cageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cageTableAdapter = new PetStore.PetStoreDataSetTableAdapters.CageTableAdapter();
            this.tableAdapterManager = new PetStore.PetStoreDataSetTableAdapters.TableAdapterManager();
            this.cage_idTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.group_of_animal_idTextBox = new System.Windows.Forms.TextBox();
            cage_idLabel = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            group_of_animal_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cageBindingSource
            // 
            this.cageBindingSource.DataMember = "Cage";
            this.cageBindingSource.DataSource = this.petStoreDataSet;
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
            // cage_idLabel
            // 
            cage_idLabel.AutoSize = true;
            cage_idLabel.Location = new System.Drawing.Point(44, 88);
            cage_idLabel.Name = "cage_idLabel";
            cage_idLabel.Size = new System.Drawing.Size(46, 13);
            cage_idLabel.TabIndex = 1;
            cage_idLabel.Text = "Cage id:";
            // 
            // cage_idTextBox
            // 
            this.cage_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cageBindingSource, "Cage_id", true));
            this.cage_idTextBox.Location = new System.Drawing.Point(145, 85);
            this.cage_idTextBox.Name = "cage_idTextBox";
            this.cage_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.cage_idTextBox.TabIndex = 2;
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
            // capacityTextBox
            // 
            this.capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cageBindingSource, "Capacity", true));
            this.capacityTextBox.Location = new System.Drawing.Point(145, 111);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacityTextBox.TabIndex = 4;
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
            // group_of_animal_idTextBox
            // 
            this.group_of_animal_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cageBindingSource, "Group_of_animal_id", true));
            this.group_of_animal_idTextBox.Location = new System.Drawing.Point(145, 137);
            this.group_of_animal_idTextBox.Name = "group_of_animal_idTextBox";
            this.group_of_animal_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.group_of_animal_idTextBox.TabIndex = 6;
            // 
            // CageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 295);
            this.Controls.Add(cage_idLabel);
            this.Controls.Add(this.cage_idTextBox);
            this.Controls.Add(capacityLabel);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(group_of_animal_idLabel);
            this.Controls.Add(this.group_of_animal_idTextBox);
            this.Name = "CageForm";
            this.Text = "CageForm";
            this.Load += new System.EventHandler(this.CageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox group_of_animal_idTextBox;
    }
}