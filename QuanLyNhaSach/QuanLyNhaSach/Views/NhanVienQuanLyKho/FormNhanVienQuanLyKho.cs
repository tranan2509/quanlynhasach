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

namespace QuanLyNhaSach.Views.NhanVienQuanLyKho
{
    public partial class FormNhanVienQuanLyKho : Form
    {
        public NhanVien NV { get; set; }
        public FormNhanVienQuanLyKho()
        {
            NV = NhanVienDAO.Instance.LayNhanVienTheoMaNhanVien(2);
            InitializeComponent();
        }

        public FormNhanVienQuanLyKho(NhanVien nv)
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
            FillForm();
            openChildForm(new FormQuanLyKho(NV));
        }

        void FillForm()
        {
            lbTenNhanVien.Text = NV.HoTen;
            lbChucVu.Text = "Quản lý kho | Mã: " + NV.Ma;
        }
        #endregion

        #region Events
        private void FormNhanVienQuanLyKho_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void khoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQuanLyKho(NV));
        }

        #endregion

        private void ThongTinCaNhantoolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormThongTinNhanVien(NV));
        }
    }
}
