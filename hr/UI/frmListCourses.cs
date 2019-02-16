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
    public partial class frmListCourses : Form
    {
        public Course cr = new Course();
        public int CourseId;

        public frmListCourses()
        {
            InitializeComponent();
        }

        private void FrmListCourses_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            PopulateDataGridView();
            dgvCourses.Dock = DockStyle.None;
            pnlCoursesList.Anchor = AnchorStyles.Top;
        }

        private void PopulateDataGridView()
        {
            using (AppContext db = new AppContext())
            {
                //var del = (from a in db.Details where a.Deleted == false).ToList();
                var del = db.Courses.Where(x => x.Deleted == false).ToList();
                dgvCourses.DataSource = del;
                this.dgvCourses.Columns["Id"].Visible = false;
                this.dgvCourses.Columns["Deleted"].Visible = false;
                this.dgvCourses.Columns["Users"].Visible = false;
                this.dgvCourses.Columns["Exams"].Visible = false;
                this.dgvCourses.Columns["Signs"].Visible = false;
            }
        }

        private void dgvCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            cr = (Course)dgv.CurrentRow.DataBoundItem;

            frmEditRemoveCourse f2 = new frmEditRemoveCourse();

            btnAddCourse.Visible = false;
            panel1.Controls.Clear();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.None;

            f2.txtCOR.Text = cr.COR.ToString();
            f2.txtCourseName.Text = cr.CourseName;
            f2.dtp1.Value = (DateTime)cr.StartDate;
            f2.dtp2.Value = (DateTime)cr.EndDate;
            f2.txtDuration.Text = cr.Duration.ToString();
            f2.txtOragnizedBy.Text = cr.OrganizedBy;
            f2.txtOcupation.Text = cr.Ocupation;
            f2.txtLocation.Text = cr.LocationCounty;
            f2.txtCounty.Text = cr.County;
            f2.txtRegistrationNumber.Text = cr.RegistrationNumber.ToString();
            f2.CourseId = cr.Id;

            f2.cr = cr;

            panel1.Visible = true;
            searchButton.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            btnRefreshDG.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            f2.Show();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnAddCourse.Visible = false;
            panel1.Controls.Clear();
            frmAddCourse f2 = new frmAddCourse();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }
    }
}
