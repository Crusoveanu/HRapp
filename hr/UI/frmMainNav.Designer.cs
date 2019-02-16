namespace hr.UI
{
    partial class frmMainNav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainNav));
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.pbManageUsers = new System.Windows.Forms.PictureBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.pbListUsers = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbUsers = new System.Windows.Forms.Button();
            this.pbAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(199, 147);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(94, 23);
            this.lblUsers.TabIndex = 6;
            this.lblUsers.Text = "U S E R S";
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            this.lblManageUsers.Location = new System.Drawing.Point(480, 534);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(217, 23);
            this.lblManageUsers.TabIndex = 13;
            this.lblManageUsers.Text = "M A N A G E  U S E R S";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            this.lblAddUser.Location = new System.Drawing.Point(562, 297);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(146, 23);
            this.lblAddUser.TabIndex = 12;
            this.lblAddUser.Text = "A D D   U S E R";
            // 
            // pbManageUsers
            // 
            this.pbManageUsers.Image = global::hr.Properties.Resources.manageUser;
            this.pbManageUsers.Location = new System.Drawing.Point(544, 418);
            this.pbManageUsers.Name = "pbManageUsers";
            this.pbManageUsers.Size = new System.Drawing.Size(78, 113);
            this.pbManageUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbManageUsers.TabIndex = 11;
            this.pbManageUsers.TabStop = false;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            this.lblPrint.Location = new System.Drawing.Point(795, 525);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(90, 23);
            this.lblPrint.TabIndex = 17;
            this.lblPrint.Text = "P R I N T";
            // 
            // lblUserList
            // 
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            this.lblUserList.Location = new System.Drawing.Point(811, 271);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(144, 23);
            this.lblUserList.TabIndex = 16;
            this.lblUserList.Text = "U S E R  L I S T";
            // 
            // pbPrint
            // 
            this.pbPrint.Image = ((System.Drawing.Image)(resources.GetObject("pbPrint.Image")));
            this.pbPrint.Location = new System.Drawing.Point(799, 435);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(97, 74);
            this.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrint.TabIndex = 15;
            this.pbPrint.TabStop = false;
            // 
            // pbListUsers
            // 
            this.pbListUsers.Image = ((System.Drawing.Image)(resources.GetObject("pbListUsers.Image")));
            this.pbListUsers.Location = new System.Drawing.Point(839, 147);
            this.pbListUsers.Name = "pbListUsers";
            this.pbListUsers.Size = new System.Drawing.Size(88, 88);
            this.pbListUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbListUsers.TabIndex = 14;
            this.pbListUsers.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pbAddUser);
            this.panel1.Controls.Add(this.pbListUsers);
            this.panel1.Controls.Add(this.pbUsers);
            this.panel1.Controls.Add(this.lblPrint);
            this.panel1.Controls.Add(this.lblUserList);
            this.panel1.Controls.Add(this.lblUsers);
            this.panel1.Controls.Add(this.pbPrint);
            this.panel1.Controls.Add(this.pbManageUsers);
            this.panel1.Controls.Add(this.lblAddUser);
            this.panel1.Controls.Add(this.lblManageUsers);
            this.panel1.Location = new System.Drawing.Point(98, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 623);
            this.panel1.TabIndex = 18;
            // 
            // pbUsers
            // 
            this.pbUsers.Location = new System.Drawing.Point(203, 121);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(75, 23);
            this.pbUsers.TabIndex = 18;
            this.pbUsers.Text = "pbUsers";
            this.pbUsers.UseVisualStyleBackColor = true;
            this.pbUsers.Click += new System.EventHandler(this.pbUsers_Click);
            // 
            // pbAddUser
            // 
            this.pbAddUser.Location = new System.Drawing.Point(587, 238);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.Size = new System.Drawing.Size(75, 23);
            this.pbAddUser.TabIndex = 19;
            this.pbAddUser.Text = " pbAddUser";
            this.pbAddUser.UseVisualStyleBackColor = true;
            this.pbAddUser.Click += new System.EventHandler(this.pbAddUser_Click);
            // 
            // frmMainNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 897);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainNav";
            this.Text = "frmMainNav";
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.PictureBox pbManageUsers;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Label lblUserList;
        private System.Windows.Forms.PictureBox pbPrint;
        private System.Windows.Forms.PictureBox pbListUsers;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pbUsers;
        private System.Windows.Forms.Button pbAddUser;
    }
}