using DocumentFormat.OpenXml.Math;
using QuanLyQuanKaraoke.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        QLQKDbContext context = new QLQKDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        frmNhanVien nhanVien = null;
        frmKhachHang khachHang = null;
        frmDichVu dichVu = null;
        frmKhuyenMai khuyenMai = null;
        frmPhong phong = null;
        frmLoaiPhong loaiPhong = null;
        frmDangNhap dangNhap = null;
        string TenNhanVien = "";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        


    }
}
