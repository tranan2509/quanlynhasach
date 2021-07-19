using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class GioHangDAO
    {
        private static GioHangDAO instance;

        public static GioHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GioHangDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private GioHangDAO() { }

        public GioHang LayThongTinSach(int maKhachHang, int isbn)
        {
            string query = "SELECT * FROM GioHang WHERE MaKhachHang = @MaKhachHang AND ISBN = @ISBN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maKhachHang, isbn });
            if (data.Rows.Count > 0)
                return new GioHang(data.Rows[0]);
            return null;
        }

        public DataTable LayThongTinGioHangTheoMaKhachHang(int maKhachHang)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LayThongTinGioHangTheoMaKhachHang @MaKhachHang", new object[] { maKhachHang });
            return data;
        }

        public DataTable LayThongLichSuMuaHangTheoMaKhachHang(int maKhachHang)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LayThongLichSuMuaHangTheoMaKhachHang @MaKhachHang", new object[] { maKhachHang });
            return data;
        }

        public bool CapNhatGioHang(int maKhachHang, int ISBN, int soLuong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_CapNhatGioHang @MaKhachHang , @ISBN , @SoLuong", new object[] { maKhachHang, ISBN, soLuong });
            return result > 0;
        }

        public bool XoaSachTrongGioHang(int maKhachHang, int ISBN)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_XoaSachTrongGioHang @MaKhachHang , @ISBN", new object[] { maKhachHang, ISBN });
            return result > 0;
        }

        public bool XoaTatCaSachTrongGioHang(int maKhachHang)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_XoaTatCaSachTrongGioHang @MaKhachHang", new object[] { maKhachHang });
            return result > 0;
        }

        public bool ThemSachVaoGioHang(int maKhachHang, int ISBN, float giaGoc, int soLuong, float thanhTien)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_ThemSachVaoGioHang @MaKhachHang , @ISBN , @GiaGoc , @SoLuong , @ThanhTien", new object[] { maKhachHang, ISBN, giaGoc, soLuong, thanhTien });
            return result > 0;
        }
    }
}
