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
                dataGridViewStudent2.DataSource = dt;
                da.Update(dt);
                dataGridViewStudent.AllowUserToAddRows = false;
                dataGridViewStudent2.AllowUserToAddRows = false;


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
        public void displayDataAttendance()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  Student.id[student ID],Student.FisrtName[First Name], Student.MiddleName[Middle Name], Student.LastName[Last Name], Student.DOB[Date of Birth], .Attendance.Yr1_Term1[Grade 1 Term1], Attendance.Yr1_Term2[Grade 1 Term2], Attendance.Yr1_Term3[Grade 1 Term3], Attendance.Yr2_Term1[Grade 2 Term1],Attendance.Yr2_Term2[Grade 2 Term2], Attendance.Yr2_Term3[Grade 2 Term3], Attendance.Yr3_Term1[Grade 3 Term1], Attendance.Yr3_Term2[Grade 3 Term2], Attendance.Yr3_Term3[Grade 3 Term3], Attendance.Yr4_Term1[Grade 4 Term1], Attendance.Yr4_Term2[Grade 4 Term2], Attendance.Yr4_Term3[Grade 4 Term3],Attendance.Yr5_Term1[Grade 5 Term1], Attendance.Yr5_Term2[Grade 5 Term2], Attendance.Yr5_Term3[Grade 5 Term3], Attendance.Yr6_Term1[Grade 6 Term1], Attendance.Yr6_Term2[Grade 6 Term2], Attendance.Yr6_Term3[Grade 6 Term3],Student.Photo FROM Attendance INNER JOIN Student ON Attendance.id_Stu = Student.id";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewAttendance.DataSource = dt;
                da.Update(dt);
                dataGridViewAttendance.AllowUserToAddRows = false;
                
               

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
            MaximizeBox = false;
            ControlBox = true;
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
            displayDataAttendance();
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
                    string sql = "INSERT INTO Student(ERN,FisrtName,MiddleName,LastName,BirthNum,DOB,DOReg,House,Club,Gender,StudentAddress,MotherName,MatherOccupation,MotherAddress,MotherTel,FatherName,FatherOccupation,FatherAddress,FatherTel,GuardianName,GuardianOccupation,GuardianAddress,GuardianTel,Photo) values('" + ERN.Text + "','" + FnameStuTB.Text + "','" + MiddnameStuTB.Text + "','" + LastNameStuTB.Text + "','" + BirthNum.Text + "','" + DOBStudt.Text + "','" + DateRegdt.Text + "','" + HousecomboBx.Text + "','" + ClubcomboBx.Text + "','" + GenderComBx.Text + "','" + StuAddress.Text + "','" + motherName.Text + "','" + mothersOccupation.Text + "','" + motherAddress.Text + "','" + mothersTelephone.Text + "','" + fathersName.Text + "','" + fathersOccupation.Text + "','" + fathersAddress.Text + "','" + fathersTelephone.Text + "','" + GuardianName.Text + "','" + GuardianOccupation.Text + "','" + GuardianAddress.Text + "','" + GuardianTelephone.Text + "', @img)";

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
          
        }

        private void dataGridViewStudent2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewStudent2.Rows[e.RowIndex];
                    studentid.Text = row.Cells[0].Value.ToString();
                    FnameTB.Text = row.Cells[2].Value.ToString();
                    MiddnameTB.Text = row.Cells[3].Value.ToString();
                    LastNameTB.Text = row.Cells[4].Value.ToString();
                   
                    var data = (Byte[])(row.Cells[24].Value);
                    var stream = new MemoryStream(data);
                    StudentPhoto.Image = Image.FromStream(stream);
                    Y1T1.Text = "";
                    Y1T2.Text = ""; 
                    Y1T3.Text = "";
                    Y2T1.Text = ""; 
                    Y2T2.Text = ""; 
                    Y2T3.Text = ""; 
                    Y3T1.Text = "";
                    Y3T2.Text = ""; 
                    Y3T3.Text = ""; 
                    Y4T1.Text = "";
                    Y4T2.Text = ""; 
                    Y4T3.Text = "";
                    Y5T1.Text = "";
                    Y5T2.Text = "";
                    Y5T3.Text = "";
                    Y6T1.Text = "";
                    Y6T2.Text = ""; 
                    Y6T3.Text = "";
     

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

        private void saveAttenBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

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

                SqlCommand cmd = new SqlCommand("SELECT * from Attendance where id_Stu =@id_Stu", con);
                cmd.Parameters.AddWithValue("@id_Stu", studentid.Text.ToLower());
                //con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Record already exist");
                   con.Close();
                }
                else
                {
                   con.Close();
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Attendance(Yr1_Term1, Yr1_Term2, Yr1_Term3, Yr2_Term1, Yr2_Term2, Yr2_Term3, Yr3_Term1, Yr3_Term2, Yr3_Term3, Yr4_Term1, Yr4_Term2, Yr4_Term3, Yr5_Term1, Yr5_Term2, Yr5_Term3, Yr6_Term1, Yr6_Term2, Yr6_Term3,id_Stu) VALUES(@Yr1_Term1, @Yr1_Term2, @Yr1_Term3, @Yr2_Term1, @Yr2_Term2, @Yr2_Term3, @Yr3_Term1, @Yr3_Term2, @Yr3_Term3, @Yr4_Term1, @Yr4_Term2, @Yr4_Term3, @Yr5_Term1, @Yr5_Term2, @Yr5_Term3, @Yr6_Term1, @Yr6_Term2, @Yr6_Term3,@id_Stu)", con);
                    //cmd = new SqlCommand("INSERT INTO Attendance(id_Stu) VALUES(@id_Stu)", con);

                    cmd.Parameters.AddWithValue("@Yr1_Term1", Y1T1.Text);
                    cmd.Parameters.AddWithValue("@Yr1_Term2", Y1T2.Text);
                    cmd.Parameters.AddWithValue("@Yr1_Term3", Y1T3.Text);
                    cmd.Parameters.AddWithValue("@Yr2_Term1", Y2T1.Text);
                    cmd.Parameters.AddWithValue("@Yr2_Term2", Y2T2.Text);
                    cmd.Parameters.AddWithValue("@Yr2_Term3", Y2T3.Text);
                    cmd.Parameters.AddWithValue("@Yr3_Term1", Y3T1.Text);
                    cmd.Parameters.AddWithValue("@Yr3_Term2", Y3T2.Text);
                    cmd.Parameters.AddWithValue("@Yr3_Term3", Y3T3.Text);
                    cmd.Parameters.AddWithValue("@Yr4_Term1", Y4T1.Text);
                    cmd.Parameters.AddWithValue("@Yr4_Term2", Y4T2.Text);
                    cmd.Parameters.AddWithValue("@Yr4_Term3", Y4T3.Text);
                    cmd.Parameters.AddWithValue("@Yr5_Term1", Y5T1.Text);
                    cmd.Parameters.AddWithValue("@Yr5_Term2", Y5T2.Text);
                    cmd.Parameters.AddWithValue("@Yr5_Term3", Y5T3.Text);
                    cmd.Parameters.AddWithValue("@Yr6_Term1", Y6T1.Text);
                    cmd.Parameters.AddWithValue("@Yr6_Term2", Y6T2.Text);
                    cmd.Parameters.AddWithValue("@Yr6_Term3", Y6T3.Text);
                    cmd.Parameters.AddWithValue("@id_Stu", studentid.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully.");
                    displayDataAttendance();
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
