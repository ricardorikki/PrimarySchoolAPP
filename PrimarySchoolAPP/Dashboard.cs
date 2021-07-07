using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Management;

namespace PrimarySchoolAPP
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");




        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //public static extern bool ReleaseCapture();

        
        public Dashboard()
        {
            InitializeComponent();
           
        }


       
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Display Username
                WELname.Text = Login.UserDisplayName.displayName;  

            //**************************Removing the Max button***************************************
            MaximizeBox = false;
            ControlBox = true;
            
            //btnHome.ForeColor = Color.Black;
            //teaBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            //button1.BackColor = Color.White;

            // metroButton1.FlatAppearance.BorderSize = 0;


            

            //label2.Text = Environment.UserName.ToString();

            //teacherStatlab.Text = dataGridView1.RowCount.ToString();
            displayDataTeachers();



            if (MyConnection.type == "A")
            {
               UsersBNT.Visible = true;
               
            }
            else if (MyConnection.type == "U")
            {
                UsersBNT.Visible = false;
               
            }

            userConTeacher1.Hide();   //Users
            userConUser1.Hide();

            //*****Menu Indicators*******
            pnlHome.Show();
            pnStu.Hide();
            pnTea.Hide();
            pnAd.Hide();
            pnWat.Hide();
            pnSet.Hide();
            


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
                dataGridView1.DataSource = dt;
                da.Update(dt);
                teacherStatlab.Text = dt.Rows.Count.ToString();



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





        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    ReleaseCapture();
            //    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            //}


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {

        }

        private void teaBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void UsersBNT_Click(object sender, EventArgs e)
        {
            
        }
        private void WatchmenBtn_Click(object sender, EventArgs e)
        {
            
        }
        bool close = true;
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult result = MessageBox.Show("You are about to Exit the application, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }

                else
                {
                    e.Cancel = true;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            //btnHome.BackColor = System.Drawing.Color.White;
            //this.btnHome1.BackColor = System.Drawing.Color.White;
            // btnHome.BackColor = Color.White;
            // btnHome.ForeColor = Color.Black;
            // stuBtn.BackColor = Color.DodgerBlue;
            // teaBtn.BackColor = Color.DodgerBlue;
            //metroButton1.BackColor = Color.DodgerBlue;
            userConTeacher1.Hide();   //Users
            userConUser1.Hide();

            //*****Menu Indicators*******
            pnlHome.Show();
            pnStu.Hide();
            pnTea.Hide();
            pnAd.Hide();
            pnWat.Hide();
            pnSet.Hide();


            displayDataTeachers();
        }

        private void stuBTN_Click_1(object sender, EventArgs e)
        {

            //stuBtn.BackColor = Color.White;
            //stuBtn.ForeColor = Color.Black;
            //btnHome.BackColor = Color.DodgerBlue;
            //teaBtn.BackColor = Color.DodgerBlue;
            //*****Menu Indicators*******
            pnlHome.Hide();
            pnStu.Show();
            pnTea.Hide();
            pnAd.Hide();
            pnWat.Hide();
            pnSet.Hide();
        }

        private void TeacherBTN_Click(object sender, EventArgs e)
        {
            //teaBtn.BackColor = Color.White;
            //teaBtn.ForeColor = Color.Black;
            //stuBtn.BackColor = Color.DodgerBlue;
            //btnHome.BackColor = Color.DodgerBlue;
            userConTeacher1.Show();
            //metroButton1.BackColor = Color.White;

            pnlHome.Hide();
            pnStu.Hide();
            pnTea.Show();
            pnAd.Hide();
            pnWat.Hide();
            pnSet.Hide();

        }

        private void AdminiBTN_Click(object sender, EventArgs e)
        {
            //teaBtn.BackColor = Color.White;
            //teaBtn.ForeColor = Color.Black;
            //stuBtn.BackColor = Color.DodgerBlue;
            //btnHome.BackColor = Color.DodgerBlue;
            userConTeacher1.Show();
            pnlHome.Hide();
            pnStu.Hide();
            pnTea.Hide();
            pnAd.Show();
            pnWat.Hide();
            pnSet.Hide();
        }

        private void WatchBTN_Click(object sender, EventArgs e)
        {
            //teaBtn.BackColor = Color.White;
            //teaBtn.ForeColor = Color.Black;
            //stuBtn.BackColor = Color.DodgerBlue;
            //btnHome.BackColor = Color.DodgerBlue;
            userConTeacher1.Show();
            pnlHome.Hide();
            pnStu.Hide();
            pnTea.Hide();
            pnAd.Hide();
            pnWat.Show();
            pnSet.Hide();
        }

        private void UsersBNT_Click_1(object sender, EventArgs e)
        {
            //teaBtn.BackColor = Color.White;
            //teaBtn.ForeColor = Color.Black;
            //stuBtn.BackColor = Color.DodgerBlue;
            //btnHome.BackColor = Color.DodgerBlue;
            userConUser1.Show();
            pnlHome.Hide();
            pnStu.Hide();
            pnTea.Hide();
            pnAd.Hide();
            pnWat.Hide();
            pnSet.Show();
        }
    }


}
