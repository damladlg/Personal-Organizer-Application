namespace Prelab2
{
    partial class SalaryCalculator
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
            this.lblMy = new System.Windows.Forms.Label();
            this.lblFamilyStatus = new System.Windows.Forms.Label();
            this.lblManagement = new System.Windows.Forms.Label();
            this.lblForeignLanguage = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.cBoxExperience = new System.Windows.Forms.ComboBox();
            this.cBoxProvince = new System.Windows.Forms.ComboBox();
            this.cBoxEducation = new System.Windows.Forms.ComboBox();
            this.cBoxForeignLanguage = new System.Windows.Forms.ComboBox();
            this.cBoxManagement = new System.Windows.Forms.ComboBox();
            this.listBoxFamilyStatus = new System.Windows.Forms.ListBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblYourSalary = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMy
            // 
            this.lblMy.AutoSize = true;
            this.lblMy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMy.Location = new System.Drawing.Point(38, 36);
            this.lblMy.Name = "lblMy";
            this.lblMy.Size = new System.Drawing.Size(128, 17);
            this.lblMy.TabIndex = 46;
            this.lblMy.Text = "Your Information";
            // 
            // lblFamilyStatus
            // 
            this.lblFamilyStatus.AutoSize = true;
            this.lblFamilyStatus.Location = new System.Drawing.Point(38, 226);
            this.lblFamilyStatus.Name = "lblFamilyStatus";
            this.lblFamilyStatus.Size = new System.Drawing.Size(72, 13);
            this.lblFamilyStatus.TabIndex = 45;
            this.lblFamilyStatus.Text = "Family Status:";
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Location = new System.Drawing.Point(38, 194);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(99, 13);
            this.lblManagement.TabIndex = 44;
            this.lblManagement.Text = "Management Task:";
            // 
            // lblForeignLanguage
            // 
            this.lblForeignLanguage.AutoSize = true;
            this.lblForeignLanguage.Location = new System.Drawing.Point(38, 162);
            this.lblForeignLanguage.Name = "lblForeignLanguage";
            this.lblForeignLanguage.Size = new System.Drawing.Size(96, 13);
            this.lblForeignLanguage.TabIndex = 43;
            this.lblForeignLanguage.Text = "Foreign Language:";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(38, 130);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(58, 13);
            this.lblEducation.TabIndex = 42;
            this.lblEducation.Text = "Education:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(38, 103);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 41;
            this.lblProvince.Text = "Province:";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(38, 71);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(63, 13);
            this.lblExperience.TabIndex = 40;
            this.lblExperience.Text = "Experience:";
            // 
            // cBoxExperience
            // 
            this.cBoxExperience.FormattingEnabled = true;
            this.cBoxExperience.Items.AddRange(new object[] {
            "0-2 years",
            "2-4 years",
            "5-9 years",
            "10-14 years",
            "15-20 years",
            "Over 20 years"});
            this.cBoxExperience.Location = new System.Drawing.Point(140, 68);
            this.cBoxExperience.Name = "cBoxExperience";
            this.cBoxExperience.Size = new System.Drawing.Size(144, 21);
            this.cBoxExperience.TabIndex = 47;
            // 
            // cBoxProvince
            // 
            this.cBoxProvince.FormattingEnabled = true;
            this.cBoxProvince.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Kocaeli,Sakarya,Düzce,Bolu,Yalova",
            "Edirne,Kırklareli,Tekirdağ",
            "Trabzon,Ordu,Giresun,Rize,Artvin,Gümüşhane",
            "Bursa,Eskişehir,Bilecik",
            "Aydın,Denizli,Muğla",
            "Adana,Mersin",
            "Balıkesir,Çanakkale",
            "Antalya,Isparta,Burdur",
            "Other"});
            this.cBoxProvince.Location = new System.Drawing.Point(140, 99);
            this.cBoxProvince.Name = "cBoxProvince";
            this.cBoxProvince.Size = new System.Drawing.Size(144, 21);
            this.cBoxProvince.TabIndex = 48;
            // 
            // cBoxEducation
            // 
            this.cBoxEducation.FormattingEnabled = true;
            this.cBoxEducation.Items.AddRange(new object[] {
            "Vocational master\'s degree",
            "Doctorate about profession",
            "Professorship related to profession",
            "Non-professional master\'s degree",
            "PhD / associate professorship not related to the profession"});
            this.cBoxEducation.Location = new System.Drawing.Point(140, 127);
            this.cBoxEducation.Name = "cBoxEducation";
            this.cBoxEducation.Size = new System.Drawing.Size(144, 21);
            this.cBoxEducation.TabIndex = 49;
            // 
            // cBoxForeignLanguage
            // 
            this.cBoxForeignLanguage.FormattingEnabled = true;
            this.cBoxForeignLanguage.Items.AddRange(new object[] {
            "Documented English knowledge",
            "English language school graduation",
            "Other documented foreign language knowledge"});
            this.cBoxForeignLanguage.Location = new System.Drawing.Point(140, 159);
            this.cBoxForeignLanguage.Name = "cBoxForeignLanguage";
            this.cBoxForeignLanguage.Size = new System.Drawing.Size(144, 21);
            this.cBoxForeignLanguage.TabIndex = 50;
            // 
            // cBoxManagement
            // 
            this.cBoxManagement.FormattingEnabled = true;
            this.cBoxManagement.Items.AddRange(new object[] {
            "No",
            "TeamLeader/GroupManager/TechnicalManager/Software/Architect",
            "Project Manager",
            "Director/ProjectsManager",
            "CTO/GeneralManager",
            "IT Manager/Manager(-5)",
            "IT Manager/Manager(+5)"});
            this.cBoxManagement.Location = new System.Drawing.Point(140, 191);
            this.cBoxManagement.Name = "cBoxManagement";
            this.cBoxManagement.Size = new System.Drawing.Size(144, 21);
            this.cBoxManagement.TabIndex = 51;
            // 
            // listBoxFamilyStatus
            // 
            this.listBoxFamilyStatus.FormattingEnabled = true;
            this.listBoxFamilyStatus.Items.AddRange(new object[] {
            "Not married",
            "Married and spouse not working",
            "0-6 year old child",
            "7-18 year old child",
            "Child over 18"});
            this.listBoxFamilyStatus.Location = new System.Drawing.Point(141, 226);
            this.listBoxFamilyStatus.Name = "listBoxFamilyStatus";
            this.listBoxFamilyStatus.Size = new System.Drawing.Size(143, 69);
            this.listBoxFamilyStatus.TabIndex = 52;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalary.Location = new System.Drawing.Point(439, 335);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(14, 17);
            this.lblSalary.TabIndex = 54;
            this.lblSalary.Text = "-";
            // 
            // lblYourSalary
            // 
            this.lblYourSalary.AutoSize = true;
            this.lblYourSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYourSalary.Location = new System.Drawing.Point(318, 335);
            this.lblYourSalary.Name = "lblYourSalary";
            this.lblYourSalary.Size = new System.Drawing.Size(115, 17);
            this.lblYourSalary.TabIndex = 55;
            this.lblYourSalary.Text = "Your Salary Is:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdate.Location = new System.Drawing.Point(140, 332);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 23);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Honeydew;
            this.btnCalculate.Location = new System.Drawing.Point(218, 332);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(65, 23);
            this.btnCalculate.TabIndex = 57;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // SalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(546, 409);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblYourSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.listBoxFamilyStatus);
            this.Controls.Add(this.cBoxManagement);
            this.Controls.Add(this.cBoxForeignLanguage);
            this.Controls.Add(this.cBoxEducation);
            this.Controls.Add(this.cBoxProvince);
            this.Controls.Add(this.cBoxExperience);
            this.Controls.Add(this.lblMy);
            this.Controls.Add(this.lblFamilyStatus);
            this.Controls.Add(this.lblManagement);
            this.Controls.Add(this.lblForeignLanguage);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblExperience);
            this.Name = "SalaryCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryCalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalaryCalculator_FormClosing);
            this.Load += new System.EventHandler(this.SalaryCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMy;
        private System.Windows.Forms.Label lblFamilyStatus;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Label lblForeignLanguage;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.ComboBox cBoxExperience;
        private System.Windows.Forms.ComboBox cBoxProvince;
        private System.Windows.Forms.ComboBox cBoxEducation;
        private System.Windows.Forms.ComboBox cBoxForeignLanguage;
        private System.Windows.Forms.ComboBox cBoxManagement;
        private System.Windows.Forms.ListBox listBoxFamilyStatus;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblYourSalary;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCalculate;
    }
}