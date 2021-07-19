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
    public partial class FormThemKhachHang : Form
    {
        public NhanVien NV { get; set; }
        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        public FormThemKhachHang(NhanVien nv)
        {
            NV = nv;
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            cmbGioiTinh.DataSource = KhachHangDAO.Instance.DsGioiTinh;
            txtTenDangNhap.Text = TaiKhoanDAO.Instance.TaoTenDangNhap();
            txtMatKhau.Text = TaiKhoanDAO.Instance.TaoMatKhau(txtTenDangNhap.Text);
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtHoTen.Focus();
            dtpkNgaySinh.Value = new DateTime(2000, 1, 1);
            dtpkNgaySinh.MaxDate = DateTime.Now;
        }

        public bool kiemTraHopLeNhap()
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpkNgaySinh.Value;
            string gioiTinh = cmbGioiTinh.Text;
            string dienThoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(tenDangNhap) ||
                string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(hoTen) ||
                string.IsNullOrEmpty(gioiTinh) ||
                string.IsNullOrEmpty(dienThoai) ||
                string.IsNullOrEmpty(email)
                )
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi thêm thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!KhachHangDAO.Instance.EmailHopLe(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


        #endregion

        #region Events
        private void FormThemKhachHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemTraHopLeNhap())
                    return;
                string tenDangNhap = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;
                string hoTen = txtHoTen.Text;
                DateTime ngaySinh = dtpkNgaySinh.Value;
                string gioiTinh = cmbGioiTinh.Text;
                string dienThoai = txtDienThoai.Text;
                string email = txtEmail.Text;
                string maTaiKhoan = TaiKhoanDAO.Instance.TaoMaTaiKhoan();
                if (KhachHangDAO.Instance.TonTaiSoDienThoai(dienThoai))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (KhachHangDAO.Instance.ThemKhachHang(maTaiKhoan, tenDangNhap, matKhau, hoTen, ngaySinh, gioiTinh, dienThoai, email))
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        #endregion
    }
}
