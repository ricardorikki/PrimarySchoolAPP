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
    public partial class about : MetroFramework.Forms.MetroForm
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void about_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard das = new Dashboard();
            this.Dispose(false);
            das.Show();
            this.Hide();
        }
    }
}
