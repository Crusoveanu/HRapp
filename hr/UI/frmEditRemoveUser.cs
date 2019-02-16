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
    public partial class frmEditRemoveUser : Form
    {
        public UserDetails ud = new UserDetails();
        public frmEditRemoveUser()
        {
            InitializeComponent();
            txtId.Visible = false;
            label12.Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Deleted Succesfully");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                }
                db.SaveChanges();
            }

        }
    }
}
