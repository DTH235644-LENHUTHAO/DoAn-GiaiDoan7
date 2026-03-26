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

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmChiTietHoaDon : Form
    {
        QLQKDbContext context = new QLQKDbContext();
        int hoaDonID;
        public frmChiTietHoaDon(int id)
        {
            InitializeComponent();
            hoaDonID = id;
        }
        
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            var ct = context.ChiTietHoaDon
                .Where(x => x.HoaDonID == hoaDonID) 
                .Select(r => new
                {
                    r.ID,
                    r.HoaDonID,
                    r.GhiChu,
                    r.ThanhTien
                })
                .ToList();

            dataGridView1.DataSource = ct;
        }
    }
}
