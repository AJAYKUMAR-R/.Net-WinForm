namespace Billing
{
    partial class UserRegister_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textmobile = new System.Windows.Forms.TextBox();
            this.textsingup = new System.Windows.Forms.Button();
            this.labelinvalidUser = new System.Windows.Forms.Label();
            this.labelinvalidemail = new System.Windows.Forms.Label();
            this.labelinvalidpassword = new System.Windows.Forms.Label();
            this.labelinvalidmobile = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(250, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User or Admin Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter The UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Mobile No";
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(322, 113);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(355, 23);
            this.textuser.TabIndex = 5;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(322, 178);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(355, 23);
            this.textpassword.TabIndex = 7;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // textmobile
            // 
            this.textmobile.Location = new System.Drawing.Point(322, 256);
            this.textmobile.Name = "textmobile";
            this.textmobile.Size = new System.Drawing.Size(355, 23);
            this.textmobile.TabIndex = 8;
            // 
            // textsingup
            // 
            this.textsingup.Location = new System.Drawing.Point(312, 423);
            this.textsingup.Name = "textsingup";
            this.textsingup.Size = new System.Drawing.Size(150, 41);
            this.textsingup.TabIndex = 9;
            this.textsingup.Text = "Sign Up";
            this.textsingup.UseVisualStyleBackColor = true;
            this.textsingup.Click += new System.EventHandler(this.textsingup_Click);
            // 
            // labelinvalidUser
            // 
            this.labelinvalidUser.AutoSize = true;
            this.labelinvalidUser.ForeColor = System.Drawing.Color.Red;
            this.labelinvalidUser.Location = new System.Drawing.Point(323, 146);
            this.labelinvalidUser.Name = "labelinvalidUser";
            this.labelinvalidUser.Size = new System.Drawing.Size(0, 15);
            this.labelinvalidUser.TabIndex = 10;
            // 
            // labelinvalidemail
            // 
            this.labelinvalidemail.AutoSize = true;
            this.labelinvalidemail.ForeColor = System.Drawing.Color.Red;
            this.labelinvalidemail.Location = new System.Drawing.Point(322, 204);
            this.labelinvalidemail.Name = "labelinvalidemail";
            this.labelinvalidemail.Size = new System.Drawing.Size(0, 15);
            this.labelinvalidemail.TabIndex = 11;
            // 
            // labelinvalidpassword
            // 
            this.labelinvalidpassword.AutoSize = true;
            this.labelinvalidpassword.ForeColor = System.Drawing.Color.Red;
            this.labelinvalidpassword.Location = new System.Drawing.Point(323, 216);
            this.labelinvalidpassword.Name = "labelinvalidpassword";
            this.labelinvalidpassword.Size = new System.Drawing.Size(0, 15);
            this.labelinvalidpassword.TabIndex = 12;
            // 
            // labelinvalidmobile
            // 
            this.labelinvalidmobile.AutoSize = true;
            this.labelinvalidmobile.ForeColor = System.Drawing.Color.Red;
            this.labelinvalidmobile.Location = new System.Drawing.Point(323, 294);
            this.labelinvalidmobile.Name = "labelinvalidmobile";
            this.labelinvalidmobile.Size = new System.Drawing.Size(0, 15);
            this.labelinvalidmobile.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = " No special charcter number and alphabets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Select Role";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.comboBoxRole.Location = new System.Drawing.Point(323, 325);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(155, 23);
            this.comboBoxRole.TabIndex = 16;
            // 
            // UserRegister_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelinvalidmobile);
            this.Controls.Add(this.labelinvalidpassword);
            this.Controls.Add(this.labelinvalidemail);
            this.Controls.Add(this.labelinvalidUser);
            this.Controls.Add(this.textsingup);
            this.Controls.Add(this.textmobile);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserRegister_Form";
            this.Text = "UserRegister_Form";
            this.Load += new System.EventHandler(this.UserRegister_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textuser;
        private TextBox textpassword;
        private TextBox textmobile;
        private Button textsingup;
        private Label labelinvalidUser;
        private Label labelinvalidemail;
        private Label labelinvalidpassword;
        private Label labelinvalidmobile;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxRole;
    }
}