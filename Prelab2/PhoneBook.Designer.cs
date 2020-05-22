namespace Prelab2
{
    partial class PhoneBook
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
            this.DeleteBttn = new System.Windows.Forms.Button();
            this.UpdateBttn = new System.Windows.Forms.Button();
            this.CreateBttn = new System.Windows.Forms.Button();
            this.MailLbl = new System.Windows.Forms.Label();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.NumberLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.PhoneNumBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.gridPhonebk = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhonebk)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.BackColor = System.Drawing.Color.Honeydew;
            this.DeleteBttn.Location = new System.Drawing.Point(321, 83);
            this.DeleteBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(63, 23);
            this.DeleteBttn.TabIndex = 40;
            this.DeleteBttn.Text = "Delete";
            this.DeleteBttn.UseVisualStyleBackColor = false;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteBttn_Click);
            // 
            // UpdateBttn
            // 
            this.UpdateBttn.BackColor = System.Drawing.Color.Honeydew;
            this.UpdateBttn.Location = new System.Drawing.Point(188, 81);
            this.UpdateBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateBttn.Name = "UpdateBttn";
            this.UpdateBttn.Size = new System.Drawing.Size(68, 25);
            this.UpdateBttn.TabIndex = 39;
            this.UpdateBttn.Text = "Update";
            this.UpdateBttn.UseVisualStyleBackColor = false;
            this.UpdateBttn.Click += new System.EventHandler(this.UpdateBttn_Click);
            // 
            // CreateBttn
            // 
            this.CreateBttn.BackColor = System.Drawing.Color.Honeydew;
            this.CreateBttn.Location = new System.Drawing.Point(61, 81);
            this.CreateBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateBttn.Name = "CreateBttn";
            this.CreateBttn.Size = new System.Drawing.Size(58, 25);
            this.CreateBttn.TabIndex = 38;
            this.CreateBttn.Text = "Create";
            this.CreateBttn.UseVisualStyleBackColor = false;
            this.CreateBttn.Click += new System.EventHandler(this.CreateBttn_Click);
            // 
            // MailLbl
            // 
            this.MailLbl.AutoSize = true;
            this.MailLbl.Location = new System.Drawing.Point(411, 32);
            this.MailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MailLbl.Name = "MailLbl";
            this.MailLbl.Size = new System.Drawing.Size(38, 13);
            this.MailLbl.TabIndex = 29;
            this.MailLbl.Text = "E-mail:";
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(489, 32);
            this.MailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(68, 20);
            this.MailBox.TabIndex = 35;
            this.MailBox.Leave += new System.EventHandler(this.MailBox_Leave);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(411, 14);
            this.DescriptionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 28;
            this.DescriptionLbl.Text = "Description:";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(226, 14);
            this.AddressLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(48, 13);
            this.AddressLbl.TabIndex = 27;
            this.AddressLbl.Text = "Address:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(489, 12);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(68, 20);
            this.DescriptionBox.TabIndex = 34;
            // 
            // NumberLbl
            // 
            this.NumberLbl.AutoSize = true;
            this.NumberLbl.Location = new System.Drawing.Point(8, 52);
            this.NumberLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(81, 13);
            this.NumberLbl.TabIndex = 26;
            this.NumberLbl.Text = "Phone Number:";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(8, 32);
            this.SurnameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(52, 13);
            this.SurnameLbl.TabIndex = 25;
            this.SurnameLbl.Text = "Surname:";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(283, 14);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(101, 58);
            this.AddressBox.TabIndex = 33;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(8, 14);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 24;
            this.NameLbl.Text = "Name:";
            // 
            // PhoneNumBox
            // 
            this.PhoneNumBox.Location = new System.Drawing.Point(117, 53);
            this.PhoneNumBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneNumBox.Name = "PhoneNumBox";
            this.PhoneNumBox.Size = new System.Drawing.Size(68, 20);
            this.PhoneNumBox.TabIndex = 32;
            this.PhoneNumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumBox_KeyPress);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(117, 32);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(68, 20);
            this.SurnameBox.TabIndex = 31;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(117, 12);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(68, 20);
            this.NameBox.TabIndex = 30;
            // 
            // gridPhonebk
            // 
            this.gridPhonebk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhonebk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnPhoneNum,
            this.ColumnEmail,
            this.ColumnDescrp,
            this.ColumnAddress});
            this.gridPhonebk.Location = new System.Drawing.Point(10, 122);
            this.gridPhonebk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridPhonebk.Name = "gridPhonebk";
            this.gridPhonebk.RowTemplate.Height = 24;
            this.gridPhonebk.Size = new System.Drawing.Size(483, 263);
            this.gridPhonebk.TabIndex = 43;
            this.gridPhonebk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhonebk_CellClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "Surname";
            this.ColumnSurname.Name = "ColumnSurname";
            // 
            // ColumnPhoneNum
            // 
            this.ColumnPhoneNum.HeaderText = "PhoneNumber";
            this.ColumnPhoneNum.Name = "ColumnPhoneNum";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnDescrp
            // 
            this.ColumnDescrp.HeaderText = "Description";
            this.ColumnDescrp.Name = "ColumnDescrp";
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // PhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(725, 395);
            this.Controls.Add(this.gridPhonebk);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.UpdateBttn);
            this.Controls.Add(this.CreateBttn);
            this.Controls.Add(this.MailLbl);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.NumberLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.PhoneNumBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PhoneBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhoneBook_FormClosing);
            this.Load += new System.EventHandler(this.PhoneBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhonebk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteBttn;
        private System.Windows.Forms.Button UpdateBttn;
        private System.Windows.Forms.Button CreateBttn;
        private System.Windows.Forms.Label MailLbl;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox PhoneNumBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.DataGridView gridPhonebk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
    }
}