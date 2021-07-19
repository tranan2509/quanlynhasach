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
    public partial class FormDanhSachKhachHang : Form
    {
        public NhanVien NV { get; set; }
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
        }

        public FormDanhSachKhachHang(NhanVien nv)
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
            pnlChildEdit.Controls.Add(childForm);
            pnlChildEdit.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void LoadForm()
        {
            LoadDanhSachKhachHang();
        }

        void LoadDanhSachKhachHang()
        {
            dtgvKhachHang.DataSource = KhachHangDAO.Instance.LayThongTinKhahcHang();
            setColumnDataGridView();
        }

        void setColumnDataGridView()
        {
            dtgvKhachHang.ReadOnly = true;
            dtgvKhachHang.AllowUserToAddRows = false;
            dtgvKhachHang.Columns["Ma"].HeaderText = "Mã";
            dtgvKhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
            dtgvKhachHang.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dtgvKhachHang.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dtgvKhachHang.Columns["DienThoai"].HeaderText = "Điện Thoại";
            dtgvKhachHang.Columns["Email"].HeaderText = "Email";
            dtgvKhachHang.Columns["DiemTichLuy"].HeaderText = "Điểm";
            dtgvKhachHang.Columns["MaTaiKhoan"].HeaderText = "Mã Tài Khoản";
            dtgvKhachHang.Columns["Ma"].DisplayIndex = 0;
            dtgvKhachHang.Columns["HoTen"].DisplayIndex = 1;
            dtgvKhachHang.Columns["NgaySinh"].DisplayIndex = 2;
            dtgvKhachHang.Columns["GioiTinh"].DisplayIndex = 3;
            dtgvKhachHang.Columns["DienThoai"].DisplayIndex = 4;
            dtgvKhachHang.Columns["Email"].DisplayIndex = 5;
            dtgvKhachHang.Columns["DiemTichLuy"].DisplayIndex = 6;
            dtgvKhachHang.Columns["MaTaiKhoan"].DisplayIndex = 7;
        }


        #endregion

        #region Events
        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            if (string.IsNullOrEmpty(keyword))
            {
                LoadDanhSachKhachHang();
            }
            else
            {
                dtgvKhachHang.DataSource = KhachHangDAO.Instance.LayThongTinKhachHangTheoTuKhoa(keyword);
            }
        }

        #endregion

        private void dtgvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = dtgvKhachHang.CurrentRow.Cells["Ma"].Value.ToString();
                int maKhachHangInt = Convert.ToInt32(maKhachHang);
                KhachHang khachHang = KhachHangDAO.Instance.LayThongTinKhachHang(maKhachHangInt);
                dtgvKhachHang.Width = 710;
                
                FormSuaThongTinKhachHang fSuaThongTin = new FormSuaThongTinKhachHang(maKhachHang);
                openChildForm(fSuaThongTin);
                fSuaThongTin.CapNhatKhachHang += FSuaThongTin_CapNhatKhachHang;
                fSuaThongTin.HuyCapNhat += FSuaThongTin_HuyCapNhat;
            }
            catch
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FSuaThongTin_HuyCapNhat(object sender, EventArgs e)
        {
            dtgvKhachHang.Width = 1140;
        }

        private void FSuaThongTin_CapNhatKhachHang(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
        }
    }
}
