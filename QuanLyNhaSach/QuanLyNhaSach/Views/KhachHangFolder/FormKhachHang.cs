using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.DAO;
using QuanLyNhaSach.Model;

namespace QuanLyNhaSach.Views.KhachHangFolder
{
    public partial class FormKhachHang : Form
    {
        public KhachHang KH { get; set; }
        public FormKhachHang()
        {
            KH = KhachHangDAO.Instance.LayThongTinKhachHang(1);
            InitializeComponent();
        }

        public FormKhachHang(KhachHang kh)
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
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void LoadForm()
        {
            lbTenKhachHang.Text = KH.HoTen;
            lbChucVu.Text = "Khách hàng | Mã: " + KH.Ma;
            openChildForm(new FormTrangChuKhachHang(KH));
        }
        #endregion

        #region Events
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTrangChuKhachHang(KH));
        }

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQuanLyGioHang(KH));
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormThongTinKhachHang(KH));
        }
        #endregion


    }
}
