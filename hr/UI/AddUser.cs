using ExcelDataReader;
using hr.Models;
using hr.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace hr
{
    public partial class frmAddUser : Form
    {
        UserDetails ud = new UserDetails();
        public frmAddUser()
        {
            InitializeComponent();
            pnlAddUser.Anchor = AnchorStyles.Top;
            
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
                    if (string.IsNullOrEmpty(c.Text) && c.Name != "txtEmail")
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
            if(!string.IsNullOrEmpty(builder.ToString()))
            { 
                MessageBox.Show(builder.ToString());
            }
            return state;
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fr = new frmMain();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Put a mandatory in label (*), also highlight the texbox which  in empty
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
                ud.BirthDay = dpBob.Value;
                ud.FullName = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();
                ud.Deleted = false;
                try
                {
                    if (!textBox_validator())
                    {
                        db.Details.Add(ud);
                        db.SaveChanges();
                        MessageBox.Show("Commited");
                    }
                }
                catch
                {
                    MessageBox.Show("Send an e-mail to AM Support!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(ThreadMethod));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        static void ThreadMethod()
        {
            OpenFileDialog ope = new OpenFileDialog();
            ope.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (ope.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream stream = new FileStream(ope.FileName, FileMode.Open);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            DataSet result = excelReader.AsDataSet();

            AppContext conn = new AppContext();
            foreach (DataTable table in result.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    UserDetails ud = new UserDetails();
                    {
                        ud.FirstName = Convert.ToString(dr[0]);

                    };
                    conn.Details.Add(ud);
                }
            }
            conn.SaveChanges();
            excelReader.Close();
            stream.Close();

            MessageBox.Show("Imported!");
        }
    }
}
