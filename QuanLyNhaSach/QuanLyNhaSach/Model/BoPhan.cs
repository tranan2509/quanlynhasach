using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class BoPhan
    {
        private int maBoPhan;
        private string tenBoPhan;

        public int MaBoPhan { get => maBoPhan; set => maBoPhan = value; }
        public string TenBoPhan { get => tenBoPhan; set => tenBoPhan = value; }

        public BoPhan()
        {

        }

        public BoPhan(DataRow row)
        {
            this.MaBoPhan = (int)row["MaBoPhan"];
            this.TenBoPhan = row["TenBoPhan"].ToString();
        }
    }
}
