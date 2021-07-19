using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class ChiTietHoaDon
    {
        private int maHoaDon;
        private int iSBN;
        private string maKhuyenMai;
        private int soLuong;

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int ISBN { get => iSBN; set => iSBN = value; }
        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public ChiTietHoaDon()
        {

        }

        public ChiTietHoaDon(int maHoaDon, int iSBN, string maKhuyenMai, int soLuong)
        {
            this.MaHoaDon = maHoaDon;
            this.ISBN = iSBN;
            this.MaKhuyenMai = maKhuyenMai;
            this.SoLuong = soLuong;
        }
        public ChiTietHoaDon(DataRow row)
        {
            this.MaHoaDon = (int)row["MaHoaDon"];
            this.ISBN = (int)row["ISBN"];
            this.MaKhuyenMai = row["MaKhuyenMai"].ToString();
            this.SoLuong = (int)row["SoLuong"];
        }
    }
}
