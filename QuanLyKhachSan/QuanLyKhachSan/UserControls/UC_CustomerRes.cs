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
            dgv_Customer.ColumnHeadersDefaultCellStyle.ForeColor = Color.MintCream;
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

    }
}
