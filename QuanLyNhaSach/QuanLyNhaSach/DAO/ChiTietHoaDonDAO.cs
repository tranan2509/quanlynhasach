using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoaDonDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ChiTietHoaDonDAO() { }

        public bool ThemChiTietHoaDon(int maHoaDon, int isbn, string maKhuyenMai, string soLuong)
        {
            string query = "USP_ThemChiTietHoaDon @MaHoaDon , @ISBN , @MaKhuyenMai , @SoLuong";
            object[] obj = new object[] { maHoaDon, isbn, maKhuyenMai, soLuong };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public bool ThemChiTietHoaDon(ChiTietHoaDon chiTiet)
        {
            string query = "USP_ThemChiTietHoaDon @MaHoaDon , @ISBN , @MaKhuyenMai , @SoLuong";
            object[] obj = new object[] { chiTiet.MaHoaDon, chiTiet.ISBN, chiTiet.MaKhuyenMai, chiTiet.SoLuong };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public DataTable LayDayDuThongTinChiTietHoaDonTheoMaHoaDon(int maHoaDon)
        {
            string query = "USP_LayDayDuThongTinChiTietHoaDonTheoMaHoaDon @MaHoaDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maHoaDon });
            return data;
        }
    }
}
