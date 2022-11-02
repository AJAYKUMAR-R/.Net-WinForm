namespace Billing
{
    partial class NewProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxproductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerbtnProductDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewNewProduct = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // textBoxproductName
            // 
            this.textBoxproductName.Location = new System.Drawing.Point(247, 156);
            this.textBoxproductName.Name = "textBoxproductName";
            this.textBoxproductName.Size = new System.Drawing.Size(196, 23);
            this.textBoxproductName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Date";
            // 
            // dateTimePickerbtnProductDate
            // 
            this.dateTimePickerbtnProductDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerbtnProductDate.Location = new System.Drawing.Point(243, 233);
            this.dateTimePickerbtnProductDate.MinDate = new System.DateTime(2022, 8, 14, 0, 0, 0, 0);
            this.dateTimePickerbtnProductDate.Name = "dateTimePickerbtnProductDate";
            this.dateTimePickerbtnProductDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerbtnProductDate.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "New Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewNewProduct
            // 
            this.dataGridViewNewProduct.AllowUserToAddRows = false;
            this.dataGridViewNewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewNewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewNewProduct.Location = new System.Drawing.Point(512, 0);
            this.dataGridViewNewProduct.Name = "dataGridViewNewProduct";
            this.dataGridViewNewProduct.ReadOnly = true;
            this.dataGridViewNewProduct.RowTemplate.Height = 25;
            this.dataGridViewNewProduct.Size = new System.Drawing.Size(586, 450);
            this.dataGridViewNewProduct.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 41);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete New Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewNewProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerbtnProductDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxproductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProductForm";
            this.Text = "NewProductForm";
            this.Load += new System.EventHandler(this.NewProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxproductName;
        private Label label3;
        private DateTimePicker dateTimePickerbtnProductDate;
        private Button button1;
        private DataGridView dataGridViewNewProduct;
        private Button btnDelete;
    }
}