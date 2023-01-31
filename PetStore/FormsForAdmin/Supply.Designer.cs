namespace PetStore.FormsForAdmin
{
    partial class Supply
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
            System.Windows.Forms.Label supply_idLabel;
            System.Windows.Forms.Label date_of_deliveryLabel;
            System.Windows.Forms.Label expiry_dateLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label feed_idLabel;
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyTableAdapter = new PetStore.PetStoreDataSetTableAdapters.SupplyTableAdapter();
            this.tableAdapterManager = new PetStore.PetStoreDataSetTableAdapters.TableAdapterManager();
            this.feedTableAdapter = new PetStore.PetStoreDataSetTableAdapters.FeedTableAdapter();
            this.supply_idTextBox = new System.Windows.Forms.TextBox();
            this.date_of_deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expiry_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.feedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            supply_idLabel = new System.Windows.Forms.Label();
            date_of_deliveryLabel = new System.Windows.Forms.Label();
            expiry_dateLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            feed_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supply_idLabel
            // 
            supply_idLabel.AutoSize = true;
            supply_idLabel.Location = new System.Drawing.Point(40, 86);
            supply_idLabel.Name = "supply_idLabel";
            supply_idLabel.Size = new System.Drawing.Size(53, 13);
            supply_idLabel.TabIndex = 1;
            supply_idLabel.Text = "Supply id:";
            // 
            // date_of_deliveryLabel
            // 
            date_of_deliveryLabel.AutoSize = true;
            date_of_deliveryLabel.Location = new System.Drawing.Point(40, 113);
            date_of_deliveryLabel.Name = "date_of_deliveryLabel";
            date_of_deliveryLabel.Size = new System.Drawing.Size(84, 13);
            date_of_deliveryLabel.TabIndex = 3;
            date_of_deliveryLabel.Text = "Date of delivery:";
            // 
            // expiry_dateLabel
            // 
            expiry_dateLabel.AutoSize = true;
            expiry_dateLabel.Location = new System.Drawing.Point(40, 139);
            expiry_dateLabel.Name = "expiry_dateLabel";
            expiry_dateLabel.Size = new System.Drawing.Size(62, 13);
            expiry_dateLabel.TabIndex = 5;
            expiry_dateLabel.Text = "Expiry date:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(40, 164);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 7;
            amountLabel.Text = "Amount:";
            // 
            // feed_idLabel
            // 
            feed_idLabel.AutoSize = true;
            feed_idLabel.Location = new System.Drawing.Point(40, 190);
            feed_idLabel.Name = "feed_idLabel";
            feed_idLabel.Size = new System.Drawing.Size(45, 13);
            feed_idLabel.TabIndex = 9;
            feed_idLabel.Text = "Feed id:";
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "Supply";
            this.supplyBindingSource.DataSource = this.petStoreDataSet;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CageTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FeedTableAdapter = this.feedTableAdapter;
            this.tableAdapterManager.GroupOfAnimalTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SellingTableAdapter = null;
            this.tableAdapterManager.SupplyTableAdapter = this.supplyTableAdapter;
            this.tableAdapterManager.UpdateOrder = PetStore.PetStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // feedTableAdapter
            // 
            this.feedTableAdapter.ClearBeforeFill = true;
            // 
            // supply_idTextBox
            // 
            this.supply_idTextBox.Location = new System.Drawing.Point(130, 83);
            this.supply_idTextBox.Name = "supply_idTextBox";
            this.supply_idTextBox.ReadOnly = true;
            this.supply_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.supply_idTextBox.TabIndex = 2;
            // 
            // date_of_deliveryDateTimePicker
            // 
            this.date_of_deliveryDateTimePicker.Location = new System.Drawing.Point(130, 109);
            this.date_of_deliveryDateTimePicker.Name = "date_of_deliveryDateTimePicker";
            this.date_of_deliveryDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_deliveryDateTimePicker.TabIndex = 4;
            // 
            // expiry_dateDateTimePicker
            // 
            this.expiry_dateDateTimePicker.Location = new System.Drawing.Point(130, 135);
            this.expiry_dateDateTimePicker.Name = "expiry_dateDateTimePicker";
            this.expiry_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expiry_dateDateTimePicker.TabIndex = 6;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(130, 161);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 20);
            this.amountTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Supply";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "ЗБЕРЕГТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.feedBindingSource;
            this.comboBox1.DisplayMember = "Feed_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "Feed_id";
            // 
            // feedBindingSource
            // 
            this.feedBindingSource.DataMember = "Feed";
            this.feedBindingSource.DataSource = this.petStoreDataSet;
            // 
            // Supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(396, 289);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(supply_idLabel);
            this.Controls.Add(this.supply_idTextBox);
            this.Controls.Add(date_of_deliveryLabel);
            this.Controls.Add(this.date_of_deliveryDateTimePicker);
            this.Controls.Add(expiry_dateLabel);
            this.Controls.Add(this.expiry_dateDateTimePicker);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(feed_idLabel);
            this.Name = "Supply";
            this.Text = "Supply";
            this.Load += new System.EventHandler(this.Supply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private PetStoreDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter;
        private PetStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox supply_idTextBox;
        private System.Windows.Forms.DateTimePicker date_of_deliveryDateTimePicker;
        private System.Windows.Forms.DateTimePicker expiry_dateDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private PetStoreDataSetTableAdapters.FeedTableAdapter feedTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource feedBindingSource;
    }
}