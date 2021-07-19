using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class GioHang
    {
        private int maKhachHang;
        private int iSBN;
        private int soLuong;
        private float giaGoc;
        private string maKhuyenMai;
        private float thanhTien;

        public GioHang()
        {
        }

        public GioHang(int maKhachHang, int iSBN, int soLuong, float giaGoc, string maKhuyenMai, float thanhTien)
        {
            MaKhachHang = maKhachHang;
            ISBN = iSBN;
            SoLuong = soLuong;
            GiaGoc = giaGoc;
            MaKhuyenMai = maKhuyenMai;
            ThanhTien = thanhTien;
        }

        public GioHang(DataRow row)
        {
            MaKhachHang = (int)row["MaKhachHang"];
            ISBN = (int)row["ISBN"];
            SoLuong = (int)row["SoLuong"];
            GiaGoc = (float)Convert.ToDouble(row["GiaGoc"].ToString());
            MaKhuyenMai = row["MaKhuyenMai"].ToString();
            ThanhTien = (float)Convert.ToDouble(row["ThanhTien"].ToString());
        }

        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int ISBN { get => iSBN; set => iSBN = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float GiaGoc { get => giaGoc; set => giaGoc = value; }
        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
