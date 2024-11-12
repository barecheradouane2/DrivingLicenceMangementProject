using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User
{
    public partial class frmChangePassword : Form
    {
        private int UserID;

        clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            _User= clsUser.Find(UserID);
        }

        private void ctrlUserInfo1_Load(object sender, EventArgs e)
        {
            ctrlUserInfo1.LoadUserInfo(UserID);
        }

        private void textCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textCurrentPassword.Text))
            {
                // Show an error message
                errorProvider1.SetError(textCurrentPassword, "Password cannot be empty");
                // Prevent moving to the next control
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textCurrentPassword, "");
            }

            if (textCurrentPassword.Text!= _User.Password)
            {
                // Show an error message
                errorProvider1.SetError(textCurrentPassword, "Password is Not Correct");
                // Prevent moving to the next control
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(textCurrentPassword, "");
            }
        }

     

        private void textConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textConfirmPassword.Text))
            {
                // Show an error message
                errorProvider1.SetError(textConfirmPassword, " Confirm Password cannot be empty");
                // Prevent moving to the next control
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textConfirmPassword, "");
            }

            if (textNewPassword.Text!= textConfirmPassword.Text)
            {
                errorProvider1.SetError(textConfirmPassword, " Confirm dose not much with New Password");
                // Prevent moving to the next control
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textConfirmPassword, "");
            }

        }

        private void textNewPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textNewPassword.Text))
            {
                // Show an error message
                errorProvider1.SetError(textNewPassword,  " New Password cannot be empty");
                // Prevent moving to the next control
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textNewPassword, "");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_User.Save())
            {
                MessageBox.Show("The Password change Succufully");
            }
            else
            {
                MessageBox.Show("Something went worng");
            }
        }

        private void textConfirmPassword_Validated(object sender, EventArgs e)
        {
            _User.Password = textConfirmPassword.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
