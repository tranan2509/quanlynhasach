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
    public partial class FormThongTinNhanVien : Form
    {
        public NhanVien NV;
        public FormThongTinNhanVien()
        {
            InitializeComponent();
        }

        public FormThongTinNhanVien(NhanVien nv)
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
            pnlChildDoiMatKhau.Controls.Add(childForm);
            pnlChildDoiMatKhau.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void LoadForm()
        {
            BoPhan boPhan = BoPhanDAO.Instance.LayBoPhanTheoMaBoPhan(NV.MaBoPhan);
            txtMaNhanVien.Text = NV.Ma.ToString();
            txtHoTen.Text = NV.HoTen;
            dtpkNgaySinh.Value = NV.NgaySinh;
            txtGioiTinh.Text = NV.GioiTinh;
            txtDienThoai.Text = NV.DienThoai;
            txtEmail.Text = NV.Email;
            txtCMND.Text = NV.CMND;
            txtTenBoPhan.Text = boPhan.TenBoPhan;
        }

        #endregion

        #region Events
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhauNhanVien fDoiMK = new FormDoiMatKhauNhanVien(NV);
            pnlThongTinNhanVien.Location = new Point(3, 3);
            openChildForm(fDoiMK);
            fDoiMK.HuyDoiMatKhau += FDoiMK_HuyDoiMatKhau;
        }

        private void FDoiMK_HuyDoiMatKhau(object sender, EventArgs e)
        {
            pnlThongTinNhanVien.Location = new Point(274, 3);
        }

        private void FormThongTinNhanVien_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        #endregion


    }
}
