namespace PetStore.FormsForAdmin
{
    partial class SellingForm
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
            System.Windows.Forms.Label selling_idLabel;
            System.Windows.Forms.Label selling_dateLabel;
            System.Windows.Forms.Label total_priceLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label label2;
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.sellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellingTableAdapter = new PetStore.PetStoreDataSetTableAdapters.SellingTableAdapter();
            this.tableAdapterManager = new PetStore.PetStoreDataSetTableAdapters.TableAdapterManager();
            this.selling_idTextBox = new System.Windows.Forms.TextBox();
            this.selling_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.total_priceTextBox = new System.Windows.Forms.TextBox();
            this.buttonForPrintAndSave = new System.Windows.Forms.Button();
            this.buttonForSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxForProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxForClient = new System.Windows.Forms.ComboBox();
            this.textBoxForFullName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            selling_idLabel = new System.Windows.Forms.Label();
            selling_dateLabel = new System.Windows.Forms.Label();
            total_priceLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            client_idLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selling_idLabel
            // 
            selling_idLabel.AutoSize = true;
            selling_idLabel.Location = new System.Drawing.Point(12, 89);
            selling_idLabel.Name = "selling_idLabel";
            selling_idLabel.Size = new System.Drawing.Size(52, 13);
            selling_idLabel.TabIndex = 1;
            selling_idLabel.Text = "Selling id:";
            // 
            // selling_dateLabel
            // 
            selling_dateLabel.AutoSize = true;
            selling_dateLabel.Location = new System.Drawing.Point(10, 118);
            selling_dateLabel.Name = "selling_dateLabel";
            selling_dateLabel.Size = new System.Drawing.Size(65, 13);
            selling_dateLabel.TabIndex = 3;
            selling_dateLabel.Text = "Selling date:";
            // 
            // total_priceLabel
            // 
            total_priceLabel.AutoSize = true;
            total_priceLabel.Location = new System.Drawing.Point(10, 227);
            total_priceLabel.Name = "total_priceLabel";
            total_priceLabel.Size = new System.Drawing.Size(60, 13);
            total_priceLabel.TabIndex = 5;
            total_priceLabel.Text = "Total price:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(12, 167);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(58, 13);
            product_idLabel.TabIndex = 7;
            product_idLabel.Text = "Product id:";
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Location = new System.Drawing.Point(12, 194);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(47, 13);
            client_idLabel.TabIndex = 9;
            client_idLabel.Text = "Client id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 143);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 13);
            label2.TabIndex = 18;
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellingBindingSource
            // 
            this.sellingBindingSource.DataMember = "Selling";
            this.sellingBindingSource.DataSource = this.petStoreDataSet;
            // 
            // sellingTableAdapter
            // 
            this.sellingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CageTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FeedTableAdapter = null;
            this.tableAdapterManager.GroupOfAnimalTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SellingTableAdapter = this.sellingTableAdapter;
            this.tableAdapterManager.SupplyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetStore.PetStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // selling_idTextBox
            // 
            this.selling_idTextBox.Location = new System.Drawing.Point(76, 82);
            this.selling_idTextBox.Name = "selling_idTextBox";
            this.selling_idTextBox.ReadOnly = true;
            this.selling_idTextBox.Size = new System.Drawing.Size(195, 20);
            this.selling_idTextBox.TabIndex = 2;
            // 
            // selling_dateDateTimePicker
            // 
            this.selling_dateDateTimePicker.Location = new System.Drawing.Point(76, 112);
            this.selling_dateDateTimePicker.Name = "selling_dateDateTimePicker";
            this.selling_dateDateTimePicker.Size = new System.Drawing.Size(195, 20);
            this.selling_dateDateTimePicker.TabIndex = 4;
            // 
            // total_priceTextBox
            // 
            this.total_priceTextBox.Location = new System.Drawing.Point(76, 224);
            this.total_priceTextBox.Name = "total_priceTextBox";
            this.total_priceTextBox.Size = new System.Drawing.Size(195, 20);
            this.total_priceTextBox.TabIndex = 6;
            // 
            // buttonForPrintAndSave
            // 
            this.buttonForPrintAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForPrintAndSave.Location = new System.Drawing.Point(42, 273);
            this.buttonForPrintAndSave.Name = "buttonForPrintAndSave";
            this.buttonForPrintAndSave.Size = new System.Drawing.Size(268, 45);
            this.buttonForPrintAndSave.TabIndex = 11;
            this.buttonForPrintAndSave.Text = "ЗБЕРЕГТИ ТА РОЗДРУКУВАТИ";
            this.buttonForPrintAndSave.UseVisualStyleBackColor = true;
            this.buttonForPrintAndSave.Click += new System.EventHandler(this.buttonForPrintAndSave_Click);
            // 
            // buttonForSave
            // 
            this.buttonForSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForSave.Location = new System.Drawing.Point(42, 324);
            this.buttonForSave.Name = "buttonForSave";
            this.buttonForSave.Size = new System.Drawing.Size(268, 45);
            this.buttonForSave.TabIndex = 12;
            this.buttonForSave.Text = "ЗБЕРЕГТИ";
            this.buttonForSave.UseVisualStyleBackColor = true;
            this.buttonForSave.Click += new System.EventHandler(this.buttonForSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selling";
            // 
            // comboBoxForProduct
            // 
            this.comboBoxForProduct.FormattingEnabled = true;
            this.comboBoxForProduct.Location = new System.Drawing.Point(76, 167);
            this.comboBoxForProduct.Name = "comboBoxForProduct";
            this.comboBoxForProduct.Size = new System.Drawing.Size(195, 21);
            this.comboBoxForProduct.TabIndex = 14;
            this.comboBoxForProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxForProduct_SelectedIndexChanged);
            // 
            // comboBoxForClient
            // 
            this.comboBoxForClient.FormattingEnabled = true;
            this.comboBoxForClient.Location = new System.Drawing.Point(76, 194);
            this.comboBoxForClient.Name = "comboBoxForClient";
            this.comboBoxForClient.Size = new System.Drawing.Size(195, 21);
            this.comboBoxForClient.TabIndex = 15;
            this.comboBoxForClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxForClient_SelectedIndexChanged);
            // 
            // textBoxForFullName
            // 
            this.textBoxForFullName.Location = new System.Drawing.Point(371, 194);
            this.textBoxForFullName.Name = "textBoxForFullName";
            this.textBoxForFullName.ReadOnly = true;
            this.textBoxForFullName.Size = new System.Drawing.Size(113, 20);
            this.textBoxForFullName.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Тварина",
            "Корм"});
            this.comboBox1.Location = new System.Drawing.Point(281, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Тип продукту";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(496, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxForFullName);
            this.Controls.Add(this.comboBoxForClient);
            this.Controls.Add(this.comboBoxForProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonForSave);
            this.Controls.Add(this.buttonForPrintAndSave);
            this.Controls.Add(selling_idLabel);
            this.Controls.Add(this.selling_idTextBox);
            this.Controls.Add(selling_dateLabel);
            this.Controls.Add(this.selling_dateDateTimePicker);
            this.Controls.Add(total_priceLabel);
            this.Controls.Add(this.total_priceTextBox);
            this.Controls.Add(product_idLabel);
            this.Controls.Add(client_idLabel);
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource sellingBindingSource;
        private PetStoreDataSetTableAdapters.SellingTableAdapter sellingTableAdapter;
        private PetStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox selling_idTextBox;
        private System.Windows.Forms.DateTimePicker selling_dateDateTimePicker;
        private System.Windows.Forms.TextBox total_priceTextBox;
        private System.Windows.Forms.Button buttonForPrintAndSave;
        private System.Windows.Forms.Button buttonForSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxForProduct;
        private System.Windows.Forms.ComboBox comboBoxForClient;
        private System.Windows.Forms.TextBox textBoxForFullName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}