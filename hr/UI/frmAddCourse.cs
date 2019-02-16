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
    public partial class frmAddCourse : Form
    {
        Supliment sp = new Supliment();
        Course cr = new Course();
        public frmAddCourse()
        {
            InitializeComponent();
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
                    if (string.IsNullOrEmpty(c.Text) && c.Name != "txtRegistrationNumber")
                    {
                        //MessageBox.Show(c.Name + " must be filled");
                        list.Add(c.Name + " must be filled");
                        c.BackColor = Color.Yellow;
                        c.Focus();
                        state = true;
                    }
                }
            }
            foreach (string str in list)
            {
                builder.Append(str.ToString()).AppendLine();
            }
            MessageBox.Show(builder.ToString());
            return state;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                try
                {
                    if (!textBox_validator())
                    {
                        cr.CourseName = txtCourseName.Text.Trim();
                        cr.StartDate = dtpStart.Value;
                        cr.EndDate = dtpEnd.Value;
                        cr.Duration = int.Parse(txtDuration.Text);
                        cr.Ocupation = txtOcupation.Text.Trim();
                        cr.COR = int.Parse(txtCOR.Text.Trim());
                        cr.OrganizedBy = txtOrganizedBy.Text.Trim();
                        cr.LocationCounty = txtLocationCounty.Text.Trim();
                        cr.County = txtCounty.Text.Trim();
                        cr.RegistrationNumber = txtRegistrationNumber.Text == "" ? (int?)null : Convert.ToInt32(txtRegistrationNumber.Text);
                        cr.Deleted = false;

                        db.Courses.Add(cr);
                        db.SaveChanges();

                        int id = cr.Id;
                        string ocupation = cr.Ocupation;
                        string orgBy = cr.OrganizedBy;
                        int duration = cr.Duration;
                        sp.CourseId = id;
                        sp.Ocupation= ocupation;
                        sp.Furnizor = orgBy;
                        sp.Hours = duration;

                        db.Supliments.Add(sp);
                        MessageBox.Show("Commited");
                        db.SaveChanges();
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
