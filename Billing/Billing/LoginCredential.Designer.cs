namespace Billing
{
    partial class LoginCredential
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCredential));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textuserpassword = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(468, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter User name";
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(627, 157);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(211, 23);
            this.textusername.TabIndex = 3;
            // 
            // textuserpassword
            // 
            this.textuserpassword.Location = new System.Drawing.Point(627, 215);
            this.textuserpassword.Name = "textuserpassword";
            this.textuserpassword.Size = new System.Drawing.Size(211, 23);
            this.textuserpassword.TabIndex = 4;
            this.textuserpassword.UseSystemPasswordChar = true;
            this.textuserpassword.TextChanged += new System.EventHandler(this.textuserpassword_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(492, 301);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(116, 40);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(58, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 288);
            this.panel1.TabIndex = 6;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(689, 301);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(116, 40);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            this.btnregister.MouseLeave += new System.EventHandler(this.btnregister_MouseLeave);
            this.btnregister.MouseHover += new System.EventHandler(this.btnregister_MouseHover);
            // 
            // LoginCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textuserpassword);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginCredential";
            this.Text = "LoginCredential";
            this.Load += new System.EventHandler(this.LoginCredential_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textusername;
        private TextBox textuserpassword;
        private Button Login;
        private Panel panel1;
        private Button btnregister;
    }
}