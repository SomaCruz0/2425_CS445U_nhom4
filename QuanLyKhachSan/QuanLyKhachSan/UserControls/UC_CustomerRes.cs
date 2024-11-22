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
    public partial class UC_CustomerRes : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRes()
        {
            InitializeComponent();
        }

        private void Config()
        {
            dgv_Customer.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgv_Customer.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_Customer.RowTemplate.Height = 40;
        }
        void LoadCustomer()
        {
            query = "Select * from KhachHang";
            DataSet ds = fn.getData(query);
            dgv_Customer.DataSource = ds.Tables[0];
        }
        private void UC_CustomerRes_Load(object sender, EventArgs e)
        {
            Config();
            LoadCustomer();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Phone.Text != "" && txt_Proof.Text != "" && txt_Email.Text != "" && txt_Address.Text != "")
            {

                query = "insert into KhachHang values (N'" + txt_Name.Text + "','" + txt_Proof.Text + "','" + txt_Phone.Text + "','" + txt_Email.Text + "',N'" + txt_Address.Text + "',convert(datetime,'" + dtp_ResDate.Text + "',103))";
                fn.setData(query, "Đã thêm khách hàng");
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Phone.Text != "" && txt_Proof.Text != "" && txt_Email.Text != "" && txt_Address.Text != "")
            {

                query = "Update KhachHang Set " +
                    "HoTen = N'" + txt_Name.Text + "', " +
                    "CCCD = '" + txt_Proof.Text + "', " +
                    "Phone = '" + txt_Phone.Text + "', " +
                    "Email = '" + txt_Email.Text + "', " +
                    "DiaChi = N'" + txt_Address.Text + "', " +
                    "NgayDangKy = Convert(Datetime,'" + dtp_ResDate.Text + "',103) " +
                    "Where IDKH = '" + txt_IDKH.Text + "'";
                fn.setData(query, "Sửa thành công");
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDKH.Text = dgv_Customer.CurrentRow.Cells[0].Value.ToString();
            txt_Name.Text = dgv_Customer.CurrentRow.Cells[1].Value.ToString();
            txt_Proof.Text = dgv_Customer.CurrentRow.Cells[2].Value.ToString();
            txt_Phone.Text = dgv_Customer.CurrentRow.Cells[3].Value.ToString();
            txt_Email.Text = dgv_Customer.CurrentRow.Cells[4].Value.ToString();
            txt_Address.Text = dgv_Customer.CurrentRow.Cells[5].Value.ToString();
            dtp_ResDate.Text = dgv_Customer.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_IDKH.Text = "";
            txt_Name.Text = "";
            txt_Proof.Text = "";
            txt_Phone.Text = "";
            txt_Email.Text = "";
            txt_Address.Text = "";
            dtp_ResDate.Text = DateTime.Now.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_IDKH.Text != "")
            {

                query = "Select * from DatPhong WHERE IDKH = '" + txt_IDKH.Text + "'";
                DataTable dt = new DataTable();
                dt = fn.GetDataTable(query);

                if (dt.Rows.Count == 0)
                {
                    query = "delete KhachHang where IDKH = '" + txt_IDKH.Text + "'";
                    fn.setData(query, "Xóa thành công");
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Không thể xóa khách hàng đã được lưu hóa đơn", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
