using QuanLyNhaSach.Model;
using QuanLyNhaSach.Views.KhachHangFolder;
using QuanLyNhaSach.Views.NhanVienQuanLyKho;
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

namespace QuanLyNhaSach.Views.NhanVienAdmin
{
    public partial class AdminForm : Form
    {
        public NhanVien NV { get; set; }
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(NhanVien nv)
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
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void LoadForm()
        {
            lbTenNhanVien.Text = NV.HoTen;
            lbChucVuNhanVien.Text = "Nhân viên quản lý | Mã: " + NV.Ma;
        }
        #endregion

        #region Events

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormThongTinNhanVien(NV));
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQuanLyNhanVien(NV));
        }
        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDanhSachKhachHang(NV));
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemKhachHang fThemKhachHang = new FormThemKhachHang(NV);
            fThemKhachHang.ShowDialog(this);
        }
        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQuanLyKho(NV));
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormKhuyenMai(NV));
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDoanhThu(NV));
        }
        #endregion


    }
}
