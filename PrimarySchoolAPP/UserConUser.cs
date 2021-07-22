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
using System.Text.RegularExpressions;

namespace PrimarySchoolAPP
{
    public partial class UserConUser : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");
        SqlCommand cmd;
        public UserConUser()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            FnameUSER.Text = "";
            LastNameUSER.Text = "";
            EmailUSER.Text = "";
            UsernameUSER.Text = "";
            PasswordUSER.Text = "";
            RolecomboBx.SelectedIndex = -1;
            roleIDtb.Text = "";
            


        }

        public void displayDataUsers()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Login";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewUsers.DataSource = dt;
                da.Update(dt);
                dataGridViewUsers.AllowUserToAddRows = false;

                

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

        private void UserConUser_Load(object sender, EventArgs e)
        {
            displayDataUsers();
            ClearData();
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewUsers.Rows[e.RowIndex];
                    roleIDtb.Text = row.Cells[0].Value.ToString();
                    FnameUSER.Text = row.Cells[1].Value.ToString();
                    LastNameUSER.Text = row.Cells[2].Value.ToString();
                    EmailUSER.Text = row.Cells[3].Value.ToString();
                    UsernameUSER.Text = row.Cells[4].Value.ToString();
                    PasswordUSER.Text = row.Cells[5].Value.ToString();
                    RolecomboBx.Text = row.Cells[6].Value.ToString();
                  
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
            try
            {
                string pattern = @"^\s*[\w\-\+_']+(\.[\w\-\+_']+)*\@[A-Za-z0-9]([\w\.-]*[A-Za-z0-9])?\.[A-Za-z][A-Za-z\.]*[A-Za-z]$";
            if (Regex.IsMatch(EmailUSER.Text, pattern))
            {
                errorProvider1.Clear();

            }
            else
            {
                MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                errorProvider1.SetError(this.EmailUSER, "Please enter a correct email address");
                return;
            }

                if (FnameUSER.Text != ""  && LastNameUSER.Text != ""  && EmailUSER.Text != "" && UsernameUSER.Text != "" && PasswordUSER.Text != "" && RolecomboBx.Text != "" )
                {
                    string sql = "INSERT INTO Login(FirstName,LastName,Email,Username,Password,Role) values('" + FnameUSER.Text + "', '" + LastNameUSER.Text + "','" + EmailUSER.Text + "','" + UsernameUSER.Text + "','" +PasswordUSER.Text + "','" + RolecomboBx.Text + "')";

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand(sql, con);
                   
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    displayDataUsers();
                    //ClearData();
                    MessageBox.Show(x.ToString() + " Record inserted successfully");
                }

                else
                {
                    MessageBox.Show("Please Provide Details!", "Record not save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
 

            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }





            if (string.IsNullOrEmpty(FnameUSER.Text))
            {
                FnameUSER.Focus();
                errorProvider1.SetError(FnameUSER, "Please Enter First Name");
            }
            if (string.IsNullOrEmpty(LastNameUSER.Text))
            {
                LastNameUSER.Focus();
                errorProvider1.SetError(LastNameUSER, "Please Enter Last Name");
            }
           
            if (string.IsNullOrEmpty(EmailUSER.Text))
            {
                EmailUSER.Focus();
                errorProvider1.SetError(EmailUSER, "Please Enter Email Address");
            }

            if (string.IsNullOrEmpty(UsernameUSER.Text))
            {
                UsernameUSER.Focus();
                errorProvider1.SetError(UsernameUSER, "Please Enter Username");
            }
            if (string.IsNullOrEmpty(PasswordUSER.Text))
            {
                PasswordUSER.Focus();
                errorProvider1.SetError(PasswordUSER, "Please Enter Password");
            }
            if (string.IsNullOrEmpty(RolecomboBx.Text))
            {
                RolecomboBx.Focus();
                errorProvider1.SetError(RolecomboBx, "Please select a Role");
            }


           
        }

        private void UpdateBNT_Click(object sender, EventArgs e)
        {

            try
            {


               
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }



                SqlCommand cmd = con.CreateCommand();
                string Sql = "UPDATE Login SET FirstName='" + FnameUSER.Text + "', LastName='" + LastNameUSER.Text + "',Email='" + EmailUSER.Text + "',Username='" + UsernameUSER.Text + "',Password='" +PasswordUSER.Text + "',Role='" + RolecomboBx.Text + "' WHERE ID='" + roleIDtb.Text + "'";
                cmd = new SqlCommand(Sql, con);
               
                int x = cmd.ExecuteNonQuery();
                displayDataUsers();
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
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Login where ID ='" + roleIDtb.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Update(dt);
                dataGridViewUsers.DataSource = dt;
                displayDataUsers();
                MessageBox.Show("Record Deleted successfully");
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

        private void NewBNT_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void EmailUSER_Leave(object sender, EventArgs e)
        {
          string pattern = @"^\s*[\w\-\+_']+(\.[\w\-\+_']+)*\@[A-Za-z0-9]([\w\.-]*[A-Za-z0-9])?\.[A-Za-z][A-Za-z\.]*[A-Za-z]$";
          if (Regex.IsMatch(EmailUSER.Text, pattern))
            {
                errorProvider1.Clear();

            }
          else
            {
                MessageBox.Show("Please enter a correct email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                errorProvider1.SetError(this.EmailUSER, "Please enter a correct email address");
                return;
            }

        }
    }
}
