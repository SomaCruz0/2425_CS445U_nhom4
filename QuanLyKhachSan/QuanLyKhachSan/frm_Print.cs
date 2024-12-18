using Microsoft.AnalysisServices;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_Print : Form
    {
        Bill _bill;
        List<BillDetailRoom> _list;
        List<ServiceDetail> _listS;
        public frm_Print(Bill bill, List<BillDetailRoom> list, List<ServiceDetail> listS)
        {
            InitializeComponent();
            _bill = bill;
            _list = list;
            _listS = listS;
        }
        private void frm_Print_Load(object sender, EventArgs e)
        {
            billDetailRoomBindingSource1.DataSource = _list;
            serviceDetailBindingSource.DataSource = _listS;
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pIDDatPhong",_bill.IDDatPhong.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pHoTen",_bill.HoTen.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pNgayDat",_bill.NgayDat.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDiaChi",_bill.DiaChi.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pPhone",_bill.Phone.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pName",_bill.Name.ToString()),
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
