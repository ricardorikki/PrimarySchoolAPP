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
    public partial class StudentAdd : MetroFramework.Forms.MetroForm
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");

        //SqlCommand cmd;
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
                cmd.CommandText = "SELECT id[Student ID], ERN, FisrtName[First Name], MiddleName[Middle Name], LastName[Last Name], BirthNum[Birth Cert. #], DOB[Date of Birth], DOReg[Date of Reg.], House, Club, Gender, StudentAddress[Student Address], MotherName[Mother Name], MatherOccupation[Mother Occupation], MotherAddress[Mother Address], MotherTel[Mother Telephone], FatherName[Father Name], FatherOccupation[Father Occupation], FatherAddress[Father Address], FatherTel[Father Telephone], GuardianName[Guardian Name], GuardianOccupation[Guardian Occupation], GuardianAddress[Guardian Address], GuardianTel[Guardian Telephone], Photo FROM Student";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewStudent.DataSource = dt;
                dataGridViewStudent2.DataSource = dt;
                dataGridViewStudent3.DataSource = dt;
                dataGridViewStudentHealth.DataSource = dt;
                da.Update(dt);
                dataGridViewStudent.AllowUserToAddRows = false;
                dataGridViewStudent2.AllowUserToAddRows = false;
                dataGridViewStudent3.AllowUserToAddRows = false;
                dataGridViewStudentHealth.AllowUserToAddRows = false;
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
                cmd.CommandText = "SELECT  Student.id[Student ID],Student.FisrtName[First Name], Student.MiddleName[Middle Name], Student.LastName[Last Name], Student.DOB[Date of Birth], .Attendance.Yr1_Term1[Grade 1 Term1], Attendance.Yr1_Term2[Grade 1 Term2], Attendance.Yr1_Term3[Grade 1 Term3], Attendance.Yr2_Term1[Grade 2 Term1],Attendance.Yr2_Term2[Grade 2 Term2], Attendance.Yr2_Term3[Grade 2 Term3], Attendance.Yr3_Term1[Grade 3 Term1], Attendance.Yr3_Term2[Grade 3 Term2], Attendance.Yr3_Term3[Grade 3 Term3], Attendance.Yr4_Term1[Grade 4 Term1], Attendance.Yr4_Term2[Grade 4 Term2], Attendance.Yr4_Term3[Grade 4 Term3],Attendance.Yr5_Term1[Grade 5 Term1], Attendance.Yr5_Term2[Grade 5 Term2], Attendance.Yr5_Term3[Grade 5 Term3], Attendance.Yr6_Term1[Grade 6 Term1], Attendance.Yr6_Term2[Grade 6 Term2], Attendance.Yr6_Term3[Grade 6 Term3],Student.Photo FROM Attendance INNER JOIN Student ON Attendance.id_Stu = Student.id";
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
        public void displayDataAssessment()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Student.id[Student ID],Student.ERN, Student.FisrtName[Fisrt Name], Student.MiddleName[Middle Name], Student.LastName[Last Name], National_Assessment.GenKnowledge[General Knowledge], National_Assessment.NumberConcepts[Number Concepts], National_Assessment.OralLang[Oral Language], National_Assessment.Reading, National_Assessment.Structure, National_Assessment.Vocab[Vocabulary], National_Assessment.StudySkills[Study Skills], National_Assessment.ComTask[Com. Task], National_Assessment.NumEst[Number Estimation & Measurement], National_Assessment.Geometry, National_Assessment.Algebra, National_Assessment.[Statistics], National_Assessment.LangArtGrade4[Lang. Arts Grade 4], National_Assessment.MathGrade4[Math Grade 4],National_Assessment.LangArtGrade5[Lang. Arts Grade 5], National_Assessment.MathGrade5[Math Grade 5], National_Assessment.LangArtGrade6[Lang. Arts 6], National_Assessment.AbilityTest[Ability Test], National_Assessment.MathGrade6[Math Grade 6],National_Assessment.LangArtGrade6Curri[Lang. Arts Grade 6 Curriculum], National_Assessment.MathGrade6Curri[Math Grade 6 Curriculum], National_Assessment.Science,National_Assessment.SocialStudies[Social Studies], National_Assessment.id_Stu[Student ID], National_Assessment.WritingDrawing[Writing Drawing] FROM Student INNER JOIN National_Assessment ON Student.id = National_Assessment.id_Stu";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewAssessment.DataSource = dt;
                da.Update(dt);
                dataGridViewAssessment.AllowUserToAddRows = false;



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
        public void displayDataHealth()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Stu_Health.id_Student[Student ID], Student.ERN, Student.FisrtName[First Name], Student.MiddleName[Middle Name],Student.LastName[Last Name], Stu_Health.Physical_Defects[Physical Defects], Stu_Health.Asthmatic, Stu_Health.Heart_Problem[Heart Problem], Stu_Health.Urinary_Disorder[Urinary Disorder],  Stu_Health.Ear_Problem[Ear Problem], Stu_Health.Eye_Problem[Eye Problem], Stu_Health.Other, Student.Photo FROM Student INNER JOIN Stu_Health ON Student.id = Stu_Health.id_Student";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewHealth.DataSource = dt;
                da.Update(dt);
                dataGridViewHealth.AllowUserToAddRows = false;



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
        public void Clear()
        {

            GenKnw.Text = "";
            NumCon.Text = "";
            OralLang.Text = "";
            Reading.Text = "";
            Structure.Text = "";
            Vocab.Text = "";
            StudySkills.Text = "";
            ComTask.Text = "";
            NumEst.Text = "";
            Geometry.Text = "";
            Algebra.Text = "";
            Statistics.Text = "";
            LangArtGrade4.Text = "";
            MathGrade4.Text = "";
            LangArtGrade5.Text = "";
            MathGrade5.Text = "";
            LangArtGrade6.Text = "";
            AbilityTest.Text = "";
            MathGrade6.Text = "";
            LangArtCurriGrade6.Text = "";
            MathCurriGrade6.Text = "";
            SocialStudies.Text = "";
            Science.Text = "";
            FnameStudent.Text = "";
            LnameStudent.Text = "";
            idAssessment.Text = "";
            WriteDraw.Text = "";
        }
        private void StudentAdd_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            ControlBox = true;
            metroTabPage1.Text = @"Bio";
            metroTabPage2.Text = @"Assessment";
            metroTabPage3.Text = @"Health Record";
            metroTabPage4.Text = @"Attendance Record";

            FnameStuTB.Text = "First Name";
            MiddnameStuTB.Text = "Middle Name";
            LastNameStuTB.Text = "Last Name";
            ERN.Text = "Student Reg. Number";

            FnameStuTB.ForeColor = Color.Black;
            MiddnameStuTB.ForeColor = Color.Black;
            LastNameStuTB.ForeColor = Color.Black;
            ERN.ForeColor = Color.Black;

            GenderComBx.Items.Add("Male");
            GenderComBx.Items.Add("Female");
            ClubcomboBx.Items.Add("Computer");
            ClubcomboBx.Items.Add("4H");
            ClubcomboBx.Items.Add("Builders");
            ClubcomboBx.Items.Add("Cub Scout");
            ClubcomboBx.Items.Add("Girls Guide");
            HousecomboBx.Items.Add("Red-Fullerton");
            HousecomboBx.Items.Add("Blue-McLoud");
            HousecomboBx.Items.Add("Yellow-Dalass");
            HousecomboBx.Items.Add("Purple-AJ'S");
            displayDataStudent();
            displayDataAttendance();
            displayDataAssessment();
            displayDataHealth();


            StuPhoto.Image = Properties.Resources.user;
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


        //**************************Attendance Save**************************************************************
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
                    MessageBox.Show("The Record you are attempting to save exists within the Database already.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Record was saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //**************************Attendance CellClick**************************************************************
        private void dataGridViewAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewAttendance.Rows[e.RowIndex];
                    studentid.Text = row.Cells[0].Value.ToString();
                    FnameTB.Text = row.Cells[1].Value.ToString();
                    MiddnameTB.Text = row.Cells[2].Value.ToString();
                    LastNameTB.Text = row.Cells[3].Value.ToString();
                    Y1T1.Text = row.Cells[5].Value.ToString();
                    Y1T2.Text = row.Cells[6].Value.ToString();
                    Y1T3.Text = row.Cells[7].Value.ToString();
                    Y2T1.Text = row.Cells[8].Value.ToString();
                    Y2T2.Text = row.Cells[9].Value.ToString();
                    Y2T3.Text = row.Cells[10].Value.ToString();
                    Y3T1.Text = row.Cells[11].Value.ToString();
                    Y3T2.Text = row.Cells[12].Value.ToString();
                    Y3T3.Text = row.Cells[13].Value.ToString();
                    Y4T1.Text = row.Cells[14].Value.ToString();
                    Y4T2.Text = row.Cells[15].Value.ToString();
                    Y4T3.Text = row.Cells[16].Value.ToString();
                    Y5T1.Text = row.Cells[17].Value.ToString();
                    Y5T2.Text = row.Cells[18].Value.ToString();
                    Y5T3.Text = row.Cells[19].Value.ToString();
                    Y6T1.Text = row.Cells[20].Value.ToString();
                    Y6T2.Text = row.Cells[21].Value.ToString();
                    Y6T3.Text = row.Cells[22].Value.ToString();
                    var data = (Byte[])(row.Cells[23].Value);
                    var stream = new MemoryStream(data);
                    StudentPhoto.Image = Image.FromStream(stream);



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
        //**************************Attendance Update**************************************************************
        private void UpdateAttenBTN_Click(object sender, EventArgs e)
        {

            try
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                SqlCommand cmd = con.CreateCommand();
                string Sql = "UPDATE Attendance SET Yr1_Term1='" + Y1T1.Text + "',Yr1_Term2='" + Y1T2.Text + "', Yr1_Term3='" + Y1T3.Text + "', Yr2_Term1='" + Y2T1.Text + "', Yr2_Term2='" + Y2T2.Text + "', Yr2_Term3='" + Y2T3.Text + "', Yr3_Term1='" + Y3T1.Text + "', Yr3_Term2='" + Y3T2.Text + "', Yr3_Term3='" + Y3T3.Text + "', Yr4_Term1='" + Y4T1.Text + "', Yr4_Term2='" + Y4T2.Text + "', Yr4_Term3='" + Y4T3.Text + "', Yr5_Term1='" + Y5T1.Text + "', Yr5_Term2='" + Y5T2.Text + "', Yr5_Term3='" + Y5T3.Text + "', Yr6_Term1='" + Y6T1.Text + "', Yr6_Term2='" + Y6T2.Text + "', Yr6_Term3='" + Y6T3.Text + "' WHERE id_Stu='" + studentid.Text + "'";

                cmd = new SqlCommand(Sql, con);
                //cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                displayDataAttendance();
                MessageBox.Show("Record updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ClearData();
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
        //**************************Attendance Delete**************************************************************
        private void DeleteAttenBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("You are about to detele the selected record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete From Attendance WHERE id_Stu='" + studentid.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);
                    dataGridViewAttendance.DataSource = dt;
                    displayDataAttendance();
                    MessageBox.Show("Record Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ClearData();
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
        //**************************Student2-Attendance CellClick**************************************************************
        private void dataGridViewStudent2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
        //**************************Students Delete**************************************************************
        private void DeleteBNT_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("You are about to detele the selected record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    if (IDStuTB.Text != "")
                    {
                        con.Open();




                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Delete From Student WHERE id='" + IDStuTB.Text + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        da.Update(dt);
                        dataGridViewStudent.DataSource = dt;
                        displayDataStudent();
                        MessageBox.Show("Record Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        IDStuTB.Text = "";
                        ERN.Text = "";
                        FnameStuTB.Text = "";
                        MiddnameStuTB.Text = "";
                        LastNameStuTB.Text = ""; ;
                        BirthNum.Text = "";
                        DOBStudt.Text = "";
                        DateRegdt.Text = "";
                        HousecomboBx.Items.Clear();

                        ClubcomboBx.Items.Clear();
                        GenderComBx.Items.Clear();
                        GenderComBx.Items.Add("Male");
                        GenderComBx.Items.Add("Female");
                        ClubcomboBx.Items.Add("Computer");
                        ClubcomboBx.Items.Add("4H");
                        ClubcomboBx.Items.Add("Builders");
                        ClubcomboBx.Items.Add("Cub Scout");
                        ClubcomboBx.Items.Add("Girls Guide");
                        HousecomboBx.Items.Add("Red-Fullerton");
                        HousecomboBx.Items.Add("Blue-McLoud");
                        HousecomboBx.Items.Add("Yellow-Dalass");
                        HousecomboBx.Items.Add("Purple-AJ'S");
                        StuAddress.Text = "";
                        motherName.Text = "";
                        mothersOccupation.Text = "";
                        motherAddress.Text = "";
                        mothersTelephone.Text = "";
                        fathersName.Text = "";
                        fathersOccupation.Text = "";
                        fathersAddress.Text = "";
                        fathersTelephone.Text = "";
                        GuardianName.Text = "";
                        GuardianOccupation.Text = "";
                        GuardianAddress.Text = "";
                        GuardianTelephone.Text = "";
                        StuPhoto.Image = Properties.Resources.user;

                    }
                    else if (IDStuTB.Text == "")
                    {
                        MessageBox.Show("Data Match Error: No data found. Please Check if the Student defails was selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }

                }
            }





            catch (Exception)
            {

                MessageBox.Show("Something went wrong while executing the request. Please ensure that the record is not being used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        } 

    
 //**************************Students Update**************************************************************
        private void UpdateBNT_Click(object sender, EventArgs e)
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



                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand cmd = con.CreateCommand();
                string Sql = "UPDATE Student SET ERN='" + ERN.Text + "',FisrtName='" + FnameStuTB.Text + "',MiddleName='" + MiddnameStuTB.Text + "',LastName='" + LastNameStuTB.Text + "',BirthNum='" + BirthNum.Text + "',DOB='" + DOBStudt.Text + "',DOReg='" + DateRegdt.Text + "',House='" + HousecomboBx.Text + "',Club='" + ClubcomboBx.Text + "',Gender='" + GenderComBx.Text + "',StudentAddress='" + StuAddress.Text + "',MotherName='" + motherName.Text + "',MatherOccupation='" + mothersOccupation.Text + "',MotherAddress='" + motherAddress.Text + "',MotherTel='" + mothersTelephone.Text + "',FatherName='" + fathersName.Text + "',FatherOccupation='" + fathersOccupation.Text + "',FatherAddress='" + fathersAddress.Text + "',FatherTel='" + fathersTelephone.Text + "',GuardianName='" + GuardianName.Text + "',GuardianOccupation='" + GuardianOccupation.Text + "',GuardianAddress='" + GuardianAddress.Text + "',GuardianTel='" + GuardianTelephone.Text + "',Photo=@img WHERE ID='" + IDStuTB.Text + "'";

                cmd = new SqlCommand(Sql, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                displayDataStudent();
                MessageBox.Show("Record updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ClearData();
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
//**************************Students New**************************************************************
        private void NewBNT_Click(object sender, EventArgs e)
        {
            IDStuTB.Text = "";
            ERN.Text = "";
            FnameStuTB.Text = "";
            MiddnameStuTB.Text = "";
            LastNameStuTB.Text = ""; ;
            BirthNum.Text = "";
            DOBStudt.Text = "";
            DateRegdt.Text = "";
            HousecomboBx.Items.Clear();

            ClubcomboBx.Items.Clear();
            GenderComBx.Items.Clear();
            GenderComBx.Items.Add("Male");
            GenderComBx.Items.Add("Female");
            ClubcomboBx.Items.Add("Computer");
            ClubcomboBx.Items.Add("4H");
            ClubcomboBx.Items.Add("Builders");
            ClubcomboBx.Items.Add("Cub Scout");
            ClubcomboBx.Items.Add("Girls Guide");
            HousecomboBx.Items.Add("Red-Fullerton");
            HousecomboBx.Items.Add("Blue-McLoud");
            HousecomboBx.Items.Add("Yellow-Dalass");
            HousecomboBx.Items.Add("Purple-AJ'S");
            StuAddress.Text = "";
            motherName.Text = "";
            mothersOccupation.Text = "";
            motherAddress.Text = "";
            mothersTelephone.Text = "";
            fathersName.Text = "";
            fathersOccupation.Text = "";
            fathersAddress.Text = "";
            fathersTelephone.Text = "";
            GuardianName.Text = "";
            GuardianOccupation.Text = "";
            GuardianAddress.Text = "";
            GuardianTelephone.Text = "";
            StuPhoto.Image = Properties.Resources.user;
        }
//**************************Students Save**************************************************************      
        private void SaveBNT_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("SELECT * from Student where ERN =@ERN", con);
                cmd.Parameters.AddWithValue("@ERN", ERN.Text.ToLower());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("The Record you are attempting to save exists within the Database already.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                if (DOBStudt.Value.Date > DateTime.Now.AddYears(-6))
                {
                    MessageBox.Show("Please enter a valid birth date","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOBStudt.Focus();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string sql = "INSERT INTO Student(ERN,FisrtName,MiddleName,LastName,BirthNum,DOB,DOReg,House,Club,Gender,StudentAddress,MotherName,MatherOccupation,MotherAddress,MotherTel,FatherName,FatherOccupation,FatherAddress,FatherTel,GuardianName,GuardianOccupation,GuardianAddress,GuardianTel,Photo) values('" + ERN.Text + "','" + FnameStuTB.Text + "','" + MiddnameStuTB.Text + "','" + LastNameStuTB.Text + "','" + BirthNum.Text + "','" + DOBStudt.Text + "','" + DateRegdt.Text + "','" + HousecomboBx.Text + "','" + ClubcomboBx.Text + "','" + GenderComBx.Text + "','" + StuAddress.Text + "','" + motherName.Text + "','" + mothersOccupation.Text + "','" + motherAddress.Text + "','" + mothersTelephone.Text + "','" + fathersName.Text + "','" + fathersOccupation.Text + "','" + fathersAddress.Text + "','" + fathersTelephone.Text + "','" + GuardianName.Text + "','" + GuardianOccupation.Text + "','" + GuardianAddress.Text + "','" + GuardianTelephone.Text + "', @img)";


                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();

                    displayDataStudent();
                    // ClearData();
                    MessageBox.Show(x.ToString() + " Record inserted successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); con.Close();
            }
            finally
            {
                con.Close();
            }


        }
//**************************Student Photo Browse**************************************************************
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
//**************************Student CellClick**************************************************************
        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    IDStuTB.Text = row.Cells[0].Value.ToString();
                    ERN.Text = row.Cells[1].Value.ToString();
                    FnameStuTB.Text = row.Cells[2].Value.ToString();
                    MiddnameStuTB.Text = row.Cells[3].Value.ToString();
                    LastNameStuTB.Text = row.Cells[4].Value.ToString();
                    BirthNum.Text = row.Cells[5].Value.ToString();
                    DOBStudt.Text = row.Cells[6].Value.ToString();
                    DateRegdt.Text = row.Cells[7].Value.ToString();
                    HousecomboBx.Text = row.Cells[8].Value.ToString();
                    ClubcomboBx.Text = row.Cells[9].Value.ToString();
                    GenderComBx.Text = row.Cells[10].Value.ToString();
                    StuAddress.Text = row.Cells[11].Value.ToString();
                    motherName.Text = row.Cells[12].Value.ToString();
                    mothersOccupation.Text = row.Cells[13].Value.ToString();
                    motherAddress.Text = row.Cells[14].Value.ToString();
                    mothersTelephone.Text = row.Cells[15].Value.ToString();
                    fathersName.Text = row.Cells[16].Value.ToString();
                    fathersOccupation.Text = row.Cells[17].Value.ToString();
                    fathersAddress.Text = row.Cells[18].Value.ToString();
                    fathersTelephone.Text = row.Cells[19].Value.ToString();
                    GuardianName.Text = row.Cells[20].Value.ToString();
                    GuardianOccupation.Text = row.Cells[21].Value.ToString();
                    GuardianAddress.Text = row.Cells[22].Value.ToString();
                    GuardianTelephone.Text = row.Cells[23].Value.ToString();

                    var data = (Byte[])(row.Cells[24].Value);
                    var stream = new MemoryStream(data);
                    StuPhoto.Image = Image.FromStream(stream);

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
 
        
//**************************Assessment Save**************************************************************
        private void SaveBTNassessment_Click(object sender, EventArgs e)
        {
            GenKnw.Text = "";
            NumCon.Text = "";
            OralLang.Text = "";
            Reading.Text = "";
            Structure.Text = "";
            Vocab.Text = "";
            StudySkills.Text = "";
            ComTask.Text = "";
            NumEst.Text = "";
            Geometry.Text = "";
            Algebra.Text = "";
            Statistics.Text = "";
            LangArtGrade4.Text = "";
            MathGrade4.Text = "";
            LangArtGrade5.Text = "";
            MathGrade5.Text = "";
            LangArtGrade6.Text = "";
            AbilityTest.Text = "";
            MathGrade6.Text = "";
            LangArtCurriGrade6.Text = "";
            MathCurriGrade6.Text = "";
            SocialStudies.Text = "";
            Science.Text = "";
            WriteDraw.Text = "";

           


            try
            {

                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * from  National_Assessment where id_Stu =@id_Stu", con);
                cmd.Parameters.AddWithValue("@id_Stu", idAssessment.Text.ToLower());
                //con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("The Record you are attempting to save exists within the Database already.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO National_Assessment(GenKnowledge,NumberConcepts,OralLang,Reading,Structure,Vocab,StudySkills,ComTask,NumEst,Geometry,Algebra,[Statistics],LangArtGrade4,MathGrade4,LangArtGrade5,MathGrade5,LangArtGrade6,AbilityTest,MathGrade6,LangArtGrade6Curri,MathGrade6Curri,Science,SocialStudies,id_Stu,WritingDrawing) VALUES(@GenKnowledge,@NumberConcepts,@OralLang,@Reading,@Structure,@Vocab,@StudySkills,@ComTask,@NumEst,@Geometry,@Algebra,@Statistics,@LangArtGrade4,@MathGrade4,@LangArtGrade5,@MathGrade5,@LangArtGrade6,@AbilityTest,@MathGrade6,@LangArtGrade6Curri,@MathGrade6Curri,@Science,@SocialStudies,@id_Stu,@WritingDrawing)", con);
                    //cmd = new SqlCommand("INSERT INTO Attendance(id_Stu) VALUES(@id_Stu)", con);

                    cmd.Parameters.AddWithValue("@GenKnowledge",GenKnw.Text);
                    cmd.Parameters.AddWithValue("@NumberConcepts", NumCon.Text);
                    cmd.Parameters.AddWithValue("@OralLang", OralLang.Text);
                    cmd.Parameters.AddWithValue("@Reading", Reading.Text);
                    cmd.Parameters.AddWithValue("@Structure", Structure.Text);
                    cmd.Parameters.AddWithValue("@Vocab", Vocab.Text);
                    cmd.Parameters.AddWithValue("@StudySkills", StudySkills.Text);
                    cmd.Parameters.AddWithValue("@ComTask", ComTask.Text);
                    cmd.Parameters.AddWithValue("@NumEst", NumEst.Text);
                    cmd.Parameters.AddWithValue("@Geometry", Geometry.Text);
                    cmd.Parameters.AddWithValue("@Algebra", Algebra.Text);
                    cmd.Parameters.AddWithValue("@Statistics", Statistics.Text);
                    cmd.Parameters.AddWithValue("@LangArtGrade4", LangArtGrade4.Text);
                    cmd.Parameters.AddWithValue("@MathGrade4", MathGrade4.Text);
                    cmd.Parameters.AddWithValue("@LangArtGrade5", LangArtGrade5.Text);
                    cmd.Parameters.AddWithValue("@MathGrade5", MathGrade5.Text);
                    cmd.Parameters.AddWithValue("@LangArtGrade6", LangArtGrade6.Text);
                    cmd.Parameters.AddWithValue("@AbilityTest", AbilityTest.Text);
                    cmd.Parameters.AddWithValue("@MathGrade6", MathGrade6.Text);
                    cmd.Parameters.AddWithValue("@LangArtGrade6Curri", LangArtCurriGrade6.Text);
                    cmd.Parameters.AddWithValue("@MathGrade6Curri", MathCurriGrade6.Text);
                    cmd.Parameters.AddWithValue("@Science", Science.Text);
                    cmd.Parameters.AddWithValue("@SocialStudies", SocialStudies.Text);
                    cmd.Parameters.AddWithValue("@id_Stu", idAssessment.Text);
                    cmd.Parameters.AddWithValue("@WritingDrawing", WriteDraw.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record was saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayDataAssessment();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); con.Close();
            }
            finally
            {
                con.Close();
            }
        }
//**************************Assessment Update**************************************************************
        private void UpdateBTNassessment_Click(object sender, EventArgs e)
        {
            try
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand cmd = con.CreateCommand();
                //string Sql = "UPDATE National_Assessment SET ERN='" + ERN.Text + "',FisrtName='" + FnameStuTB.Text + "',MiddleName='" + MiddnameStuTB.Text + "',LastName='" + LastNameStuTB.Text + "',BirthNum='" + BirthNum.Text + "',DOB='" + DOBStudt.Text + "',DOReg='" + DateRegdt.Text + "',House='" + HousecomboBx.Text + "',Club='" + ClubcomboBx.Text + "',Gender='" + GenderComBx.Text + "',StudentAddress='" + StuAddress.Text + "',MotherName='" + motherName.Text + "',MatherOccupation='" + mothersOccupation.Text + "',MotherAddress='" + motherAddress.Text + "',MotherTel='" + mothersTelephone.Text + "',FatherName='" + fathersName.Text + "',FatherOccupation='" + fathersOccupation.Text + "',FatherAddress='" + fathersAddress.Text + "',FatherTel='" + fathersTelephone.Text + "',GuardianName='" + GuardianName.Text + "',GuardianOccupation='" + GuardianOccupation.Text + "',GuardianAddress='" + GuardianAddress.Text + "',GuardianTel='" + GuardianTelephone.Text + "',Photo=@img WHERE ID='" + IDStuTB.Text + "'";
                string Sql = "UPDATE National_Assessment SET GenKnowledge='" + GenKnw.Text + "',NumberConcepts='" + NumCon.Text + "',OralLang='" + OralLang.Text + "',Reading='" + Reading.Text + "',Structure='" + Structure.Text + "',Vocab='" + Vocab.Text + "',StudySkills='" + StudySkills.Text + "',ComTask='" + ComTask.Text + "',NumEst='" + NumEst.Text + "',Geometry='" + Geometry.Text + "',Algebra='" + Algebra.Text + "',[Statistics]='" + Statistics.Text + "',LangArtGrade4='" + LangArtGrade4.Text + "',MathGrade4='" + MathGrade4.Text + "',LangArtGrade5='" + LangArtGrade5.Text + "',MathGrade5='" + MathGrade5.Text + "',LangArtGrade6='" + LangArtGrade6.Text + "',AbilityTest='" + AbilityTest.Text + "',MathGrade6='" + MathGrade6.Text + "',LangArtGrade6Curri='" + LangArtCurriGrade6.Text + "',MathGrade6Curri='" + MathCurriGrade6.Text + "',Science='" + Science.Text + "',SocialStudies='" + SocialStudies.Text + "',WritingDrawing='" + WriteDraw.Text +"' WHERE id_Stu='" + idAssessment.Text + "'";


                cmd = new SqlCommand(Sql, con);
                //cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                displayDataAssessment();
                MessageBox.Show("Record updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ClearData();
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
//**************************Assessment Delete**************************************************************
        private void DeleteBTNassessment_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("You are about to detele the selected record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    if (idAssessment.Text != "")
                    {
                        con.Open();

                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Delete From National_Assessment WHERE id_Stu='" + idAssessment.Text + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        da.Update(dt);
                        dataGridViewStudent.DataSource = dt;
                        displayDataAssessment();
                        MessageBox.Show("Record Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else if (idAssessment.Text == "")
                    {
                        MessageBox.Show("Data Match Error: No data found. Please Check if the Student Assessment defails was selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }

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
//**************************Assessment CellClick**************************************************************
        private void dataGridViewAssessment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewAssessment.Rows[e.RowIndex];
                    FnameStudent.Text = row.Cells[1].Value.ToString();
                    LnameStudent.Text = row.Cells[3].Value.ToString();
                    idAssessment.Text = row.Cells[27].Value.ToString();
                   
                    GenKnw.Text = row.Cells[4].Value.ToString();
                    NumCon.Text = row.Cells[5].Value.ToString();
                    OralLang.Text = row.Cells[6].Value.ToString();
                    Reading.Text = row.Cells[7].Value.ToString();
                    Structure.Text = row.Cells[8].Value.ToString();
                    Vocab.Text = row.Cells[9].Value.ToString();
                    StudySkills.Text = row.Cells[10].Value.ToString();
                    ComTask.Text = row.Cells[11].Value.ToString();
                    NumEst.Text = row.Cells[12].Value.ToString();
                    Geometry.Text = row.Cells[13].Value.ToString();
                    Algebra.Text = row.Cells[14].Value.ToString();
                    Statistics.Text = row.Cells[15].Value.ToString();
                    LangArtGrade4.Text = row.Cells[16].Value.ToString();
                    MathGrade4.Text = row.Cells[17].Value.ToString();
                    LangArtGrade5.Text = row.Cells[18].Value.ToString();
                    MathGrade5.Text = row.Cells[19].Value.ToString();
                    LangArtGrade6.Text = row.Cells[20].Value.ToString();
                    AbilityTest.Text = row.Cells[21].Value.ToString();
                    MathGrade6.Text = row.Cells[22].Value.ToString();
                    LangArtCurriGrade6.Text = row.Cells[23].Value.ToString();
                    MathCurriGrade6.Text = row.Cells[24].Value.ToString();
                    Science.Text = row.Cells[25].Value.ToString();
                    SocialStudies.Text = row.Cells[26].Value.ToString();
                    WriteDraw.Text = row.Cells[28].Value.ToString();

                    
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

//**************************Student Assessment Click**************************************************************
        private void dataGridViewStudent3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GenKnw.Text = "";
            NumCon.Text = "";
            OralLang.Text = "";
            Reading.Text = "";
            Structure.Text = "";
            Vocab.Text = "";
            StudySkills.Text = "";
            ComTask.Text = "";
            NumEst.Text = "";
            Geometry.Text = "";
            Algebra.Text = "";
            Statistics.Text = "";
            LangArtGrade4.Text = "";
            MathGrade4.Text = "";
            LangArtGrade5.Text = "";
            MathGrade5.Text = "";
            LangArtGrade6.Text = "";
            AbilityTest.Text = "";
            MathGrade6.Text = "";
            LangArtCurriGrade6.Text = "";
            MathCurriGrade6.Text = "";
            SocialStudies.Text = "";
            Science.Text = "";
            WriteDraw.Text = "";

            try

            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewStudent2.Rows[e.RowIndex];

                    FnameStudent.Text = row.Cells[2].Value.ToString();
                    LnameStudent.Text = row.Cells[4].Value.ToString();                 
                    idAssessment.Text = row.Cells[0].Value.ToString();

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

        private void SaveHealthBTN_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("SELECT * from Stu_Health where id_Student =@id_Student", con);
                cmd.Parameters.AddWithValue("@id_Student", IDstudentHealth.Text.ToLower());
                //con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("The Record you are attempting to save exists within the Database already.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Stu_Health( Physical_Defects, Asthmatic, Heart_Problem, Urinary_Disorder, Ear_Problem, Eye_Problem, Other, id_Student) VALUES(@Physical_Defects, @Asthmatic, @Heart_Problem, @Urinary_Disorder, @Ear_Problem, @Eye_Problem, @Other, @id_Student)", con);
                    //cmd = new SqlCommand("INSERT INTO Attendance(id_Stu) VALUES(@id_Stu)", con);
                    
                    cmd.Parameters.AddWithValue("@Physical_Defects", PhysicalTB.Text);
                    cmd.Parameters.AddWithValue("@Asthmatic", AsthmaticTB .Text);
                    cmd.Parameters.AddWithValue("@Heart_Problem", HeartTB.Text);
                    cmd.Parameters.AddWithValue("@Urinary_Disorder", UrinaryTB.Text);
                    cmd.Parameters.AddWithValue("@Ear_Problem", EarTB.Text);
                    cmd.Parameters.AddWithValue("@Eye_Problem", EyeTB.Text);
                    cmd.Parameters.AddWithValue("@Other", OtherTB.Text);
                    cmd.Parameters.AddWithValue("@id_Student", IDstudentHealth.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record was saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayDataHealth();
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

        private void UpdateHealthBTN_Click(object sender, EventArgs e)
        {
            try
            {


                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                SqlCommand cmd = con.CreateCommand();
                string Sql = "UPDATE Stu_Health SET Physical_Defects='"+PhysicalTB.Text+ "', Asthmatic='" + AsthmaticTB.Text + "', Heart_Problem='" + HeartTB.Text + "', Urinary_Disorder='" + UrinaryTB.Text + "', Ear_Problem='" + EarTB.Text + "', Eye_Problem='" + EyeTB.Text + "', Other='" + OtherTB.Text + "' WHERE id_Student = '" + IDstudentHealth.Text + "'";

                cmd = new SqlCommand(Sql, con);
                //cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                displayDataHealth();
                MessageBox.Show("Record updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ClearData();
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
       
        private void DeleteHealthBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("You are about to detele the selected record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    if (IDstudentHealth.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Delete From Stu_Health WHERE id_Student='" + IDstudentHealth.Text + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        da.Update(dt);
                        dataGridViewStudent.DataSource = dt;
                        displayDataHealth();
                        MessageBox.Show("Record Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IDstudentHealth.Text = "";
                        FnameHealth.Text = "";
                        MnameHealth.Text = "";
                        LnameHealth.Text = "";
                        PhysicalTB.Text = "";
                        AsthmaticTB.Text = "";
                        HeartTB.Text = "";
                        UrinaryTB.Text = "";
                        EarTB.Text = "";
                        EyeTB.Text = "";
                        OtherTB.Text = "";
                    }

                    else if (IDstudentHealth.Text == "")
                    {
                        MessageBox.Show("Data Match Error: No data found. Please Check if the Student Health defails was selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }

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

        private void dataGridViewStudentHealth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PhysicalTB.Text = "";
            HeartTB.Text =  "";
            AsthmaticTB.Text = "";
            UrinaryTB.Text = "";
            EarTB.Text = "";
            EyeTB.Text = "";
            OtherTB.Text = "";

            try

            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewStudentHealth.Rows[e.RowIndex];
                    IDstudentHealth.Text = row.Cells[0].Value.ToString();
                    FnameHealth.Text = row.Cells[2].Value.ToString();
                    MnameHealth.Text = row.Cells[3].Value.ToString();
                    LnameHealth.Text = row.Cells[4].Value.ToString();
                    var data = (Byte[])(row.Cells[24].Value);
                    var stream = new MemoryStream(data);
                    StudenPhotoHealth.Image = Image.FromStream(stream);
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

        private void dataGridViewStuHealth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewHealth.Rows[e.RowIndex];
                    IDstudentHealth.Text = row.Cells[0].Value.ToString();
                    FnameHealth.Text = row.Cells[2].Value.ToString();
                    MnameHealth.Text = row.Cells[3].Value.ToString();
                    LnameHealth.Text = row.Cells[4].Value.ToString();
                    PhysicalTB.Text = row.Cells[5].Value.ToString();
                    AsthmaticTB.Text = row.Cells[6].Value.ToString();
                    HeartTB.Text = row.Cells[7].Value.ToString();
                    UrinaryTB.Text = row.Cells[8].Value.ToString();
                    EarTB.Text = row.Cells[9].Value.ToString();
                    EyeTB.Text = row.Cells[10].Value.ToString();
                    OtherTB.Text = row.Cells[11].Value.ToString();
                    var data = (Byte[])(row.Cells[12].Value);
                    var stream = new MemoryStream(data);
                    StudenPhotoHealth.Image = Image.FromStream(stream);
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
