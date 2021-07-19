using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class NhanVien:People
    {
        private string cMND;
       

        public string CMND { get => cMND; set => cMND = value; }
      
    
        public NhanVien() : base()
        {

        }

        public NhanVien(DataRow row) : base(row)
        {
            this.Ma = (int)row["MaNhanVien"];
            this.CMND = row["CMND"].ToString();
            
        }
    }
}
