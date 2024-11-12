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

namespace DVLD.Applications
{
    public partial class frmUpdateApplicationTypes : Form
    {
        private int _ID;
        private clsApplicationType _ApplicationType;
        public frmUpdateApplicationTypes(int iD)
        {
            InitializeComponent();
            _ID = iD;
            _ApplicationType = clsApplicationType.Find(_ID);
        }

        private void frmUpdateApplicationTypes_Load(object sender, EventArgs e)
        {
            lblID.Text = _ApplicationType.ID.ToString();
              textTitle.Text= _ApplicationType.Title.ToString();
              textFees.Text= _ApplicationType.Fees.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ApplicationType.Title = textTitle.Text.ToString();
            _ApplicationType.Fees = float.Parse(textFees.Text);

            if (_ApplicationType.Save())
            {
                MessageBox.Show("Save Sucuufully","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something Went  Wrong", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
