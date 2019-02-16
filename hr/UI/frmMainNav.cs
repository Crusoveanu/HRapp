using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hr.UI
{
    public partial class frmMainNav : Form
    {
        frmMain nav = new frmMain();
        public frmMainNav()
        {
            InitializeComponent();
            pbAddUser.Visible = false;
            pbManageUsers.Visible = false;
            pbPrint.Visible = false;
            pbListUsers.Visible = false;
            lblManageUsers.Visible = false;
            lblUserList.Visible = false;
            lblPrint.Visible = false;
            lblAddUser.Visible = false;
        }

        private void pbUsers_Click(object sender, EventArgs e)
        {
            pbUsers.Visible = false;
            lblUsers.Visible = false;
            pbAddUser.Visible = true;
            pbManageUsers.Visible = true;
            pbPrint.Visible = true;
            pbListUsers.Visible = true;
            lblManageUsers.Visible = true;
            lblUserList.Visible = true;
            lblPrint.Visible = true;
            lblAddUser.Visible = true;
        }

        private void pbUsers_MouseEnter(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(Properties.Resources.hover);
            for (int w = 0; w < pic.Width; w++)
            {
                for (int h = 0; h < pic.Height; h++)
                {
                    Color c = pic.GetPixel(w, h);
                    Color newC = Color.FromArgb(10, c);
                    pic.SetPixel(w, h, newC);
                }
            }
            pbUsers.Image = pic;
            pbAddUser.Image = pic;
        }

        private void pbUsers_MouseLeave(object sender, EventArgs e)
        {
            pbUsers.Image = new Bitmap(Properties.Resources.users);

            pbAddUser.Image = new Bitmap(Properties.Resources.adduser);
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.Top;

            panel1.Controls.Clear();
            frmAddUser f2 = new frmAddUser();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            panel1.AutoSize = true;
            f2.panel1.AutoSize = true;
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;

            f2.Show();
        }
    }
}
