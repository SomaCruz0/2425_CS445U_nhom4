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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        function fn = new function();
        private void btn_Exit_Click(object sender, EventArgs e)
        {

            DialogResult dt = MessageBox.Show("Bạn có thực sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            string sql = "Select * from TAIKHOAN WHERE UserName = '" + txt_UserName.Text + "'and Password ='" + txt_Password.Text + "'";
            DataTable dt = new DataTable();
            dt = fn.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Const.ID = int.Parse(dt.Rows[0][0].ToString());
                lbl_Error.Visible = false;
                frm_Dashboard db = new frm_Dashboard();
                this.Hide();
                db.Show();
            }
            else
            {
                lbl_Error.Show();
            }
        }
    }
}
