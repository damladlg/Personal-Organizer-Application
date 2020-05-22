using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prelab2
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        private void SalaryCalculator_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < User.salaryInfoList.Count(); i++)
            {
                if (User.salaryInfoList[i].Username == LoginedUser.getInstance().User.Username)
                {
                    cBoxExperience.Text = User.salaryInfoList[i].Experience;
                    cBoxProvince.Text = User.salaryInfoList[i].Province;
                    cBoxEducation.Text = User.salaryInfoList[i].Education;
                    cBoxForeignLanguage.Text = User.salaryInfoList[i].ForeignLanguage;
                    cBoxManagement.Text = User.salaryInfoList[i].ManagmentTask;
                    listBoxFamilyStatus.Text = User.salaryInfoList[i].FamilyStatus;
                }
            }
            btnCalculate.Visible = false;
            btnUpdate.Visible = false;
            if (cBoxExperience.Text == "" && cBoxProvince.Text == "" && cBoxEducation.Text == "" && cBoxForeignLanguage.Text == "" && cBoxManagement.Text == "" && listBoxFamilyStatus.Text == "")
            {
                btnCalculate.Visible = true;
            }
            else
            {
                btnUpdate.Visible = true;
            } 
        }

        private void calculateSalary()
        {
            int grossWages = 4500; //brüt ücret
            double coefficient = 0.00; //eklenecek katsayı

            // Experience
            if (cBoxExperience.Text == "0-2 years")
                coefficient += 0.00;
            else if (cBoxExperience.Text == "2-4 years")
                coefficient += 0.06;
            else if (cBoxExperience.Text == "5-9 years")
                coefficient += 1.00;
            else if (cBoxExperience.Text == "10-14 years")
                coefficient += 1.20;
            else if (cBoxExperience.Text == "15-20 years")
                coefficient += 1.35;
            else if (cBoxExperience.Text == "Over 20 years")
                coefficient += 1.50;

            // Province
            if (cBoxProvince.Text == "İstanbul")
                coefficient += 0.15;
            else if ((cBoxProvince.Text == "Ankara") || (cBoxProvince.Text == "İzmir"))
                coefficient += 0.10;
            else if ((cBoxProvince.Text == "Kocaeli,Sakarya,Düzce,Bolu,Yalova") || (cBoxProvince.Text == "Edirne,Kırklareli,Tekirdağ"))
                coefficient += 0.05;
            else if (cBoxProvince.Text == "Other")
                coefficient += 0.00;
            else
                coefficient += 0.03;

            // Education
            if (cBoxEducation.Text == "Vocational master's degree")
                coefficient += 0.10;
            else if (cBoxEducation.Text == "Doctorate about profession")
                coefficient += 0.30;
            else if (cBoxEducation.Text == "Professorship related to profession")
                coefficient += 0.35;
            else if (cBoxEducation.Text == "Non-professional master's degree")
                coefficient += 0.05;
            else if (cBoxEducation.Text == "PhD / associate professorship not related to the profession")
                coefficient += 0.15;

            // Foreign Language
            if ((cBoxForeignLanguage.Text == "Documented English knowledge") || (cBoxForeignLanguage.Text == "English language school graduation"))
                coefficient += 0.20;
            else if (cBoxForeignLanguage.Text == "Other documented foreign language knowledge")
                coefficient += 0.05;

            // Management Task
            if (cBoxManagement.Text == "No")
                coefficient += 0.00;
            else if (cBoxManagement.Text == "TeamLeader/GroupManager/TechnicalManager/Software/Architect")
                coefficient += 0.50;
            else if (cBoxManagement.Text == "Project Manager")
                coefficient += 0.75;
            else if (cBoxManagement.Text == "Director/ProjectsManager")
                coefficient += 0.85;
            else if (cBoxManagement.Text == "CTO/GeneralManager")
                coefficient += 1.00;
            else if (cBoxManagement.Text == "IT Manager/Manager(-5)")
                coefficient += 0.40;
            else if (cBoxManagement.Text == "IT Manager/Manager(+5)")
                coefficient += 0.60;

            // Family Status
            if (listBoxFamilyStatus.Text == "Not married")
                coefficient += 0.00;
            else if ((listBoxFamilyStatus.Text == "Married and spouse not working") || (listBoxFamilyStatus.Text == "0-6 year old child"))
                coefficient += 0.20;
            else if (listBoxFamilyStatus.Text == "7-18 year old child")
                coefficient += 0.30;
            else if (listBoxFamilyStatus.Text == "Child over 18")
                coefficient += 0.40;

            // Calculate
            lblSalary.Text = (grossWages * (coefficient + 1)).ToString();
        }

        private void SalaryCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(this, "Really want to exit??", "Closing", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    PersonalOrganizer personalOrganizer = new PersonalOrganizer();
                    personalOrganizer.Show();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.salaryInfoList.Count(); i++)
            {
                if (User.salaryInfoList[i].Username == LoginedUser.getInstance().User.Username)
                {
                    User.salaryInfoList[i].Experience = cBoxExperience.Text;
                    User.salaryInfoList[i].Province = cBoxProvince.Text;
                    User.salaryInfoList[i].Education = cBoxEducation.Text;
                    User.salaryInfoList[i].ForeignLanguage = cBoxForeignLanguage.Text;
                    User.salaryInfoList[i].ManagmentTask = cBoxManagement.Text;
                    User.salaryInfoList[i].FamilyStatus = listBoxFamilyStatus.Text;
                    User.salaryInfoList[i].Username = LoginedUser.getInstance().User.Username;
                    Util.WriteSalary(User.salaryInfoList, @"salaryInfo.csv");
                }
            }
            calculateSalary();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            User.salaryInfoList.Add(new ClassSalaryCalc(cBoxExperience.Text, cBoxProvince.Text, cBoxEducation.Text, cBoxForeignLanguage.Text, cBoxManagement.Text, listBoxFamilyStatus.Text, LoginedUser.getInstance().User.Username));

            Util.WriteSalary(User.salaryInfoList, @"salaryInfo.csv");
            calculateSalary();
        }
    }
}