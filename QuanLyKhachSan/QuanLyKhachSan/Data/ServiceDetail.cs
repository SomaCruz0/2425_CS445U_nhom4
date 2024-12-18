using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    public class ServiceDetail
    {
        public string TenSanPham {  get; set; }
        public decimal Gia {  get; set; }
        public int SoLuong { get; set; }
        public decimal Total
        {
            get
            {
                return Gia * SoLuong;
            }
        }
    }
}
