using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

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
            dgv_Booking.RowTemplate.Height = 50;
        }
        void LoadBill()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyKhachSan.Properties.Settings.QLKSConnectionString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                query = "select dp.IDDatPhong, HoTen, Name, Phone, DiaChi, NgayDat " +
                    " from DatPhong dp, KhachHang kh, TaiKhoan tk " +
                    $"where kh.IDKH = dp.IDKH and tk.uid = dp.uid and dp.TrangThai = 'YES'";
                billBindingSource.DataSource = db.Query<Bill>(query, commandType: CommandType.Text);
            }
        }
        private void UC_BookingDetail_Load(object sender, EventArgs e)
        {
            Config();
            LoadBill();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyKhachSan.Properties.Settings.QLKSConnectionString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                query = "select dp.IDDatPhong, HoTen, Name, Phone, DiaChi, NgayDat " +
                    " from DatPhong dp, KhachHang kh, TaiKhoan tk " +
                    $"where kh.IDKH = dp.IDKH and tk.uid = dp.uid and NgayDat between Convert(Datetime,'{fromDate.Value}',103) and Convert(Datetime,'{toDate.Value}',103) and dp.TrangThai = 'YES'";
                billBindingSource.DataSource = db.Query<Bill>(query, commandType: CommandType.Text);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Bill obj = billBindingSource.Current as Bill;
            if (obj != null)
            {

                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyKhachSan.Properties.Settings.QLKSConnectionString"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    query = "select ct.IDDatPhong, ct.SoPhong, Checkin, Checkout, SoNguoi, p.Gia " +
                        " from CTDP ct, Phong p, DatPhong dp " +
                        " where ct.IDDatPhong = dp.IDDatPhong and p.SoPhong = ct.SoPhong and ct.IDDatPhong = '" + obj.IDDatPhong + "'";
                    List<BillDetailRoom> list = db.Query<BillDetailRoom>(query, commandType: CommandType.Text).ToList();
                    using (frm_Print frm = new frm_Print(obj, list))
                    {
                        frm.ShowDialog();
                    }
                }
            }
        }
    }
}
