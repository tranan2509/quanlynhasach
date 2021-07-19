using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private KhachHangDAO() { }

        public bool EmailHopLe(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public List<String> DsGioiTinh = new List<string>() { "Nam", "Nữ", "Khác" };

        public bool TonTaiSoDienThoai(string dienThoai)
        {
            string query = "SELECT dbo.FN_TonTaiSoDienThoai( @DienThoai )";
            bool result = (bool)DataProvider.Instance.ExecuteScalar(query, new object[] { dienThoai });
            return result;
        }

        public bool ThemKhachHang(string maTaiKhoan, string tenDangNhap, string matKhau, string hoTen, DateTime ngaySinh, string gioiTinh, string dienThoai, string email)
        {
            string query = "USP_ThemKhachHang @MaTaiKhoan , @username , @password , @Hoten , @NgaySinh , @GioiTinh , @DienThoai , @Email";
            object[] obj = new object[] { maTaiKhoan, tenDangNhap, matKhau, hoTen, ngaySinh, gioiTinh, dienThoai, email };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public KhachHang LayThongTinKhachHang(int maKhachHang)
        {
            string query = "USP_LayThongTinKhachHangTheoMaKhachHang @maKhachHang";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maKhachHang });
            if (result.Rows.Count > 0)
                return new KhachHang(result.Rows[0]);
            return null;
        }

        public List<KhachHang> LayThongTinKhahcHang()
        {
            List<KhachHang> DsKhachHang = new List<KhachHang>();
            string query = "USP_LayThongTinKhachHang";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                KhachHang khachHang = new KhachHang(item);
                if (khachHang.Ma != -1)
                    DsKhachHang.Add(khachHang);
            }
            return DsKhachHang;
        }

        public bool SuaThongTinKhachHangTheoMaKhachHang(int maKhachHang, string hoTen, DateTime ngaySinh, string gioiTinh, string dienThoai, string email)
        {
            string query = "USP_SuaThongTinKhachHangTheoMaKhachHang @MaKhachHang , @Hoten , @NgaySinh , @GioiTinh , @DienThoai , @Email";
            object[] obj = new object[] { maKhachHang, hoTen, ngaySinh, gioiTinh, dienThoai, email };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public List<KhachHang> LayThongTinKhachHangTheoTuKhoa(string keywork)
        {
            List<KhachHang> DsKhachHang = new List<KhachHang>();
            string query = "USP_LayThongTinKhachHangTheoTuKhoa @keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keywork });
            foreach (DataRow item in data.Rows)
            {
                KhachHang khachHang = new KhachHang(item);
                DsKhachHang.Add(khachHang);
            }
            return DsKhachHang;
        }

        public int LayDiemTichLuyBangMaKhachHang(int maKhachHang)
        {
            string query = "USP_LayDiemTichLuyBangMaKhachHang @MaKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maKhachHang });
            if (data.Rows.Count > 0)
                return (int)data.Rows[0]["DiemTichLuy"];
            return -1;
        }

        public bool CapNhatDiemTichLuyBangMaKhachHang(int maKhachHang, int diemTichLuy)
        {
            string query = "USP_CapNhatDiemTichLuyBangMaKhachHang @MaKhachHang , @DiemTichLuy";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKhachHang, diemTichLuy });
            return result > 0;
        }
    }
}
