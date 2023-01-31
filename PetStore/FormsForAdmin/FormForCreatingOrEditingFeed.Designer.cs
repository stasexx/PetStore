namespace PetStore.FormsForAdmin
{
    partial class FormForCreatingOrEditingFeed
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
            System.Windows.Forms.Label feed_idLabel;
            System.Windows.Forms.Label feed_nameLabel;
            System.Windows.Forms.Label caloricLabel;
            System.Windows.Forms.Label kindLabel;
            System.Windows.Forms.Label purposeLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label label2;
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.feedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedTableAdapter = new PetStore.PetStoreDataSetTableAdapters.FeedTableAdapter();
            this.tableAdapterManager = new PetStore.PetStoreDataSetTableAdapters.TableAdapterManager();
            this.feed_nameTextBox = new System.Windows.Forms.TextBox();
            this.caloricTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxForIdFeed = new System.Windows.Forms.ComboBox();
            this.comboBoxForKind = new System.Windows.Forms.ComboBox();
            this.comboBoxPurpose = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            feed_idLabel = new System.Windows.Forms.Label();
            feed_nameLabel = new System.Windows.Forms.Label();
            caloricLabel = new System.Windows.Forms.Label();
            kindLabel = new System.Windows.Forms.Label();
            purposeLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // feed_idLabel
            // 
            feed_idLabel.AutoSize = true;
            feed_idLabel.Location = new System.Drawing.Point(35, 108);
            feed_idLabel.Name = "feed_idLabel";
            feed_idLabel.Size = new System.Drawing.Size(45, 13);
            feed_idLabel.TabIndex = 1;
            feed_idLabel.Text = "Feed id:";
            // 
            // feed_nameLabel
            // 
            feed_nameLabel.AutoSize = true;
            feed_nameLabel.Location = new System.Drawing.Point(35, 134);
            feed_nameLabel.Name = "feed_nameLabel";
            feed_nameLabel.Size = new System.Drawing.Size(63, 13);
            feed_nameLabel.TabIndex = 3;
            feed_nameLabel.Text = "Feed name:";
            // 
            // caloricLabel
            // 
            caloricLabel.AutoSize = true;
            caloricLabel.Location = new System.Drawing.Point(35, 160);
            caloricLabel.Name = "caloricLabel";
            caloricLabel.Size = new System.Drawing.Size(42, 13);
            caloricLabel.TabIndex = 5;
            caloricLabel.Text = "Caloric:";
            // 
            // kindLabel
            // 
            kindLabel.AutoSize = true;
            kindLabel.Location = new System.Drawing.Point(35, 186);
            kindLabel.Name = "kindLabel";
            kindLabel.Size = new System.Drawing.Size(31, 13);
            kindLabel.TabIndex = 7;
            kindLabel.Text = "Kind:";
            // 
            // purposeLabel
            // 
            purposeLabel.AutoSize = true;
            purposeLabel.Location = new System.Drawing.Point(35, 212);
            purposeLabel.Name = "purposeLabel";
            purposeLabel.Size = new System.Drawing.Size(49, 13);
            purposeLabel.TabIndex = 9;
            purposeLabel.Text = "Purpose:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(35, 264);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 13;
            costLabel.Text = "Cost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 240);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 20;
            label2.Text = "Discount:";
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.SupplyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetStore.PetStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // feed_nameTextBox
            // 
            this.feed_nameTextBox.Location = new System.Drawing.Point(121, 131);
            this.feed_nameTextBox.Name = "feed_nameTextBox";
            this.feed_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.feed_nameTextBox.TabIndex = 4;
            // 
            // caloricTextBox
            // 
            this.caloricTextBox.Location = new System.Drawing.Point(121, 157);
            this.caloricTextBox.Name = "caloricTextBox";
            this.caloricTextBox.Size = new System.Drawing.Size(200, 20);
            this.caloricTextBox.TabIndex = 6;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(121, 261);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 20);
            this.costTextBox.TabIndex = 14;
            // 
            // comboBoxForIdFeed
            // 
            this.comboBoxForIdFeed.AllowDrop = true;
            this.comboBoxForIdFeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForIdFeed.FormattingEnabled = true;
            this.comboBoxForIdFeed.Location = new System.Drawing.Point(121, 104);
            this.comboBoxForIdFeed.Name = "comboBoxForIdFeed";
            this.comboBoxForIdFeed.Size = new System.Drawing.Size(198, 21);
            this.comboBoxForIdFeed.TabIndex = 15;
            // 
            // comboBoxForKind
            // 
            this.comboBoxForKind.FormattingEnabled = true;
            this.comboBoxForKind.Items.AddRange(new object[] {
            "М\'ясо",
            "Трава"});
            this.comboBoxForKind.Location = new System.Drawing.Point(121, 183);
            this.comboBoxForKind.Name = "comboBoxForKind";
            this.comboBoxForKind.Size = new System.Drawing.Size(198, 21);
            this.comboBoxForKind.TabIndex = 16;
            // 
            // comboBoxPurpose
            // 
            this.comboBoxPurpose.FormattingEnabled = true;
            this.comboBoxPurpose.Location = new System.Drawing.Point(121, 208);
            this.comboBoxPurpose.Name = "comboBoxPurpose";
            this.comboBoxPurpose.Size = new System.Drawing.Size(198, 21);
            this.comboBoxPurpose.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Feed";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(121, 235);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(200, 20);
            this.textBoxDiscount.TabIndex = 21;
            // 
            // FormForCreatingOrEditingFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(387, 454);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPurpose);
            this.Controls.Add(this.comboBoxForKind);
            this.Controls.Add(this.comboBoxForIdFeed);
            this.Controls.Add(feed_idLabel);
            this.Controls.Add(feed_nameLabel);
            this.Controls.Add(this.feed_nameTextBox);
            this.Controls.Add(caloricLabel);
            this.Controls.Add(this.caloricTextBox);
            this.Controls.Add(kindLabel);
            this.Controls.Add(purposeLabel);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Name = "FormForCreatingOrEditingFeed";
            this.Text = "FormForCreatingOrEditingFeed";
            this.Load += new System.EventHandler(this.FormForCreatingOrEditingFeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource feedBindingSource;
        private PetStoreDataSetTableAdapters.FeedTableAdapter feedTableAdapter;
        private PetStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox feed_nameTextBox;
        private System.Windows.Forms.TextBox caloricTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.ComboBox comboBoxForIdFeed;
        private System.Windows.Forms.ComboBox comboBoxForKind;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDiscount;
    }
}