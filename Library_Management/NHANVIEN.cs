using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class NHANVIEN
    {
       // NHANVIEN(idNV, HoTen , NgaySinh, GioiTinh, DiaChi,
       //         SoDienThoai , ChucVu, Luong, MatKhau)

        public string idNV { get; set; }
        public string hoTen { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
        public string chucVu { get; set; }
        public int luong { get; set; }
        public string matKhau { get; set; }

        //1 Nhan Vien co the co nhieu booking
        public ICollection<BOOKING> dsBooking;
        //1 Nhan vien co the lam nhieu hop dong
        public ICollection<THUEPHONG> dsHopDong;
        //1 Nhan vien co the lap nhieu hoa don
        public ICollection<THANHTOANPHONG> dsHoaDon;

        public NHANVIEN(NHANVIEN nv)
        {
            this.idNV = nv.idNV;
            this.hoTen = nv.hoTen;
            this.ngaySinh = nv.ngaySinh;
            this.gioiTinh = nv.gioiTinh;
            this.diaChi = nv.diaChi;
            this.sdt = nv.sdt;
            this.chucVu = nv.chucVu;
            this.luong = nv.luong;
            this.matKhau = nv.matKhau;
            this.dsBooking = nv.dsBooking;
            this.dsHopDong = nv.dsHopDong;
            this.dsHoaDon = nv.dsHoaDon;
        }


        public NHANVIEN(string idNV, string hoTen,
        string ngaySinh, string gioiTinh, string diaChi,
        string sdt, string chucVu, int luong, string matKhau,
        ICollection<BOOKING> dsBooking, ICollection<THUEPHONG> dsHopDong,
        ICollection<THANHTOANPHONG> dsHoaDon)
        {
            this.idNV = idNV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.chucVu = chucVu;
            this.luong = luong;
            this.matKhau = matKhau;
            this.dsBooking = dsBooking;
            this.dsHopDong = dsHopDong;
            this.dsHoaDon =dsHoaDon;
        }
      
    }
}
