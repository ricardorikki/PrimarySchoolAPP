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
    public partial class UserConWatch : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True");

        
        SqlCommand cmd;
        string imgLoc = "";
        public UserConWatch()
        {
            InitializeComponent();
        }
        public void displayDataWatch()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Watchmen";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewWatch.DataSource = dt;
                da.Update(dt);
                dataGridViewWatch.AllowUserToAddRows = false;



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
            FnameWatchTB.Text = "";
            MiddnameWatchTB.Text = "";
            LastNameWatchTB.Text = "";
            DOBWatchDT.Text = "";
            GenderComWatchBx.Text = "";
            DateAppointmentWatchDT.Text = "";
            EmailWatchTB.Text = "";
            StatcomboWatchBx.Text = "";
            NOKnameWatchTB.Text = "";
            NOKconWatchTB.Text = "";
            IDWatchTB.Text = "";
            WatchPhoto.Image = Properties.Resources.user;
        }
        private void UserConWatch_Load(object sender, EventArgs e)
        {
            GenderComWatchBx.Items.Add("Male");
            GenderComWatchBx.Items.Add("Female");
            StatcomboWatchBx.Items.Add("Temp");
            StatcomboWatchBx.Items.Add("Permanent");
            displayDataWatch();

            WatchPhoto.Image = Properties.Resources.user;
        }

        private void NewWatchBNT_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void SaveWatchBNT_Click(object sender, EventArgs e)
        {
            try
            {
                string pattern = @"^\s*[\w\-\+_']+(\.[\w\-\+_']+)*\@[A-Za-z0-9]([\w\.-]*[A-Za-z0-9])?\.[A-Za-z][A-Za-z\.]*[A-Za-z]$";
                if (Regex.IsMatch(EmailWatchTB.Text, pattern))
                {
                    errorProvider1.Clear();

                }
                else
                {
                    MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    errorProvider1.SetError(this.EmailWatchTB, "Please enter a correct email address");
                    return;
                }

                byte[] img = null;

                if (WatchPhoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    WatchPhoto.Image.Save(ms, WatchPhoto.Image.RawFormat);
                    img = ms.GetBuffer();
                    ms.Close();
                }

                if (WatchPhoto.Image == null)
                {
                    MessageBox.Show("Please Update Image ", "WARRING NOT SAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                if (FnameWatchTB.Text != "" && MiddnameWatchTB.Text != "" && LastNameWatchTB.Text != "" && DOBWatchDT.Text != "" && GenderComWatchBx.Text != "" && DateAppointmentWatchDT.Text != "" && EmailWatchTB.Text != "" && StatcomboWatchBx.Text != "" && NOKnameWatchTB.Text != "" && NOKconWatchTB.Text != "")
                {
                    string sql = "INSERT INTO Watchmen (FirstName,MiddleName,LastName,DOB,Gender,DateAppointment,Email,Status,NextKin,NextKinCon,Photo) values('" + FnameWatchTB.Text + "','" + MiddnameWatchTB.Text + "', '" + LastNameWatchTB.Text + "','" + DOBWatchDT.Text + "','" + GenderComWatchBx.Text + "','" + DateAppointmentWatchDT.Text + "','" + EmailWatchTB.Text + "','" + StatcomboWatchBx.Text + "','" + NOKnameWatchTB.Text + "','" + NOKconWatchTB.Text + "',@img)";

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    displayDataWatch();
                    //ClearData();
                    MessageBox.Show(x.ToString() + " Record inserted successfully");
                }

                if (DOBWatchDT.Value.Date > DateTime.Now.AddYears(-6))
                {
                    MessageBox.Show("Please enter a valid birth date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOBWatchDT.Focus();
                    errorProvider1.SetError(this.DOBWatchDT, "Please enter a correct email address");
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





            if (string.IsNullOrEmpty(FnameWatchTB.Text))
            {
                FnameWatchTB.Focus();
                errorProvider1.SetError(FnameWatchTB, "Please Enter First Name");
            }
            if (string.IsNullOrEmpty(MiddnameWatchTB.Text))
            {
                MiddnameWatchTB.Focus();
                errorProvider1.SetError(MiddnameWatchTB, "Please Enter Middle Name");
            }
            if (string.IsNullOrEmpty(LastNameWatchTB.Text))
            {
                LastNameWatchTB.Focus();
                errorProvider1.SetError(LastNameWatchTB, "Please Enter Last Name");
            }

            if (string.IsNullOrEmpty(EmailWatchTB.Text))
            {
                EmailWatchTB.Focus();
                errorProvider1.SetError(EmailWatchTB, "Please Enter Email Address");
            }

            if (string.IsNullOrEmpty(StatcomboWatchBx.Text))
            {
                StatcomboWatchBx.Focus();
                errorProvider1.SetError(StatcomboWatchBx, "Please select a Status");
            }

            if (string.IsNullOrEmpty(NOKnameWatchTB.Text))
            {
                NOKnameWatchTB.Focus();
                errorProvider1.SetError(NOKnameWatchTB, "Please Enter Next of Kin Name");
            }
            if (string.IsNullOrEmpty(NOKconWatchTB.Text))
            {
                NOKconWatchTB.Focus();
                errorProvider1.SetError(NOKconWatchTB, "Please Enter Next of Kin Contact");
            }
            if (string.IsNullOrEmpty(GenderComWatchBx.Text))
            {
                GenderComWatchBx.Focus();
                errorProvider1.SetError(GenderComWatchBx, "Please select your gender");
            }


        }

        private void UpdateWatchBNT_Click(object sender, EventArgs e)
        {
            try
            {


                byte[] img = null;

                if (WatchPhoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    WatchPhoto.Image.Save(ms, WatchPhoto.Image.RawFormat);
                    img = ms.GetBuffer();
                    ms.Close();
                }

                if (WatchPhoto.Image == null)
                {
                    MessageBox.Show("Please Update Image ", "WARRING NOT SAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }



                SqlCommand cmd = con.CreateCommand();
                string Sql = "UPDATE Watchmen SET FirstName='" + FnameWatchTB.Text + "',MiddleName='" + MiddnameWatchTB.Text + "',LastName='" + LastNameWatchTB.Text + "',DOB='" + DOBWatchDT.Text + "',Gender='" + GenderComWatchBx.Text + "',DateAppointment='" + DateAppointmentWatchDT.Text + "',Email='" + EmailWatchTB.Text + "',Status='" + StatcomboWatchBx.Text + "',NextKin='" + NOKnameWatchTB.Text + "',NextKinCon='" + NOKconWatchTB.Text + "',Photo=@img WHERE ID='" + IDWatchTB.Text + "'";
                cmd = new SqlCommand(Sql, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                displayDataWatch();
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

        private void DeleteWatchBNT_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from Watchmen where ID ='" + IDWatchTB.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);
                    dataGridViewWatch.DataSource = dt;
                    displayDataWatch();
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

        private void browseWatchBTN_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALL Files(*.*)|*.*";
                dlg.Title = "Select Watchman Picture";


                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    WatchPhoto.ImageLocation = imgLoc;
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

        private void dataGridViewWatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewWatch.Rows[e.RowIndex];
                    IDWatchTB.Text = row.Cells[0].Value.ToString();
                    FnameWatchTB.Text = row.Cells[1].Value.ToString();
                    MiddnameWatchTB.Text = row.Cells[2].Value.ToString();
                    LastNameWatchTB.Text = row.Cells[3].Value.ToString();
                    DOBWatchDT.Text = row.Cells[4].Value.ToString();
                    GenderComWatchBx.Text = row.Cells[5].Value.ToString();
                    DateAppointmentWatchDT.Text = row.Cells[6].Value.ToString();
                    EmailWatchTB.Text = row.Cells[7].Value.ToString();
                    StatcomboWatchBx.Text = row.Cells[8].Value.ToString();
                    NOKnameWatchTB.Text = row.Cells[9].Value.ToString();
                    NOKconWatchTB.Text = row.Cells[10].Value.ToString();
                    var data = (Byte[])(row.Cells[11].Value);
                    var stream = new MemoryStream(data);
                    WatchPhoto.Image = Image.FromStream(stream);
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

        private void WatchSearTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (WatchSearCBO.Text == "First Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Watchmen where [FirstName] like'" + WatchSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewWatch.DataSource = dt;
                }
                else if (WatchSearCBO.Text == "Last Name")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Administrative where [LastName] like'" + WatchSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewWatch.DataSource = dt;
                }


                else if (WatchSearCBO.Text == "Gender")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Watchmen where [Gender] like'" + WatchSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewWatch.DataSource = dt;
                }
                else if (WatchSearCBO.Text == "Status")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Watchmen where [Status] like'" + WatchSearTB.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Update(dt);

                    dataGridViewWatch.DataSource = dt;
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
