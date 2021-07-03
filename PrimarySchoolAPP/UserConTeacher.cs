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
    public partial class userConTeacher : UserControl
    {
        SqlConnection con = new SqlConnection ("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");

       // (@"Data Source=DESKTOP-SINTN8E\SQLEXPRESS;Initial Catalog=EdHardware;Integrated Security=True");
        SqlCommand cmd;
        string imgLoc = "";
        public userConTeacher()
        {
            InitializeComponent();
            //TeacherPhoto.Image = Properties.Resources.user;
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
            TeacherPhoto.Image = Properties.Resources.user;
        }



        private void userConTeacher_Load(object sender, EventArgs e)
        {
            GenderComBx.Items.Add("--Select--");
            GenderComBx.Items.Add("Male");
            GenderComBx.Items.Add("Female");
            GenderComBx.Items.Add("Other");


            StatcomboBx.Items.Add("--Select--");
            StatcomboBx.Items.Add("Temp");
            StatcomboBx.Items.Add("Permanent");
            
           

            RankcomboBx.Items.Add("--Select--");
            RankcomboBx.Items.Add("Junior Teacher");
            RankcomboBx.Items.Add("Senior Teacher");
            RankcomboBx.Items.Add("Vice Principal");
            RankcomboBx.Items.Add("Principal");
            RankcomboBx.Items.Add("Librarian");
            RankcomboBx.Items.Add("Guidance Counselor");

            ClubcomboBx.Items.Add("--Select--");
            ClubcomboBx.Items.Add("Computer");
            ClubcomboBx.Items.Add("4H");
            ClubcomboBx.Items.Add("Builders");
            ClubcomboBx.Items.Add("Cub Scouth");
            ClubcomboBx.Items.Add("Girls Guide");

            HousecomboBx.Items.Add("--Select--");
            HousecomboBx.Items.Add("Red-Fullerton");
            HousecomboBx.Items.Add("Blue-McLoud");
            HousecomboBx.Items.Add("Yellow-Dalass");
            HousecomboBx.Items.Add("Purple-AJ'S");
            displayDataTeachers();

            TeacherPhoto.Image = Properties.Resources.user;


        }

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
                    //populate the textbox from specific value of the coordinates of column and row.
                    

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

        private void SaveBNT_Click(object sender, EventArgs e)
        {
            //********************INSERT*********************************************************************


          
            try {

                byte[] img = null;
                //FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                //BinaryReader br = new BinaryReader(fs);
                //img = br.ReadBytes((int)fs.Length);


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
    }
}
