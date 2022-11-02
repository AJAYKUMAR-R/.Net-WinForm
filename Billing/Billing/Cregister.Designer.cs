namespace Billing
{
    partial class Cregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cregister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.mobileno = new System.Windows.Forms.TextBox();
            this.useremail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.useraddress = new System.Windows.Forms.RichTextBox();
            this.labeluserinvalid = new System.Windows.Forms.Label();
            this.labelemailinvalid = new System.Windows.Forms.Label();
            this.labelinvalidmobile = new System.Windows.Forms.Label();
            this.labelinvalidadress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(549, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(458, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(457, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mobile No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(458, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(626, 91);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 23);
            this.username.TabIndex = 4;
            // 
            // mobileno
            // 
            this.mobileno.Location = new System.Drawing.Point(626, 219);
            this.mobileno.Name = "mobileno";
            this.mobileno.Size = new System.Drawing.Size(200, 23);
            this.mobileno.TabIndex = 5;
            // 
            // useremail
            // 
            this.useremail.Location = new System.Drawing.Point(626, 155);
            this.useremail.Name = "useremail";
            this.useremail.Size = new System.Drawing.Size(200, 23);
            this.useremail.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(54, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 294);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(458, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(458, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // useraddress
            // 
            this.useraddress.Location = new System.Drawing.Point(626, 283);
            this.useraddress.Name = "useraddress";
            this.useraddress.Size = new System.Drawing.Size(200, 96);
            this.useraddress.TabIndex = 10;
            this.useraddress.Text = "";
            // 
            // labeluserinvalid
            // 
            this.labeluserinvalid.AutoSize = true;
            this.labeluserinvalid.ForeColor = System.Drawing.Color.Red;
            this.labeluserinvalid.Location = new System.Drawing.Point(629, 127);
            this.labeluserinvalid.Name = "labeluserinvalid";
            this.labeluserinvalid.Size = new System.Drawing.Size(0, 15);
            this.labeluserinvalid.TabIndex = 11;
            // 
            // labelemailinvalid
            // 
            this.labelemailinvalid.AutoSize = true;
            this.labelemailinvalid.ForeColor = System.Drawing.Color.Red;
            this.labelemailinvalid.Location = new System.Drawing.Point(626, 191);
            this.labelemailinvalid.Name = "labelemailinvalid";
            this.labelemailinvalid.Size = new System.Drawing.Size(0, 15);
            this.labelemailinvalid.TabIndex = 12;
            // 
            // labelinvalidmobile
            // 
            this.labelinvalidmobile.AutoSize = true;
            this.labelinvalidmobile.ForeColor = System.Drawing.Color.Red;
            this.labelinvalidmobile.Location = new System.Drawing.Point(629, 255);
            this.labelinvalidmobile.Name = "labelinvalidmobile";
            this.labelinvalidmobile.Size = new System.Drawing.Size(0, 15);
            this.labelinvalidmobile.TabIndex = 13;
            // 
            // labelinvalidadress
            // 
            this.labelinvalidadress.AutoSize = true;
            this.labelinvalidadress.ForeColor = System.Drawing.Color.Red;
            this.labelinvalidadress.Location = new System.Drawing.Point(626, 392);
            this.labelinvalidadress.Name = "labelinvalidadress";
            this.labelinvalidadress.Size = new System.Drawing.Size(0, 15);
            this.labelinvalidadress.TabIndex = 14;
            // 
            // Cregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 498);
            this.Controls.Add(this.labelinvalidadress);
            this.Controls.Add(this.labelinvalidmobile);
            this.Controls.Add(this.labelemailinvalid);
            this.Controls.Add(this.labeluserinvalid);
            this.Controls.Add(this.useraddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.useremail);
            this.Controls.Add(this.mobileno);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cregister";
            this.Text = "Cregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox username;
        private TextBox mobileno;
        private TextBox useremail;
        private Panel panel1;
        private Button button1;
        private Label label5;
        private RichTextBox useraddress;
        private Label labeluserinvalid;
        private Label labelemailinvalid;
        private Label labelinvalidmobile;
        private Label labelinvalidadress;
    }
}