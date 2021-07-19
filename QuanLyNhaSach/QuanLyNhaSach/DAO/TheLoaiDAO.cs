using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class TheLoaiDAO
    {
        private static TheLoaiDAO instance;

        public static TheLoaiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoaiDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private TheLoaiDAO() { }

        public List<TheLoai> LayDanhSachTheLoai()
        {
            List<TheLoai> DsTheLoai = new List<TheLoai>();
            string query = "SELECT * FROM TheLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TheLoai theLoai = new TheLoai(item);
                DsTheLoai.Add(theLoai);
            }
            return DsTheLoai;
        }

        public TheLoai LayTheLoaiTheoMa(int maTheLoai)
        {
            string query = "SELECT * FROM TheLoai WHERE MaTheLoai = @MaTheLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTheLoai });
            if (data.Rows.Count > 0)
                return new TheLoai(data.Rows[0]);
            return null;
        }

        public TheLoai LayTheLoaiTheoTen(string tenTheLoai)
        {
            string query = "SELECT * FROM TheLoai WHERE TenTheLoai = @TenTheLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenTheLoai });
            if (data.Rows.Count > 0)
                return new TheLoai(data.Rows[0]);
            return null;
        }

        public bool SuaTheLoai(int maTheLoai, string tenTheLoai)
        {
            string query = "UPDATE dbo.TheLoai SET TenTheLoai = @TenTheLoai WHERE MaTheLoai = @MaTheLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenTheLoai, maTheLoai });
            return result > 0;
        }

        public bool ThemTheLoai(string tenTheLoai)
        {
            string query = "INSERT INTO TheLoai VALUES ( @TenTheLoai )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenTheLoai });
            return result > 0;
        }

        public bool XoaTheLoaiTheMa(int maTheLoai)
        {
            string query = "USP_XoaTheLoaiTheMa @MaTheLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maTheLoai });
            return result > 0;
        }
    }
}
