namespace DVLD.People
{
    partial class frmListPeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPeople));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterByPersonInfo = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPeopleNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFilterByPersonInfo = new System.Windows.Forms.TextBox();
            this.cbGendor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(572, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage People";
            // 
            // dgvListPeople
            // 
            this.dgvListPeople.AllowUserToAddRows = false;
            this.dgvListPeople.AllowUserToDeleteRows = false;
            this.dgvListPeople.AllowUserToOrderColumns = true;
            this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListPeople.Location = new System.Drawing.Point(12, 213);
            this.dgvListPeople.Name = "dgvListPeople";
            this.dgvListPeople.ReadOnly = true;
            this.dgvListPeople.RowHeadersWidth = 51;
            this.dgvListPeople.RowTemplate.Height = 24;
            this.dgvListPeople.Size = new System.Drawing.Size(1329, 393);
            this.dgvListPeople.TabIndex = 3;
            this.dgvListPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPeople_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetails,
            this.AddNewPerson,
            this.Edit,
            this.Delete,
            this.SendEmail,
            this.PhoneCall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 260);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ShowDetails
            // 
            this.ShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("ShowDetails.Image")));
            this.ShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(226, 38);
            this.ShowDetails.Text = "Show Details";
            this.ShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // AddNewPerson
            // 
            this.AddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("AddNewPerson.Image")));
            this.AddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPerson.Name = "AddNewPerson";
            this.AddNewPerson.Size = new System.Drawing.Size(226, 38);
            this.AddNewPerson.Text = "Add New Person";
            this.AddNewPerson.Click += new System.EventHandler(this.AddNewPerson_Click);
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(226, 38);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(226, 38);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SendEmail
            // 
            this.SendEmail.Image = ((System.Drawing.Image)(resources.GetObject("SendEmail.Image")));
            this.SendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(226, 38);
            this.SendEmail.Text = "Send Email";
            this.SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // PhoneCall
            // 
            this.PhoneCall.Image = ((System.Drawing.Image)(resources.GetObject("PhoneCall.Image")));
            this.PhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PhoneCall.Name = "PhoneCall";
            this.PhoneCall.Size = new System.Drawing.Size(226, 38);
            this.PhoneCall.Text = "Phone Call";
            this.PhoneCall.Click += new System.EventHandler(this.PhoneCall_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By :";
            // 
            // cbFilterByPersonInfo
            // 
            this.cbFilterByPersonInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByPersonInfo.FormattingEnabled = true;
            this.cbFilterByPersonInfo.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National ID",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Gendor",
            "Date Of Birth",
            "Nationality",
            "Phone ",
            "Email",
            ""});
            this.cbFilterByPersonInfo.Location = new System.Drawing.Point(87, 174);
            this.cbFilterByPersonInfo.Name = "cbFilterByPersonInfo";
            this.cbFilterByPersonInfo.Size = new System.Drawing.Size(145, 24);
            this.cbFilterByPersonInfo.TabIndex = 5;
            this.cbFilterByPersonInfo.SelectedIndexChanged += new System.EventHandler(this.cbFilterByPersonInfo_SelectedIndexChanged);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVLD.Properties.Resources.Add_Person_40;
            this.btnAddPerson.Location = new System.Drawing.Point(1275, 153);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(66, 54);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(545, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "#Records :";
            // 
            // lblPeopleNum
            // 
            this.lblPeopleNum.AutoSize = true;
            this.lblPeopleNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleNum.Location = new System.Drawing.Point(103, 633);
            this.lblPeopleNum.Name = "lblPeopleNum";
            this.lblPeopleNum.Size = new System.Drawing.Size(15, 16);
            this.lblPeopleNum.TabIndex = 8;
            this.lblPeopleNum.Text = "0";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1206, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbFilterByPersonInfo
            // 
            this.tbFilterByPersonInfo.Location = new System.Drawing.Point(248, 176);
            this.tbFilterByPersonInfo.Name = "tbFilterByPersonInfo";
            this.tbFilterByPersonInfo.Size = new System.Drawing.Size(145, 22);
            this.tbFilterByPersonInfo.TabIndex = 10;
            this.tbFilterByPersonInfo.TextChanged += new System.EventHandler(this.tbFilterByPersonInfo_TextChanged);
            // 
            // cbGendor
            // 
            this.cbGendor.FormattingEnabled = true;
            this.cbGendor.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGendor.Location = new System.Drawing.Point(408, 176);
            this.cbGendor.Name = "cbGendor";
            this.cbGendor.Size = new System.Drawing.Size(121, 24);
            this.cbGendor.TabIndex = 11;
            this.cbGendor.SelectedIndexChanged += new System.EventHandler(this.cbGendor_SelectedIndexChanged);
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 677);
            this.Controls.Add(this.cbGendor);
            this.Controls.Add(this.tbFilterByPersonInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPeopleNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.cbFilterByPersonInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListPeople";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmListPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterByPersonInfo;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPeopleNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowDetails;
        private System.Windows.Forms.ToolStripMenuItem AddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem SendEmail;
        private System.Windows.Forms.ToolStripMenuItem PhoneCall;
        private System.Windows.Forms.TextBox tbFilterByPersonInfo;
        private System.Windows.Forms.ComboBox cbGendor;
    }
}