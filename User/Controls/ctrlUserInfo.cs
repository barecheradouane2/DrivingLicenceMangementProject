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

namespace DVLD.User.Controls
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        public clsUser _User;

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);

           

            if (_User == null)
            {
             //   ResetPersonInfo();
                MessageBox.Show("no user with this id   " + UserID);
                return;

            }

           



            _FillUserInfo();


        }


        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonId);

            lblUserID.Text = _User.UserId.ToString();
            lblUserName.Text= _User.UserName.ToString();
            lblIsActive.Text= _User.IsActive==0?"No":"Yes";

        }

        private void ctrlUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
