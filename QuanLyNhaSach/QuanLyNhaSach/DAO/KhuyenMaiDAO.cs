using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class KhuyenMaiDAO
    {
        private static KhuyenMaiDAO instance;

        public static KhuyenMaiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhuyenMaiDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private KhuyenMaiDAO() { }

        public KhuyenMai LayGiamGiaTheoMaKhuyenMai(string maKhuyenMai)
        {
            string query = "USP_LayGiamGiaTheoMaKhuyenMai @maKhuyenMai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maKhuyenMai });
            if (data.Rows.Count > 0)
                return new KhuyenMai(data.Rows[0]);
            return null;
        }

        public DataTable LayDanhSachKhuyenMai()
        {
            DataTable dskm = DataProvider.Instance.ExecuteQuery("Select * from KhuyenMai");
            return dskm;
        }

        public DataTable LayDanhSachISBN()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from DauSach");
            return data;
        }
        public List<string> DsDoiTuong = new List<string>() { "Sách", "Hóa đơn" };
        public bool ThemKhuyenMai(string MaKhuyenMai, string TenKhuyenMai, string DoiTuong, int ISBN, int DieuKien, int MucGiam, DateTime Ngaybatdau, DateTime Ngayketthuc)
        {
            string query = "exec Proc_ThemKhuyenMai @MaKhuyenMai , @TenKhuyenMai , @DoiTuong , @ISBN , @DieuKien , @MucGiam , @NgayBatDau , @NgayKetThuc";
            object[] objs = new object[] { MaKhuyenMai, TenKhuyenMai, DoiTuong, ISBN, DieuKien, MucGiam, Ngaybatdau, Ngayketthuc };
            int result = DataProvider.Instance.ExecuteNonQuery(query, objs);
            return result > 0;
        }
        public bool KiemTraMaKhuyenMai(string MaKhuyenMai)
        {
            string query = "SELECT dbo.FN_KiemTraMaKhuyenMai( @MaKhuyenMai )";
            bool result = (bool)DataProvider.Instance.ExecuteScalar(query, new object[] { MaKhuyenMai });
            return result;
        }
        public bool SuaKhuyenMai(string MaKhuyenMai, string TenKhuyenMai, string DoiTuong, int MaCuonSach, int DieuKien, int MucGiam, DateTime Ngaybatdau, DateTime Ngayketthuc)
        {
            string query = "Proc_SuaKhuyenMaiTheoMa @MaNhanVien , @Hoten , @NgaySinh , @GioiTinh , @DienThoai , @Email , @CNMD , @MaBoPhan";
            object[] obj = new object[] { MaKhuyenMai, TenKhuyenMai, DoiTuong, MaCuonSach, DieuKien, MucGiam, Ngaybatdau, Ngayketthuc };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
    }
}
