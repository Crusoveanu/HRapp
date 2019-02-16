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
    public partial class frmSupliment : Form
    {
        public int crsId;
        public Supliment sp = new Supliment();
        public frmSupliment()
        {
            InitializeComponent();
        }
        private void frmSupliment_Load(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                Course cr = (from y in db.Courses select y).Where(y => y.Id == crsId && y.Deleted == false).SingleOrDefault();
                Supliment sup = (from z in db.Supliments select z).Where(z => z.CourseId == cr.Id).FirstOrDefault();
                txtType.Text = sup.Type;
                txtSeries.Text = sup.Seria;
                txtNumber.Text = sup.Number.ToString();
                txtOcupation.Text = sup.Ocupation;
                txtCOR.Text = cr.COR.ToString();
                txtOrganizedBy.Text = cr.OrganizedBy;
                txtCalifLevel.Text = sup.Califications;
                txtStudyLevel.Text = sup.StudyLevel;
                txtProgramType.Text = sup.ProgramType;
                txtHours.Text = sup.Hours.ToString();
                txtTotal.Text = sup.Total.ToString();
                txtTeoreticPreg.Text = sup.TeoreticPreg;
                txtPractPreg.Text = sup.PracticPreg;
                txtCompetences.Text = sup.Competences;
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                Course cr = (from y in db.Courses select y).Where(y => y.Id == crsId && y.Deleted == false).SingleOrDefault();
                Supliment sup = (from z in db.Supliments select z).Where(z => z.CourseId == cr.Id).FirstOrDefault();

                sup.Type = txtType.Text.Trim();
                sup.Seria = txtSeries.Text.Trim();
                sup.Number = int.Parse(txtNumber.Text.Trim());
                sup.Ocupation = cr.Ocupation;
                sup.Hours = cr.Duration;
                cr.COR = int.Parse(txtCOR.Text);
                cr.OrganizedBy = txtOrganizedBy.Text.Trim();
                sup.Califications = txtCalifLevel.Text.Trim();
                sup.StudyLevel = txtStudyLevel.Text.Trim();
                sup.ProgramType = txtProgramType.Text.Trim();
                sup.Total = int.Parse(txtTotal.Text.Trim());
                sup.TeoreticPreg = txtTeoreticPreg.Text.Trim();
                sup.PracticPreg = txtPractPreg.Text.Trim();
                sup.Competences = txtCompetences.Text.Trim();

                if (MessageBox.Show("Are you sure you want to edit this user?", "Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (crsId == sup.CourseId)
                    {
                        db.Entry(sup).State = EntityState.Modified;
                        MessageBox.Show("Edited");
                    }
                    else
                    {
                        db.Entry(sup).State = EntityState.Added;
                        MessageBox.Show("Added");
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
