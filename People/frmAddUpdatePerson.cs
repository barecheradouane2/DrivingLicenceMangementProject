using DVLD.Global_Classes;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackHandler(object sender, int personId);
        public  event DataBackHandler DataBack;

        public enum enMode { Addnew = 0, Update = 1 };
        private int PersonID = -1;
        string destinationFolder = @"C:\DVLD-People-Images";
        string destinationFile = "";

        clsPerson person;

        public enMode Mode { get; set; } 
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            if (PersonID == -1)
            {
                Mode=enMode.Addnew;
            }
            else
            {
                Mode = enMode.Update;
                this.PersonID = PersonID;
            }


        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (Mode== enMode.Update)
            {
              
                _putPersonInfo();
            }
          
        }


        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();



            if (Mode == enMode.Addnew)
            {
   
                lblForm.Text = "Add New Person";
                person = new clsPerson();

            }
            else
            {
                lblForm.Text = " Update Person";
            }



            if (rdbMale.Checked)
            {
                pbPersonImg.Image = Properties.Resources.Male_512;

            }
            else
            {
                pbPersonImg.Image = Properties.Resources.Female_512;

            }

            lklRemove.Visible = (pbPersonImg.ImageLocation != null);

            dtDateOfBirth.MaxDate= DateTime.Now.AddYears(-18);
            dtDateOfBirth.MinDate= DateTime.Now.AddYears(-100);

            dtDateOfBirth.Value = dtDateOfBirth.MaxDate;
            cbCountry.SelectedIndex = cbCountry.FindString("Algeria");

            tbFirstName.Text = "";
            tbSecondName.Text = "";
            tbThirdName.Text = "";
            tbLastName.Text = "";
            tbNationnalNo.Text = "";
            rdbMale.Checked = true;
            tbPhone.Text = "";
            textBox8.Text = "";
            tbAddress.Text = "";








        }

        private void _AssignDefaultImg()
        {


          
                if (rdbMale.Checked)
                {
                    pbPersonImg.Image = Properties.Resources.Male_512;

                }
                else
                {
                    pbPersonImg.Image = Properties.Resources.Female_512;

                }
        
        }
        private void _putPersonInfo()
        {

            person = clsPerson.Find(PersonID);

            if (person == null)
            {
                MessageBox.Show("no person with this id");
                this.Close();
                return;
            }

            lblPersonID.Text= person.PersonId.ToString();
            tbFirstName.Text = person.FirstName;
            tbSecondName.Text= person.SecondName;
            tbLastName.Text = person.LastName;
            tbThirdName.Text=person.ThirdName;
            tbLastName.Text=person.LastName;
            tbNationnalNo.Text = person.NationalNo;
            tbAddress.Text = person.Address;
            tbPhone.Text = person.Phone;
            textBox8.Text = person.Email;
            dtDateOfBirth.Value = person.DateOfBirth;

            cbCountry.SelectedIndex = cbCountry.FindString(person.CountryInfo.CountryName);

            if (person.Gendor == 0)
            {
                rdbMale.Checked = true;
            }
            else 
            {

                rdbFemale.Checked = true;
               
               
            }


            if (person.ImagePath != "")
            {

                pbPersonImg.ImageLocation = person.ImagePath;

            }
           

            lklRemove.Visible = (pbPersonImg.ImageLocation !=null);
           
           

          



        }

       
        private void _LoadPersonInfo()
        {
            int NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;

      


            person.FirstName= tbFirstName.Text.Trim();
            person.SecondName= tbSecondName.Text.Trim();
            person.ThirdName= tbThirdName.Text.Trim();
            person.LastName=tbLastName.Text.Trim();
            person.NationalNo= tbNationnalNo.Text.Trim();
            person.Address= tbAddress.Text.Trim();
            person.Phone= tbPhone.Text.Trim();
            person.Email= textBox8.Text.Trim();
            person.DateOfBirth= dtDateOfBirth.Value;
            person.NationalityCountryID = NationalityCountryID;


           // person.Nationlity= cbCountry.Text.ToString();

            //  person.Nationlity= clsCountry;


            if (rdbMale.Checked)
            {
                person.Gendor = 0;
                
             
            }
            else
            {

                person.Gendor = 1;
            }

            if (pbPersonImg.ImageLocation!=null)
            {
                person.ImagePath = pbPersonImg.ImageLocation;
            }
            else
            {
                person.ImagePath = "";
            }
           
            
           
            







        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtcountries = clsCountry.GetAllCountries();

            foreach (DataRow raw in dtcountries.Rows)
            {
                cbCountry.Items.Add(raw["CountryName"]);
                
            }
        }

        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (person.ImagePath != pbPersonImg.ImageLocation)
            {
                if (person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImg.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImg.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImg.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("some fields are not valide !");
                return;
            }

            if (!_HandlePersonImage())
            {
                return;
            }
            _LoadPersonInfo();
            
            if (person.Save())
            {
                lblPersonID.Text = person.PersonId.ToString();

                Mode=enMode.Update;
                lblForm.Text = "Update Person";

                MessageBox.Show(" you add new person +");

                DataBack?.Invoke(this, person.PersonId);

            }
            else
            {
                MessageBox.Show("something worng ");
            }
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {

            if (pbPersonImg.ImageLocation == null)
                pbPersonImg.Image = Resources.Male_512;


        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {

            if (pbPersonImg.ImageLocation == null)
                pbPersonImg.Image = Resources.Female_512;
        }

        private void lblsetimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif", // Filter to show only image files
                Title = "Select an Image"
            };



            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImg.Load(selectedFilePath);
                lklRemove.Visible = true;
                // ...
            }












        }

        private void lklRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImg.ImageLocation = null;



            if (rdbMale.Checked)
                pbPersonImg.Image = Resources.Male_512;
            else
                pbPersonImg.Image = Resources.Female_512;

            lklRemove.Visible = false;


        }

        private void tbNationnalNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNationnalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tbNationnalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationnalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(tbNationnalNo, null);
            }

            //Make sure the national number is not used by another person
            if (tbNationnalNo.Text.Trim() != person.NationalNo && clsPerson.isPersonExist(tbNationnalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationnalNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(tbNationnalNo, null);
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {

            if (textBox8.Text.Trim() == "")
            {
                return;
            }
            if (!clsValidation.ValidateEmail(textBox8.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox8, "Invalid Email Address Format !");
            }
            else
            {
                errorProvider1.SetError(textBox8, null);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox Temp)
            {
                if (string.IsNullOrEmpty(Temp.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(Temp, "This field is required!");
                }
                else
                {
                    errorProvider1.SetError(Temp, null);
                }
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
