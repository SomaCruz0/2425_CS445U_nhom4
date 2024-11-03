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
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select roomid, roomNo as N'Số phòng', RTName as N'Loại phòng', BedName as N'Loại giường', price as 'Giá', booked from BedType b, RoomType rt, Rooms r where b.Bid = r.bedtype and rt.RTid = r.roomType";
            DataSet ds = fn.getData(query);
            dgv_Room.DataSource = ds.Tables[0];

            query = "select * from BedType";
            DataSet bt = fn.getData(query);
            cb_BedType.DataSource = bt.Tables[0];
            cb_BedType.ValueMember = "Bid";
            cb_BedType.DisplayMember = "BedName";

            query = "select * from RoomType";
            DataSet rt = fn.getData(query);
            cb_RoomType.DataSource = rt.Tables[0];
            cb_RoomType.ValueMember = "RTid";
            cb_RoomType.DisplayMember = "RTName";
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            if (txt_RoomNo.Text != "" || txt_Price.Text != "")
            {
                query = "insert into rooms (roomNo, roomType, bedType, price) values ('" + txt_RoomNo.Text + "','" + cb_RoomType.SelectedValue + "','" + cb_BedType.SelectedValue + "','" + txt_Price.Text + "')";
                fn.setData(query, "Đã thêm phòng");
                UC_AddRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin","Warning!" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_RoomNo.Text = dgv_Room.CurrentRow.Cells[1].Value.ToString();
            cb_RoomType.Text = dgv_Room.CurrentRow.Cells[2].Value.ToString();
            cb_BedType.Text = dgv_Room.CurrentRow.Cells[3].Value.ToString();
            txt_Price.Text = dgv_Room.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
