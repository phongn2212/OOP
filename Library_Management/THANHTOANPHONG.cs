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
        public string idHopDongTP { get; set; }
        public string ngayThanhToan { get; set; }
        public int tienPhong { get; set; }
        public int tienDichVu { get; set; }

        public THANHTOANPHONG (THANHTOANPHONG ttp)
        {
            this.idThanhToan = ttp.idThanhToan;
            this.idHopDongTP = ttp.idHopDongTP;
            this.ngayThanhToan = ttp.ngayThanhToan;
            this.tienPhong = ttp.tienPhong;
            this.tienDichVu = ttp.tienDichVu;

        }

        public THANHTOANPHONG(string idThanhToan, string idHopDongTP, string ngayThanhToan, int tienPhong, int tienDichVu)
        {
            this.idThanhToan = idThanhToan;
            this.idHopDongTP = idHopDongTP;
            this.ngayThanhToan = ngayThanhToan;
            this.tienPhong =tienPhong;
            this.tienDichVu = tienDichVu;

        }

    }
}
