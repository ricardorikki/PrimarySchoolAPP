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




        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public Dashboard()
        {
            InitializeComponent();
           
        }

       private void Dashboard_Load(object sender, EventArgs e)
        {
            //**************************Removing the Max button***************************************
            MaximizeBox = false;
            ControlBox = true;
            btnHome.BackColor = Color.White;
            btnHome.ForeColor = Color.Black;

            userConTeacher1.Hide();   //Users

            //label2.Text = Environment.UserName.ToString();

            //teacherStatlab.Text = dataGridView1.RowCount.ToString();
            displayDataTeachers();
            
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
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            btnHome.BackColor = Color.White;
            btnHome.ForeColor = Color.Black;
            stuBtn.BackColor = Color.DeepSkyBlue;
            teaBtn.BackColor = Color.DeepSkyBlue;
            userConTeacher1.Hide();   //Users
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {
           
            stuBtn.BackColor = Color.White;
            stuBtn.ForeColor = Color.Black;
            btnHome.BackColor = Color.DeepSkyBlue;
            teaBtn.BackColor = Color.DeepSkyBlue;
        }

        private void teaBtn_Click(object sender, EventArgs e)
        {
            teaBtn.BackColor = Color.White;
            teaBtn.ForeColor = Color.Black;
            stuBtn.BackColor = Color.DeepSkyBlue;
            btnHome.BackColor = Color.DeepSkyBlue;
            userConTeacher1.Show();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            teaBtn.BackColor = Color.White;
            teaBtn.ForeColor = Color.Black;
            stuBtn.BackColor = Color.DeepSkyBlue;
            btnHome.BackColor = Color.DeepSkyBlue;
            userConTeacher1.Show();
        }

        private void WatchmenBtn_Click(object sender, EventArgs e)
        {
            teaBtn.BackColor = Color.White;
            teaBtn.ForeColor = Color.Black;
            stuBtn.BackColor = Color.DeepSkyBlue;
            btnHome.BackColor = Color.DeepSkyBlue;
            userConTeacher1.Show();
        }

        
    }




}
