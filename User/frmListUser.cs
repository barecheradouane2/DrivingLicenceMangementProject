using DVLD.People;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD.User
{
    public partial class frmListUser : Form
    {

        private static DataTable _dtAllUser = clsUser.GetAllUsers();
        private static DataTable _dtuser = _dtAllUser.DefaultView.ToTable(false,"UserID","PersonID","FullName","UserName","IsActive");
        public frmListUser()
        {
            InitializeComponent();
         
        }

        public void Intial()
        {

             _dtAllUser = clsUser.GetAllUsers();
        _dtuser = _dtAllUser.DefaultView.ToTable(false, "UserID", "PersonID", "FullName", "UserName", "IsActive");


            dgvListUsers.DataSource = _dtuser;
            cbFilterByUserInfo.SelectedIndex = 0;
            lblUsersNum.Text = dgvListUsers.Rows.Count.ToString();
        }
     

        private void dgvListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListUser_Load(object sender, EventArgs e)
        {
            dgvListUsers.DataSource= _dtuser;
            cbFilterByUserInfo.SelectedIndex = 0;
            lblUsersNum.Text= dgvListUsers.Rows.Count.ToString();

            //tbFilterByUserInfo.Visible=false;

            if (dgvListUsers.Rows.Count > 0)
            {
                dgvListUsers.Columns[0].HeaderText = "User ID";
                dgvListUsers.Columns[0].Width = 150;

                dgvListUsers.Columns[1].HeaderText = "Person ID";
                dgvListUsers.Columns[1].Width = 150;

                dgvListUsers.Columns[2].HeaderText = "Full Name";
                dgvListUsers.Columns[2].Width = 330;

                dgvListUsers.Columns[3].HeaderText = "UserName";
                dgvListUsers.Columns[3].Width = 150;

                dgvListUsers.Columns[4].HeaderText = "is Active";
                dgvListUsers.Columns[4].Width = 165;


                //   _dtuser.DefaultView.RowFilter=string.Format("[{0}] LIKE '{1}%'",,)

                //  Person ID
                //     Full Name
                //    UserName
                //   Is Active

            }
        }

        private void cbFilterByUserInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            tbFilterByUserInfo.Visible = (cbFilterByUserInfo.Text != "None");

            if(cbFilterByUserInfo.Visible)
            {
                tbFilterByUserInfo.Text = "";
                tbFilterByUserInfo.Focus(); 
            }
        }

        private void tbFilterByUserInfo_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterByUserInfo.Text)
            {
                case "None":

                    FilterColumn = "None";

                    break;

                case "User ID":

                    FilterColumn = "UserID";
                    break;
                case "Person ID":
                       FilterColumn = "PersonID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;
                case "Is Active":
                    FilterColumn = "IsActive";
                    break;


            }

            if (tbFilterByUserInfo.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtuser.DefaultView.RowFilter = "";
                lblUsersNum.Text = dgvListUsers.Rows.Count.ToString();
                return;
            }


            if(FilterColumn == "UserID" || FilterColumn == "PersonID")
            {
                _dtuser.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn,tbFilterByUserInfo.Text.Trim());
            }
            else
            {
                _dtuser.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterByUserInfo.Text.Trim());
            }
            lblUsersNum.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void tbFilterByUserInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterByUserInfo.Text== "User ID" || cbFilterByUserInfo.Text == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // If the key pressed is not a digit or a control key, ignore it
                    e.Handled = true;
                }
            }
        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            
            Form frm = new frmUserInfo((int)dgvListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();   
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Form frm =new frmAddNewUser();
            frm.ShowDialog();
            Intial();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        //    _RefreshPeopleList();
            Form frm = new frmAddNewUser((int)dgvListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            Intial();
        }

        private void AddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewUser();
            frm.ShowDialog();
            Intial();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this User","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK)
            {
                clsUser.DeleteUser((int)dgvListUsers.CurrentRow.Cells[0].Value);
                MessageBox.Show("the user deleted succufully");
                Intial();
            }
            
       
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
