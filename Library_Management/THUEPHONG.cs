using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class THUEPHONG
    {
        public string idHopDongTP { get; set; }
        public string idNhanVien { get; set; }
        public string maPhong { get; set; }
        public string ngayThue { get; set; }
        public string ngayDangKyTra { get; set; }

        public THUEPHONG(THUEPHONG hopdong)
        {
            this.idHopDongTP = hopdong.idHopDongTP;
            this.idNhanVien = hopdong.idNhanVien;
            this.maPhong = hopdong.maPhong;
            this.ngayThue = hopdong.ngayThue;
            this.ngayDangKyTra = hopdong.ngayDangKyTra;
        }

        public THUEPHONG(string idHopDongTP, string idNhanVien, string maPhong,
            string ngayThue, string ngayDangKyTra)
        {
            this.idHopDongTP = idHopDongTP;
            this.idNhanVien = idNhanVien;
            this.maPhong = maPhong;
            this.ngayThue = ngayThue;
            this.ngayDangKyTra = ngayDangKyTra;
        }
    }
}
