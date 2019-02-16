using hr.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
            panel2.Visible = false;
            btnPrev.Visible = false;
            btnNext.Visible = false;
        }
        //Suppliments
        private void btnSup_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cmbBox.Visible = true;
            btnPrev.Visible = true;
            btnNext.Visible = true;
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
                var supliments = (from x in db.Supliments where x.CourseId == course.Id && x.Deleted == false select x).First();

                txtCalifications.Text = supliments.Califications;
                txtCOR.Text = course.COR.ToString();
                txtSeries.Text = supliments.Seria;
                txtType.Text = supliments.Type;
                txtNumber.Text = supliments.Number.ToString();
                txtCOD.Text = "ASK HR";
                txtFurnizor.Text = supliments.Furnizor;
                txtLevel.Text = supliments.StudyLevel;
                txtMarks.Text = "de la 1 la 10";
                txtCalif.Text = supliments.Califications;
                txtLegalBase.Text = "OG 129/2000";
                txtStudyLevel.Text = supliments.StudyLevel;
                txtDuration.Text = course.Duration.ToString();
                txtTotal.Text = supliments.Total.ToString();
                txtThPreg.Text = supliments.TeoreticPreg;
                txtPracticPreg.Text = supliments.PracticPreg;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Refresh();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);

            float tgtWidthMM = 210;  //A4 paper size
            float tgtHeightMM = 297;
            float tgtWidthInches = tgtWidthMM / 25.4f;
            float tgtHeightInches = tgtHeightMM / 25.4f;
            float srcWidthPx = bmp.Width;
            float srcHeightPx = bmp.Height;
            float dpiX = srcWidthPx / tgtWidthInches;
            float dpiY = srcHeightPx / tgtHeightInches;

            bmp.SetResolution(dpiX, dpiY);

            panel1.DrawToBitmap(bmp, panel1.ClientRectangle);

            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            e.Graphics.DrawImage(bmp, 0, 0, tgtWidthMM, tgtHeightMM);
        }
        //Exams
        private void btnExam_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }


    }
}
