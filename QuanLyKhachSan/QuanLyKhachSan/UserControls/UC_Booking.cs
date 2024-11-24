using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UserControls
{
    public partial class UC_Booking : UserControl
    {
        function fn = new function();
        String query;
        public UC_Booking()
        {
            InitializeComponent();
        }
        private void Config()
        {
            dgv_Room.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Room.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_Room.RowTemplate.Height = 40;

            dgv_Customer.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Customer.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_Customer.RowTemplate.Height = 40;

            dtp_CheckIn.Value = DateTime.Today;
            dtp_Checkout.Value = DateTime.Today;
        }
        void LoadTable()
        {
            LoadKhachHang();
            LoadRoom();
        }
        void LoadRoom()
        {

            query = "select SoPhong, rt.Ten as N'Loại Phòng', b.Ten as N'Loại Giường' , Gia, TinhTrang " +
               "from LoaiGiuong b, LoaiPhong rt, Phong r " +
               "where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong and TinhTrang = N'Trống'";
            DataSet ds = fn.getData(query);
            dgv_Room.DataSource = ds.Tables[0];
        }
        void LoadKhachHang()
        {
            query = "Select HoTen, CCCD, Phone, DiaChi, NgayDangKy from KhachHang";
            DataSet ds2 = fn.getData(query);
            dgv_Customer.DataSource = ds2.Tables[0];
        }
        void LoadComboBox()
        {
            query = "select * from KhachHang";
            DataSet kh = fn.getData(query);
            cb_KhachHang.DataSource = kh.Tables[0];
            cb_KhachHang.ValueMember = "IDKH";
            cb_KhachHang.DisplayMember = "HoTen";
            cb_KhachHang.SelectedIndex = -1;

            query = "select * from LoaiGiuong";
            DataSet bt = fn.getData(query);
            cb_BedType.DataSource = bt.Tables[0];
            cb_BedType.ValueMember = "IDLoaiGiuong";
            cb_BedType.DisplayMember = "Ten";
            cb_BedType.SelectedIndex = -1;

            query = "select * from LoaiPhong";
            DataSet rt = fn.getData(query);
            cb_RoomType.DataSource = rt.Tables[0];
            cb_RoomType.ValueMember = "IDLoaiPhong";
            cb_RoomType.DisplayMember = "Ten";
            cb_RoomType.SelectedIndex = -1;
        }
        private void UC_Booking_Load(object sender, EventArgs e)
        {
            Config();
            LoadComboBox();
            LoadTable();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            query = "select HoTen, CCCD, Phone, DiaChi, NgayDangKy from KhachHang where LOWER(HoTen) like Lower(N'%" + txt_Search.Text + "%')";
            DataSet ds = fn.getData(query);
            dgv_Customer.DataSource = ds.Tables[0];

        }

        private void cb_BedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_RoomType.SelectedIndex == -1)
            {
                query = "select SoPhong, rt.Ten as N'Loại Phòng', b.Ten as N'Loại Giường' , Gia, TinhTrang " +
                "from LoaiGiuong b, LoaiPhong rt, Phong r " +
                "where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong and TinhTrang = N'Trống' and b.Ten = N'" + cb_BedType.Text + "'";
                DataSet ds = fn.getData(query);
                dgv_Room.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select SoPhong, rt.Ten as N'Loại Phòng', b.Ten as N'Loại Giường' , Gia, TinhTrang " +
                "from LoaiGiuong b, LoaiPhong rt, Phong r " +
                "where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong and TinhTrang = N'Trống' and b.Ten = N'" + cb_BedType.Text + "' and rt.Ten = N'" + cb_RoomType.Text + "'";
                DataSet ds = fn.getData(query);
                dgv_Room.DataSource = ds.Tables[0];
            }
        }

        private void cb_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_BedType.SelectedIndex == -1)
            {
                query = "select SoPhong, rt.Ten as N'Loại Phòng', b.Ten as N'Loại Giường' , Gia, TinhTrang " +
                "from LoaiGiuong b, LoaiPhong rt, Phong r " +
                "where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong and TinhTrang = N'Trống' and rt.Ten = N'" + cb_RoomType.Text + "'";
                DataSet ds = fn.getData(query);
                dgv_Room.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select SoPhong, rt.Ten as N'Loại Phòng', b.Ten as N'Loại Giường' , Gia, TinhTrang " +
                "from LoaiGiuong b, LoaiPhong rt, Phong r " +
                "where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong and TinhTrang = N'Trống' and b.Ten = N'" + cb_BedType.Text + "' and rt.Ten = N'" + cb_RoomType.Text + "'";
                DataSet ds = fn.getData(query);
                dgv_Room.DataSource = ds.Tables[0];
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            cb_BedType.SelectedIndex = -1;
            cb_RoomType.SelectedIndex = -1;
            txt_RoomNo.Text = "";
            txt_Price.Text = "";
            LoadRoom();
        }
        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_KhachHang.Text = dgv_Customer.CurrentRow.Cells[0].Value.ToString();
        }
        private void dgv_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_RoomNo.Text = dgv_Room.CurrentRow.Cells[0].Value.ToString();
        }
        int SoNgay = 0;
        private void btn_CalTotal_Click(object sender, EventArgs e)
        {
            DateTime startTime = dtp_CheckIn.Value;
            DateTime endTime = dtp_Checkout.Value;
            TimeSpan duration = endTime - startTime;

            SoNgay = int.Parse(duration.Days.ToString());
            float DonGia = float.Parse(dgv_Room.CurrentRow.Cells[3].Value.ToString());

            txt_Price.Text = (SoNgay * int.Parse(nb_Customer.Value.ToString()) * DonGia).ToString();

        }
        private void label13_MouseHover(object sender, EventArgs e)
        {
            label13.Text = "Tổng tiền (Số ngày x Số người x Đơn giá)";
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.Text = "Tổng tiền";
        }

        private void btn_AllotRoom_Click(object sender, EventArgs e)
        {
            if (txt_RoomNo.Text != "" && cb_KhachHang.SelectedIndex != -1 && txt_Price.Text != "0" && txt_Price.Text != "")
            {
                query = "insert into DatPhong " +
                    "values ('" + cb_KhachHang.SelectedValue + "','" + txt_RoomNo.Text + "',Convert(datetime,'" + dtp_CheckIn.Text + "',103),Convert(Datetime,'" + dtp_Checkout.Text + "',103),'" + Const.ID + "','NO')";
                fn.setData(query, "Đã thêm hóa đơn");

                query = "DECLARE @MaxMHD INT; " +
                    "SELECT @MaxMHD = MAX(IDDatPhong) FROM DatPhong; " +
                    "INSERT INTO CTDP VALUES (@MaxMHD, '"+SoNgay+"', '"+((int)nb_Customer.Value)+"', '"+float.Parse(txt_Price.Text)+"')";
                fn.setData(query, "Đã thêm chi tiết hóa đơn");

                LoadRoom();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
