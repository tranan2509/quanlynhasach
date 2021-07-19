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
    public partial class FormLichSuBanHang : Form
    {
        public NhanVien NV { get; set; }

        public FormLichSuBanHang()
        {
            InitializeComponent();
        }

        public FormLichSuBanHang(NhanVien nv)
        {
            NV = nv;
            InitializeComponent();
        }

        #region Methods

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildChiTietLichSuBanHang.Controls.Add(childForm);
            pnlChildChiTietLichSuBanHang.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void LoadForm()
        {
            DataTable data = HoaDonDAO.Instance.LayDayDuThongTinLichSuMuaHang();
            LoadDataGridView(data);
        }

        void LoadDataGridView(DataTable data)
        {
            dtgvLichSuMuaHang.DataSource = data;
            dtgvLichSuMuaHang.ReadOnly = true;
            dtgvLichSuMuaHang.AllowUserToAddRows = false;
            dtgvLichSuMuaHang.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
            dtgvLichSuMuaHang.Columns["HoTenKH"].HeaderText = "Tên khách hàng";
            dtgvLichSuMuaHang.Columns["HoTenNV"].HeaderText = "Tên nhân viên";
            dtgvLichSuMuaHang.Columns["TongGiaGoc"].HeaderText = "Gía gốc";
            dtgvLichSuMuaHang.Columns["MaKhuyenMai"].HeaderText = "Mã khuyến mãi";
            dtgvLichSuMuaHang.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dtgvLichSuMuaHang.Columns["NgayThanhToan"].HeaderText = "Ngày thanh toán";
            dtgvLichSuMuaHang.Columns["MaHoaDon"].DisplayIndex = 0;
            dtgvLichSuMuaHang.Columns["HoTenKH"].DisplayIndex = 1;
            dtgvLichSuMuaHang.Columns["HoTenNV"].DisplayIndex = 2;
            dtgvLichSuMuaHang.Columns["TongGiaGoc"].DisplayIndex = 3;
            dtgvLichSuMuaHang.Columns["MaKhuyenMai"].DisplayIndex = 4;
            dtgvLichSuMuaHang.Columns["ThanhTien"].DisplayIndex = 5;
            dtgvLichSuMuaHang.Columns["NgayThanhToan"].DisplayIndex = 6;
        }

        #endregion

        #region Events

        private void FormLichSuBanHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dtgvLichSuMuaHang_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                string maHoaDon = dtgvLichSuMuaHang.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                int maHoaDonInt = Convert.ToInt32(maHoaDon);
                FormChiTietLichSuBanHang fChiTietMuaHang = new FormChiTietLichSuBanHang(maHoaDonInt);
                dtgvLichSuMuaHang.Height = 250;
                openChildForm(fChiTietMuaHang);
                fChiTietMuaHang.HuyCapNhat += FChiTietMuaHang_HuyCapNhat;
                /////
            }
            catch
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FChiTietMuaHang_HuyCapNhat(object sender, EventArgs e)
        {
            dtgvLichSuMuaHang.Height = 486;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            DataTable data = null;
            if (string.IsNullOrEmpty(keyword))
            {
                data = HoaDonDAO.Instance.LayDayDuThongTinLichSuMuaHang();
            }
            else
            {
                data = HoaDonDAO.Instance.LayDayDuThongTinLichSuMuaHangTheoTuKhoa(keyword);
            }
            LoadDataGridView(data);
        }

        #endregion
    }
}
