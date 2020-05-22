namespace Prelab2
{
    partial class ManagementWindow
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
            this.btnSend = new System.Windows.Forms.Button();
            this.gridManagment = new System.Windows.Forms.DataGridView();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.backgroundProcess = new System.ComponentModel.BackgroundWorker();
            this.progressBarEmail = new System.Windows.Forms.ProgressBar();
            this.lblProcessing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridManagment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Honeydew;
            this.btnSend.Location = new System.Drawing.Point(678, 275);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 35);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gridManagment
            // 
            this.gridManagment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridManagment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsername,
            this.ColumnPassword,
            this.ColumnUsertype,
            this.ColumnEmail});
            this.gridManagment.Location = new System.Drawing.Point(32, 45);
            this.gridManagment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridManagment.Name = "gridManagment";
            this.gridManagment.RowTemplate.Height = 24;
            this.gridManagment.Size = new System.Drawing.Size(612, 266);
            this.gridManagment.TabIndex = 8;
            this.gridManagment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridManagment_CellClick);
            this.gridManagment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridManagment_CellContentClick);
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.HeaderText = "Username";
            this.ColumnUsername.Name = "ColumnUsername";
            this.ColumnUsername.Width = 150;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            this.ColumnPassword.Visible = false;
            this.ColumnPassword.Width = 300;
            // 
            // ColumnUsertype
            // 
            this.ColumnUsertype.HeaderText = "Usertype";
            this.ColumnUsertype.Name = "ColumnUsertype";
            this.ColumnUsertype.Width = 150;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 200;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdate.Location = new System.Drawing.Point(678, 155);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // backgroundProcess
            // 
            this.backgroundProcess.WorkerReportsProgress = true;
            this.backgroundProcess.WorkerSupportsCancellation = true;
            this.backgroundProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundProcess_DoWork);
            this.backgroundProcess.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundProcess_ProgressChanged);
            this.backgroundProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundProcess_RunWorkerCompleted);
            // 
            // progressBarEmail
            // 
            this.progressBarEmail.BackColor = System.Drawing.Color.Honeydew;
            this.progressBarEmail.Location = new System.Drawing.Point(598, 378);
            this.progressBarEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarEmail.Name = "progressBarEmail";
            this.progressBarEmail.Size = new System.Drawing.Size(266, 22);
            this.progressBarEmail.TabIndex = 10;
            this.progressBarEmail.Click += new System.EventHandler(this.progressBarEmail_Click);
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Location = new System.Drawing.Point(694, 355);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(103, 20);
            this.lblProcessing.TabIndex = 11;
            this.lblProcessing.Text = "Processing....";
            this.lblProcessing.Click += new System.EventHandler(this.lblProcessing_Click);
            // 
            // ManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(960, 432);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.progressBarEmail);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gridManagment);
            this.Controls.Add(this.btnSend);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagementWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementWindow_FormClosing);
            this.Load += new System.EventHandler(this.ManagementWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridManagment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridView gridManagment;
        private System.Windows.Forms.Button btnUpdate;
        private System.ComponentModel.BackgroundWorker backgroundProcess;
        private System.Windows.Forms.ProgressBar progressBarEmail;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
    }
}