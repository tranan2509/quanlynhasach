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
    public partial class FormDoiMatKhauNhanVien : Form
    {
        public NhanVien NV;
        public KhachHang KH { get; set; }
        public TaiKhoan TK;

        public FormDoiMatKhauNhanVien()
        {
            InitializeComponent();
        }

        public FormDoiMatKhauNhanVien(NhanVien nv)
        {
            NV = nv;
            InitializeComponent();
        }

        public FormDoiMatKhauNhanVien(KhachHang kh)
        {
            KH = kh;
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            if (NV != null)
                TK = TaiKhoanDAO.Instance.LayTaiKhoanTheoMaTaiKhoan(NV.MaTaiKhoan);
            else if (KH != null)
                TK = TaiKhoanDAO.Instance.LayTaiKhoanTheoMaTaiKhoan(KH.MaTaiKhoan);
        }

        bool NhapDu()
        {
            if (string.IsNullOrEmpty(txtMatKhauCu.Text) ||
                string.IsNullOrEmpty(txtNhapLai.Text) ||
                string.IsNullOrEmpty(txtMatKhauMoi.Text))
                return false;
            return true;
        }

        bool MatKhauKhop()
        {
            if (txtMatKhauMoi.Text.Equals(txtNhapLai.Text))
                return true;
            return false;
        }

        bool MatKhauCuDung(string matKhau, string matKhauXacThuc)
        {
            if (matKhau.Equals(matKhauXacThuc))
                return true;
            return false;
        }
        #endregion

        #region Events
        private void FormDoiMatKhauNhanVien_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string matKhauCu = txtMatKhauCu.Text;
                string matKhauMoi = txtMatKhauMoi.Text;
                string nhapLai = txtNhapLai.Text;
                if (NhapDu())
                {
                    int ma = NV != null ? NV.Ma : KH.Ma;
                    string maTK = NV != null ? NV.MaTaiKhoan : KH.MaTaiKhoan;
                    if (TaiKhoanDAO.Instance.CapNhatMatKhauTheoUserId(ma, matKhauCu, matKhauMoi, nhapLai))
                    {
                        TK = TaiKhoanDAO.Instance.LayTaiKhoanTheoMaTaiKhoan(maTK);
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatKhauCu.Text = "";
                        txtMatKhauMoi.Text = "";
                        txtNhapLai.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (huyDoiMatKhau != null)
                huyDoiMatKhau(this, new EventArgs());
            this.Close();
        }

        #endregion

        private event EventHandler huyDoiMatKhau;
        public event EventHandler HuyDoiMatKhau
        {
            add { huyDoiMatKhau += value; }
            remove { huyDoiMatKhau -= value; }
        }
    }
}
