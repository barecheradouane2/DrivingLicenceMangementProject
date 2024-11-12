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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.User
{
    public partial class frmAddNewUser : Form
    {

        private int PersonID ;
        //private AutoComp

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public clsUser _user;
        public frmAddNewUser()
        {
            InitializeComponent();
            this.PersonID = -1;
            _user = new clsUser();
            Mode = enMode.AddNew;
        }

        public frmAddNewUser(int UserID)
        {
            InitializeComponent();
            _user = clsUser.Find(UserID);
            this.PersonID = clsUser.Find(UserID).PersonId;
            Mode = enMode.Update;
         
        }

        private void LoadUserInfo()
        {
            lblAddOrUpdate.Text = "Update User";
            ctrlPersonCardWithFilter1.LoadPersonInfo(PersonID);
            


            lblUserID.Text = _user.UserId.ToString();
            textUserName.Text = _user.UserName.ToString();
            textPassword.Text = _user.Password.ToString();
            textConfirmPassword.Text= _user.Password.ToString();
            if (_user.IsActive==1)
            {
                checkIsActive.Checked = true;
            }

        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            btnNextPage.Enabled = false;

            if (Mode== enMode.Update)
            {
                LoadUserInfo();
            }
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
          
            PersonID = obj;
            btnNextPage.Enabled = true ;
            //MessageBox.Show("Result =" + PersonID);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (clsUser.isPersonisUser(PersonID) )
            {
                MessageBox.Show("Selected Person already  has a User .Choose another one .","Select Another Person",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PersonID==-1)
            {
                MessageBox.Show("Plz Select a person  .", "Select  Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                tabControl1.SelectedIndex += 1;

            }

           
        }

    

        private void textUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textUserName.Text))
            {
                e.Cancel = true; // Cancel focus change
                errorProvider1.SetError(textUserName, "This field cannot be empty!");

                return;
            }
            else
            {
                errorProvider1.SetError(textUserName, null);
            }
        }

        private void textPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textPassword.Text))
            {
                e.Cancel = true; // Cancel focus change
                errorProvider1.SetError(textPassword, "This field cannot be empty!");

                return;
            }
            else
            {
                errorProvider1.SetError(textPassword, null);
            }
        }

        private void textConfirmPassword_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textConfirmPassword.Text))
            {
                e.Cancel = true; // Cancel focus change
                errorProvider1.SetError(textConfirmPassword, "This field cannot be empty!");

                return;
            }
            else
            {
                errorProvider1.SetError(textConfirmPassword, null);
            }


            if (textConfirmPassword.Text!= textPassword.Text)
            {
                e.Cancel = true; // Cancel focus change
                errorProvider1.SetError(textConfirmPassword, "This field donse not much with password field!");

                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _user.UserName= textUserName.Text.ToString();
            _user.Password= textPassword.Text.ToString();
            _user.PersonId = PersonID;
            _user.IsActive = checkIsActive.Checked == true ? (byte) 1 : (byte)0;

            if (_user.Save())
            {
                MessageBox.Show("Data Saved Successfully .","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);

                Mode = enMode.Update;
                LoadUserInfo();
            }
            else
            {
                MessageBox.Show("Something was wrong .", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
