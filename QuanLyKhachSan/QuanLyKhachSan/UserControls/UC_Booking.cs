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
    public partial class UC_Booking : UserControl
    {
        function fn = new function();
        String query;
        public UC_Booking()
        {
            InitializeComponent();
        }

        private void UC_Booking_Load(object sender, EventArgs e)
        {
            query = "Select * from DatPhong";
            DataSet ds = fn.getData(query);
            dgv_Booking.DataSource = ds.Tables[0];
        }
    }
}
