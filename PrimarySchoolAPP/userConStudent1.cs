using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimarySchoolAPP
{
    public partial class userConStudent1 : UserControl
    {
        public userConStudent1()
        {
            InitializeComponent();
        }

        private void userConStudent1_Load(object sender, EventArgs e)
        {   
            //tabPage1.Text = @"Something Meaningful";
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
