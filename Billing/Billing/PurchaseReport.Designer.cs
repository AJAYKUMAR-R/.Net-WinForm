namespace Billing
{
    partial class PurchaseReport
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
            this.panelDate = new System.Windows.Forms.Panel();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPrice = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.panelDate.SuspendLayout();
            this.panelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.Transparent;
            this.panelDate.Controls.Add(this.button1);
            this.panelDate.Controls.Add(this.dateTimePicker1);
            this.panelDate.Controls.Add(this.label2);
            this.panelDate.Controls.Add(this.label1);
            this.panelDate.Controls.Add(this.dataGridView1);
            this.panelDate.ForeColor = System.Drawing.Color.Black;
            this.panelDate.Location = new System.Drawing.Point(165, 12);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(809, 451);
            this.panelDate.TabIndex = 5;
            this.panelDate.Visible = false;
            // 
            // panelPrice
            // 
            this.panelPrice.BackColor = System.Drawing.Color.Transparent;
            this.panelPrice.Controls.Add(this.textBoxPrice);
            this.panelPrice.Controls.Add(this.buttonPrice);
            this.panelPrice.Controls.Add(this.label3);
            this.panelPrice.Controls.Add(this.label4);
            this.panelPrice.Controls.Add(this.dataGridViewPrice);
            this.panelPrice.ForeColor = System.Drawing.Color.Black;
            this.panelPrice.Location = new System.Drawing.Point(165, 12);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(812, 451);
            this.panelPrice.TabIndex = 10;
            this.panelPrice.Visible = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(297, 66);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(199, 23);
            this.textBoxPrice.TabIndex = 10;
            // 
            // buttonPrice
            // 
            this.buttonPrice.Location = new System.Drawing.Point(548, 59);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(146, 28);
            this.buttonPrice.TabIndex = 9;
            this.buttonPrice.Text = "Show";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(117, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select the Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(207, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Purchase Details Based On The Price";
            // 
            // dataGridViewPrice
            // 
            this.dataGridViewPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrice.Location = new System.Drawing.Point(29, 107);
            this.dataGridViewPrice.Name = "dataGridViewPrice";
            this.dataGridViewPrice.RowTemplate.Height = 25;
            this.dataGridViewPrice.Size = new System.Drawing.Size(739, 309);
            this.dataGridViewPrice.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(307, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(117, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select the Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Purchase Details Based On The Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(739, 309);
            this.dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(24, 199);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(126, 46);
            this.btnPrice.TabIndex = 7;
            this.btnPrice.Text = "Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 496);
            this.Controls.Add(this.panelPrice);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelDate);
            this.Name = "PurchaseReport";
            this.Text = "PurchaseReport";
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDate;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button btnPrice;
        private Panel panelPrice;
        private TextBox textBoxPrice;
        private Button buttonPrice;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewPrice;
    }
}