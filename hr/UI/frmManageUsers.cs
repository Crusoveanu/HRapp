using hr.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hr.UI
{ 
    public partial class frmManageUsers : Form
    {
        UserDetails ud = new UserDetails();

        public frmManageUsers()
        {
            InitializeComponent();
            txtId.Visible = false;
            label12.Visible = false;
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            dgvUsers.Dock = DockStyle.None;
            panel1.Anchor = AnchorStyles.Top;
        }

        private void PopulateDataGridView()
        {
            using (AppContext db = new AppContext())
            {
                var del = db.Details.Where(x => x.Deleted == false).ToList();
                dgvUsers.DataSource = del;
                this.dgvUsers.Columns["Id"].Visible = false;
                this.dgvUsers.Columns["Deleted"].Visible = false;
                this.dgvUsers.Columns["Courses"].Visible = false;
                this.dgvUsers.Columns["Exams"].Visible = false;
                //For the moment, it will be, maybe, visible.
                this.dgvUsers.Columns["County"].Visible = false;
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

            txtFirstName.Text = ud.FirstName;
            txtLastName.Text = ud.LastName;
            txtCNP.Text = ud.CNP;
            txtCity.Text = ud.City;
            txtCountry.Text = ud.Country;
            txtAddress.Text = ud.Address;
            txtPhone.Text = ud.Phone;
            txtEmail.Text = ud.Email;
            txtFatherName.Text = ud.FatherName;
            txtMotherName.Text = ud.MotherName;
            txtId.Text = ud.Id.ToString();
            dateTimePicker.Value = (DateTime)ud.BirthDay;
            cmbGender.Text = ud.Gender;
            btnAdd.Enabled = false;
            pictureBox1.Visible = false;
            btnAdd.Text = "Cannot be pressed";
        }

        private void btnRefreshDG_Click(object sender, EventArgs e)
        {
            this.dgvUsers.DataSource = null;
            this.dgvUsers.Rows.Clear();
            PopulateDataGridView();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext())
            {

                if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
                {
                    var del = db.Details.Where(x => x.Deleted == false).ToList();
                    dgvUsers.DataSource = del;
                    MessageBox.Show("Refresh done!");
                }
                else if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    var del = db.Details.Where(x => x.Deleted == false && x.FullName.Contains(textBox1.Text)).ToList();
                    dgvUsers.DataSource = del;
                }
                else if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
                {
                    var del = db.Details.Where(x => x.Deleted == false && x.FullName.Contains(textBox1.Text) && x.CNP.Contains(textBox2.Text)).ToList();
                    dgvUsers.DataSource = del;
                }
                else
                {
                    var del = db.Details.Where(x => x.Deleted == false && x.CNP.Contains(textBox2.Text)).ToList();
                    dgvUsers.DataSource = del;
                }
            }
        }

        public bool textBox_validator()
        {
            //variabila stringbuilder; la finalul foreachului o afisam
            bool state = false;
            StringBuilder builder = new StringBuilder();
            List<string> list = new List<string>();

            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    if (string.IsNullOrEmpty(c.Text) && c.Name != "txtEmail" && c.Name != "txtId" && c.Name != "textBox1" && c.Name != "textBox2")
                    {
                        //MessageBox.Show(c.Name + " must be filled");
                        list.Add(c.Name + " must be filled");
                        c.BackColor = Color.Yellow;
                        c.Focus();
                        state = true;
                    }
                    else if (c.Name == "txtEmail" && !txtEmail.Text.Contains('@') || c.Name == "txtEmail" && !txtEmail.Text.Contains('.'))
                    {
                        c.BackColor = Color.Yellow;
                        c.Focus();
                        list.Add("Please Enter A Valid Email which contains @ and .");
                        //MessageBox.Show("Please Enter A Valid Email which contains @ and .");
                        state = true;
                    }
                }
            }
            foreach (string str in list)
            {
                builder.Append(str.ToString()).AppendLine();
            }
            if (!string.IsNullOrEmpty(builder.ToString()))
            {
                MessageBox.Show(builder.ToString());
            }
            return state;
        }

        private void setEmpty(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if( (c is TextBox) || (c is ComboBox) || (c is DateTimePicker))
                { 
                    if (c != null)
                    {
                        c.Text = string.Empty;
                    }

                    this.setEmpty(c);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.setEmpty(this);
            btnAdd.Enabled = true;
            btnAdd.Text = "Add";
            pictureBox1.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (AppContext db = new AppContext())
                {
                    var entry = db.Entry(ud);
                    if (entry.State == EntityState.Detached)
                        db.Details.Attach(ud);
                    ud.Deleted = true;
                    db.SaveChanges();
                    this.dgvUsers.DataSource = null;
                    this.dgvUsers.Rows.Clear();
                    PopulateDataGridView();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                ud.FirstName = txtFirstName.Text.Trim();
                ud.LastName = txtLastName.Text.Trim();
                ud.CNP = txtCNP.Text.Trim();
                ud.City = txtCity.Text.Trim();
                ud.Country = txtCountry.Text.Trim();
                ud.Address = txtAddress.Text.Trim();
                ud.Phone = txtPhone.Text.Trim();
                ud.Email = txtEmail.Text.Trim();
                ud.FatherName = txtFatherName.Text.Trim();
                ud.MotherName = txtMotherName.Text.Trim();
                ud.Gender = cmbGender.Text.Trim();
                ud.BirthDay = dateTimePicker.Value;

                if (MessageBox.Show("Are you sure you want to edit this user?", "Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ud.Id == 0)
                    {
                        db.Entry(ud).State = EntityState.Added;
                        ud.FullName = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();
                        MessageBox.Show("Updated");         
                    }
                    else
                    {
                        db.Entry(ud).State = EntityState.Modified;
                        ud.FullName = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();
                        MessageBox.Show("Edited");
                    }
                        this.dgvUsers.Refresh();
                        this.dgvUsers.Parent.Refresh();
                }
                db.SaveChanges();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                ud.FirstName = txtFirstName.Text.Trim();
                ud.LastName = txtLastName.Text.Trim();
                ud.CNP = txtCNP.Text.Trim();
                ud.City = txtCity.Text.Trim();
                ud.Country = txtCountry.Text.Trim();
                ud.Address = txtAddress.Text.Trim();
                ud.Phone = txtPhone.Text.Trim();
                ud.Email = txtEmail.Text.Trim();
                ud.FatherName = txtFatherName.Text.Trim();
                ud.MotherName = txtMotherName.Text.Trim();
                ud.Gender = cmbGender.Text.Trim();
                ud.BirthDay = dateTimePicker.Value;
                ud.FullName = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();
                ud.Deleted = false;
                try
                {
                    if (!textBox_validator())
                    {
                        db.Details.Add(ud);
                        db.SaveChanges();
                        MessageBox.Show("Commited");
                        this.dgvUsers.DataSource = null;
                        this.dgvUsers.Rows.Clear();
                        PopulateDataGridView();
                        this.setEmpty(this);
                    }
                }
                catch
                {
                    MessageBox.Show("Send an e-mail to AM Support!");
                }
            }
        }


    }
}
