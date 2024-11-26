using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UserControls
{
    public partial class UC_Service : UserControl
    {
        function fn = new function();
        String query;
        public UC_Service()
        {
            InitializeComponent();
        }

        void LoadBooking()
        {
            query = "Select IDDatPhong as N'Mã HĐ', HoTen, SoPhong, NgayDat, NgayTra, Name as N'Nhân viên' " +
                "from DatPhong dp, KhachHang, TaiKhoan tk " +
                "where KhachHang.IDKH = dp.IDKH and tk.Uid = dp.Uid and dp.Trangthai = 'No'";
            DataSet ds = fn.getData(query);
            dgv_Booking.DataSource = ds.Tables[0];
        }
        void LoadService()
        {
            query = "Select * from SanPham";
            DataSet ds = fn.getData(query);
            dgv_Service.DataSource = ds.Tables[0];
        }
        void Config()
        {
            dgv_Booking.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Booking.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_Booking.RowTemplate.Height = 40;

            dgv_Service.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Service.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_Service.RowTemplate.Height = 40;
        }
        void LoadComboBox()
        {
            query = "select * from KhachHang kh, DatPhong dp where kh.IDKH = dp.IDKH and dp.Trangthai = 'No'";
            DataSet kh = fn.getData(query);
            cb_KhachHang.DataSource = kh.Tables[0];
            cb_KhachHang.ValueMember = "IDKH";
            cb_KhachHang.DisplayMember = "HoTen";
            cb_KhachHang.SelectedIndex = -1;

            query = "select * from DatPhong where Trangthai = 'No'";
            DataSet bt = fn.getData(query);
            cb_SoPhong.DataSource = bt.Tables[0];
            cb_SoPhong.ValueMember = "SoPhong";
            cb_SoPhong.DisplayMember = "SoPhong";
            cb_SoPhong.SelectedIndex = -1;
        }
        private void UC_DichVu_Load(object sender, EventArgs e)
        {
            LoadBooking();
            LoadService();
            Config();
            LoadComboBox();
        }

    }
}
