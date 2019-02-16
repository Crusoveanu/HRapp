using hr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MySql.Data.Entity;

namespace hr
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

    Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new UI.frmMain());
            }
        //TO DO: form pentru userii care nu-s autorizati.
        //UserDetails details = new UserDetails();
        //Course Courses = new Course();


        //competences.Competences = "Good";
        //details.FullName = "Gabriel";
        //
        //AppContext context = new AppContext();
        //context.Competences.Add(competences);
        //context.Details.Add(details);
        //
        //context.SaveChanges();
    }
}
