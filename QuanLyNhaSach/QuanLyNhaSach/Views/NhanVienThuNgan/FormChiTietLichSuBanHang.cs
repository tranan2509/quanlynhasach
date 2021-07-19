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

namespace QuanLyNhaSach.Views.NhanVienThuNgan
{
    public partial class FormChiTietLichSuBanHang : Form
    {
        public KhachHang KH;
        public NhanVien NV;
        public HoaDon HD;
        public int MaHoaDonMuaHang;

        public FormChiTietLichSuBanHang()
        {
            InitializeComponent();
        }

        public FormChiTietLichSuBanHang(int maHoaDon)
        {
            HD = HoaDonDAO.Instance.LayThongTinHoaDonTheoMaHoaDon(maHoaDon);
            InitializeComponent();
        }

        #region Methods


        void LoadForm()
        {
            KH = KhachHangDAO.Instance.LayThongTinKhachHang(HD.MaKhachHang);
            NV = NhanVienDAO.Instance.LayNhanVienTheoMaNhanVien(HD.MaNhanVien);

            txtMaHoaDon.Text = HD.MaHoaDon.ToString();
            txtTenNhanVien.Text = NV.HoTen;
            txtMaNhanVien.Text = NV.Ma.ToString();
            txtTenKhachHang.Text = KH.HoTen;
            txtMaKhachHang.Text = KH.Ma.ToString();
            txtSoDienThoai.Text = KH.DienThoai;
            txtGioiTinh.Text = KH.GioiTinh;
            txtEmail.Text = KH.Email;
            txtDiemTichLuy.Text = KH.DiemTichLuy.ToString();
            txtMaGiamGia.Text = HD.MaKhuyenMai;
            txtThanhTien.Text = HD.ThanhTien.ToString();
            dtgvChiTietLichSuMuaHang.Focus();

            dtgvChiTietLichSuMuaHang.ReadOnly = true;
            dtgvChiTietLichSuMuaHang.AllowUserToAddRows = false;
            DataTable data = ChiTietHoaDonDAO.Instance.LayDayDuThongTinChiTietHoaDonTheoMaHoaDon(HD.MaHoaDon);
            LoadDataGridView(data);
        }

        void LoadDataGridView(DataTable data)
        {
            dtgvChiTietLichSuMuaHang.DataSource = data;
            dtgvChiTietLichSuMuaHang.Columns["ISBN"].HeaderText = "ISBN";
            dtgvChiTietLichSuMuaHang.Columns["TenDauSach"].HeaderText = "Tên sách";
            dtgvChiTietLichSuMuaHang.Columns["GiaBia"].HeaderText = "Giá";
            dtgvChiTietLichSuMuaHang.Columns["MaKhuyenMai"].HeaderText = "Mã khuyến mãi";
            dtgvChiTietLichSuMuaHang.Columns["MucGiam"].HeaderText = "Giảm giá (%)";
            dtgvChiTietLichSuMuaHang.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgvChiTietLichSuMuaHang.Columns["ThanhTien"].HeaderText = "Thành tiền";

            dtgvChiTietLichSuMuaHang.Columns["ISBN"].DisplayIndex = 0;
            dtgvChiTietLichSuMuaHang.Columns["TenDauSach"].DisplayIndex = 1;
            dtgvChiTietLichSuMuaHang.Columns["GiaBia"].DisplayIndex = 2;
            dtgvChiTietLichSuMuaHang.Columns["MaKhuyenMai"].DisplayIndex = 3;
            dtgvChiTietLichSuMuaHang.Columns["MucGiam"].DisplayIndex = 4;
            dtgvChiTietLichSuMuaHang.Columns["SoLuong"].DisplayIndex = 5;
            dtgvChiTietLichSuMuaHang.Columns["ThanhTien"].DisplayIndex = 6;
        }

        #endregion

        #region Events
        private void FormChiTietLichSuBanHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (huyCapNhat != null)
                huyCapNhat(this, new EventArgs());
            this.Close();
        }

        #endregion

        private event EventHandler huyCapNhat;
        public event EventHandler HuyCapNhat
        {
            add { huyCapNhat += value; }
            remove { huyCapNhat -= value; }
        }
    }
}
