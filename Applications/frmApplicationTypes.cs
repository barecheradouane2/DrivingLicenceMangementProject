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
    public partial class frmApplicationTypes : Form
    {

        private DataTable _dtApplicationTypes;
       
        public frmApplicationTypes()
        {
            InitializeComponent();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _SetDefault()
        {
            dataGridView1.DataSource = clsApplicationType.GetAllApplicationType();
            lblRecords.Text = clsApplicationType.GetAllApplicationType().Rows.Count.ToString();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].Width = 150;


                dataGridView1.Columns[1].HeaderText = "Title";
                dataGridView1.Columns[1].Width = 330;

                dataGridView1.Columns[2].HeaderText = "Fees";
                dataGridView1.Columns[2].Width = 200;




            }

        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {

            _SetDefault();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationTypes frm = new frmUpdateApplicationTypes((int)dataGridView1.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _SetDefault();
        }
    }
}
