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
    public partial class userConStudent1 : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");

        //SqlCommand cmd;
  
        public userConStudent1()
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
                cmd.CommandText = "SELECT id[Student ID], ERN, FisrtName[First Name], MiddleName[Middle Name], LastName[Last Name], BirthNum[Birth Cert. #], DOB[Date of Birth], DOReg[Date of Reg.], House, Club, Gender, StudentAddress[Student Address], MotherName[Mother Name], MatherOccupation[Mother Occupation], MotherAddress[Mother Address], MotherTel[Mother Telephone], FatherName[Father Name], FatherOccupation[Father Occupation], FatherAddress[Father Address], FatherTel[Father Telephone], GuardianName[Guardian Name], GuardianOccupation[Guardian Occupation], GuardianAddress[Guardian Address], GuardianTel[Guardian Telephone], Photo FROM Student";
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
        private void userConStudent1_Load(object sender, EventArgs e)
        {
            displayDataStudent();
        }

        private void editBNT_Click(object sender, EventArgs e)
        {

            Dashboard DAS =(Dashboard)this.Parent;
            this.Dispose(false);
            DAS.Hide();

            StudentAdd stu = new StudentAdd();
            this.Dispose(false);
            stu.Show();
            this.Hide();



        }

        private void StudentSearTB_TextChanged(object sender, EventArgs e)
        {
            try
            {



                if (StudentSearCOBO.Text == "Student ID")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT id[Student ID], ERN, FisrtName[First Name], MiddleName[Middle Name], LastName[Last Name], BirthNum[Birth Cert. #], DOB[Date of Birth], DOReg[Date of Reg.], House, Club, Gender, StudentAddress[Student Address], MotherName[Mother Name], MatherOccupation[Mother Occupation], MotherAddress[Mother Address], MotherTel[Mother Telephone], FatherName[Father Name], FatherOccupation[Father Occupation], FatherAddress[Father Address], FatherTel[Father Telephone], GuardianName[Guardian Name], GuardianOccupation[Guardian Occupation], GuardianAddress[Guardian Address], GuardianTel[Guardian Telephone], Photo FROM Student where [id] like'" + StudentSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewStudent.DataSource = dt;
                }

                else if (StudentSearCOBO.Text == "ERN")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT id[Student ID], ERN, FisrtName[First Name], MiddleName[Middle Name], LastName[Last Name], BirthNum[Birth Cert. #], DOB[Date of Birth], DOReg[Date of Reg.], House, Club, Gender, StudentAddress[Student Address], MotherName[Mother Name], MatherOccupation[Mother Occupation], MotherAddress[Mother Address], MotherTel[Mother Telephone], FatherName[Father Name], FatherOccupation[Father Occupation], FatherAddress[Father Address], FatherTel[Father Telephone], GuardianName[Guardian Name], GuardianOccupation[Guardian Occupation], GuardianAddress[Guardian Address], GuardianTel[Guardian Telephone], Photo from Student where [ERN] like'" + StudentSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewStudent.DataSource = dt;
                }


                else if (StudentSearCOBO.Text == "First Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT id[Student ID], ERN, FisrtName[First Name], MiddleName[Middle Name], LastName[Last Name], BirthNum[Birth Cert. #], DOB[Date of Birth], DOReg[Date of Reg.], House, Club, Gender, StudentAddress[Student Address], MotherName[Mother Name], MatherOccupation[Mother Occupation], MotherAddress[Mother Address], MotherTel[Mother Telephone], FatherName[Father Name], FatherOccupation[Father Occupation], FatherAddress[Father Address], FatherTel[Father Telephone], GuardianName[Guardian Name], GuardianOccupation[Guardian Occupation], GuardianAddress[Guardian Address], GuardianTel[Guardian Telephone], Photo FROM Student where [FisrtName] like'" + StudentSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewStudent.DataSource = dt;
                }
                else if (StudentSearCOBO.Text == "Last Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT id[Student ID], ERN, FisrtName[First Name], MiddleName[Middle Name], LastName[Last Name], BirthNum[Birth Cert. #], DOB[Date of Birth], DOReg[Date of Reg.], House, Club, Gender, StudentAddress[Student Address], MotherName[Mother Name], MatherOccupation[Mother Occupation], MotherAddress[Mother Address], MotherTel[Mother Telephone], FatherName[Father Name], FatherOccupation[Father Occupation], FatherAddress[Father Address], FatherTel[Father Telephone], GuardianName[Guardian Name], GuardianOccupation[Guardian Occupation], GuardianAddress[Guardian Address], GuardianTel[Guardian Telephone], Photo FROM Student where [LastName] like'" + StudentSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewStudent.DataSource = dt;
                }

               
                else if (StudentSearCOBO.Text == "Gender")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT id[Student ID], ERN, FisrtName[First Name], MiddleName[Middle Name], LastName[Last Name], BirthNum[Birth Cert. #], DOB[Date of Birth], DOReg[Date of Reg.], House, Club, Gender, StudentAddress[Student Address], MotherName[Mother Name], MatherOccupation[Mother Occupation], MotherAddress[Mother Address], MotherTel[Mother Telephone], FatherName[Father Name], FatherOccupation[Father Occupation], FatherAddress[Father Address], FatherTel[Father Telephone], GuardianName[Guardian Name], GuardianOccupation[Guardian Occupation], GuardianAddress[Guardian Address], GuardianTel[Guardian Telephone], Photo FROM Student where [Gender] like'" + StudentSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewStudent.DataSource = dt;
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

        private void editBNT_MouseClick(object sender, MouseEventArgs e)
        {

            //Dashboard DAS = new Dashboard();
            //DAS.Hide();

            //ForgetPassword fp = new ForgetPassword();
            //this.Dispose(false);
            //fp.Show();
            //this.Hide();




            //StudentAdd stu = new StudentAdd();
            //this.Dispose(false);
            //stu.Show();
            //this.Hide();

        }

        
    }
}
