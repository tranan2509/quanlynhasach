using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class TheLoai
    {
        private int maTheLoai;
        private string tenTheLoai;

        public int MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }

        public TheLoai()
        {

        }

        public TheLoai(DataRow row)
        {
            this.MaTheLoai = (int)row["MaTheLoai"];
            this.TenTheLoai = row["TenTheLoai"].ToString();
        }
    }
}
