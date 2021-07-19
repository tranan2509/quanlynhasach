using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class BoPhanDAO
    {
        private static BoPhanDAO instance;

        public static BoPhanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BoPhanDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private BoPhanDAO() { }

        public BoPhan LayBoPhanTheoMaBoPhan(int maBoPhan)
        {
            string query = "SELECT * FROM BoPhan WHERE MaBoPhan = @MaBoPhan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maBoPhan });
            if (data.Rows.Count > 0)
                return new BoPhan(data.Rows[0]);
            return null;
        }

        public DataTable LayDanhSachBoPhan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from BoPhan where MaBoPhan!=1");
            return data;
        }
        public int LayMaBoPhan(string tenBoPhan)
        {
            string query = "select dbo.FN_LayMaBoPhan( @TenBoPhan ) ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenBoPhan });
            if (data.Rows.Count > 0)
                return (int)data.Rows[0][0];
            return -1;
        }
        public string LayTenBoPhan(int maBoPhan)
        {
            string query = "select dbo.FN_LayTenBoPhan( @MaBoPhan ) ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maBoPhan });
            if (data.Rows.Count > 0)
                return data.Rows[0][0].ToString();
            return null;
        }
    }
}
