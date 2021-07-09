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

        SqlCommand cmd;
  
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
        private void userConStudent1_Load(object sender, EventArgs e)
        {
            displayDataStudent();
        }

        private void editBNT_Click(object sender, EventArgs e)
        {
            StudentAdd stu = new StudentAdd();
            this.Dispose(false);
            stu.Show();
            this.Hide();

            Dashboard das = new Dashboard();
            this.Dispose(false);
            das.Hide();
            this.Hide();
        }
    }
}
