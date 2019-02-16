using hr.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hr.UI
{
    public partial class frmPrinter : Form
    {
        public frmPrinter()
        {
            InitializeComponent();
            FillCombobox();
            panel1.Visible = false;
            cmbBox.Visible = false;
        }
        //Suppliments
        private void btnSup_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cmbBox.Visible = true;
            panel1.Refresh();
        }

        public void FillCombobox()
        {
            frmSupliment sp = new frmSupliment();
            using (AppContext db = new AppContext())
            {
                var courseName = db.Courses.Select(x => x.CourseName).ToList();

                foreach (var item in courseName)
                    cmbBox.Items.Add(item);
            }
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                var getClientID = cmbBox.SelectedItem.ToString();
                var course = (from t in db.Courses where t.CourseName == getClientID && t.Deleted == false select t).Single();
                var supliments = (from x in db.Supliments where x.CourseId == course.Id && x.Deleted == false select x).Single();

                textBox1.Text = supliments.Type;
                textBox2.Text = course.COR.ToString();
                txtSeries.Text = supliments.Seria;
                //textBox1.Text = fillTextBoxes.Ocupation;
                //textBox1.Text = fillTextBoxes.Ocupation;
                //textBox1.Text = fillTextBoxes.Ocupation;
                //textBox1.Text = fillTextBoxes.Ocupation;
                //textBox1.Text = fillTextBoxes.Ocupation;


            }
        }

        //Exams
        private void btnExam_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
