using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class KhuyenMai
    {
        private string maKhuyenMai;
        private string tenKhuyenMai;
        private string doiTuong;
        private int iSBN;
        private int dieuKien;
        private int mucGiam;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public string TenKhuyenMai { get => tenKhuyenMai; set => tenKhuyenMai = value; }
        public string DoiTuong { get => doiTuong; set => doiTuong = value; }
        public int ISBN { get => iSBN; set => iSBN = value; }
        public int DieuKien { get => dieuKien; set => dieuKien = value; }
        public int MucGiam { get => mucGiam; set => mucGiam = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }

        public KhuyenMai()
        {

        }

        public KhuyenMai(DataRow row)
        {
            this.MaKhuyenMai = row["MaKhuyenMai"].ToString();
            this.TenKhuyenMai = row["TenKhuyenMai"].ToString();
            this.DoiTuong = row["DoiTuong"].ToString();
            this.ISBN = (int)row["ISBN"];
            this.DieuKien = (int)row["DieuKien"];
            this.MucGiam = (int)row["MucGiam"];
            this.NgayBatDau = (DateTime)row["NgayBatDau"];
            this.NgayKetThuc = (DateTime)row["NgayKetThuc"];
        }

    }
}
