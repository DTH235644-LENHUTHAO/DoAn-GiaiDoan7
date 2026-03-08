using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.Data
{
    public class HoaDon
    {
        public int ID {  get; set; }
        public int DatPhongID { get; set; }
        public int? KhuyenMaiID { get; set; }
        public DateTime ThoiGianLap {  get; set; }
        public decimal TongTien {  get; set; }

        public virtual ObservableCollectionListSource<ChiTietHoaDon> ChiTietHoaDon { get; } = new();
        public virtual KhuyenMai KhuyenMai { get; set; } = null!;
        public virtual ObservableCollectionListSource<ThanhToan> ThanhToan { get; } = new();


        public virtual DatPhong DatPhong { get; set; } = null!;

    }
}
