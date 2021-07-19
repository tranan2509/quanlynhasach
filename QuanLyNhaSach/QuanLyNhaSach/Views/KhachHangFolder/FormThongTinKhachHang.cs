using QuanLyNhaSach.DAO;
using QuanLyNhaSach.Model;
using QuanLyNhaSach.Views.NhanVienThuNgan;
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
    public partial class FormThongTinKhachHang : Form
    {
        public KhachHang KH { get; set; }
        public FormThongTinKhachHang()
        {
            InitializeComponent();
        }

        public FormThongTinKhachHang(KhachHang kh)
        {
            KH = kh;
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
            pnlChildDoiMatKhau.Controls.Add(childForm);
            pnlChildDoiMatKhau.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void LoadForm()
        {
            FillData();
        }

        void FillData()
        {
            txtMa.Text = KH.Ma.ToString();
            txtHoTen.Text = KH.HoTen;
            dtpkNgaySinh.Value = KH.NgaySinh;
            cmGioiTinh.Text = KH.GioiTinh;
            txtDienThoai.Text = KH.DienThoai;
            txtEmail.Text = KH.Email;
            txtDiemTichLuy.Text = KH.DiemTichLuy.ToString();
        }

        void CapNhatThongTin(int maKhachHang, string hoTen, DateTime ngaySinh, string gioiTinh, string dienThoai, string email)
        {
            if (KhachHangDAO.Instance.SuaThongTinKhachHangTheoMaKhachHang(maKhachHang, hoTen, ngaySinh, gioiTinh, dienThoai, email))
            {
                KH = KhachHangDAO.Instance.LayThongTinKhachHang(KH.Ma);
                FillData();
                MessageBox.Show("Cập nhật thông tin thành công!", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                MessageBox.Show("Cập nhật thông tin thất bại!", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verify(string hoten, DateTime ngaySinh, string gioiTinh, string dienThoai, string email)
        {
            if (string.IsNullOrEmpty(hoten)
                || string.IsNullOrEmpty(gioiTinh)
                || string.IsNullOrEmpty(dienThoai)
                || string.IsNullOrEmpty(email))
                return false;
            if (DateTime.Now.Year - ngaySinh.Year < 10)
                return false;
            return true;
        }
        #endregion

        #region Events
        private void FormThongTinKhachHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhauNhanVien fDoiMK = new FormDoiMatKhauNhanVien(KH);
            pnlThongTinNhanVien.Location = new Point(3, 3);
            openChildForm(fDoiMK);
            fDoiMK.HuyDoiMatKhau += FDoiMK_HuyDoiMatKhau; ;
        }

        private void FDoiMK_HuyDoiMatKhau(object sender, EventArgs e)
        {
            pnlThongTinNhanVien.Location = new Point(274, 3);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int maKhachHang = Int32.Parse(txtMa.Text);
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpkNgaySinh.Value;
            string gioiTinh = cmGioiTinh.Text;
            string dienThoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            if (verify(hoTen, ngaySinh, gioiTinh, dienThoai, email))
            {
                CapNhatThongTin(maKhachHang, hoTen, ngaySinh, gioiTinh, dienThoai, email);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion


    }
}
