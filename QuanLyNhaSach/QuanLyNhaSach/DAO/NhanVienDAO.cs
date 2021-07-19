using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private NhanVienDAO() { }

        public NhanVien LayNhanVienTheoMaNhanVien(int maNhanVien)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNhanVien });
            if (data.Rows.Count > 0)
                return new NhanVien(data.Rows[0]);
            return null;
        }

        public DataTable LayDayDuThongTinNhanVienTheoMaNhanVien(int maNhanVien)
        {
            string query = "USP_LayDayDuThongTinNhanVienTheoMaNhanVien @MaNhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNhanVien });
            return data;
        }

        public DataTable LayDanhSachNhanVien()
        {
            DataTable dsnv = DataProvider.Instance.ExecuteQuery("Select * from DanhSachNhanVien");
            return dsnv;
        }
        public bool ThemNhanVien(string hoTen, DateTime ngaySinh, string gioiTinh, string dienThoai, string email, string cmnd, int maBoPhan)
        {
            string query = "Proc_ThemNhanVien @Hoten , @NgaySinh , @GioiTinh , @DienThoai , @Email , @CNMD , @MaBoPhan";
            object[] obj = new object[] { hoTen, ngaySinh, gioiTinh, dienThoai, email, cmnd, maBoPhan };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool KiemTraMaNhanVien(int MaNhanVien)
        {
            string query = "SELECT dbo.FN_KiemTraMaNhanVien( @MaNhanVien )";
            bool result = (bool)DataProvider.Instance.ExecuteScalar(query, new object[] { MaNhanVien });
            return result;
        }
        public bool SuaNhanVien(int maNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, string dienThoai, string email, string cmnd, int maBoPhan)
        {
            string query = "Proc_SuaNhanVienTheoMa @MaNhanVien , @Hoten , @NgaySinh , @GioiTinh , @DienThoai , @Email , @CNMD , @MaBoPhan";
            object[] obj = new object[] { maNhanVien, hoTen, ngaySinh, gioiTinh, dienThoai, email, cmnd, maBoPhan };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool XoaNhanVien(int maNhanVien)
        {
            string query = "Proc_XoaNhanVien @MaNhanVien ";
            object[] obj = new object[] { maNhanVien };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
    }
}
