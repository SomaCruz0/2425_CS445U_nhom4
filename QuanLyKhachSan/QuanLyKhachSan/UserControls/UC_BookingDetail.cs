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
    public partial class UC_BookingDetail : UserControl
    {
        function fn = new function();
        string query;
        public UC_BookingDetail()
        {
            InitializeComponent();
        }
        private void Config()
        {
            dgv_Booking.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Booking.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_Booking.RowTemplate.Height = 40;

        }
        void LoadBill()
        {
            query = "Select IDDatPhong as N'Mã hóa đơn', HoTen as N'Khách hàng', SoPhong as N'Số phòng', NgayDat as N'Ngày đặt phòng', NgayTra as N'Ngày trả phòng', Name as N'Người lập hóa đơn' " +
                "from KhachHang kh, DatPhong dp, TaiKhoan tk where kh.IDKH = dp.IDKH and tk.Uid = dp.Uid";
            DataSet ds = fn.getData(query);
            dgv_Booking.DataSource = ds.Tables[0];
        }
        private void UC_BookingDetail_Load(object sender, EventArgs e)
        {
            LoadBill();
            Config();
        }


        private void btn_Print_Click(object sender, EventArgs e)
        {
            query = "Select * from DatPhong where IDDatPhong = '" + dgv_Booking.CurrentRow.Cells[0].Value.ToString() + "'";
            DataTable dt = fn.GetDataTable(query);
            Const.BookingID = int.Parse(dt.Rows[0][0].ToString());
            frm_Print pr = new frm_Print();
            pr.ShowDialog();
        }
    }
}
