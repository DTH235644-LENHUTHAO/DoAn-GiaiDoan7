using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuanLyQuanKaraoke.Data
{
    public class KhuyenMai
    {
        public int ID { get; set; }
        public string TenKhuyenMai { get; set; }
        public decimal PhanTramGiam { get; set; }
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }

    
}
