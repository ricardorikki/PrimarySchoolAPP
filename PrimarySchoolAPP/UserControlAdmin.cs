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
    public partial class UserControlAdmin : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");

        // (@"Data Source=DESKTOP-SINTN8E\SQLEXPRESS;Initial Catalog=EdHardware;Integrated Security=True");
        SqlCommand cmd;
        string imgLoc = "";
        public UserControlAdmin()
        {
            InitializeComponent();
        }

        public void displayDataAdmin()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Administrative";
                //cmd.CommandText ="SELECT id AS ID, FirstName AS [First Name], MiddleName AS [Middle Name], LastName AS [Last Name],DOB, Gender,DateAppointment AS [Date of Appointment],Email,Status,Rank,House,Club,NextKin AS [Next of Kin Name],NextKinCon AS [Next of Kin Contact] FROM Teachers ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewAdmin.DataSource = dt;
                da.Update(dt);
                dataGridViewAdmin.AllowUserToAddRows = false;



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
            FnameAdminTB.Text = "";
            MiddnameAdminTB.Text = "";
            LastNameAdminTB.Text = "";
            DOBadminDT.Text = "";
            GenderComAdminBx.Text = "";
            DateAppointmentAdminDT.Text = "";
            EmailAdminTB.Text = "";
            StatcomboAdminBx.Text = "";
            NOKnameAdminTB.Text = "";
            NOKconAdminTB.Text = "";
            IDAdminTB.Text = "";
            AdminPhoto.Image = Properties.Resources.user;
        }

        private void NewAdminBNT_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void SaveAdminBNT_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] img = null;

                if (AdminPhoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    AdminPhoto.Image.Save(ms, AdminPhoto.Image.RawFormat);
                    img = ms.GetBuffer();
                    ms.Close();
                }

                if (AdminPhoto.Image == null)
                {
                    MessageBox.Show("Please Update Image ", "WARRING NOT SAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                if (FnameAdminTB.Text != "" && MiddnameAdminTB.Text != "" && LastNameAdminTB.Text != "" && DOBadminDT.Text != "" && GenderComAdminBx.Text != "" && DateAppointmentAdminDT.Text != "" && EmailAdminTB.Text != "" && StatcomboAdminBx.Text != ""  && NOKnameAdminTB.Text != "" && NOKconAdminTB.Text != "")
                {
                    string sql = "INSERT INTO Administrative (FirstName,MiddleName,LastName,DOB,Gender,DateAppointment,Email,Status,NextKin,NextKinCon,Photo) values('" + FnameAdminTB.Text + "','" + MiddnameAdminTB.Text + "', '" + LastNameAdminTB.Text + "','" + DOBadminDT.Text + "','" + GenderComAdminBx.Text + "','" + DateAppointmentAdminDT.Text + "','" + EmailAdminTB.Text + "','" + StatcomboAdminBx.Text + "','" + NOKnameAdminTB.Text + "','" + NOKconAdminTB.Text + "',@img)";

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    displayDataAdmin();
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





            if (string.IsNullOrEmpty(FnameAdminTB.Text))
            {
                FnameAdminTB.Focus();
                errorProvider1.SetError(FnameAdminTB, "Please Enter First Name");
            }
            if (string.IsNullOrEmpty(MiddnameAdminTB.Text))
            {
                MiddnameAdminTB.Focus();
                errorProvider1.SetError(MiddnameAdminTB, "Please Enter Middle Name");
            }
            if (string.IsNullOrEmpty(LastNameAdminTB.Text))
            {
                LastNameAdminTB.Focus();
                errorProvider1.SetError(LastNameAdminTB, "Please Enter Last Name");
            }

            if (string.IsNullOrEmpty(EmailAdminTB.Text))
            {
                EmailAdminTB.Focus();
                errorProvider1.SetError(EmailAdminTB, "Please Enter Email Address");
            }

            if (string.IsNullOrEmpty(StatcomboAdminBx.Text))
            {
                StatcomboAdminBx.Focus();
                errorProvider1.SetError(StatcomboAdminBx, "Please select a Status");
            }
            
            if (string.IsNullOrEmpty(NOKnameAdminTB.Text))
            {
                NOKnameAdminTB.Focus();
                errorProvider1.SetError(NOKnameAdminTB, "Please Enter Next of Kin Name");
            }
            if (string.IsNullOrEmpty(NOKconAdminTB.Text))
            {
                NOKconAdminTB.Focus();
                errorProvider1.SetError(NOKconAdminTB, "Please Enter Next of Kin Contact");
            }
            if (string.IsNullOrEmpty(GenderComAdminBx.Text))
            {
                GenderComAdminBx.Focus();
                errorProvider1.SetError(GenderComAdminBx, "Please select your gender");
            }




        }

        private void UpdateAdminBNT_Click(object sender, EventArgs e)
        {
            try
            {


                byte[] img = null;

                if (AdminPhoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    AdminPhoto.Image.Save(ms, AdminPhoto.Image.RawFormat);
                    img = ms.GetBuffer();
                    ms.Close();
                }

                if (AdminPhoto.Image == null)
                {
                    MessageBox.Show("Please Update Image ", "WARRING NOT SAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }



                SqlCommand cmd = con.CreateCommand();
                string Sql = "UPDATE Administrative SET FirstName='" + FnameAdminTB.Text + "',MiddleName='" + MiddnameAdminTB.Text + "',LastName='" + LastNameAdminTB.Text + "',DOB='" + DOBadminDT.Text + "',Gender='" + GenderComAdminBx.Text + "',DateAppointment='" + DateAppointmentAdminDT.Text + "',Email='" + EmailAdminTB.Text + "',Status='" + StatcomboAdminBx.Text + "',NextKin='" + NOKnameAdminTB.Text + "',NextKinCon='" + NOKconAdminTB.Text + "',Photo=@img WHERE ID='" + IDAdminTB.Text + "'";
                cmd = new SqlCommand(Sql, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                displayDataAdmin();
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

        private void DeleteAdminBNT_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Administrative where ID ='" + IDAdminTB.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Update(dt);
                dataGridViewAdmin.DataSource = dt;
                displayDataAdmin();
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

        private void browseAdminBTN_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALL Files(*.*)|*.*";
                dlg.Title = "Select Administrative Picture";


                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    AdminPhoto.ImageLocation = imgLoc;
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

        private void UserControlAdmin_Load(object sender, EventArgs e)
        {
            GenderComAdminBx.Items.Add("Male");
            GenderComAdminBx.Items.Add("Female");
            StatcomboAdminBx.Items.Add("Temp");
            StatcomboAdminBx.Items.Add("Permanent");
            displayDataAdmin();

            AdminPhoto.Image = Properties.Resources.user;
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try

            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewAdmin.Rows[e.RowIndex];
                    IDAdminTB.Text = row.Cells[0].Value.ToString();
                    FnameAdminTB.Text = row.Cells[1].Value.ToString();
                    MiddnameAdminTB.Text = row.Cells[2].Value.ToString();
                    LastNameAdminTB.Text = row.Cells[3].Value.ToString();
                    DOBadminDT.Text = row.Cells[4].Value.ToString();
                    GenderComAdminBx.Text = row.Cells[5].Value.ToString();
                    DateAppointmentAdminDT.Text = row.Cells[6].Value.ToString();
                    EmailAdminTB.Text = row.Cells[7].Value.ToString();
                    StatcomboAdminBx.Text = row.Cells[8].Value.ToString();
                    NOKnameAdminTB.Text = row.Cells[9].Value.ToString();
                    NOKconAdminTB.Text = row.Cells[10].Value.ToString();
                    var data = (Byte[])(row.Cells[11].Value);
                    var stream = new MemoryStream(data);
                    AdminPhoto.Image = Image.FromStream(stream);
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

        private void AdminSearTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AdminSearCBO.Text == "First Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Administrative where [FirstName] like'" + AdminSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewAdmin.DataSource = dt;
                }
                else if (AdminSearCBO.Text == "Last Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Administrative where [LastName] like'" + AdminSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewAdmin.DataSource = dt;
                }

               
                else if (AdminSearCBO.Text == "Gender")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Administrative where [Gender] like'" + AdminSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewAdmin.DataSource = dt;
                }
                else if (AdminSearCBO.Text == "Status")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Administrative where [Status] like'" + AdminSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewAdmin.DataSource = dt;
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
