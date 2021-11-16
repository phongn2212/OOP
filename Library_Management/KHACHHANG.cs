using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    /* idKH, HoTen, CMND, NgaySinh, GioiTinh, ThanhPho,
       DiaChi, SoDienThoai. */
    class KHACHHANG
    {
        public string idKH { get; set; }  // primary key
        public string hoTen { get; set; }
        public string CMND { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string thanhPho { get; set; }
        public string sdt { get; set; }

        // 1 khach hang su dung n loai tien te
        public ICollection<TIENTE> tienTeSuDung { get; set; }

        // 1 khach hang co nhieu quoc tich
        public ICollection<QUOCGIA> dsQuocTich { get; set; }



        // 

        public KHACHHANG (KHACHHANG kh)
        {
            this.idKH = kh.idKH;
            this.hoTen = kh.hoTen;
            this.CMND = kh.CMND;
            this.ngaySinh = kh.ngaySinh;
            this.gioiTinh = kh.gioiTinh;
            this.thanhPho = kh.thanhPho;
            this.sdt = kh.sdt;
            this.tienTeSuDung = kh.tienTeSuDung;
            this.dsQuocTich = kh.dsQuocTich;
        }

        public KHACHHANG(string idKH, string hoTen, string CMND, string ngaySinh, string gioiTinh, string thanhPho, string sdt,
            ICollection<TIENTE> tienTeSuDung, ICollection<QUOCGIA> dsQuocTich)
        {
            this.idKH = idKH;
            this.hoTen = hoTen;
            this.CMND = CMND;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.thanhPho = thanhPho;
            this.sdt = sdt;
            this.tienTeSuDung = tienTeSuDung;
            this.dsQuocTich = dsQuocTich;
        }

        // relate
    }
}
