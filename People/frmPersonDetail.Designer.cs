namespace DVLD.People
{
    partial class frmPersonDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonCard2 = new DVLD.People.Controls.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(367, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person Details";
            // 
            // ctrlPersonCard2
            // 
            this.ctrlPersonCard2.Location = new System.Drawing.Point(41, 45);
            this.ctrlPersonCard2.Name = "ctrlPersonCard2";
            this.ctrlPersonCard2.Size = new System.Drawing.Size(913, 454);
            this.ctrlPersonCard2.TabIndex = 4;
            this.ctrlPersonCard2.Load += new System.EventHandler(this.ctrlPersonCard2_Load);
            // 
            // frmPersonDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 521);
            this.Controls.Add(this.ctrlPersonCard2);
            this.Controls.Add(this.label1);
            this.Name = "frmPersonDetail";
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.frmPersonDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Controls.ctrlPersonCard ctrlPersonCard2;
    }
}