using DVLD.Global_Classes;
using DVLD_Buisness;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            string userline = _LoadUserInfoFromText();

            if (userline != "")
            {
                _UserName = userline.Split(':')[0];
                _Password = userline.Split(':')[1];
                textUserName.Text = _UserName;
                textPassword.Text = _Password;
                checkRemberMe.Checked = true;
            }
        }

        private string _UserName;
        private string _Password;
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SaveUserInfoInText()
        {
            // The string you want to save
            string textToSave = _UserName+":"+ _Password;

            // Specify the file path and name
            string filePath = @"C:\DVLDUSERINFO\DVLDUser.txt";
          

            try
            {
                // Write the string to the file
                File.WriteAllText(filePath, textToSave);

                
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur
             
            }

        }
        private string _LoadUserInfoFromText()
        {


            // Specify the file path
            string filePath = @"C:\DVLDUSERINFO\DVLDUser.txt";
            string fileContents = "";

            try
            {
                // Read the file content and save it in a string
                 fileContents = File.ReadAllText(filePath);

              

              


            }
            catch (Exception ex)
            {
              
            }





            return fileContents;
        }

        private void _DeleteUsersInfoFromText()
        {

            // Specify the file path
            string filePath = @"C:\DVLDUSERINFO\DVLDUser.txt";

            try
            {
                // Overwrite the file with an empty string, effectively deleting its contents
                File.WriteAllText(filePath, string.Empty);

                
            }
            catch (Exception ex)
            {
                // Handle any potential errors
                
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsUser.Login(_UserName, _Password).IsActive==1)
            {
                clsGlobal.CurrentUser = clsUser.Login(_UserName, _Password);

                if (checkRemberMe.Checked)
                {
                    _SaveUserInfoInText();
                }
                else
                {
                    _DeleteUsersInfoFromText();
                }

                this.Hide();

                frmMain frm = new frmMain();
                frm.Show();

               // this.Close();


            }else if (clsUser.Login(_UserName, _Password).IsActive == 0)
            {
                MessageBox.Show(" Your Account is Not Active Contact your Admin ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(" Your Password or Username Is Not Valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Check if the text is empty
            if (string.IsNullOrWhiteSpace(textUserName.Text))
            {
                // Set the error on the textUserName control
                errorProvider1.SetError(textUserName, "Username is required.");

                // Cancel the event to prevent the user from leaving the control
                e.Cancel = true;
            }
            else
            {
                // Clear the error if the input is valid
                errorProvider1.SetError(textUserName, "");
                _UserName= textUserName.Text;
            }
        }

        private void textPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Check if the text is empty
            if (string.IsNullOrWhiteSpace(textPassword.Text))
            {
                // Set the error on the textUserName control
                errorProvider1.SetError(textPassword, "textPassword is required.");

                // Cancel the event to prevent the user from leaving the control
                e.Cancel = true;
            }
            else
            {
                // Clear the error if the input is valid
                errorProvider1.SetError(textPassword, "");
                _Password= textPassword.Text;
            }

        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void checkRemberMe_CheckedChanged(object sender, EventArgs e)
        {
           

        }
    }
}
