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

namespace QuanLyNhaSach.Views.KhachHangFolder
{
    public partial class FormTrangChuKhachHang : Form
    {
        public KhachHang KH { get; set; }
        public FormTrangChuKhachHang()
        {
            InitializeComponent();
        }
        public FormTrangChuKhachHang(KhachHang kh)
        {
            KH = kh;
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            DataTable data = DauSachDAO.Instance.LayThongTinSachKhachHang();
            LoadDataGridView(data);
        }

        void LoadDataGridView(DataTable data)
        {
            dtgvDauSach.DataSource = data;
            dtgvDauSach.ReadOnly = true;
            dtgvDauSach.AllowUserToAddRows = false;
            dtgvDauSach.Columns["ISBN"].HeaderText = "ISBN";
            dtgvDauSach.Columns["TenDauSach"].HeaderText = "Tên sách";
            dtgvDauSach.Columns["NXB"].HeaderText = "NXB";
            dtgvDauSach.Columns["TacGia"].HeaderText = "Tác giả";
            dtgvDauSach.Columns["NamXuatBan"].HeaderText = "Năm sản xuất";
            dtgvDauSach.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
            dtgvDauSach.Columns["GiaBia"].HeaderText = "Giá sách";
            dtgvDauSach.Columns["MucGiam"].HeaderText = "Mức giảm";
            dtgvDauSach.Columns["GiaKhuyenMai"].HeaderText = "Giá khuyến mãi";
            dtgvDauSach.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgvDauSach.Columns["ISBN"].DisplayIndex = 0;
            dtgvDauSach.Columns["TenDauSach"].DisplayIndex = 1;
            dtgvDauSach.Columns["NXB"].DisplayIndex = 2;
            dtgvDauSach.Columns["TacGia"].DisplayIndex = 3;
            dtgvDauSach.Columns["NamXuatBan"].DisplayIndex = 4;
            dtgvDauSach.Columns["TenTheLoai"].DisplayIndex = 5;
            dtgvDauSach.Columns["GiaBia"].DisplayIndex = 6;
            dtgvDauSach.Columns["MucGiam"].DisplayIndex = 7;
            dtgvDauSach.Columns["GiaKhuyenMai"].DisplayIndex = 8;
            dtgvDauSach.Columns["SoLuong"].DisplayIndex = 9;
        }

        #endregion

        #region Events
        private void FormTrangChuKhachHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void tbTimDauSach_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimDauSach.Text;
            DataTable data = null;
            if (!string.IsNullOrEmpty(keyword))
                data = DauSachDAO.Instance.LayDanhSachSachChoKhachHangByKeyword(keyword);
            else
                data = DauSachDAO.Instance.LayThongTinSachKhachHang();
            LoadDataGridView(data);
        }

        private void nmSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGia.Text))
                txtThanhTien.Text = ((int)nmSoLuong.Value * Convert.ToInt32(txtGia.Text)).ToString();
        }
        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGia.Text))
                txtThanhTien.Text = ((int)nmSoLuong.Value * Convert.ToInt32(txtGia.Text)).ToString();
        }

        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
                return;
            int isbn = Int32.Parse(txtISBN.Text);
            float gia = float.Parse(txtGia.Text);
            int soLuong = (int)nmSoLuong.Value;
            float thanhTien = float.Parse(txtThanhTien.Text);

            int soLuongKho = DauSachDAO.Instance.LayDauSachTheoISBN(isbn).SoLuong;
            if (soLuongKho >= (int)nmSoLuong.Value)
            {
                if (!GioHangDAO.Instance.ThemSachVaoGioHang(KH.Ma, isbn, gia, soLuong, thanhTien))
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Đã thêm " + soLuong + " quyển sách " + txtTenSach.Text + " vào giỏ hàng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Số lượng sách trong kho còn lại là " + soLuongKho.ToString(), "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtISBN.Text))
            {
                int isbn = Convert.ToInt32(txtISBN.Text);
                try
                {
                    if (GioHangDAO.Instance.LayThongTinSach(KH.Ma, isbn) != null)
                        nmSoLuong.Maximum -= GioHangDAO.Instance.LayThongTinSach(KH.Ma, isbn).SoLuong;
                }
                catch { }
            }
        }

        #endregion

        private void dtgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int isbn = Int32.Parse(dtgvDauSach.CurrentRow.Cells["ISBN"].Value.ToString());
            string tenSach = dtgvDauSach.CurrentRow.Cells["TenDauSach"].Value.ToString();
            string giaSach = dtgvDauSach.CurrentRow.Cells["GiaBia"].Value.ToString();
            int soLuong = Int32.Parse(dtgvDauSach.CurrentRow.Cells["SoLuong"].Value.ToString());

            txtISBN.Text = isbn.ToString();
            txtTenSach.Text = tenSach;
            txtGia.Text = giaSach;
            nmSoLuong.Maximum = soLuong;
            nmSoLuong.Value = soLuong > 0 ? 1 : 0;
        }
    }
}
