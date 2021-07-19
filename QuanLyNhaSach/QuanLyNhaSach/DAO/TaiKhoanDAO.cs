using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        Random rd = new Random();

        public bool TonTaiTenDangNhap(string tenDangNhap)
        {
            string query = "SELECT dbo.FN_TonTaiTenDangNhap( @TenDangNhap )";
            bool result = (bool)DataProvider.Instance.ExecuteScalar(query, new object[] { tenDangNhap });
            return result;
        }

        public bool TonTaiMaTaiKhoan(string maTaiKhoan)
        {
            string query = "SELECT dbo.FN_TonTaiMaTaiKhoan( @MaTaiKhoan )";
            bool result = (bool)DataProvider.Instance.ExecuteScalar(query, new object[] { maTaiKhoan });
            return result;
        }

        public string TaoTenDangNhap()
        {
            string tenDangNhap = "KH";
            do
            {
                tenDangNhap = "KH";
                for (int i = 0; i < 8; i++)
                    tenDangNhap += rd.Next(0, 9).ToString();
            } while (TonTaiTenDangNhap(tenDangNhap));
            return tenDangNhap;
        }

        public string TaoMatKhau(string tenDangNhap)
        {
            return tenDangNhap.Replace("KH", "");
        }

        public string TaoMaTaiKhoan()
        {
            string maTaiKhoan = "KH";
            do
            {
                maTaiKhoan = "KH";
                for (int i = 0; i < 8; i++)
                    maTaiKhoan += rd.Next(0, 9).ToString();
            } while (TonTaiMaTaiKhoan(maTaiKhoan));
            return maTaiKhoan;
        }

        public TaiKhoan LayTaiKhoanTheoMaTaiKhoan(string maTaiKhoan)
        {
            string query = "SELECT * FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan });
            if (data.Rows.Count > 0)
                return new TaiKhoan(data.Rows[0]);
            return null;
        }

        public bool CapNhatMatKhauTheoUserId(int userid, string matKhauCu, string matKhauMoi, string nhapLai)
        {
            SqlCommand command = new SqlCommand("exec  proc_DoiMatKhau_Theo_id " + userid + " , '" + matKhauCu + "', " +
                          "'" + matKhauMoi + "', '" + nhapLai + "'", My_DB.Instance.getConnection);
            My_DB.Instance.openConnection();
            if (command.ExecuteNonQuery() == 1)
                return true;
            return false;
        }
    }
}
