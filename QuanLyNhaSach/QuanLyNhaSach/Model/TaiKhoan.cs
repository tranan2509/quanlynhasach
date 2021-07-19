using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class TaiKhoan
    {
        private string maTaiKhoan;
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string Password { get => password; set => password = value; }
   
        public TaiKhoan() { }

        public TaiKhoan(DataRow row)
        {
            this.MaTaiKhoan = row["MaTaiKhoan"].ToString();
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
        }

        public TaiKhoan(string maTaiKhoan, string username, string password)
        {
            this.MaTaiKhoan = maTaiKhoan;
            this.Username = username;
            this.Password = password;
        }
    }
}
