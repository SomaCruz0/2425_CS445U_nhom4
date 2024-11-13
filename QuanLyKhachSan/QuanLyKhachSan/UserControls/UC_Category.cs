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
    public partial class UC_Category : UserControl
    {
        function fn = new function();
        String query;
        public UC_Category()
        {
            InitializeComponent();
        }

        private void UC_Category_Load(object sender, EventArgs e)
        {
            query = "select * from LoaiPhong";
            DataSet ds = fn.getData(query);
            dgv_Room.DataSource = ds.Tables[0];

            query = "select * from LoaiGiuong";
            DataSet ds2 = fn.getData(query);
            dgv_LoaiGiuong.DataSource = ds2.Tables[0];

            query = "select * from SanPham";
            DataSet ds3 = fn.getData(query);
            dgv_Service.DataSource = ds3.Tables[0];
        }
    }
}
