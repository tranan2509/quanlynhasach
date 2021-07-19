using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class People
    {
        private int ma;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string dienThoai;
        private string email;
        private string maTaiKhoan;
        private int maBoPhan;

        public int Ma { get => ma; set => ma = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public int MaBoPhan { get => maBoPhan; set => maBoPhan = value; }


        public People() { }

        public People(DataRow row)
        {
            //this.Ma = row["MaKhachHang"].ToString();
            this.HoTen = row["HoTen"].ToString();
            if (row["NgaySinh"].ToString() != null)
                this.NgaySinh = (DateTime)row["NgaySinh"];
            else
                this.NgaySinh = new DateTime(1900, 1, 1);
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DienThoai = row["DienThoai"].ToString();
            this.Email = row["Email"].ToString();
            this.MaTaiKhoan = row["MaTaiKhoan"].ToString();
            this.MaBoPhan = (int)row["MaBoPhan"];
        }
    }
}
