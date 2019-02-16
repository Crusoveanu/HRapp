namespace hr.UI
{
    partial class frmMain
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnContact = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogginUser = new System.Windows.Forms.Label();
            this.lblAppFName = new System.Windows.Forms.Label();
            this.lblLNameApp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCourses = new System.Windows.Forms.Label();
            this.pbCourses = new System.Windows.Forms.PictureBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.pnlFooter.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.DarkRed;
            this.pnlFooter.Controls.Add(this.btnContact);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 814);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1600, 63);
            this.pnlFooter.TabIndex = 0;
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.DarkRed;
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.Location = new System.Drawing.Point(781, 24);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(110, 27);
            this.btnContact.TabIndex = 0;
            this.btnContact.Text = "Contact-Us";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUser.Location = new System.Drawing.Point(13, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User:";
            // 
            // lblLogginUser
            // 
            this.lblLogginUser.AutoSize = true;
            this.lblLogginUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogginUser.ForeColor = System.Drawing.Color.Red;
            this.lblLogginUser.Location = new System.Drawing.Point(57, 43);
            this.lblLogginUser.Name = "lblLogginUser";
            this.lblLogginUser.Size = new System.Drawing.Size(84, 17);
            this.lblLogginUser.TabIndex = 3;
            this.lblLogginUser.Text = "takeTheUser";
            // 
            // lblAppFName
            // 
            this.lblAppFName.AutoSize = true;
            this.lblAppFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAppFName.Location = new System.Drawing.Point(672, 396);
            this.lblAppFName.Name = "lblAppFName";
            this.lblAppFName.Size = new System.Drawing.Size(107, 37);
            this.lblAppFName.TabIndex = 4;
            this.lblAppFName.Text = "Internal";
            this.lblAppFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLNameApp
            // 
            this.lblLNameApp.AutoSize = true;
            this.lblLNameApp.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLNameApp.Location = new System.Drawing.Point(774, 396);
            this.lblLNameApp.Name = "lblLNameApp";
            this.lblLNameApp.Size = new System.Drawing.Size(117, 37);
            this.lblLNameApp.TabIndex = 5;
            this.lblLNameApp.Text = "Courses";
            this.lblLNameApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(520, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 618);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPrint);
            this.panel2.Controls.Add(this.pbPrint);
            this.panel2.Controls.Add(this.lblCourses);
            this.panel2.Controls.Add(this.pbCourses);
            this.panel2.Controls.Add(this.lblUsers);
            this.panel2.Controls.Add(this.pbUsers);
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 630);
            this.panel2.TabIndex = 0;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCourses.Location = new System.Drawing.Point(48, 279);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(113, 20);
            this.lblCourses.TabIndex = 11;
            this.lblCourses.Text = "C O U R S E S";
            // 
            // pbCourses
            // 
            this.pbCourses.Image = global::hr.Properties.Resources.courses;
            this.pbCourses.Location = new System.Drawing.Point(44, 187);
            this.pbCourses.Name = "pbCourses";
            this.pbCourses.Size = new System.Drawing.Size(121, 89);
            this.pbCourses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCourses.TabIndex = 10;
            this.pbCourses.TabStop = false;
            this.pbCourses.Click += new System.EventHandler(this.pbCourses_Click);
            this.pbCourses.MouseEnter += new System.EventHandler(this.pbCourses_MouseEnter);
            this.pbCourses.MouseLeave += new System.EventHandler(this.pbCourses_UsersMouseLeave);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(56, 139);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(82, 20);
            this.lblUsers.TabIndex = 8;
            this.lblUsers.Text = "U S E R S";
            // 
            // pbUsers
            // 
            this.pbUsers.Image = global::hr.Properties.Resources.users;
            this.pbUsers.Location = new System.Drawing.Point(44, 47);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(117, 89);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsers.TabIndex = 7;
            this.pbUsers.TabStop = false;
            this.pbUsers.Click += new System.EventHandler(this.pbUsers_Click);
            this.pbUsers.MouseEnter += new System.EventHandler(this.pbUsers_MouseEnter);
            this.pbUsers.MouseLeave += new System.EventHandler(this.pbUsers_MouseLeave);
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrint.Location = new System.Drawing.Point(69, 444);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(72, 20);
            this.lblPrint.TabIndex = 13;
            this.lblPrint.Text = "P R I N T";
            // 
            // pbPrint
            // 
            this.pbPrint.Image = global::hr.Properties.Resources.print;
            this.pbPrint.Location = new System.Drawing.Point(52, 352);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(113, 89);
            this.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrint.TabIndex = 12;
            this.pbPrint.TabStop = false;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            this.pbPrint.MouseEnter += new System.EventHandler(this.pbPrint_MouseEnter);
            this.pbPrint.MouseLeave += new System.EventHandler(this.pbPrint_UsersMouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 877);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLNameApp);
            this.Controls.Add(this.lblAppFName);
            this.Controls.Add(this.lblLogginUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlFooter);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlFooter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlFooter;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblLogginUser;
        public System.Windows.Forms.Label lblAppFName;
        public System.Windows.Forms.Label lblLNameApp;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblUsers;
        public System.Windows.Forms.PictureBox pbUsers;
        public System.Windows.Forms.Label lblCourses;
        public System.Windows.Forms.PictureBox pbCourses;
        private System.Windows.Forms.Button btnContact;
        public System.Windows.Forms.Label lblPrint;
        public System.Windows.Forms.PictureBox pbPrint;
    }
}