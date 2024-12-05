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
    public partial class UC_Checkout : UserControl
    {
        public UC_Checkout()
        {
            InitializeComponent();
        }
        function fn = new function();
        String query;

        void LoadBill()
        {
            query = "select IDDatPhong as N'Mã HĐ', Hoten as N'Khách hàng', SoPhong, NgayDat, Name as N'Nhân viên' " +
                "from DatPhong, KhachHang, TaiKhoan " +
                "where Taikhoan.Uid = DatPhong.Uid and KhachHang.IDKH = DatPhong.IDKH and DatPhong.TrangThai='NO'";
            DataSet ds = fn.getData(query);
            dgv_Booking.DataSource = ds.Tables[0];
        }
        void LoadBookingDetail()
        {
            query = "select * from CTDP where IDDatPhong = '" + dgv_Booking.CurrentRow.Cells[0].Value.ToString() +"'";
            DataSet ds = fn.getData(query);
            dgv_BookingDetail.DataSource = ds.Tables[0];
        }
        void LoadServiceDetail()
        {
            query = "select * from CTDV where IDDatPhong = '" + dgv_Booking.CurrentRow.Cells[0].Value.ToString() +"'";
            DataSet ds = fn.getData(query);
            dgv_ServiceDetail.DataSource = ds.Tables[0];
        }
        void Config()
        {
            dgv_Booking.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Booking.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_Booking.RowTemplate.Height = 40;

            dgv_BookingDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_BookingDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_BookingDetail.RowTemplate.Height = 40;

            dgv_ServiceDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_ServiceDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_ServiceDetail.RowTemplate.Height = 40;
        }
        private void UC_Checkout_Load(object sender, EventArgs e)
        {
            LoadBill();
            Config();
        }

        private void dgv_Booking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadBookingDetail();
            LoadServiceDetail();
            string RoomCost = dgv_BookingDetail.CurrentRow.Cells[4].Value.ToString();
            string ServiceCost = "0";
            if (dgv_ServiceDetail.RowCount > 0)
            {
                double S = 0;
                for(int i = 0; i < dgv_ServiceDetail.RowCount; i++)
                {
                    S += int.Parse(dgv_ServiceDetail.Rows[i].Cells[4].Value.ToString());
                }
                ServiceCost =  S.ToString();
            }
            txt_RoomCost.Text = RoomCost;
            txt_ServiceCost.Text = ServiceCost;
            txt_TongTien.Text = (int.Parse(RoomCost) + int.Parse(ServiceCost)).ToString();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            query = "update datphong set TrangThai = 'YES' where IDDatPhong = '" + dgv_Booking.CurrentRow.Cells[0].Value.ToString() + "' " +
                "update Phong set TinhTrang = N'Trống' where SoPhong = '" + dgv_Booking.CurrentRow.Cells[2].Value.ToString() +"' ";
            fn.setData(query,"Thanh toán thành công");
            LoadBill();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            txt_SearchCus.Text = "";
            txt_SearchRoom.Text = "";
            LoadBill();
        }

        private void txt_SearchCus_TextChanged(object sender, EventArgs e)
        {
            query = "select IDDatPhong as N'Mã HĐ', Hoten as N'Khách hàng', SoPhong, NgayDat, Name as N'Nhân viên' " +
                "from DatPhong, KhachHang, TaiKhoan " +
                "where Taikhoan.Uid = DatPhong.Uid and KhachHang.IDKH = DatPhong.IDKH and DatPhong.TrangThai='NO' and LOWER(HoTen) like Lower(N'%"+txt_SearchCus.Text+"%')";
            DataSet ds = fn.getData(query);
            dgv_Booking.DataSource = ds.Tables[0];
        }

        private void txt_SearchRoom_TextChanged(object sender, EventArgs e)
        {
            query = "select IDDatPhong as N'Mã HĐ', Hoten as N'Khách hàng', SoPhong, NgayDat, Name as N'Nhân viên' " +
                "from DatPhong, KhachHang, TaiKhoan " +
                "where Taikhoan.Uid = DatPhong.Uid and KhachHang.IDKH = DatPhong.IDKH and DatPhong.TrangThai='NO' and  SoPhong like '%" + txt_SearchRoom.Text.Trim() + "%'";
            DataSet ds = fn.getData(query);
            dgv_Booking.DataSource = ds.Tables[0];
        }
    }
}
