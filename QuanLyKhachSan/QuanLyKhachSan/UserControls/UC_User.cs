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
            txt_ID.Text = dt.Rows[0][0].ToString();
            txt_Name.Text = dt.Rows[0][1].ToString();
            txt_UserName.Text = dt.Rows[0][2].ToString();
            txt_Password.Text = dt.Rows[0][3].ToString();
            if (dt.Rows[0][4].ToString() == "1")
            {
                txt_Role.Text = "Admin" ;
            }
            else
            {
                txt_Role.Text = "Nhân viên";
            }
        }
    }
}
