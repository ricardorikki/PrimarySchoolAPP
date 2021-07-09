using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimarySchoolAPP
{
    public partial class StudentAdd :  MetroFramework.Forms.MetroForm
    {


        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");


    
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            metroTabPage1.Text = @"Bio";
            metroTabPage2.Text = @"Personality Record";
            metroTabPage3.Text = @"Health Record";
            metroTabPage4.Text = @"Attendance Record";
            metroTabPage5.Text = @"Academic Progress Record";

            FnameStuTB.Text = "First Name";
            MiddnameStuTB.Text = "Middle Name";
            LastNameStuTB.Text = "Last Name";
            ERN.Text = "Student Reg. Number";

            FnameStuTB.ForeColor = Color.Gray;
            MiddnameStuTB.ForeColor = Color.Gray;
            LastNameStuTB.ForeColor = Color.Gray;
            ERN.ForeColor = Color.Gray;

            GenderComBx.Items.Add("Male");
            GenderComBx.Items.Add("Female");
            ClubcomboBx.Items.Add("Computer");
            ClubcomboBx.Items.Add("4H");
            ClubcomboBx.Items.Add("Builders");
            ClubcomboBx.Items.Add("Cub Scouth");
            ClubcomboBx.Items.Add("Girls Guide");
            HousecomboBx.Items.Add("Red-Fullerton");
            HousecomboBx.Items.Add("Blue-McLoud");
            HousecomboBx.Items.Add("Yellow-Dalass");
            HousecomboBx.Items.Add("Purple-AJ'S");

        }

        private void FnameStuTB_Enter(object sender, EventArgs e)
        {
            if (FnameStuTB.Text == "First Name")
            {
                FnameStuTB.Text = "";
            }
        }

        private void FnameStuTB_Leave(object sender, EventArgs e)
        {
            if (FnameStuTB.Text == "")
            {
                FnameStuTB.Text = "First Name";
            }
        }

        private void MiddnameStuTB_Leave(object sender, EventArgs e)
        {
            if (MiddnameStuTB.Text == "")
            {
                MiddnameStuTB.Text = "Middle Name";
            }
        }

        private void MiddnameStuTB_Enter(object sender, EventArgs e)
        {
            if (MiddnameStuTB.Text == "Middle Name")
            {
                MiddnameStuTB.Text = "";
            }
        }

        private void LastNameStuTB_Leave(object sender, EventArgs e)
        {
            if (LastNameStuTB.Text == "")
            {
                LastNameStuTB.Text = "Last Name";
            }
        }

        private void LastNameStuTB_Enter(object sender, EventArgs e)
        {
            if (LastNameStuTB.Text == "Last Name")
            {
                LastNameStuTB.Text = "";
            }
        }

        private void ERN_Leave(object sender, EventArgs e)
        {
            if (ERN.Text == "")
            {
                ERN.Text = "Student Reg. Number";
            }
        }

        private void ERN_Enter(object sender, EventArgs e)
        {
            if (ERN.Text == "Student Reg. Number")
            {
                ERN.Text = "";
            }
        }
    }
}
