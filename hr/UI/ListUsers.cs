using hr.Models;
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
    public partial class ListUsers : Form
    {
        public UserDetails ud = new UserDetails();

        public Supliment sp = new Supliment();

        public ListUsers()
        {
            InitializeComponent();

        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            PopulateDataGridView();
            dgvUser.Dock = DockStyle.None;
            pnlUserList.Anchor = AnchorStyles.Top;
        }

        private void PopulateDataGridView()
        {
            using (AppContext db = new AppContext())
            {
                var del = db.Details.Where(x => x.Deleted == false).ToList();
                dgvUser.DataSource = del;
                this.dgvUser.Columns["Id"].Visible = false;
                this.dgvUser.Columns["Deleted"].Visible = false;
                this.dgvUser.Columns["Courses"].Visible = false;
                this.dgvUser.Columns["Exams"].Visible = false;
                //For the moment, it will be, maybe, visible.
                this.dgvUser.Columns["County"].Visible = false;

            }
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            
            // cand apesi pe o celula ia tot randul atunci de-comenteaza if-ul
            //if (dgv.CurrentRow.Selected)
            //{
                 ud = (UserDetails)dgv.CurrentRow.DataBoundItem;
            //}

            frmEditRemoveUser f2 = new frmEditRemoveUser();

            //f2.ud = ud;
            panel1.Controls.Clear();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.None;

            f2.txtFirstName.Text = ud.FirstName;
            f2.txtLastName.Text = ud.LastName;
            f2.txtCNP.Text = ud.CNP;
            f2.txtCity.Text = ud.City;
            f2.txtCountry.Text = ud.Country;
            f2.txtAddress.Text = ud.Address;
            f2.txtPhone.Text = ud.Phone;
            f2.txtEmail.Text = ud.Email;
            f2.txtFatherName.Text = ud.FatherName;
            f2.txtMotherName.Text = ud.MotherName;
            f2.txtId.Text = ud.Id.ToString();
            f2.dateTimePicker.Value = (DateTime)ud.BirthDay;
            f2.cmbGender.Text = ud.Gender;

            f2.ud = ud;

            panel1.Visible = true;
            searchButton.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            btnRefreshDG.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnAddUser.Visible = false;
            f2.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext())
            {

                if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
                {
                    var del = db.Details.Where(x => x.Deleted == false).ToList();
                    dgvUser.DataSource = del;
                    MessageBox.Show("Refresh done!");
                }
                else if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    var del = db.Details.Where(x => x.Deleted == false && x.FullName.Contains(textBox1.Text)).ToList();
                    dgvUser.DataSource = del;
                }
                else if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
                {
                    var del = db.Details.Where(x => x.Deleted == false && x.FullName.Contains(textBox1.Text) && x.CNP.Contains(textBox2.Text)).ToList();
                    dgvUser.DataSource = del;
                }
                else
                {
                    var del = db.Details.Where(x => x.Deleted == false && x.CNP.Contains(textBox2.Text)).ToList();
                    dgvUser.DataSource = del;
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnAddUser.Visible = false;
            searchButton.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            btnRefreshDG.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            panel1.Controls.Clear();
            frmAddUser f2 = new frmAddUser();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ListUsers f2 = new ListUsers();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }
    }

}
