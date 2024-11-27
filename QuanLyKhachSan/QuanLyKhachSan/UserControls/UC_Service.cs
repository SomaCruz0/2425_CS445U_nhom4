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


            query = "select * from DatPhong where Trangthai = 'NO'";
            DataSet hd = fn.getData(query);
            cb_IDBooking.DataSource = hd.Tables[0];
            cb_IDBooking.ValueMember = "IDDatPhong";
            cb_IDBooking.DisplayMember = "IDDatPhong";
            cb_IDBooking.SelectedIndex = -1;


            query = "select * from SanPham";
            DataSet sv = fn.getData(query);
            cb_Service.DataSource = sv.Tables[0];
            cb_Service.ValueMember = "IdSanPham";
            cb_Service.DisplayMember = "TenSanPham";
            cb_Service.SelectedIndex = -1;
        }

        private void UC_DichVu_Load(object sender, EventArgs e)
        {
            LoadBooking();
            LoadService();
            Config();
            LoadComboBox();
        }

        private void txt_SearchCustomer_TextChanged(object sender, EventArgs e)
        {
            query = "Select IDDatPhong as N'Mã HĐ', HoTen, SoPhong, NgayDat, NgayTra, Name as N'Nhân viên' " +
                "from DatPhong dp, KhachHang, TaiKhoan tk " +
                "where KhachHang.IDKH = dp.IDKH and tk.Uid = dp.Uid and dp.Trangthai = 'No' and LOWER(HoTen) like Lower(N'%" + txt_SearchCustomer.Text + "%')";
            DataSet ds = fn.getData(query);
            dgv_Booking.DataSource = ds.Tables[0];
        }

        private void dgv_Booking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_IDBooking.Text = dgv_Booking.CurrentRow.Cells[0].Value.ToString();
            cb_KhachHang.Text = dgv_Booking.CurrentRow.Cells[1].Value.ToString();
            cb_SoPhong.Text = dgv_Booking.CurrentRow.Cells[2].Value.ToString();
        }

        private void dtp_Checkin_ValueChanged(object sender, EventArgs e)
        {
            query = "Select IDDatPhong as N'Mã HĐ', HoTen, SoPhong, NgayDat, NgayTra, Name as N'Nhân viên' " +
                "from DatPhong dp, KhachHang, TaiKhoan tk " +
                "where KhachHang.IDKH = dp.IDKH and tk.Uid = dp.Uid and dp.Trangthai = 'No' and NgayDat = Convert(Datetime,'" + dtp_Checkin.Text + "',103)";
            DataSet ds = fn.getData(query);
            dgv_Booking.DataSource = ds.Tables[0];
        }

        private void btn_ShowAllCus_Click(object sender, EventArgs e)
        {
            LoadBooking();
            for (int i = 0; i < 2; i++)
            {
                cb_SoPhong.SelectedIndex = -1;
                cb_KhachHang.SelectedIndex = -1;
                cb_IDBooking.SelectedIndex = -1;
            }

        }

        private void txt_SearchService_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from SanPham where LOWER(TenSanPham) like Lower(N'%" + txt_SearchService.Text + "%')";
            DataSet ds = fn.getData(query);
            dgv_Service.DataSource = ds.Tables[0];
        }
        void TinhTongTien()
        {
            txt_Total.Text = (int.Parse(txt_Price.Text.ToString()) * nb_Quantity.Value).ToString();
        }

        void QuantityCheck()
        {
            nb_Quantity.Maximum = int.Parse(dgv_Service.CurrentRow.Cells[3].Value.ToString());
        }
        private void dgv_Service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_Service.Text = dgv_Service.CurrentRow.Cells[1].Value.ToString();
            txt_Price.Text = dgv_Service.CurrentRow.Cells[2].Value.ToString();

            TinhTongTien();
            QuantityCheck();
        }

        private void nb_Quantity_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void btn_AllService_Click(object sender, EventArgs e)
        {
            LoadService();
            for (int i = 0; i < 2; i++)
                cb_Service.SelectedIndex = -1;
            txt_Price.Text = "";
            txt_Total.Text = "";
            nb_Quantity.Value = 0;
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            if (cb_IDBooking.SelectedIndex != -1 && cb_Service.SelectedIndex != -1 && nb_Quantity.Value > 0)
            {
                query = "insert into CTDV " +
                    "values ('" + cb_IDBooking.SelectedValue + "','" + cb_Service.SelectedValue + "','" + nb_Quantity.Text + "','" + txt_Total.Text + "')";
                fn.setData(query, "Thêm dịch vụ thành công");

                query = "Update SanPham Set " +
                    "SoLuongTon = SoLuongTon - '" + nb_Quantity.Value + "' " +
                    "Where IdSanPham = '" + cb_Service.SelectedValue + "'";
                fn.setData(query, "");

                LoadService();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
