using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PrimarySchoolAPP
{
    public partial class StudentAdd :  MetroFramework.Forms.MetroForm
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");

        SqlCommand cmd;
        string imgLoc = "";

        public StudentAdd()
        {
            InitializeComponent();
        }
        public void displayDataStudent()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Student";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewStudent.DataSource = dt;
                da.Update(dt);
                dataGridViewStudent.AllowUserToAddRows = false;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

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
            displayDataStudent();
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

        private void SaveBNT_Click(object sender, EventArgs e)
        {

            try
            {

                byte[] img = null;

                if (StuPhoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    StuPhoto.Image.Save(ms, StuPhoto.Image.RawFormat);
                    img = ms.GetBuffer();
                    ms.Close();
                }

                if (StuPhoto.Image == null)
                {
                    MessageBox.Show("Please Update Image ", "WARRING NOT SAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                if (ERN.Text != "" && FnameStuTB.Text != "" && MiddnameStuTB.Text != "" && LastNameStuTB.Text != "" && BirthNum.Text != "" && DOBStudt.Text != "" && DateRegdt.Text != ""   && HousecomboBx.Text != "" && ClubcomboBx.Text != "" && GenderComBx.Text != "" && StuAddress.Text !=  ""  && motherName.Text != "" && mothersOccupation.Text != "" && motherAddress.Text != "" && mothersTelephone.Text != "" && fathersName.Text != "" && fathersOccupation.Text != "" && fathersAddress.Text != "" && fathersTelephone.Text != ""&& GuardianName.Text != "" && GuardianOccupation.Text != "" && GuardianAddress.Text != "" && GuardianTelephone.Text != "")
                {
                    string sql = "INSERT INTO Student(ERN,FisrtName,MiddleName,LastName,BirthNum,DOB,DOReg,House,Club,Gender,StudentAddress,MotherName,MatherOccupation,MotherAddress,MotherTel,FatherName,FatherOccupation,FatherAddress,FatherTel,GuardianName,GuardianOccupation,GuardianAddress,GuardianTel,Photo) values('" + ERN.Text + "','" + FnameStuTB.Text + "','" + MiddnameStuTB.Text + "','" + LastNameStuTB.Text + "','" + BirthNum.Text + "','" + DOBStudt.Text + "','" + DateRegdt.Text + "','" + GenderComBx.Text + "','" + HousecomboBx.Text + "','" + ClubcomboBx.Text + "','" + StuAddress.Text + "','" + motherName.Text + "','" + mothersOccupation.Text + "','" + motherAddress.Text + "','" + mothersTelephone.Text + "','" + fathersName.Text + "','" + fathersOccupation.Text + "','" + fathersAddress.Text + "','" + fathersTelephone.Text + "','" + GuardianName.Text + "','" + GuardianOccupation.Text + "','" + GuardianAddress.Text + "','" + GuardianTelephone.Text + "', @img)";

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    displayDataStudent();
                   // ClearData();
                    MessageBox.Show(x.ToString() + " Record inserted successfully");
                }

                else
                {
                    MessageBox.Show("Please Provide Details!", "Record not save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void browseBnt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALL Files(*.*)|*.*";
                dlg.Title = "Select Student Picture";


                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    StuPhoto.ImageLocation = imgLoc;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
