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

namespace QuanLyNhaSach.Views.NhanVienQuanLyKho
{
    public partial class FormQuanLyKho : Form
    {
        public NhanVien NV { get; set; }

        public FormQuanLyKho()
        {
            InitializeComponent();
        }

        public FormQuanLyKho(NhanVien nv)
        {
            NV = nv;
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            LoadCmbLoaiSach();
            List<DauSach> DsDauSach = DauSachDAO.Instance.LayDanhSachDauSach();
            LoadDtgvKhoSach(DsDauSach);
            List<TheLoai> DsTheLoai = TheLoaiDAO.Instance.LayDanhSachTheLoai();
            LoadDtgvTheLoai(DsTheLoai);
        }

        void LoadCmbLoaiSach()
        {
            cmbTheLoai.DataSource = TheLoaiDAO.Instance.LayDanhSachTheLoai();
            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";
        }

        void LoadFullDtgvKhoSach()
        {
            List<DauSach> DsDauSach = DauSachDAO.Instance.LayDanhSachDauSach();
            LoadDtgvKhoSach(DsDauSach);
        }

        void LoadDtgvKhoSach(List<DauSach> dsDauSach)
        {
            dtgvKhoSach.DataSource = dsDauSach;
            dtgvKhoSach.ReadOnly = true;
            dtgvKhoSach.AllowUserToAddRows = false;

            dtgvKhoSach.Columns["ISBN"].HeaderText = "ISBN";
            dtgvKhoSach.Columns["TenDauSach"].HeaderText = "Tên sách";
            dtgvKhoSach.Columns["TacGia"].HeaderText = "Tác giả";
            dtgvKhoSach.Columns["NXB"].HeaderText = "NXB";
            dtgvKhoSach.Columns["NamXuatBan"].HeaderText = "Năm xuất bản";
            dtgvKhoSach.Columns["GiaGoc"].HeaderText = "Giá gốc";
            dtgvKhoSach.Columns["GiaBia"].HeaderText = "Giá bìa";
            dtgvKhoSach.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgvKhoSach.Columns["MaTheLoai"].HeaderText = "Mã thể loại";

            dtgvKhoSach.Columns["ISBN"].DisplayIndex = 0;
            dtgvKhoSach.Columns["TenDauSach"].DisplayIndex = 1;
            dtgvKhoSach.Columns["TacGia"].DisplayIndex = 2;
            dtgvKhoSach.Columns["NXB"].DisplayIndex = 3;
            dtgvKhoSach.Columns["NamXuatBan"].DisplayIndex = 4;
            dtgvKhoSach.Columns["GiaGoc"].DisplayIndex = 5;
            dtgvKhoSach.Columns["GiaBia"].DisplayIndex = 6;
            dtgvKhoSach.Columns["SoLuong"].DisplayIndex = 7;
            dtgvKhoSach.Columns["MaTheLoai"].DisplayIndex = 8;
        }

        void LoadDtgvTheLoai(List<TheLoai> dsTheLoai = null)
        {
            if (dsTheLoai == null)
                dsTheLoai = TheLoaiDAO.Instance.LayDanhSachTheLoai();
            dtgvTheLoai.DataSource = dsTheLoai;
           
            dtgvTheLoai.ReadOnly = true;
            dtgvTheLoai.AllowUserToAddRows = false;

            dtgvTheLoai.Columns["MaTheLoai"].HeaderText = "Mã thể loại";
            dtgvTheLoai.Columns["TenTheLoai"].HeaderText = "Tên thể loại";

            dtgvTheLoai.Columns["MaTheLoai"].DisplayIndex = 0;
            dtgvTheLoai.Columns["TenTheLoai"].DisplayIndex = 1;
        }

        bool verify()
        {
            if ((txtISBN.Text.Trim() == "")
                || (txtTenSach.Text.Trim() == "")
                || (txtTacGia.Text.Trim() == "")
                || (txtNXB.Text.Trim() == ""))
                return false;
            return true;
        }

        void LamTrongDuLieu()
        {
            txtISBN.Enabled = true;
            txtISBN.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            dtpkNamXuatBan.MaxDate = DateTime.Now;
            dtpkNamXuatBan.Value = DateTime.Now.Date;
            nmSoLuong.Value = 1;
            nmGiaGoc.Value = 0;
            nmGiaBan.Value = 0;
        }

