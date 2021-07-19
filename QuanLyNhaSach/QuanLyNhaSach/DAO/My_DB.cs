using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class My_DB
    {
        public static string severName = "DESKTOP-7ORN27A";
        public static string dataName = "DoAn_HQTCSDL";
        private static My_DB instance;
        public static My_DB Instance
        {
            get
            {
                if (instance == null)
                    instance = new My_DB();
                return instance;
            }
            private set { instance = value; }
        }

        private My_DB() { }

        //private static string strconn = @"Data Source=" + severName + ";Initial Catalog=" + dataName + ";Integrated Security=True";
        private static string strconn = "Data Source=192.168.43.150;Initial Catalog=DoAn_HQTCSDL;User ID=hosting03;Password=123456";
        private SqlConnection con = new SqlConnection(strconn);

        public SqlConnection getConnection
        {
            get { return con; }
        }

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }

        public DataTable Execute(string strQuery)
        {
            SqlDataAdapter da = new SqlDataAdapter(strQuery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
