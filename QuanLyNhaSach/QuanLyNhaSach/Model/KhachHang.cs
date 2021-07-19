using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class KhachHang:People
    {

        private int diemTichLuy;
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }

        public KhachHang():base() { }

        public KhachHang(DataRow row):base(row)
        {   
            this.Ma = (int)row["MaKhachHang"];
            this.DiemTichLuy = (int)row["DiemTichLuy"];
        }

    }
}
