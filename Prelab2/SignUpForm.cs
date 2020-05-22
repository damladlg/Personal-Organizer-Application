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
using System.Collections;

namespace Prelab2
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        string usertype = "user";
        private void SignupBtn_Click(object sender, EventArgs e)
        {
            grpUserInfo.Visible = true;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            grpUserInfo.Visible = false;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only alphabetic characters.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User.userlist.Add(new User(usernameBox.Text, Util.getHashSha256(passwordBox.Text), usertype,txtName.Text, txtSurname.Text, txtPhoneNumber.Text, txtAddress.Text, txtEmail.Text));
            Util.WriteCsv(User.userlist, @"Data.csv");
        }

        Bitmap image;
        string base64Text;
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
            openFileDialog1.Title = "Select File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = (Image)image;

                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                base64Text = Convert.ToBase64String(imageArray);

                string destPath = Application.StartupPath + @"\Resources\ProfilePictures\" + usernameBox.Text + ".jpg";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\ProfilePictures\");
                File.Copy(openFileDialog1.FileName, destPath, true);
            }

            string path = @"photo.csv";
            using (StreamWriter stream = File.CreateText(path))
            {
                stream.Write(base64Text + ";" + usernameBox.Text);
            }
            txtPhoto.Text = openFileDialog1.FileName.ToString();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
        }
    }
}