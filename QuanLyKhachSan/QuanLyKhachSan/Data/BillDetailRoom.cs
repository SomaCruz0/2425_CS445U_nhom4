using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public class BillDetailRoom
    {
        public int IDDatPhong { get; set; }
        public int SoPhong { get; set; }
        public decimal Gia { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int SoNguoi { get; set; }

        public decimal RoomTotal
        {
            get
            {
                return Gia*int.Parse((Checkout - Checkin).Days.ToString());
            }
        }
    }
}
