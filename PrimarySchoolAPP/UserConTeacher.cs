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
using System.Text.RegularExpressions;

namespace PrimarySchoolAPP
{
    public partial class userConTeacher : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");

        // (@"Data Source=DESKTOP-SINTN8E\SQLEXPRESS;Initial Catalog=EdHardware;Integrated Security=True");
        SqlCommand cmd;
        string imgLoc = "";
        public userConTeacher()
        {
            InitializeComponent();

        }


        public void displayDataTeachers()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Teachers";
                //cmd.CommandText ="SELECT id AS ID, FirstName AS [First Name], MiddleName AS [Middle Name], LastName AS [Last Name],DOB, Gender,DateAppointment AS [Date of Appointment],Email,Status,Rank,House,Club,NextKin AS [Next of Kin Name],NextKinCon AS [Next of Kin Contact] FROM Teachers ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewTeachers.DataSource = dt;
                da.Update(dt);
                dataGridViewTeachers.AllowUserToAddRows = false;



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

        //*****************************************Clear RECORD*****************************************
        private void ClearData()
        {
            FnameTB.Text = "";
            MiddnameTB.Text = "";
            LastNameTB.Text = "";
            DOBdt.Text = "";
            GenderComBx.Text = "";
            DateAppointmentdt.Text = "";
            EmailTB.Text = "";
            StatcomboBx.Text = "";
            RankcomboBx.Text = "";
            HousecomboBx.Text = "";
            ClubcomboBx.Text = "";
            NOKnameTB.Text = "";
            NOKconTB.Text = "";
            IDtb.Text = "";
            TeacherPhoto.Image = Properties.Resources.user;
        }



