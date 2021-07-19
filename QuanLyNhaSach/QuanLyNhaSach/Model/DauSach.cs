using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class DauSach
    {
        private int iSBN;
        private string tenDauSach;
        private string tacGia;
        private string nXB;
        private DateTime namXuatBan;
        private float giaGoc;
        private float giaBia;
        private int soLuong;
        private int maTheLoai;

        public int ISBN { get => iSBN; set => iSBN = value; }
        public string TenDauSach { get => tenDauSach; set => tenDauSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public string NXB { get => nXB; set => nXB = value; }
        public DateTime NamXuatBan { get => namXuatBan; set => namXuatBan = value; }
        public float GiaGoc { get => giaGoc; set => giaGoc = value; }
        public float GiaBia { get => giaBia; set => giaBia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int MaTheLoai { get => maTheLoai; set => maTheLoai = value; }

        public DauSach()
        {

        }

        public DauSach(DataRow row)
        {
            this.ISBN = (int)row["ISBN"];
            this.TenDauSach = row["TenDauSach"].ToString();
            this.TacGia = row["TacGia"].ToString();
            this.NXB = row["NXB"].ToString();
            this.NamXuatBan = (DateTime)row["NamXuatBan"];
            this.GiaGoc = (float)Double.Parse(row["GiaGoc"].ToString());
            this.GiaBia = (float)Double.Parse(row["GiaBia"].ToString());
            this.SoLuong = (int)row["SoLuong"];
            this.MaTheLoai = (int)row["MaTheLoai"];
        }
    }
}
