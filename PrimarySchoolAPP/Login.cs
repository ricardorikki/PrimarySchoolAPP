﻿using System;
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

        String conString = "Data Source=DESKTOP-SINTN8E\\SQLEXPRESS;Initial Catalog=School_Mang_System;Integrated Security=True";

     
        public Login()
        {
            InitializeComponent();
        }

        public class shubh
        {
           
          }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Dashboard dashboard = new Dashboard();
        //    dashboard.ShowDialog();
        //}

        private void Login_Load(object sender, EventArgs e)
        {
            labSMS.Parent = picBoxBG;
            labSMS.BackColor = Color.Transparent;
            labSch.Parent = picBoxBG;
            labSch.BackColor = Color.Transparent;
            
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
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(conString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT Username,Password FROM login WHERE Username = @Username AND Password = @Password", myConnection);

                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                uName.Value = tbUser.Text;
                uPassword.Value = tbPass.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    MessageBox.Show("Login was successful, welcome " + tbUser.Text, "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                   

                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                    
                    
                }

                else
                {
                    MessageBox.Show("Incorect Username or Password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tbUser.Clear();
                    tbPass.Clear();
                    tbUser.Focus();
                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }

       

    }
}
