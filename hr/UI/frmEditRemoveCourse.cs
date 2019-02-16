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
    public partial class frmEditRemoveCourse : Form
    {
        public int CourseId;
        public Course cr = new Course();
        public UserDetails ud = new UserDetails();
        public Supliment sp = new Supliment();
        public frmEditRemoveCourse()
        {
            InitializeComponent();
            // PopulateDataGridView();
        }

        //TO DO: DATAGRID https://www.youtube.com/watch?v=uNwh3poNGIU
        void Clear()
        {

            cr.Id = 0;
            btnRemove.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                cr.COR = Convert.ToInt32(txtCOR.Text.Trim());
                cr.CourseName = txtCourseName.Text.Trim();
                cr.StartDate = dtp1.Value;
                cr.EndDate = dtp2.Value;
                cr.Duration = Convert.ToInt32(txtDuration.Text.Trim());
                cr.Ocupation = txtOcupation.Text.Trim();
                cr.LocationCounty = txtLocation.Text.Trim();
                cr.County = txtCounty.Text.Trim();
                cr.RegistrationNumber = Convert.ToInt32(txtRegistrationNumber.Text.Trim());

                if (MessageBox.Show("Are you sure you want to edit this user?", "Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (cr.Id == 0)
                    {
                        db.Entry(cr).State = EntityState.Added;
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        db.Entry(cr).State = EntityState.Modified;
                        MessageBox.Show("Edited");
                    }
                }
                db.SaveChanges();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (AppContext db = new AppContext())
                {
                    var entry = db.Entry(cr);
                    if (entry.State == EntityState.Detached)
                        db.Courses.Attach(cr);
                    cr.Deleted = true;
                    db.SaveChanges();
                    MessageBox.Show("Deleted Succesfully");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserToCourse f2 = new AddUserToCourse();
            f2.crsId = CourseId;
            //f2.crsId = cr.Id;
            f2.Show();
        }

        private void PopulateDataGridView()
        {
            using (AppContext db = new AppContext())
            {
                List<UserDetails> td =
                        (from s in db.Details
                         join r in db.Supliments on s.Id equals r.UserDetailsId
                         where r.CourseId == cr.Id && s.Deleted == false && r.Deleted == false
                         select s).ToList();

                dgvDisplayUsers.DataSource = td;
            }
        }

        private void frmEditRemoveCourse_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void dgvDisplayUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvDisplayUsers.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvDisplayUsers.Columns["Delete"].Index)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null)
                    return;

                // cand apesi pe o celula ia tot randul atunci de-comenteaza if-ul
                //if (dgv.CurrentRow.Selected)
                //{
                ud = (UserDetails)dgv.CurrentRow.DataBoundItem;
                //sa tinem minte id ul cursului

                using (AppContext db = new AppContext())
                {
                    Supliment sp = (from z in db.Supliments select z).Where(z => z.UserDetailsId == ud.Id && z.CourseId == cr.Id).FirstOrDefault();
                    var entry = db.Entry(sp);

                    //if (entry.State == EntityState.Detached)
                    //    db.Supliments.Attach(sp);
                    sp.Deleted = true;
                    db.Entry(sp).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Deleted Succesfully");

                    this.dgvDisplayUsers.DataSource = null;
                    this.dgvDisplayUsers.Rows.Clear();
                    PopulateDataGridView();
                }
            }
        }

        private void btnSupliment_Click(object sender, EventArgs e)
        {
            frmSupliment f2 = new frmSupliment();
            f2.crsId = CourseId;
            f2.Show();
        }
    }
}