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

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            dgv_Room.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Room.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_Room.RowTemplate.Height = 35;
            query = "select IDPhong, SoPhong as N'Số phòng', rt.Ten as N'Loại phòng', b.Ten as N'Loại giường', Gia as 'Giá', TinhTrang from LoaiGiuong b, LoaiPhong rt, Phong r where b.IDLoaiGiuong = r.LoaiGiuong and rt.IDLoaiPhong = r.LoaiPhong";

            DataSet ds = fn.getData(query);
            dgv_Room.DataSource = ds.Tables[0];

            query = "select * from LoaiGiuong";
            DataSet bt = fn.getData(query);
            cb_BedType.DataSource = bt.Tables[0];
            cb_BedType.ValueMember = "IDLoaiGiuong";
            cb_BedType.DisplayMember = "Ten";

            query = "select * from LoaiPhong";
            DataSet rt = fn.getData(query);
            cb_RoomType.DataSource = rt.Tables[0];
            cb_RoomType.ValueMember = "IDLoaiPhong";
            cb_RoomType.DisplayMember = "Ten";
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            if (txt_RoomNo.Text != "" || txt_Price.Text != "")
            {
                query = "Select * from PHONG WHERE SoPhong = '" + txt_RoomNo.Text + "'";
                DataTable dt = new DataTable();
                dt = fn.GetDataTable(query);

                if (dt.Rows.Count == 0)
                {
                    query = "insert into Phong (SoPhong, LoaiPhong, LoaiGiuong, Gia) values ('" + txt_RoomNo.Text + "','" + cb_RoomType.SelectedValue + "','" + cb_BedType.SelectedValue + "','" + txt_Price.Text + "')";
                    fn.setData(query, "Đã thêm phòng");
                    UC_AddRoom_Load(this, null);
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
            txt_ID.Text = dgv_Room.CurrentRow.Cells[0].Value.ToString();
            txt_RoomNo.Text = dgv_Room.CurrentRow.Cells[1].Value.ToString();
            cb_RoomType.Text = dgv_Room.CurrentRow.Cells[2].Value.ToString();
            cb_BedType.Text = dgv_Room.CurrentRow.Cells[3].Value.ToString();
            txt_Price.Text = dgv_Room.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            query = "Update Phong Set " +
                        "SoPhong = N'" + txt_RoomNo.Text + "', " +
                        "LoaiPhong = '" + cb_RoomType.SelectedValue + "', " +
                        "LoaiGiuong = N'" + cb_BedType.SelectedValue + "', " +
                        "Gia = N'" + txt_Price.Text + "' " +
                        "Where IDPhong = '" + txt_ID.Text + "'";
            fn.setData(query, "Sửa thành công");
            UC_AddRoom_Load(this, null);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            query = "Select * from DatPhong WHERE IDPhong = '" + txt_ID.Text + "'";
            DataTable dt = new DataTable();
            dt = fn.GetDataTable(query);

            if (dt.Rows.Count == 0)
            {
                query = "delete phong where IDPhong = '" + txt_ID.Text + "'";
                fn.setData(query, "Xóa thành công");
                UC_AddRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Không thể xóa do phòng đã được lưu trong hóa đơn", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
