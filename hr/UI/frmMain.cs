using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace hr.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lblLogginUser.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }
        //REFRESH PANEL
        public void refresh_Panel()
        {
            pbUsers.Visible = true;
            lblUsers.Visible = true;
            pbCourses.Visible = true;
            lblCourses.Visible = true;
            pbPrint.Visible = true;
            lblPrint.Visible = true;

        }
        //MAIN CATEGORY FROM PANEL
        private void pbUsers_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);

            panel1.Controls.Clear();
            ListUsers f2 = new ListUsers();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }
        //EFECT
        private void pbUsers_MouseEnter(object sender, EventArgs e)
        {
            pbUsers.BorderStyle = BorderStyle.FixedSingle;
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
        }
        //EFECT
        private void pbUsers_MouseLeave(object sender, EventArgs e)
        {
            pbUsers.BorderStyle = BorderStyle.None;
            pbUsers.Image = new Bitmap(Properties.Resources.users);
        }

        private void pbCourses_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Controls.Clear();
            frmListCourses f2 = new frmListCourses();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void pbCourses_MouseEnter(object sender, EventArgs e)
        {
            pbCourses.BorderStyle = BorderStyle.FixedSingle;
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
            pbCourses.Image = pic;
        }

        private void pbCourses_UsersMouseLeave(object sender, EventArgs e)
        {
            pbCourses.BorderStyle = BorderStyle.None;
            pbCourses.Image = new Bitmap(Properties.Resources.courses);
        }

        private void pbPrint_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Controls.Clear();
            frmPrinter f2 = new frmPrinter();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();

        }

        private void pbPrint_MouseEnter(object sender, EventArgs e)
        {
            pbPrint.BorderStyle = BorderStyle.FixedSingle;
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
            pbPrint.Image = pic;
        }

        private void pbPrint_UsersMouseLeave(object sender, EventArgs e)
        {
            pbPrint.BorderStyle = BorderStyle.None;
            pbPrint.Image = new Bitmap(Properties.Resources.print);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = "mihai.crusoveanu@pirelli.com";
            oMailItem.CC = "doru.bulubasa@pirelli.com";
            // body, bcc etc...
            oMailItem.Display(true);

        }
    }
}
