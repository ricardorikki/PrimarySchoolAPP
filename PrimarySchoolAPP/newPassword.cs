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


    public partial class newPassword : MetroFramework.Forms.MetroForm
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");


        variable v = new variable();
        public newPassword(string str)
        {
            InitializeComponent();
            lbEmail.Text = str;
        }

        private void newPassword_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
             if (txtNewPass.Text == txtConfirm.Text)
            {
                variable v = new variable();

                try
                {
                    String str = "UPDATE Login   SET Password = '" + txtNewPass.Text + "'  WHERE email ='" + lbEmail.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(str, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Successfully");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Login log = new Login();
                this.Dispose(false);
                log.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not match your password ");
            }
        }
    }
}
