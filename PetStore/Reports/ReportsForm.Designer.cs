namespace PetStore.Reports
{
    partial class ReportsForm
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
            this.buttonForOld = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonForNew = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new PetStore.PetStoreDataSetTableAdapters.ProductTableAdapter();
            this.sellingTableAdapter = new PetStore.PetStoreDataSetTableAdapters.SellingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonForOld
            // 
            this.buttonForOld.Location = new System.Drawing.Point(12, 94);
            this.buttonForOld.Name = "buttonForOld";
            this.buttonForOld.Size = new System.Drawing.Size(113, 60);
            this.buttonForOld.TabIndex = 0;
            this.buttonForOld.Text = "РОЗДРУКУВАТИ ЧЄК ІСНУЧОЇ ПРОДАЖІ";
            this.buttonForOld.UseVisualStyleBackColor = true;
            this.buttonForOld.Click += new System.EventHandler(this.buttonForOld_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 108);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sellingBindingSource;
            this.comboBox1.DisplayMember = "Selling_id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Selling_id";
            // 
            // sellingBindingSource
            // 
            this.sellingBindingSource.DataMember = "Selling";
            this.sellingBindingSource.DataSource = this.petStoreDataSet;
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ДРУК ЧЄКА";
            // 
            // buttonForNew
            // 
            this.buttonForNew.Location = new System.Drawing.Point(163, 94);
            this.buttonForNew.Name = "buttonForNew";
            this.buttonForNew.Size = new System.Drawing.Size(117, 90);
            this.buttonForNew.TabIndex = 4;
            this.buttonForNew.Text = "СТВОРИТИ ТА РОЗДРУКУВАТИ ЧЄК ДЛЯ НОВОГО ПРОДАЖУ";
            this.buttonForNew.UseVisualStyleBackColor = true;
            this.buttonForNew.Click += new System.EventHandler(this.buttonForNew_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.petStoreDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // sellingTableAdapter
            // 
            this.sellingTableAdapter.ClearBeforeFill = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 338);
            this.Controls.Add(this.buttonForNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonForOld);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForOld;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonForNew;
        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private PetStoreDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource sellingBindingSource;
        private PetStoreDataSetTableAdapters.SellingTableAdapter sellingTableAdapter;
    }
}