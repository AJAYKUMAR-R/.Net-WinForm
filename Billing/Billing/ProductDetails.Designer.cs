namespace Billing
{
    partial class ProductDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelpriceinvalid = new System.Windows.Forms.Label();
            this.labestockinvalid = new System.Windows.Forms.Label();
            this.labelproductDescriptioninvalid = new System.Windows.Forms.Label();
            this.labelproductinvalid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textStockUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCatgoriesName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerAddPcat = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(245, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product Management";
            // 
            // labelpriceinvalid
            // 
            this.labelpriceinvalid.AutoSize = true;
            this.labelpriceinvalid.ForeColor = System.Drawing.Color.Red;
            this.labelpriceinvalid.Location = new System.Drawing.Point(396, 404);
            this.labelpriceinvalid.Name = "labelpriceinvalid";
            this.labelpriceinvalid.Size = new System.Drawing.Size(0, 15);
            this.labelpriceinvalid.TabIndex = 25;
            // 
            // labestockinvalid
            // 
            this.labestockinvalid.AutoSize = true;
            this.labestockinvalid.ForeColor = System.Drawing.Color.Red;
            this.labestockinvalid.Location = new System.Drawing.Point(396, 326);
            this.labestockinvalid.Name = "labestockinvalid";
            this.labestockinvalid.Size = new System.Drawing.Size(0, 15);
            this.labestockinvalid.TabIndex = 24;
            // 
            // labelproductDescriptioninvalid
            // 
            this.labelproductDescriptioninvalid.AutoSize = true;
            this.labelproductDescriptioninvalid.ForeColor = System.Drawing.Color.Red;
            this.labelproductDescriptioninvalid.Location = new System.Drawing.Point(396, 248);
            this.labelproductDescriptioninvalid.Name = "labelproductDescriptioninvalid";
            this.labelproductDescriptioninvalid.Size = new System.Drawing.Size(0, 15);
            this.labelproductDescriptioninvalid.TabIndex = 23;
            // 
            // labelproductinvalid
            // 
            this.labelproductinvalid.AutoSize = true;
            this.labelproductinvalid.BackColor = System.Drawing.SystemColors.Control;
            this.labelproductinvalid.ForeColor = System.Drawing.Color.Red;
            this.labelproductinvalid.Location = new System.Drawing.Point(396, 170);
            this.labelproductinvalid.Name = "labelproductinvalid";
            this.labelproductinvalid.Size = new System.Drawing.Size(0, 15);
            this.labelproductinvalid.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Price";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(396, 361);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(186, 23);
            this.textPrice.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Stocks Count";
            // 
            // textStockUnit
            // 
            this.textStockUnit.Location = new System.Drawing.Point(396, 283);
            this.textStockUnit.Name = "textStockUnit";
            this.textStockUnit.Size = new System.Drawing.Size(186, 23);
            this.textStockUnit.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product Categoeries Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textCatgoriesName
            // 
            this.textCatgoriesName.Location = new System.Drawing.Point(396, 211);
            this.textCatgoriesName.Name = "textCatgoriesName";
            this.textCatgoriesName.Size = new System.Drawing.Size(186, 23);
            this.textCatgoriesName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Product Added Date";
            // 
            // dateTimePickerAddPcat
            // 
            this.dateTimePickerAddPcat.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerAddPcat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAddPcat.Location = new System.Drawing.Point(396, 445);
            this.dateTimePickerAddPcat.MinDate = new System.DateTime(2022, 8, 2, 0, 0, 0, 0);
            this.dateTimePickerAddPcat.Name = "dateTimePickerAddPcat";
            this.dateTimePickerAddPcat.Size = new System.Drawing.Size(186, 23);
            this.dateTimePickerAddPcat.TabIndex = 27;
            this.dateTimePickerAddPcat.Value = new System.DateTime(2022, 8, 14, 0, 0, 0, 0);
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(401, 125);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(181, 23);
            this.comboBoxProductName.TabIndex = 28;
            this.comboBoxProductName.SelectedValueChanged += new System.EventHandler(this.comboBoxProductName_SelectedValueChanged);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 714);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.dateTimePickerAddPcat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelpriceinvalid);
            this.Controls.Add(this.labestockinvalid);
            this.Controls.Add(this.labelproductDescriptioninvalid);
            this.Controls.Add(this.labelproductinvalid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textStockUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCatgoriesName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label5;
        private Label labelpriceinvalid;
        private Label labestockinvalid;
        private Label labelproductDescriptioninvalid;
        private Label labelproductinvalid;
        private Label label4;
        private TextBox textPrice;
        private Label label3;
        private TextBox textStockUnit;
        private Label label2;
        private TextBox textCatgoriesName;
        private Label label1;
        private Label label6;
        private DateTimePicker dateTimePickerAddPcat;
        private ComboBox comboBoxProductName;
    }
}