        void XoaDauSach(int isbn)
        {
            if (!(DauSachDAO.Instance.LayDauSachTheoISBN(isbn) == null))
            {
                if (MessageBox.Show("Bạn có muốn xóa sách này không?", "Xóa Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DauSachDAO.Instance.XoaDauSachTheoISBN(isbn))
                    {
                        MessageBox.Show("Đã xóa sách thành công", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFullDtgvKhoSach();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách không thành công", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ISBN không tồn tại", "Xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void SuaDauSach(int isbn, string tenDauSach, string tacGia, string nxb, DateTime namXB, int giaGoc, int giaBia, int soLuong, int maTheLoai)
        {     
            if (DauSachDAO.Instance.LayDauSachTheoISBN(isbn) != null)
            {
                if (DauSachDAO.Instance.CapNhatDauSach(isbn, tenDauSach, tacGia, nxb, namXB, giaGoc, giaBia, soLuong, maTheLoai))
                {
                    MessageBox.Show("Đã chỉnh sửa sách thành công!", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFullDtgvKhoSach();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa sách thất bại!", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ISBN không tồn tại", "Sửa sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ThemDauSach(int isbn, string tenDauSach, string tacGia, string nxb, DateTime namXB, int giaGoc, int giaBia, int soLuong, int maTheLoai)
        {
            if (DauSachDAO.Instance.LayDauSachTheoISBN(isbn) == null)
            {
                if (DauSachDAO.Instance.ThemDauSach(isbn, tenDauSach, tacGia, nxb, namXB, giaGoc, giaBia, soLuong, maTheLoai))
                {
                    MessageBox.Show("Đã thêm sách thành công!", "Thêm sách Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFullDtgvKhoSach();
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại!", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ISBN đã tồn tại", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void SuaTheLoai(int maTheLoai, string tenTheLoai)
        {
            if (TheLoaiDAO.Instance.LayTheLoaiTheoMa(maTheLoai) != null)
            {
                if (TheLoaiDAO.Instance.SuaTheLoai(maTheLoai, tenTheLoai))
                {
                    MessageBox.Show("Đã sửa tên thể loại thành công!", "Sửa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCmbLoaiSach();
                    LoadDtgvTheLoai();
                }
                else
                {
                    MessageBox.Show("Sửa tên thể loại thất bại thất bại!", "Sửa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã thể loại không tồn tại!", "Sửa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ThemTheLoai(string tenTheLoai)
        {
            if (TheLoaiDAO.Instance.LayTheLoaiTheoTen(tenTheLoai) == null)
            {
                if (TheLoaiDAO.Instance.ThemTheLoai(tenTheLoai))
                {
                    MessageBox.Show("Thêm thể loại thành công!", "Thêm thể loại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCmbLoaiSach();
                    LoadDtgvTheLoai();
                }
                else
                {
                    MessageBox.Show("Thêm thể loại thất bại thất bại!", "Thêm thể loại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thể loại đã tồn tại!", "Thêm thể loại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void XoaTheLoai(int maTheLoai)
        {
            if (TheLoaiDAO.Instance.LayTheLoaiTheoMa(maTheLoai) != null)
            {
                if (TheLoaiDAO.Instance.XoaTheLoaiTheMa(maTheLoai))
                {
                    MessageBox.Show("Xóa thể loại thành công!", "Xóa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCmbLoaiSach();
                    LoadDtgvTheLoai();
                }
                else
                {
                    MessageBox.Show("Đang có những cuốn sách thuộc thể loại này!", "Xóa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thể loại không tồn tại!", "Xóa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Events
        private void FormQuanLyKho_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            List<DauSach> DsDauSach = new List<DauSach>();
            if (!string.IsNullOrEmpty(keyword))
            {
                DsDauSach = DauSachDAO.Instance.LayThongTinDuyNhatDauSachTheoTuKhoa(keyword);
            }
            else
            {
                DsDauSach = DauSachDAO.Instance.LayDanhSachDauSach();
            }
            LoadDtgvKhoSach(DsDauSach);
        }

        private void btnLamTrongDuLieu_Click(object sender, EventArgs e)
        {
            LamTrongDuLieu();
        }

        private void dtgvKhoSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int isbn = Int32.Parse(dtgvKhoSach.CurrentRow.Cells[0].Value.ToString());

            DauSach dauSach = DauSachDAO.Instance.LayDauSachTheoISBN(isbn);

            txtISBN.Text = dauSach.ISBN.ToString();
            txtTenSach.Text = dauSach.TenDauSach;
            txtTacGia.Text = dauSach.TacGia;
            txtNXB.Text = dauSach.NXB;
            dtpkNamXuatBan.Value = dauSach.NamXuatBan;
            nmGiaGoc.Value = (int)dauSach.GiaGoc;
            nmGiaBan.Value = (int)dauSach.GiaBia;
            nmSoLuong.Value = dauSach.SoLuong;

            cmbTheLoai.SelectedValue = dauSach.MaTheLoai;
            txtISBN.Enabled = false;
        }

        private void dtgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maTheLoai = Int32.Parse(dtgvTheLoai.CurrentRow.Cells[0].Value.ToString());
            TheLoai theLoai = TheLoaiDAO.Instance.LayTheLoaiTheoMa(maTheLoai);
            txtMaTheLoai.Text = theLoai.MaTheLoai.ToString();
            txtTenTheLoai.Text = theLoai.TenTheLoai;
        }

        private void btnXoaDauSach_Click(object sender, EventArgs e)
        {
            string strISBN = txtISBN.Text;
            if (!string.IsNullOrEmpty(strISBN))
            {
                int isbn;
                if (Int32.TryParse(strISBN, out isbn))
                    XoaDauSach(isbn);
                else
                {
                    MessageBox.Show("ISBN không hợp lệ!", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập vào ISBN của sách bạn muốn xóa!", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaDauSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (verify())
                {
                    int isbn;
                    if (Int32.TryParse(txtISBN.Text, out isbn))
                    {
                        string tenDauSach = txtTenSach.Text;
                        string tacGia = txtTacGia.Text;
                        string nxb = txtNXB.Text;
                        DateTime namXuatBan = dtpkNamXuatBan.Value;
                        int giaGoc = Int32.Parse(nmGiaGoc.Value.ToString());
                        int giaBia = Int32.Parse(nmGiaBan.Value.ToString());
                        int soLuong = Int32.Parse(nmSoLuong.Value.ToString());
                        int maTheLoai = Int32.Parse(cmbTheLoai.SelectedValue.ToString());
                        SuaDauSach(isbn, tenDauSach, tacGia, nxb, namXuatBan, giaGoc, giaBia, soLuong, maTheLoai);
                    }
                    else
                    {
                        MessageBox.Show("ISBN không hợp lệ!", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhapDauSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (verify())
                {
                    int isbn;
                    if (Int32.TryParse(txtISBN.Text, out isbn))
                    {
                        string tenDauSach = txtTenSach.Text;
                        string tacGia = txtTacGia.Text;
                        string nxb = txtNXB.Text;
                        DateTime namXuatBan = dtpkNamXuatBan.Value;
                        int giaGoc = Int32.Parse(nmGiaGoc.Value.ToString());
                        int giaBia = Int32.Parse(nmGiaBan.Value.ToString());
                        int soLuong = Int32.Parse(nmSoLuong.Value.ToString());
                        int maTheLoai = Int32.Parse(cmbTheLoai.SelectedValue.ToString());
                        ThemDauSach(isbn, tenDauSach, tacGia, nxb, namXuatBan, giaGoc, giaBia, soLuong, maTheLoai);
                    }
                    else
                    {
                        MessageBox.Show("ISBN không hợp lệ!", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtMaTheLoai.Text) || string.IsNullOrEmpty(txtTenTheLoai.Text)))
            {
                int maTheLoai;
                string tenTheLoai = txtTenTheLoai.Text;
                if (Int32.TryParse(txtMaTheLoai.Text, out maTheLoai))
                {
                    SuaTheLoai(maTheLoai, tenTheLoai);
                }
                else
                {
                    MessageBox.Show("Mã thể loại không hợp lệ!", "Sửa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Sửa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txtTenTheLoai.Text;
            if (!string.IsNullOrEmpty(tenTheLoai))
            {
                ThemTheLoai(tenTheLoai);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thêm thể loại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaTheLoai.Text))
            {
                int maTheLoai;
                if (Int32.TryParse(txtMaTheLoai.Text, out maTheLoai))
                {
                    XoaTheLoai(maTheLoai);
                }
                else
                {
                    MessageBox.Show("Mã thể loại không hợp lệ!", "Xóa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã thể loại!", "Xóa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion


    }
}
