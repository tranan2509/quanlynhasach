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
    public partial class FormNhanVienThuNgan : Form
    {

        public NhanVien NV { get; set; }
        public FormNhanVienThuNgan()
        {
            NV = new NhanVien();
            NV = NhanVienDAO.Instance.LayNhanVienTheoMaNhanVien(1);
            InitializeComponent();
        }

        public FormNhanVienThuNgan(NhanVien nv)
        {
            NV = nv;
            InitializeComponent();
        }

        private void FormNhanVienThuNgan_Load(object sender, EventArgs e)
        {
            LoadForm();
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
            lbChucVuNhanVien.Text = "Nhân viên thu ngân | Mã: " + NV.Ma;
        }

        #endregion

        #region Events
        private void thanhToánĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormThanhToan(NV));
        }


        private void danhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTraCuuSach(NV));
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDanhSachKhachHang(NV));
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormThemKhachHang fThem = new FormThemKhachHang(NV);
            fThem.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lịchSửMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormLichSuBanHang(NV));
        }


        #endregion

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormThongTinNhanVien(NV));
        }

    }
}
