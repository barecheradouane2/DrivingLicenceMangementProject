using DVLD.Applications;
using DVLD.Global_Classes;
using DVLD.People;
using DVLD.User;
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

namespace DVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
        }

        private void drivingLiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private Form frmListPeople1 = new frmListPeople();

        private Form frmListUser1  = new frmListUser();

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUser1.Close();

            try
            {
                
              
               frmListPeople1.MdiParent = this;

                frmListPeople1.StartPosition = FormStartPosition.Manual; // Set position to Manual

                // Calculate center position
                frmListPeople1.Location = new Point(
                    (this.ClientSize.Width - frmListPeople1.Width) / 2, // Center horizontally
                    (this.ClientSize.Height - frmListPeople1.Height) / 2 // Center vertically
                );

                
                frmListPeople1.Show(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }


        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmListPeople1.Close();

            try
            {


                frmListUser1.MdiParent = this;

                frmListUser1.StartPosition = FormStartPosition.Manual; // Set position to Manual

                // Calculate center position
                frmListUser1.Location = new Point(
                    (this.ClientSize.Width - frmListUser1.Width) / 2, // Center horizontally
                    (this.ClientSize.Height - frmListUser1.Height) / 2 // Center vertically
                );


                frmListUser1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo(clsGlobal.CurrentUser.UserId);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserId);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();

            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationTypes frm = new frmApplicationTypes();
            frm.ShowDialog();
        }
    }
}
