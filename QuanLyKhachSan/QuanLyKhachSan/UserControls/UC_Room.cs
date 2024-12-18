using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UserControls
{
    public partial class UC_Room : UserControl
    {
        function fn = new function();
        String query;
        public UC_Room()
        {
            InitializeComponent();
        }

        private void Config()
        {
            dgv_Room.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Room.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_Room.RowTemplate.Height = 40;
        }
        private void LoadRoom()
        {
            query = "select SoPhong as N'Số phòng', rt.Ten as N'Loại phòng', b.Ten as N'Loại giường', Gia as 'Giá', TinhTrang " +
                "from LoaiGiuong b, LoaiPhong rt, Phong r " +
                "where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong";

            DataSet ds = fn.getData(query);
            dgv_Room.DataSource = ds.Tables[0];
            txt_Count.Text = dgv_Room.RowCount.ToString();
        }
        private void LoadDanhMuc()
        {
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
        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            Config();
            LoadRoom();
            LoadDanhMuc();
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            if (txt_RoomNo.Text != "" && txt_Price.Text != "")
            {
                query = "Select * from PHONG WHERE SoPhong = '" + txt_RoomNo.Text + "'";
                DataTable dt = new DataTable();
                dt = fn.GetDataTable(query);

                if (dt.Rows.Count == 0)
                {
                    query = "insert into Phong (SoPhong, LoaiPhong, LoaiGiuong, Gia) values ('" + txt_RoomNo.Text + "','" + cb_RoomType.SelectedValue + "','" + cb_BedType.SelectedValue + "','" + txt_Price.Text + "')";
                    fn.setData(query, "Đã thêm phòng");
                    LoadRoom();
                }
                else
                {
                    MessageBox.Show("Số phòng đã tồn tại", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_RoomNo.Text = dgv_Room.CurrentRow.Cells[0].Value.ToString();
            cb_RoomType.Text = dgv_Room.CurrentRow.Cells[1].Value.ToString();
            cb_BedType.Text = dgv_Room.CurrentRow.Cells[2].Value.ToString();
            txt_Price.Text = dgv_Room.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_RoomNo.Text != "" && txt_Price.Text != "")
            {
                query = "Update Phong Set " +
                    "LoaiPhong = '" + cb_RoomType.SelectedValue + "', " +
                    "LoaiGiuong = N'" + cb_BedType.SelectedValue + "', " +
                    "Gia = N'" + txt_Price.Text + "' " +
                    "Where SoPhong = '" + txt_RoomNo.Text + "'";
                fn.setData(query, "Sửa thành công");
                LoadRoom();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_RoomNo.Text != "")
            {
                query = "Select * from CTDP WHERE SoPhong = '" + txt_RoomNo.Text + "'";
                DataTable dt = new DataTable();
                dt = fn.GetDataTable(query);

                if (dt.Rows.Count == 0)
                {
                    query = "delete phong where SoPhong = '" + txt_RoomNo.Text + "'";
                    fn.setData(query, "Xóa thành công");
                    LoadRoom();
                }
                else
                {
                    MessageBox.Show("Không thể xóa phòng đã được lưu hóa đơn", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            query = "select SoPhong as N'Số phòng', rt.Ten as N'Loại phòng', b.Ten as N'Loại giường', Gia as 'Giá', TinhTrang " +
                "from LoaiGiuong b, LoaiPhong rt, Phong r " +
                "where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong and SoPhong like '%" + txt_Search.Text.Trim() + "%'";
            DataSet ds = fn.getData(query);
            dgv_Room.DataSource = ds.Tables[0];

            txt_Count.Text = dgv_Room.RowCount.ToString();
        }

        private void rbt_NotBooked_CheckedChanged(object sender, EventArgs e)
        {
            query = "select SoPhong as N'Số phòng', rt.Ten as N'Loại phòng', b.Ten as N'Loại giường', Gia as 'Giá', TinhTrang " +
                "from LoaiGiuong b, LoaiPhong rt, Phong r " +
                "where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong and TinhTrang = N'Trống'";
            DataSet ds = fn.getData(query);
            dgv_Room.DataSource = ds.Tables[0];

            txt_Count.Text = dgv_Room.RowCount.ToString();
        }
        private void rbt_IsBooked_CheckedChanged(object sender, EventArgs e)
        {
            query = "select SoPhong as N'Số phòng', rt.Ten as N'Loại phòng', b.Ten as N'Loại giường', Gia as 'Giá', TinhTrang " +
                "from LoaiGiuong b, LoaiPhong rt, Phong r " +
                "where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong and TinhTrang = N'Đã đặt'";
            DataSet ds = fn.getData(query);
            dgv_Room.DataSource = ds.Tables[0];

            txt_Count.Text = dgv_Room.RowCount.ToString();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            rbt_IsBooked.Checked = false;
            rbt_NotBooked.Checked = false;
            LoadRoom();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_RoomNo.Text = "";
            txt_Price.Text = "";
            LoadDanhMuc();
        }
    }
}
