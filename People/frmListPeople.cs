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

namespace DVLD.People
{
    public partial class frmListPeople : Form

    {

        private int PeopeleCount = 0;
        DataView dvPeople;

      //  enum enfilter { PersonID =1,}
        public frmListPeople()
        {
            InitializeComponent();
            tbFilterByPersonInfo.KeyPress += tbFilterByPersonInfo_KeyPress;

            // Assuming clsPerson.GetPeople() returns a DataTable
            DataTable dtPeople = clsPerson.GetAllPeople();

            // Create a DataView from the DataTable
            dvPeople = new DataView(dtPeople);
           // tbFilterByPersonInfo.KeyPress += tbFilterByPersonInfo_KeyPress;

        }


        private void _RefreshPeopleList()
        {

            DataTable dtPeople = clsPerson.GetAllPeople();

          
            dvPeople = new DataView(dtPeople);


            dgvListPeople.DataSource = dvPeople;

            tbFilterByPersonInfo.Visible = false;
            cbGendor.Visible = false;



            PeopeleCount = dgvListPeople.Rows.Count;
            lblPeopleNum.Text = PeopeleCount.ToString();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            cbFilterByPersonInfo.SelectedIndex = 0;
            _RefreshPeopleList();
        }


     /*   private void tbFilterByPersonInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and control keys (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }*/


        private void _handleFilter()
        {

            switch (cbFilterByPersonInfo.SelectedIndex)
            {

                case 1:
                    if (tbFilterByPersonInfo.Text.ToString() != "")
                    {
                        dvPeople.RowFilter = "PersonID =  '" + tbFilterByPersonInfo.Text.ToString() + "'";
                    }
                   
                    // dgvListPeople.DataSource = dvPeople;


                    break;

                case 2:

                    dvPeople.RowFilter = "NationalNo = '" + tbFilterByPersonInfo.Text + "'";
                  //  dgvListPeople.DataSource = dvPeople;

                    break;

                case 3:
                    dvPeople.RowFilter = "FirstName = '" + tbFilterByPersonInfo.Text + "'";
                  //  dgvListPeople.DataSource = dvPeople;

                    break;

                case 4:
                    dvPeople.RowFilter = "SecondName = '" + tbFilterByPersonInfo.Text + "'";
                  //  dgvListPeople.DataSource = dvPeople;

                    break;

                case 5:
                    dvPeople.RowFilter = "ThirdName = '" + tbFilterByPersonInfo.Text + "'";
                    //dgvListPeople.DataSource = dvPeople;

                    break;

                case 6:
                    dvPeople.RowFilter = "LastName = '" + tbFilterByPersonInfo.Text + "'";
                   // dgvListPeople.DataSource = dvPeople;

                    break;

                case 7:

                    if (cbGendor.SelectedIndex == 0)
                    {
                        dvPeople.RowFilter = "Gendor = 'MALE'";
                    }
                    else
                    {
                        dvPeople.RowFilter = "Gendor = 'FEMALE'";
                    }

                   
                  //  dgvListPeople.DataSource = dvPeople;

                    break;
                case 8:
                    dvPeople.RowFilter = "DateOfBirth = '" + tbFilterByPersonInfo.Text.ToString() + "'";
                  //  dgvListPeople.DataSource = dvPeople;

                    break;
                case 9:
                    dvPeople.RowFilter = "CountryName = '" + tbFilterByPersonInfo.Text.ToString() + "'";
                  //  dgvListPeople.DataSource = dvPeople;

                    break;

                case 10:
                    dvPeople.RowFilter = "Phone = '" + tbFilterByPersonInfo.Text.ToString() + "'";
                  //  dgvListPeople.DataSource = dvPeople;

                    break;

                case 11:
                    dvPeople.RowFilter = "Email = '" + tbFilterByPersonInfo.Text.ToString() + "'";
                //    dgvListPeople.DataSource = dvPeople;

                    break;


            }


            dgvListPeople.DataSource = dvPeople;

            PeopeleCount = dgvListPeople.Rows.Count;
            lblPeopleNum.Text = PeopeleCount.ToString();

        }

        private void SendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Feature is not  implemented yet! ", "Not Ready ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Feature is not  implemented yet! ", "Not Ready ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            frmPersonDetail frm = new frmPersonDetail((int)dgvListPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure ", "Confirm ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                clsPerson.DeletePerson((int)dgvListPeople.CurrentRow.Cells[0].Value);
                _RefreshPeopleList();

            }
         
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void dgvListPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddNewPerson_Click(object sender, EventArgs e)
        {

            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson((int)dgvListPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();

        }

        private void cbFilterByPersonInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterByPersonInfo.SelectedIndex == 0)
            {
                _RefreshPeopleList();
            }
            else if(cbFilterByPersonInfo.SelectedIndex == 7)
            {
                cbGendor.Visible = true;
               // cbGendor.SelectedIndex= 0;
                tbFilterByPersonInfo.Visible = false;

            }
            else
            {
                tbFilterByPersonInfo.Text = "";
                tbFilterByPersonInfo.Visible = true;
                cbGendor.Visible = false;
            }

        }

        private void tbFilterByPersonInfo_TextChanged(object sender, EventArgs e)
        {

            _handleFilter();
        }

        private void cbGendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _handleFilter();
        }


        private void tbFilterByPersonInfo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbFilterByPersonInfo.SelectedIndex == 1)
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }


            }
           

             

            
          
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
