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
    public partial class frmStatistics : Form
    {
        UserDetails ud = new UserDetails();

        public frmStatistics()
        {
            InitializeComponent();
            panel1.Anchor = AnchorStyles.Top;
            panel2.Anchor = AnchorStyles.Top;
            panel3.Anchor = AnchorStyles.Top;
            panel4.Anchor = AnchorStyles.Top;
            lblCourse.Anchor = AnchorStyles.Top;
            comboBox1.Anchor = AnchorStyles.Top;
            panel5.Anchor = AnchorStyles.Top;

            using (AppContext db = new AppContext())
            {
                lblTotalUsers.Text = db.Details.Select(x => x.Id).Distinct().Count().ToString();
                lblMale.Text = db.Details.Where(x => x.Gender == "Male").Distinct().Count().ToString();
                lblFemale.Text = db.Details.Where(x => x.Gender == "Female").Distinct().Count().ToString();
                lblNotSpecified.Text = db.Details.Where(x => x.Gender == null || x.Gender == "Not Specified").Distinct().Count().ToString();
            }
        }


    }
}
