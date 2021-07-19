using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class DauSachDAO
    {
        private static DauSachDAO instance;

        public static DauSachDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DauSachDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private DauSachDAO() { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns></returns>
        public DauSach LayDauSachTheoISBN(int ISBN)
        {
            string query = "Select * From DauSach WHERE ISBN = @isbn";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ISBN });
            if (data.Rows.Count > 0)
                return new DauSach(data.Rows[0]);
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns></returns>
        public List<DauSach> LayDauSachTheoISBN(int ISBN, bool isList)
        {
            List<DauSach> DsDauSach = new List<DauSach>();
            string query = "Select * From DauSach WHERE ISBN = @isbn";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ISBN });
            foreach (DataRow item in data.Rows)
            {
                DauSach dauSach = new DauSach(item);
                DsDauSach.Add(dauSach);
            }
            return DsDauSach;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DauSach> LayDanhSachDauSach()
        {
            List<DauSach> DsDauSach = new List<DauSach>();
            string query = "Select * From DauSach";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DauSach dauSach = new DauSach(item);
                DsDauSach.Add(dauSach);
            }
            return DsDauSach;
        }

        public int LaySoLuongSachTonKhoTheoISBN(int isbn)
        {
            string query = "USP_LaySoLuongSachTonKhoTheoISBN @ISBN";
            int result = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { isbn });
            return result;
        }

        
        public DataTable LayThongTinDayDuDauSach()
        {
            string query = "USP_LayThongTinDayDuDauSach";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable LayThongTinDauSachTheoTuKhoa(string keyword)
        {
            string query = "USP_LayThongTinDauSachTheoTuKhoa @keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
            return data;
        }

        public DataTable LayThongTinSachKhachHang()
        {
            string query = "USP_LayDanhSachSachChoKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable LayDanhSachSachChoKhachHangByKeyword(string keyword)
        {
            string query = "USP_LayDanhSachSachChoKhachHangByKeyword @keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
            return data;
        }

        public List<DauSach> LayThongTinDuyNhatDauSachTheoTuKhoa(string keyword)
        {
            List<DauSach> DsDauSach = new List<DauSach>();
            string query = "USP_LayThongTinDuyNhatDauSachTheoTuKhoa @keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
            foreach(DataRow item in data.Rows)
            {
                DauSach dauSach = new DauSach(item);
                DsDauSach.Add(dauSach);
            }
            return DsDauSach;
        }

        public bool XoaDauSachTheoISBN(int isbn)
        {
            //string query = "DELETE DauSach WHERE ISBN = @ISBN
            string query = "UPDATE DauSach SET SoLuong = 0 WHERE ISBN = @ISBN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { isbn });
            return result > 0;
        }

        public bool ThemDauSach(int isbn, string tenDauSach, string tacGia, string nxb,
            DateTime namXuatBan, float giaGoc, float giaBia, int soLuong, int maTheLoai)
        {
            string query = "INSERT INTO DauSach VALUES ( @ISBN , @TenDauSach , @TacGia , @NXB , @NamXuatBan , @GiaGoc , @GiaBia , @SoLuong , @MaTheLoai )";
            object[] objs = new object[] { isbn, tenDauSach, tacGia, nxb, namXuatBan, giaGoc, giaBia, soLuong, maTheLoai };
            int result = DataProvider.Instance.ExecuteNonQuery(query, objs);
            return result > 0;
        }

        public bool CapNhatDauSach(int isbn, string tenDauSach, string tacGia, string nxb,
           DateTime namXuatBan, float giaGoc, float giaBia, int soLuong, int maTheLoai)
        {
            string query = "UPDATE dbo.DauSach SET TenDauSach = @TenDauSach , TacGia = @TacGia , NXB = @NXB , NamXuatBan = @NamXuatBan ," +
                " GiaGoc = @GiaGoc , GiaBia = @GiaBia , SoLuong = @SoLuong , MaTheLoai = @MaTheLoai WHERE ISBN = @ISBN";
            object[] objs = new object[] { tenDauSach, tacGia, nxb, namXuatBan, giaGoc, giaBia, soLuong, maTheLoai, isbn };
            int result = DataProvider.Instance.ExecuteNonQuery(query, objs);
            return result > 0;
        }

        public DataTable LayDanhSachDauSachAdmin()
        {
            string query = "Select ISBN, TenDauSach, GiaGoc, GiaBia From DauSach ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool KiemTraMaISBN(int ISBN)
        {
            string query = "SELECT dbo.FN_KiemTraISBN( @ISBN )";
            bool result = (bool)DataProvider.Instance.ExecuteScalar(query, new object[] { ISBN });
            return result;
        }
        public bool CapNhatDauSachAdmin(int ISBN, string TenDauSach, float GiaGoc, float GiaBia)
        {
            string query = "Proc_CapNhatGiaSach @ISBN , @TenDauSach , @GiaGoc , @GiaBia ";
            object[] obj = new object[] { ISBN, TenDauSach, GiaGoc, GiaBia };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
    }
}
