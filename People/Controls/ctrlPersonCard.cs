using DVLD.Properties;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {


        private clsPerson _Person;

        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; } }

        public clsPerson  SelectPersonInfo { get { return _Person; }
}


        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int personID)
        {
            _Person = clsPerson.Find(personID);

            if (_Person==null)
            {
                ResetPersonInfo();
                MessageBox.Show("no person with this id ");
                return;

            }



            _FillPersonInfo();







        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gBPersonInfo_Enter(object sender, EventArgs e)
        {

        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblName.Text = "[????]";
          
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pBpersonImg.Image = Resources.Male_512;

        }

        private void _LoadPersonImage()
        {
            if (_Person.Gendor == 0)
                pBpersonImg.Image = Resources.Male_512;
            else
                pBpersonImg.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pBpersonImg.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPersonInfo()
        {
            //  llEditPersonInfo.Enabled = true;
               _PersonID = _Person.PersonId ;


            lblPersonID.Text = _Person.PersonId.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            lblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry.Find(90).CountryName;
            lblAddress.Text = _Person.Address;
            _LoadPersonImage();

           




        }

        private void lblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_Person.PersonId);
            frm.ShowDialog();
            LoadPersonInfo(_Person.PersonId);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
