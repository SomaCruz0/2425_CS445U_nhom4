using QuanLyKhachSan.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_Dashboard : Form
    {
        function fn = new function();
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            KiemTraQuyen();
            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            uC_DichVu1.Visible = false;
            uC_Booking1.Visible = false;
            uC_BookingDetail1.Visible = false;
            uC_Category1.Visible = false;
            uC_Checkout1.Visible = false;
            btn_Room.PerformClick();
        }

        void KiemTraQuyen()
        {
            string sql = "Select * from TAIKHOAN WHERE Uid = '"+Const.ID+"'";
            DataTable dt = new DataTable();
            dt = fn.GetDataTable(sql);
            int role = int.Parse(dt.Rows[0][4].ToString());
            txt_Name.Text = dt.Rows[0][1].ToString();
            if (role == 1)
            {
                txt_Authority.Text = "Admin";
            }
            else
            {
                txt_Authority.Text = "Nhân viên";
                btn_Account.Visible = false;
                btn_System.Visible = false;
                btn_Dashboard.Visible = false;
            }
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

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            uC_Booking1.Visible = true;
            uC_Booking1.BringToFront();
        }

        private void btn_Service_Click(object sender, EventArgs e)
        {
            uC_DichVu1.Visible = true;
            uC_DichVu1.BringToFront();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            uC_Category1.Visible = true;
            uC_Category1.BringToFront();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            uC_Checkout1.Visible = true;
            uC_Checkout1.BringToFront();
        }

        private void btn_BookingDetail_Click(object sender, EventArgs e)
        {
            uC_BookingDetail1.Visible = true;
            uC_BookingDetail1.BringToFront();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            uC_User1.Visible = true;
            uC_User1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString();

            txt_Time.Text = formattedTime;
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void btn_System_Click(object sender, EventArgs e)
        {

            uC_System1.Visible = true;
            uC_System1.BringToFront();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {

            uC_Account1.Visible = true;
            uC_Account1.BringToFront();
        }

    }
}
