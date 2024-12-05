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

        private void Config()
        {
            dgv_BedType.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_BedType.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_BedType.RowTemplate.Height = 40;

            dgv_RoomType.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_RoomType.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_RoomType.RowTemplate.Height = 40;

            dgv_Service.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Service.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
            dgv_Service.RowTemplate.Height = 40;
        }
        void LoadRoomType()
        {
            query = "select * from LoaiPhong";
            DataSet ds = fn.getData(query);
            dgv_RoomType.DataSource = ds.Tables[0];
        }

        void LoadBedType()
        {

            query = "select * from LoaiGiuong";
            DataSet ds2 = fn.getData(query);
            dgv_BedType.DataSource = ds2.Tables[0];
        }
        void LoadService()
        {
            query = "select * from SanPham";
            DataSet ds3 = fn.getData(query);
            dgv_Service.DataSource = ds3.Tables[0];
        }
        private void UC_Category_Load(object sender, EventArgs e)
        {
            LoadBedType();
            LoadRoomType();
            LoadService();
            Config();
        }

        private void dgv_RoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDRoomType.Text = dgv_RoomType.CurrentRow.Cells[0].Value.ToString();
            txt_RoomType.Text = dgv_RoomType.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgv_BedType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDBedType.Text = dgv_BedType.CurrentRow.Cells[0].Value.ToString();
            txt_BedType.Text = dgv_BedType.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgv_Service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDService.Text = dgv_Service.CurrentRow.Cells[0].Value.ToString();
            txt_NameService.Text = dgv_Service.CurrentRow.Cells[1].Value.ToString();
            txt_Price.Text = dgv_Service.CurrentRow.Cells[2].Value.ToString();
            nb_Stock.Text = dgv_Service.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            if (txt_RoomType.Text.Length > 0)
            {
                query = "insert into LoaiPhong values (N'" + txt_RoomType.Text + "')";
                fn.setData(query, "Thêm loại phòng thành công");
                LoadRoomType();
            }
            else
            {
                MessageBox.Show("Hãy nhập tên loại phòng", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_AddBed_Click(object sender, EventArgs e)
        {
            if (txt_BedType.Text.Length > 0)
            {
                query = "insert into LoaiGiuong values (N'" + txt_BedType.Text + "')";
                fn.setData(query, "Thêm loại giường thành công");
                LoadBedType();
            }
            else
            {
                MessageBox.Show("Hãy nhập tên loại giường", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_AddService_Click(object sender, EventArgs e)
        {
            if (txt_NameService.Text.Length > 0 && txt_Price.Text.Length > 0 && nb_Stock.Value > 0)
            {
                query = "insert into SanPham values (N'" + txt_NameService.Text + "', '" + txt_Price.Text + "','" + nb_Stock.Text + "')";
                fn.setData(query, "Thêm dịch vụ thành công");
                LoadService();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_EditRoom_Click(object sender, EventArgs e)
        {
            if (txt_RoomType.Text.Length > 0)
            {
                query = "update LoaiPhong set Ten = N'" + txt_RoomType.Text + "' where IDLoaiPhong = '" + txt_IDRoomType.Text + "'";
                fn.setData(query, "Sửa loại phòng thành công");
                LoadRoomType();
            }
            else
            {
                MessageBox.Show("Hãy nhập tên loại phòng", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_EditBed_Click(object sender, EventArgs e)
        {
            if (txt_BedType.Text.Length > 0)
            {
                query = "update LoaiGiuong set Ten = N'" + txt_BedType.Text + "' where IDLoaiGiuong = '" + txt_IDBedType.Text + "'";
                fn.setData(query, "Sửa loại phòng thành công");
                LoadBedType();
            }
            else
            {
                MessageBox.Show("Hãy nhập tên loại giường", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_EditService_Click(object sender, EventArgs e)
        {
            if (txt_NameService.Text.Length > 0 && txt_Price.Text.Length > 0 && nb_Stock.Value > 0)
            {
                query = "update SanPham set " +
                    "TenSanPham = N'" + txt_NameService.Text + "', " +
                    "Gia = '"+txt_Price.Text+"', " +
                    "SoLuongTon = '"+nb_Stock.Value +"' " +
                    "where IDSanPham = '" + txt_IDService.Text + "'";
                fn.setData(query, "Sửa dịch vụ thành công");
                LoadService();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {
            query = "Select * from Phong WHERE LoaiPhong = '" + txt_IDRoomType.Text + "'";
            DataTable dt = new DataTable();
            dt = fn.GetDataTable(query);

            if (dt.Rows.Count == 0)
            {
                query = "delete LoaiPhong where IDLoaiPhong = '" + txt_IDRoomType.Text + "'";
                fn.setData(query, "Xóa thành công");
                LoadRoomType();
            }
            else
            {
                MessageBox.Show("Không thể xóa loại phòng đã được chọn trong bảng phòng", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_DeleteBed_Click(object sender, EventArgs e)
        {
            query = "Select * from Phong WHERE LoaiGiuong = '" + txt_IDBedType.Text + "'";
            DataTable dt = new DataTable();
            dt = fn.GetDataTable(query);

            if (dt.Rows.Count == 0)
            {
                query = "delete LoaiGiuong where IDLoaiGiuong = '" + txt_IDBedType.Text + "'";
                fn.setData(query, "Xóa thành công");
                LoadBedType();
            }
            else
            {
                MessageBox.Show("Không thể xóa loại giường đã được chọn trong bảng phòng", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_DeleteService_Click(object sender, EventArgs e)
        {
            query = "Select * from CTDV WHERE IDSanPham = '" + txt_IDService.Text + "'";
            DataTable dt = new DataTable();
            dt = fn.GetDataTable(query);

            if (dt.Rows.Count == 0)
            {
                query = "delete SanPham where IdSanPham = '" + txt_IDService.Text + "'";
                fn.setData(query, "Xóa thành công");
                LoadService();
            }
            else
            {
                MessageBox.Show("Không thể xóa dịch vụ đã được lưu trong hóa đơn", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
