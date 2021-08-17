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

namespace PrimarySchoolAPP
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {


        //****************************Database connection*****************************************

       // String conString = "Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True";
        MyConnection db = new MyConnection();

        public Login()
        {
            InitializeComponent();
        }


        public class UserDisplayName
        {
            public static string displayName;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            labSMS.Parent = picBoxBG;
            labSMS.BackColor = Color.Transparent;
            labSch.Parent = picBoxBG;
            labSch.BackColor = Color.Transparent;
            MaximizeBox = false;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUser.Focus();
                return;
            }
            if (tbPass.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPass.Focus();
                return;
            }




            try
            {
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("role_Login", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@uname", tbUser.Text);
                    cmd.Parameters.AddWithValue("@upass", tbPass.Text);

                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[6].ToString() == "Admin")
                        {
                            MyConnection.type = "A";
                        }
                        else if (rd[6].ToString() == "User")
                        {
                            MyConnection.type = "U";
                        }
                        MessageBox.Show("Login was successful, welcome " + tbUser.Text, "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserDisplayName.displayName = tbUser.Text;
                        Dashboard d = new Dashboard();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("You have been blocked for too many attempts. Please close the program, wait 30 seconds and try again. ", "Program Shutdown", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }

        private void lkbForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            this.Dispose(false);
            fp.Show();
            this.Hide();
        }
    }
}
