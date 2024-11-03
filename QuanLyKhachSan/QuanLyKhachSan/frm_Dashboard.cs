using QuanLyKhachSan.UserControls;
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
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            btn_Room.PerformClick();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có thực sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }


        private void btn_CustomerReg_Click(object sender, EventArgs e)
        {
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }
    }
}
