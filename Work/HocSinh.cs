using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    internal class HocSinh : Nguoi
    {
        private string hoTen;
        private string diaChi;
        private string cmnd;
        private string ngayThang;
        private string email;
        private string sdt;
        private string id;
        private string gioiTinh;
        private string diem;
        public HocSinh(string hoTen, string diaChi, string cmnd, string ngayThang,string email,string sdt,string id,string gioiTinh,string diem):base(hoTen, diaChi, cmnd, ngayThang,email,sdt,id,gioiTinh)
        {
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.Cmnd = cmnd;
            this.NgayThang = ngayThang;
            this.Email = email;
            this.Sdt = sdt;
            this.Id = id;
            this.GioiTinh = gioiTinh;
            this.Diem = diem;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string NgayThang { get => ngayThang; set => ngayThang = value; }
        public string Email1 { get => email; set => email = value; }
        public string Sdt1 { get => sdt; set => sdt = value; }
        public string Id1 { get => id; set => id = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Diem { get => diem; set => diem = value; }
    }
}
