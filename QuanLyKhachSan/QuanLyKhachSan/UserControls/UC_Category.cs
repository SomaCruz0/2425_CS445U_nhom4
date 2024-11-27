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
            nb_Quantity.Text = dgv_Service.CurrentRow.Cells[3].Value.ToString();
        }

    }
}