        private void userConTeacher_Load(object sender, EventArgs e)
        {

            GenderComBx.Items.Add("Male");
            GenderComBx.Items.Add("Female");




            StatcomboBx.Items.Add("Temp");
            StatcomboBx.Items.Add("Permanent");




            RankcomboBx.Items.Add("Junior Teacher");
            RankcomboBx.Items.Add("Senior Teacher");
            RankcomboBx.Items.Add("Vice Principal");
            RankcomboBx.Items.Add("Principal");
            RankcomboBx.Items.Add("Librarian");
            RankcomboBx.Items.Add("Guidance Counselor");


            ClubcomboBx.Items.Add("Computer");
            ClubcomboBx.Items.Add("4H");
            ClubcomboBx.Items.Add("Builders");
            ClubcomboBx.Items.Add("Cub Scouth");
            ClubcomboBx.Items.Add("Girls Guide");


            HousecomboBx.Items.Add("Red-Fullerton");
            HousecomboBx.Items.Add("Blue-McLoud");
            HousecomboBx.Items.Add("Yellow-Dalass");
            HousecomboBx.Items.Add("Purple-AJ'S");
            displayDataTeachers();

            TeacherPhoto.Image = Properties.Resources.user;

        }
        //**************populate the textbox from specific value of the coordinates of column and row.*******************************
        private void dataGridViewTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewTeachers.Rows[e.RowIndex];
                    IDtb.Text = row.Cells[0].Value.ToString();
                    FnameTB.Text = row.Cells[1].Value.ToString();
                    MiddnameTB.Text = row.Cells[2].Value.ToString();
                    LastNameTB.Text = row.Cells[3].Value.ToString();
                    DOBdt.Text = row.Cells[4].Value.ToString();
                    GenderComBx.Text = row.Cells[5].Value.ToString();
                    DateAppointmentdt.Text = row.Cells[6].Value.ToString();
                    EmailTB.Text = row.Cells[7].Value.ToString();
                    StatcomboBx.Text = row.Cells[8].Value.ToString();
                    RankcomboBx.Text = row.Cells[9].Value.ToString();
                    HousecomboBx.Text = row.Cells[10].Value.ToString();
                    ClubcomboBx.Text = row.Cells[11].Value.ToString();
                    NOKnameTB.Text = row.Cells[12].Value.ToString();
                    NOKconTB.Text = row.Cells[13].Value.ToString();
                    var data = (Byte[])(row.Cells[14].Value);
                    var stream = new MemoryStream(data);
                    TeacherPhoto.Image = Image.FromStream(stream);
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
        //********************INSERT*********************************************************************
        private void SaveBNT_Click(object sender, EventArgs e)
        {

            try {
                

                byte[] img = null;

                if (TeacherPhoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    TeacherPhoto.Image.Save(ms, TeacherPhoto.Image.RawFormat);
                    img = ms.GetBuffer();
                    ms.Close();
                }

                //if (TeacherPhoto.Image == null)
                //{
                //    MessageBox.Show("Please Update Image ", "WARRING NOT SAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}



                if (FnameTB.Text != ""  && LastNameTB.Text != "" && DOBdt.Text != "" && GenderComBx.Text != ""&& EmailTB.Text != "" )
                    {
                    string sql = "INSERT INTO Teachers(FirstName,MiddleName,LastName,DOB,Gender,DateAppointment,Email,Status,Rank,House,Club,NextKin,NextKinCon,Photo) values('" + FnameTB.Text + "','" + MiddnameTB.Text + "', '" + LastNameTB.Text + "','" + DOBdt.Text + "','" + GenderComBx.Text + "','" + DateAppointmentdt.Text + "','" + EmailTB.Text + "','" + StatcomboBx.Text + "','" + RankcomboBx.Text + "','" + HousecomboBx.Text + "','" + ClubcomboBx.Text + "','" + NOKnameTB.Text + "','" + NOKconTB.Text + "',@img)";

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    displayDataTeachers();
                    ClearData();
                    MessageBox.Show(x.ToString() + " Record inserted successfully");
                }
                if (DOBdt.Value.Date > DateTime.Now.AddYears(-6))
                {
                    MessageBox.Show("Please enter a valid birth date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOBdt.Focus();
                }
                if (FnameTB.Text == "" && LastNameTB.Text == "" && GenderComBx.Text == "")
                {
                    MessageBox.Show("Please Provide First Name, Last Name and Gender", "Record not save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(this.FnameTB, "Please enter First Name");
                    errorProvider1.SetError( this.LastNameTB,  "Please enter Last Name");
                    errorProvider1.SetError(this.GenderComBx, "Please enter Gender");
                    return;
                }

                string pattern = @"^\s*[\w\-\+_']+(\.[\w\-\+_']+)*\@[A-Za-z0-9]([\w\.-]*[A-Za-z0-9])?\.[A-Za-z][A-Za-z\.]*[A-Za-z]$";
                if (Regex.IsMatch(EmailTB.Text, pattern))
                {
                    errorProvider1.Clear();

                }
                else
                {
                    MessageBox.Show("Please enter a correct email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    errorProvider1.SetError(this.EmailTB, "Please enter a valid email address");
                    return;
                }
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }





            //if (string.IsNullOrEmpty(FnameTB.Text))
            //{
            //    FnameTB.Focus();
            //    errorProvider1.SetError(FnameTB, "Please Enter First Name");
            //}

            //if (string.IsNullOrEmpty(LastNameTB.Text))
            //{
            //    LastNameTB.Focus();
            //    errorProvider1.SetError(LastNameTB, "Please Enter Last Name");
            //}

            //if (string.IsNullOrEmpty(EmailTB.Text))
            //{
            //    EmailTB.Focus();
            //    errorProvider1.SetError(EmailTB, "Please Enter Email Address");
            //}



            //if (string.IsNullOrEmpty(GenderComBx.Text))
            //{
            //    GenderComBx.Focus();
            //    errorProvider1.SetError(GenderComBx, "Please select your gender");
            //}









        }
        //*****************************************Browse for Pic*****************************************
        private void browseBnt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog(); 
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALL Files(*.*)|*.*";
                dlg.Title = "Select Teacher Picture";


                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    TeacherPhoto.ImageLocation = imgLoc;
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

        //*****************************************NEW RECORD*****************************************
        private void NewBNT_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        
        //*****************************************Search*****************************************
        private void TeacherSearTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TeacherSearCBO.Text == "First Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Teachers where [FirstName] like'" + TeacherSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewTeachers.DataSource = dt;
                }
                else if (TeacherSearCBO.Text == "Last Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Teachers where [LastName] like'" + TeacherSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewTeachers.DataSource = dt;
                }

                else if (TeacherSearCBO.Text == "Rank")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Teachers where [Rank] like'" + TeacherSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewTeachers.DataSource = dt;
                }

                else if (TeacherSearCBO.Text == "Gender")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Teachers where [Gender] like'" + TeacherSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewTeachers.DataSource = dt;
                }
                else if (TeacherSearCBO.Text == "Status")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Teachers where [Status] like'" + TeacherSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewTeachers.DataSource = dt;
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
        //********************UPDATE*********************************************************************
        private void UpdateBNT_Click(object sender, EventArgs e)
        {

            try
            {


                byte[] img = null;

                if (TeacherPhoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    TeacherPhoto.Image.Save(ms, TeacherPhoto.Image.RawFormat);
                    img = ms.GetBuffer();
                    ms.Close();
                }

                if (TeacherPhoto.Image == null)
                {
                    MessageBox.Show("Please Update Image ", "WARRING NOT SAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                

                SqlCommand cmd = con.CreateCommand();
                string Sql = "UPDATE Teachers SET FirstName='" + FnameTB.Text + "',MiddleName='" + MiddnameTB.Text + "',LastName='" + LastNameTB.Text + "',DOB='" + DOBdt.Text + "',Gender='" + GenderComBx.Text + "',DateAppointment='" + DateAppointmentdt.Text + "',Email='" + EmailTB.Text + "',Status='" + StatcomboBx.Text + "',Rank='" + RankcomboBx.Text + "',House='" + HousecomboBx.Text + "',Club='" + ClubcomboBx.Text + "',NextKin='" +NOKnameTB.Text + "',NextKinCon='" +NOKconTB.Text + "',Photo=@img WHERE ID='" + IDtb.Text + "'";
                cmd = new SqlCommand(Sql, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                displayDataTeachers();
                MessageBox.Show("Record(s) updated successfully");
                ClearData();
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

        private void DeleteBNT_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from Teachers where ID ='" + IDtb.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);
                    dataGridViewTeachers.DataSource = dt;
                    displayDataTeachers();
                    MessageBox.Show("Record Deleted successfully");
                    ClearData();
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
