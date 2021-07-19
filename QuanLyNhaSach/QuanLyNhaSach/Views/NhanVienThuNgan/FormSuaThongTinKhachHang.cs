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
    public partial class FormSuaThongTinKhachHang : Form
    {
        public static string MaKhachHang;
        public FormSuaThongTinKhachHang()
        {
            InitializeComponent();
        }

        public FormSuaThongTinKhachHang(string maKhachHang)
        {
            MaKhachHang = maKhachHang;
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            cmbGioiTinh.DataSource = KhachHangDAO.Instance.DsGioiTinh;
            LayThongTinKhachHang();
        }

        void LayThongTinKhachHang()
        {
            txtMaKhachHang.Text = MaKhachHang;
            if (string.IsNullOrEmpty(MaKhachHang))
                return;
            try
            {
                int maKhachHang = Convert.ToInt32(MaKhachHang);
                KhachHang khachHang = KhachHangDAO.Instance.LayThongTinKhachHang(maKhachHang);
                if (khachHang != null)
                {
                    txtHoTen.Text = khachHang.HoTen;
                    dtpkNgaySinh.Value = khachHang.NgaySinh;
                    cmbGioiTinh.Text = khachHang.GioiTinh;
                    txtDienThoai.Text = khachHang.DienThoai;
                    txtEmail.Text = khachHang.Email;
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        void CapNhatThongTinKhachHang()
        {
            int maKhachHang = Int32.Parse(txtMaKhachHang.Text);
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpkNgaySinh.Value;
            string gioiTinh = cmbGioiTinh.Text;
            string dienThoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            if (!kiemTraHopLeNhap())
                return;
            if (KhachHangDAO.Instance.SuaThongTinKhachHangTheoMaKhachHang(maKhachHang, hoTen, ngaySinh, gioiTinh, dienThoai, email))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool kiemTraHopLeNhap()
        {
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpkNgaySinh.Value;
            string gioiTinh = cmbGioiTinh.Text;
            string dienThoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(hoTen) ||
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

        private void FormSuaThongTinKhachHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LayThongTinKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CapNhatThongTinKhachHang();
            if (capNhatKhachHang != null)
                capNhatKhachHang(this, new EventArgs());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (huyCapNhat != null)
                huyCapNhat(this, new EventArgs());
            this.Close();
        }
        #endregion

        private event EventHandler capNhatKhachHang;
        public event EventHandler CapNhatKhachHang
        {
            add { capNhatKhachHang += value; }
            remove { capNhatKhachHang -= value; }
        }

        private event EventHandler huyCapNhat;
        public event EventHandler HuyCapNhat
        {
            add { huyCapNhat += value; }
            remove { huyCapNhat -= value; }
        }

    }
}
