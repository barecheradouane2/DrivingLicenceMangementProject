﻿using DVLD.People.Controls;
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
    public partial class frmPersonDetail : Form
    {
        private int  personID;
        public frmPersonDetail(int personID)
        {
            InitializeComponent();
            this.personID = personID;

         
        }

        private void frmPersonDetail_Load(object sender, EventArgs e)
        {

            ctrlPersonCard2.LoadPersonInfo(personID);
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard2_Load(object sender, EventArgs e)
        {

        }
    }
}
