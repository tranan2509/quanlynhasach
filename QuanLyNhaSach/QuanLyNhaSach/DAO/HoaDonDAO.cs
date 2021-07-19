using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private HoaDonDAO() { }

        public int LayMaHoaDonMoi()
        {
            string query = "SELECT dbo.FN_MaHoaDonMoi()";
            int maHoaDonMoi = (int)DataProvider.Instance.ExecuteScalar(query);
            return maHoaDonMoi;
        }

        public bool ThemHoaDon(int maKhachHang, int maNhanVien, float giaGoc, string maKhuyenMai, float thanhTien, DateTime ngayThanhToan)
        {
            string query = "USP_ThemHoaDon @MaKhachHang , @maNhanVien , @TongGiaGoc , @MaKhuyenMai , @ThanhTien , @NgayThanhToan";
            object[] obj = new object[] { maKhachHang, maNhanVien, giaGoc, maKhuyenMai, thanhTien };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public bool ThemHoaDon(HoaDon hoaDon)
        {
            string query = "USP_ThemHoaDon @MaKhachHang , @maNhanVien , @TongGiaGoc , @MaKhuyenMai , @ThanhTien , @NgayThanhToan";
            object[] obj = new object[] { hoaDon.MaKhachHang, hoaDon.MaNhanVien, hoaDon.TongGiaGoc, hoaDon.MaKhuyenMai, hoaDon.ThanhTien, hoaDon.NgayThanhToan };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public bool XoaHoaDon(int maHoaDon)
        {
            string query = "USP_XoaHoaDonTheoMaHoaDon @MaHoaDon";
            object[] obj = new object[] { maHoaDon };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public DataTable LayDayDuThongTinLichSuMuaHang()
        {
            string query = "USP_LayDayDuThongTinLichSuMuaHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable LayDayDuThongTinLichSuMuaHangTheoTuKhoa(string keyword)
        {
            string query = "USP_LayDayDuThongTinLichSuMuaHangTheoTuKhoa @keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
            return data;
        }

        public HoaDon LayThongTinHoaDonTheoMaHoaDon(int maHoaDon)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maHoaDon });
            if (data.Rows.Count > 0)
                return new HoaDon(data.Rows[0]);
            return null;
        }

        public List<String> DsThongKe = new List<string>() { "Ngày", "Tháng" };
        public DataTable LayThongKeTheoNgay(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            string query = "PROC_ThongKeDoanhThuNgay @NgayBatDau , @NgayKetThuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { NgayBatDau, NgayKetThuc });
            return data;
        }
        public DataTable LayThongKeTheoThang(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            string query = "PROC_ThongKeDoanhThuThang @NgayBatDau , @NgayKetThuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { NgayBatDau, NgayKetThuc });
            return data;
        }
    }
}
