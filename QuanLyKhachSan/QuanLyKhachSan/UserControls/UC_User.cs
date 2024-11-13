using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UserControls
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }

        function fn = new function();
        private void UC_User_Load(object sender, EventArgs e)
        {
            string sql = "Select * from TAIKHOAN WHERE Uid = '" + Const.ID + "'";
            DataTable dt = new DataTable();
            dt = fn.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                // Có dữ liệu, truy cập vào hàng đầu tiên
                DataRow row = dt.Rows[0];
                txt_ID.Text = row[0].ToString();
                txt_Name.Text = row[1].ToString();
                txt_UserName.Text = row[2].ToString();
                txt_Password.Text = row[3].ToString();
                txt_Role.Text = (row[4].ToString() == "1") ? "Admin" : "Nhân viên";
            }
            else
            {
                // Không có dữ liệu, hiển thị thông báo lỗi hoặc xử lý khác
                MessageBox.Show("Không tìm thấy dữ liệu người dùng.");
            }
        }
    }
}
