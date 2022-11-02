namespace Billing
{
    partial class UpdateProductForm
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
            this.datagridUpdate = new System.Windows.Forms.DataGridView();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelInvalidproductName = new System.Windows.Forms.Label();
            this.labelinvalidProductStock = new System.Windows.Forms.Label();
            this.labelinvalidProductprice = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridUpdate
            // 
            this.datagridUpdate.AllowUserToAddRows = false;
            this.datagridUpdate.AllowUserToDeleteRows = false;
            this.datagridUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.datagridUpdate.Location = new System.Drawing.Point(0, 0);
            this.datagridUpdate.Name = "datagridUpdate";
            this.datagridUpdate.ReadOnly = true;
            this.datagridUpdate.RowTemplate.Height = 25;
            this.datagridUpdate.Size = new System.Drawing.Size(572, 450);
            this.datagridUpdate.TabIndex = 0;
            this.datagridUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridUpdate_CellContentClick);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(838, 118);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(155, 23);
            this.textBoxProductName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catogeries Name";
            // 
            // textBoxProductStock
            // 
            this.textBoxProductStock.Location = new System.Drawing.Point(838, 180);
            this.textBoxProductStock.Name = "textBoxProductStock";
            this.textBoxProductStock.Size = new System.Drawing.Size(155, 23);
            this.textBoxProductStock.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Stock";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(838, 250);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(155, 23);
            this.textBoxProductPrice.TabIndex = 10;
            this.textBoxProductPrice.TextChanged += new System.EventHandler(this.textBoxProductPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(645, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Search Product Using Categories Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(667, 350);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 34);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(931, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 34);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelInvalidproductName
            // 
            this.labelInvalidproductName.AutoSize = true;
            this.labelInvalidproductName.ForeColor = System.Drawing.Color.Red;
            this.labelInvalidproductName.Location = new System.Drawing.Point(841, 144);
            this.labelInvalidproductName.Name = "labelInvalidproductName";
            this.labelInvalidproductName.Size = new System.Drawing.Size(0, 15);
            this.labelInvalidproductName.TabIndex = 15;
            // 
            // labelinvalidProductStock
            // 
            this.labelinvalidProductStock.AutoSize = true;
            this.labelinvalidProductStock.ForeColor = System.Drawing.Color.Red;
            this.labelinvalidProductStock.Location = new System.Drawing.Point(838, 215);
            this.labelinvalidProductStock.Name = "labelinvalidProductStock";
            this.labelinvalidProductStock.Size = new System.Drawing.Size(0, 15);
            this.labelinvalidProductStock.TabIndex = 17;
            // 
            // labelinvalidProductprice
            // 
            this.labelinvalidProductprice.AutoSize = true;
            this.labelinvalidProductprice.ForeColor = System.Drawing.Color.Red;
            this.labelinvalidProductprice.Location = new System.Drawing.Point(840, 279);
            this.labelinvalidProductprice.Name = "labelinvalidProductprice";
            this.labelinvalidProductprice.Size = new System.Drawing.Size(0, 15);
            this.labelinvalidProductprice.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(793, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 34);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelinvalidProductprice);
            this.Controls.Add(this.labelinvalidProductStock);
            this.Controls.Add(this.labelInvalidproductName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProductStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridUpdate);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProductForm";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridUpdate;
        private TextBox textBoxProductName;
        private Label label2;
        private TextBox textBoxProductStock;
        private Label label4;
        private TextBox textBoxProductPrice;
        private Label label5;
        private Label label6;
        private Button btnSearch;
        private Button btnUpdate;
        private Label labelInvalidproductName;
        private Label labelinvalidProductStock;
        private Label labelinvalidProductprice;
        private Button btnDelete;
    }
}