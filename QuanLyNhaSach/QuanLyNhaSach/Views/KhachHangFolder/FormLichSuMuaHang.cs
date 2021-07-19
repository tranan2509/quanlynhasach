using QuanLyNhaSach.DAO;
using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.Views.KhachHangFolder
{
    public partial class FormLichSuMuaHang : Form
    {
        public KhachHang KH { get; set; }
        public FormLichSuMuaHang()
        {
            InitializeComponent();
        }

        public FormLichSuMuaHang(KhachHang kh)
        {
            KH = kh;
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            DataTable data = GioHangDAO.Instance.LayThongLichSuMuaHangTheoMaKhachHang(KH.Ma);
            LoadDataGirdView(data);
        }

        void LoadDataGirdView(DataTable data)
        {
            dtgvLichSu.DataSource = data;
            dtgvLichSu.ReadOnly = true;
            dtgvLichSu.AllowUserToAddRows = false;
            dtgvLichSu.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
            dtgvLichSu.Columns["ISBN"].HeaderText = "ISBN";
            dtgvLichSu.Columns["TenDauSach"].HeaderText = "Tên sách";
            dtgvLichSu.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgvLichSu.Columns["GiaBia"].HeaderText = "Giá sách";
            dtgvLichSu.Columns["MaKhuyenMai"].HeaderText = "Mã khuyến mãi";
            dtgvLichSu.Columns["NgayThanhToan"].HeaderText = "Thời gian";

            dtgvLichSu.Columns["MaHoaDon"].DisplayIndex = 0;
            dtgvLichSu.Columns["ISBN"].DisplayIndex = 1;
            dtgvLichSu.Columns["TenDauSach"].DisplayIndex = 2;
            dtgvLichSu.Columns["SoLuong"].DisplayIndex = 3;
            dtgvLichSu.Columns["GiaBia"].DisplayIndex = 4;
            dtgvLichSu.Columns["MaKhuyenMai"].DisplayIndex = 5;
            dtgvLichSu.Columns["NgayThanhToan"].DisplayIndex = 6;
        }
        #endregion

        #region Events
        private void FormLichSuMuaHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (huyXemLichSu != null)
                huyXemLichSu(this, new EventArgs());
            this.Close();
        }
        #endregion

        private event EventHandler huyXemLichSu;
        public event EventHandler HuyXemLichSu
        {
            add { huyXemLichSu += value; }
            remove { huyXemLichSu -= value; }
        }

      
    }
}
