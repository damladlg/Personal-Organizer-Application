using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelab2
{
    public class ClassSalaryCalc
    {
        private String experience;
        private String province;
        private String education;
        private String foreignLanguage;
        private String managmentTask;
        private String familyStatus;
        private String username;

        public ClassSalaryCalc() { }

        public ClassSalaryCalc(String experience, String province, String education, String foreignLanguage, String managmentTask, String familyStatus, String username)
        {
            this.Experience = experience;
            this.Province = province;
            this.Education = education;
            this.ForeignLanguage = foreignLanguage;
            this.ManagmentTask = managmentTask;
            this.FamilyStatus = familyStatus;
            this.Username = username;
        }

        public string Experience { get => experience; set => experience = value; }
        public string Province { get => province; set => province = value; }
        public string Education { get => education; set => education = value; }
        public string ForeignLanguage { get => foreignLanguage; set => foreignLanguage = value; }
        public string ManagmentTask { get => managmentTask; set => managmentTask = value; }
        public string FamilyStatus { get => familyStatus; set => familyStatus = value; }
        public string Username { get => username; set => username = value; }

        public string ToString()
        {
            return Experience + ";" + Province + ";" + Education + ";" + ForeignLanguage + ";" + ManagmentTask + ";" + FamilyStatus + ";" + Username;
        }
    }
}