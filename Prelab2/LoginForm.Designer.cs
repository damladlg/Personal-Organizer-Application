namespace Prelab2
{
    partial class LoginForm
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
            this.EntryTime = new System.Windows.Forms.Timer(this.components);
            this.passwordlabel = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.remembercheckBox = new System.Windows.Forms.CheckBox();
            this.Signup = new System.Windows.Forms.Button();
            this.signuplabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EntryTime
            // 
            this.EntryTime.Interval = 3000;
            this.EntryTime.Tick += new System.EventHandler(this.EntryTime_Tick);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordlabel.Location = new System.Drawing.Point(45, 128);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(104, 25);
            this.passwordlabel.TabIndex = 4;
            this.passwordlabel.Text = "Password:";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Location = new System.Drawing.Point(184, 211);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(142, 38);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernamelabel.Location = new System.Drawing.Point(45, 82);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(108, 25);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Login Application";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infolabel.Location = new System.Drawing.Point(45, 358);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(145, 29);
            this.infolabel.TabIndex = 9;
            this.infolabel.Text = "Information";
            this.infolabel.Visible = false;
            // 
            // remembercheckBox
            // 
            this.remembercheckBox.AutoSize = true;
            this.remembercheckBox.Location = new System.Drawing.Point(184, 158);
            this.remembercheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remembercheckBox.Name = "remembercheckBox";
            this.remembercheckBox.Size = new System.Drawing.Size(140, 24);
            this.remembercheckBox.TabIndex = 10;
            this.remembercheckBox.Text = "Remember Me";
            this.remembercheckBox.UseVisualStyleBackColor = true;
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Signup.Location = new System.Drawing.Point(261, 294);
            this.Signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(82, 35);
            this.Signup.TabIndex = 11;
            this.Signup.Text = "Sign Up";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // signuplabel
            // 
            this.signuplabel.AutoSize = true;
            this.signuplabel.Location = new System.Drawing.Point(46, 302);
            this.signuplabel.Name = "signuplabel";
            this.signuplabel.Size = new System.Drawing.Size(202, 20);
            this.signuplabel.TabIndex = 12;
            this.signuplabel.Text = "Don\'t have an account yet?";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(184, 82);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(140, 26);
            this.usernameBox.TabIndex = 13;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(184, 115);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(140, 26);
            this.passwordBox.TabIndex = 14;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(717, 465);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.signuplabel);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.remembercheckBox);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.login);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer EntryTime;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.CheckBox remembercheckBox;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Label signuplabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
    }
}

