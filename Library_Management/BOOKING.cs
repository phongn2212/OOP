using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class BOOKING
    {
        public string idBooking { get; set; }
        public KHACHHANG kh { get; set; }
        public string ngayDangKy { get; set; }
        public string ngayNhan { get; set; }
        public int DatCoc { get; set; }
        public NHANVIEN nv { get; set; }
        


        public BOOKING(BOOKING bk)
        {
            this.idBooking = bk.idBooking;
            this.kh = bk.kh;
            this.ngayDangKy = bk.ngayDangKy;
            this.ngayNhan = bk.ngayNhan;
            this.DatCoc = bk.DatCoc;
            this.nv = bk.nv;
        }

        public BOOKING(string idBooking, KHACHHANG kh, string ngayDangKy, string ngayNhan, int DatCoc, NHANVIEN nv)
        {
            this.idBooking = idBooking;
            this.kh = kh;
            this.ngayDangKy = ngayDangKy;
            this.ngayNhan = ngayNhan;
            this.DatCoc =DatCoc;
            this.nv = nv;
        }
    }
}
