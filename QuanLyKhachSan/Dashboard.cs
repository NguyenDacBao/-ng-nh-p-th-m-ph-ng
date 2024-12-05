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
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

     

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            PanelMoving.Left =btnthem.Left + 50;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            btnthem.Visible = false;
            btnthem.PerformClick();
        }
    }
}
