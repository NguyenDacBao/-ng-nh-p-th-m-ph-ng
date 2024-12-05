using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "Bao" && txtpasswork.Text == "123" ){
                labelerror.Visible = false;
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }
            else
            {
                labelerror.Visible = true;
                txtpasswork.Clear();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
