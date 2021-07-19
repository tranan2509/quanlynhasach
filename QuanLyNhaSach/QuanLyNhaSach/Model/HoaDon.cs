using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class HoaDon
    {
        private int maHoaDon;
        private int maKhachHang;
        private int maNhanVien;
        private float tongGiaGoc;
        private string maKhuyenMai;
        private float thanhTien;
        private DateTime ngayThanhToan;


        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public float TongGiaGoc { get => tongGiaGoc; set => tongGiaGoc = value; }
        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        public DateTime NgayThanhToan { get => ngayThanhToan; set => ngayThanhToan = value; }

        public HoaDon()
        {

        }

        public HoaDon(int maHoaDon, int maKhachHang, int maNhanVien)
        {
            this.MaHoaDon = maHoaDon;
            this.MaKhachHang = maKhachHang;
            this.MaNhanVien = maNhanVien;
        }

        public HoaDon(int maHoaDon, int maKhachHang, int maNhanVien, float tongGiaGoc, string maKhuyenMai, float thanhTien)
        {
            this.MaHoaDon = maHoaDon;
            this.MaKhachHang = maKhachHang;
            this.MaNhanVien = maNhanVien;
            this.TongGiaGoc = tongGiaGoc;
            this.MaKhuyenMai = maKhuyenMai;
            this.ThanhTien = thanhTien;
        }

        public HoaDon(DataRow row)
        {
            this.MaHoaDon = (int)row["MaHoaDon"];
            this.MaKhachHang = (int)row["MaKhachHang"];
            this.MaNhanVien = (int)row["MaNhanVien"];
            this.TongGiaGoc = (float)double.Parse(row["MaNhanVien"].ToString());
            this.MaKhuyenMai = row["MaKhuyenMai"].ToString();
            this.ThanhTien = (float)double.Parse(row["ThanhTien"].ToString());
            this.NgayThanhToan = (DateTime)row["NgayThanhToan"];
        }
    }
}
