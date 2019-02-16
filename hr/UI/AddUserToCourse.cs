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
    public partial class AddUserToCourse : Form
    {
        //public Exam ex = new Exam();
        public int crsId;
        public Supliment sp = new Supliment();

        public AddUserToCourse()
        {
            InitializeComponent();
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            dgvUser.Dock = DockStyle.None;
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
                this.dgvUser.Columns["BirthDay"].Visible = false;
                this.dgvUser.Columns["City"].Visible = false;
                this.dgvUser.Columns["Country"].Visible = false;
                this.dgvUser.Columns["MotherName"].Visible = false;
                this.dgvUser.Columns["FatherName"].Visible = false;
                this.dgvUser.Columns["Gender"].Visible = false;
                this.dgvUser.Columns["Address"].Visible = false;
                this.dgvUser.Columns["Phone"].Visible = false;
                this.dgvUser.Columns["Email"].Visible = false;


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int UserId;
            Supliment sp2 = new Supliment();
            List<int> subjectId = new List<int>();

            for (int i=0; i<=dgvUser.Rows.Count-1; i++)
            {
                if(Convert.ToBoolean(dgvUser.Rows[i].Cells[0].Value) == true)
                {
                    using (AppContext db = new AppContext())
                    {
                        UserId = Convert.ToInt32(dgvUser.Rows[i].Cells[1].Value);
                        UserDetails ud = (from x in db.Details select x).Where(x => x.Id == UserId && x.Deleted == false).SingleOrDefault();
                        Course cr = (from y in db.Courses select y).Where(y => y.Id == crsId && y.Deleted == false).SingleOrDefault();
                        Supliment sup = (from z in db.Supliments select z).Where(z => z.UserDetailsId == ud.Id && z.CourseId == cr.Id).FirstOrDefault();
                        //sp2.Ocupation = cr.Ocupation;
                        //sp2.Furnizor = cr.OrganizedBy;
                        //sp2.Hours = cr.Duration;
                        sp2.CourseId = cr.Id;
                        sp2.UserDetailsId = ud.Id;

                        if(sup == null)
                        {
                            sp.Deleted = false;
                            db.Entry(sp2).State = EntityState.Added;
                            
                            //ud.FullName = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();
                            //MessageBox.Show("Added");

                            //sp2.Course = null;
                            //sp2.Users = null;

                            db.SaveChanges();

                        }
                        else if(sup.Deleted == true)
                        {
                            sup.Deleted = false;
                            db.Entry(sup).State = EntityState.Modified;

                            //ud.FullName = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();
                            //MessageBox.Show("Added");

                            //sp2.Course = null;
                            //sp2.Users = null;

                            db.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}
