namespace DVLD.User
{
    partial class frmListUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsersNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterByUserInfo = new System.Windows.Forms.ComboBox();
            this.tbFilterByUserInfo = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(556, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Users";
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.AllowUserToAddRows = false;
            this.dgvListUsers.AllowUserToDeleteRows = false;
            this.dgvListUsers.AllowUserToOrderColumns = true;
            this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListUsers.Location = new System.Drawing.Point(12, 268);
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.ReadOnly = true;
            this.dgvListUsers.RowHeadersWidth = 51;
            this.dgvListUsers.RowTemplate.Height = 24;
            this.dgvListUsers.Size = new System.Drawing.Size(1329, 393);
            this.dgvListUsers.TabIndex = 4;
            this.dgvListUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListUsers_CellContentClick);
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
            this.PhoneCall,
            this.changePasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 298);
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
            this.AddNewPerson.Text = "Add New User";
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
            // 
            // PhoneCall
            // 
            this.PhoneCall.Image = ((System.Drawing.Image)(resources.GetObject("PhoneCall.Image")));
            this.PhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PhoneCall.Name = "PhoneCall";
            this.PhoneCall.Size = new System.Drawing.Size(226, 38);
            this.PhoneCall.Text = "Phone Call";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "#Records :";
            // 
            // lblUsersNum
            // 
            this.lblUsersNum.AutoSize = true;
            this.lblUsersNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersNum.Location = new System.Drawing.Point(100, 686);
            this.lblUsersNum.Name = "lblUsersNum";
            this.lblUsersNum.Size = new System.Drawing.Size(15, 16);
            this.lblUsersNum.TabIndex = 9;
            this.lblUsersNum.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter By :";
            // 
            // cbFilterByUserInfo
            // 
            this.cbFilterByUserInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByUserInfo.FormattingEnabled = true;
            this.cbFilterByUserInfo.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "Full Name",
            "UserName",
            "Is Active"});
            this.cbFilterByUserInfo.Location = new System.Drawing.Point(100, 235);
            this.cbFilterByUserInfo.Name = "cbFilterByUserInfo";
            this.cbFilterByUserInfo.Size = new System.Drawing.Size(145, 24);
            this.cbFilterByUserInfo.TabIndex = 11;
            // 
            // tbFilterByUserInfo
            // 
            this.tbFilterByUserInfo.Location = new System.Drawing.Point(260, 237);
            this.tbFilterByUserInfo.Name = "tbFilterByUserInfo";
            this.tbFilterByUserInfo.Size = new System.Drawing.Size(145, 22);
            this.tbFilterByUserInfo.TabIndex = 12;
            this.tbFilterByUserInfo.TextChanged += new System.EventHandler(this.tbFilterByUserInfo_TextChanged);
            this.tbFilterByUserInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterByUserInfo_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1205, 676);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 37);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewUser.Image")));
            this.btnAddNewUser.Location = new System.Drawing.Point(1247, 171);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(93, 91);
            this.btnAddNewUser.TabIndex = 14;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 729);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbFilterByUserInfo);
            this.Controls.Add(this.cbFilterByUserInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsersNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListUser";
            this.Text = "frmListUser";
            this.Load += new System.EventHandler(this.frmListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsersNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterByUserInfo;
        private System.Windows.Forms.TextBox tbFilterByUserInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowDetails;
        private System.Windows.Forms.ToolStripMenuItem AddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem SendEmail;
        private System.Windows.Forms.ToolStripMenuItem PhoneCall;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}