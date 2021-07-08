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
    public partial class ForgetPassword : MetroFramework.Forms.MetroForm
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");
        string str;
        SqlCommand cmd;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "Please enter Username";
            txtEmail.Text = "Please enter Email Address";
            txtEmail.ForeColor = Color.Gray;
            txtUserName.ForeColor = Color.Gray;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Please enter Username")
            {
                txtUserName.Text = "";
             }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Please enter Username";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Please enter Email Address")
            {
                txtEmail.Text = "";
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Please enter Email Address";
            }
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            str = "SELECT Username ,Email FROM Login where Username='" + txtUserName.Text + "' and  Email='" + txtEmail.Text + "'";
            con.Open();
            cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                newPassword newp = new newPassword(txtEmail.Text);
                this.Dispose(false);
                newp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect your username and email ");
                con.Close();

            }
        }
    }
}
