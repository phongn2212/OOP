using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class THANHTOANPHONG
    {
        public string idThanhToan { get; set; }
        public string ngayThanhToan { get; set; }
        public int tienPhong { get; set; }
        public int tienDichVu { get; set; }

        public THANHTOANPHONG (THANHTOANPHONG ttp)
        {
            this.idThanhToan = ttp.idThanhToan;
            this.ngayThanhToan = ttp.ngayThanhToan;
            this.tienPhong = ttp.tienPhong;
            this.tienDichVu = ttp.tienDichVu;

        }

        public THANHTOANPHONG(string idThanhToan, string ngayThanhToan, int tienPhong, int tienDichVu)
        {
            this.idThanhToan = idThanhToan;
            this.ngayThanhToan = ngayThanhToan;
            this.tienPhong =tienPhong;
            this.tienDichVu = tienDichVu;

        }

    }
}
