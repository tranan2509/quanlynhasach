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
    public partial class FormQuanLyGioHang : Form
    {
        public KhachHang KH { get; set; }
        float TongGiaGoc;
        float ThanhTien;
        public FormQuanLyGioHang()
        {
            InitializeComponent();
        }
        public FormQuanLyGioHang(KhachHang kh)
        {
            KH = kh;
            InitializeComponent();
        }

        #region Methods
        private Form activeFormLichSu = null;
        private void openChildForm(Panel panel, Form childForm, Form active)
        {
            if (active != null)
                active.Close();
            active = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void LoadForm()
        {
            DataTable DsGioHang = GioHangDAO.Instance.LayThongTinGioHangTheoMaKhachHang(KH.Ma);
            LoadDataGridViewGioHang(DsGioHang);
            setKichThuocDtgv(852, 440);
        }


        void setKichThuocDtgv(int width, int height)
        {
            dtgvGioHang.Width = width;
            dtgvGioHang.Height = height;
        }

        void LoadDataGridViewGioHang(DataTable dsGioHang)
        {
            dtgvGioHang.DataSource = dsGioHang;
            dtgvGioHang.ReadOnly = true;
            dtgvGioHang.AllowUserToAddRows = false;
            dtgvGioHang.Columns["ISBN"].HeaderText = "ISBN";
            dtgvGioHang.Columns["TenDauSach"].HeaderText = "Tên sách";
            dtgvGioHang.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgvGioHang.Columns["GiaBia"].HeaderText = "Giá sách";
            dtgvGioHang.Columns["MaKhuyenMai"].HeaderText = "Mã khuyến mãi";
            dtgvGioHang.Columns["ThanhTien"].HeaderText = "Thành tiền";

            dtgvGioHang.Columns["ISBN"].DisplayIndex = 0;
            dtgvGioHang.Columns["TenDauSach"].DisplayIndex = 1;
            dtgvGioHang.Columns["SoLuong"].DisplayIndex = 2;
            dtgvGioHang.Columns["GiaBia"].DisplayIndex = 3;
            dtgvGioHang.Columns["MaKhuyenMai"].DisplayIndex = 4;
            dtgvGioHang.Columns["ThanhTien"].DisplayIndex = 5;
        }

        void LoadFormLichSu()
        {
            FormLichSuMuaHang fLichSu = new FormLichSuMuaHang(KH);
            fLichSu.HuyXemLichSu += FLichSu_HuyXemLichSu;
            openChildForm(pnlChildLichSuMuaHang, fLichSu , activeFormLichSu);
        }

        private void FLichSu_HuyXemLichSu(object sender, EventArgs e)
        {
            setKichThuocDtgv(852, 440);
            pnlLichSuMuaHang.Show();
        }

        List<ChiTietHoaDon> LoadDsChiTietHoaDon(int maHoaDon)
        {
            TongGiaGoc = 0;
            ThanhTien = 0;
            DataTable DsGioHang = GioHangDAO.Instance.LayThongTinGioHangTheoMaKhachHang(KH.Ma);
            List<ChiTietHoaDon> DsChiTietHoaDon = new List<ChiTietHoaDon>();
            foreach (DataRow item in DsGioHang.Rows)
            {
                int isbn = (int)item["ISBN"];
                string maKhuyenMai = item["MaKhuyenMai"].ToString();
                int soLuong = (int)item["SoLuong"];
                TongGiaGoc += (float)Convert.ToDouble(item["GiaBia"].ToString()) * soLuong;
                ThanhTien += (float)Convert.ToDouble(item["ThanhTien"].ToString());
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(maHoaDon, isbn, maKhuyenMai, soLuong);
                DsChiTietHoaDon.Add(chiTietHoaDon);
            }
            return DsChiTietHoaDon;
        }
        #endregion

        #region Events
        private void FormQuanLyGioHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnLichSuMuaHang_Click(object sender, EventArgs e)
        {
            setKichThuocDtgv(852, 159);
            LoadFormLichSu();
            pnlLichSuMuaHang.Hide();
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtISBN.Text))
                {
                    int isbn = Int32.Parse(txtISBN.Text);
                    int soLuongSach = DauSachDAO.Instance.LayDauSachTheoISBN(isbn).SoLuong;
                    nmSoLuong.Maximum = soLuongSach;
                }
            }
            catch
            {
                
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtISBN.Text))
            {
                int isbn = Int32.Parse(txtISBN.Text);
                int soLuongSach = DauSachDAO.Instance.LayDauSachTheoISBN(isbn).SoLuong;
                if (soLuongSach >= (int)nmSoLuong.Value)
                {
                    if (!GioHangDAO.Instance.CapNhatGioHang(KH.Ma, isbn, (int)nmSoLuong.Value))
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataTable data = GioHangDAO.Instance.LayThongTinGioHangTheoMaKhachHang(KH.Ma);
                        LoadDataGridViewGioHang(data);
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng sách trong kho còn lại là " + soLuongSach.ToString(), "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtISBN.Text))
            {
                int isbn = Int32.Parse(txtISBN.Text);
                int soLuongSach = DauSachDAO.Instance.LayDauSachTheoISBN(isbn).SoLuong;
                if (MessageBox.Show("Bạn có muốn xóa sách ISBN = " + isbn.ToString(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (!GioHangDAO.Instance.XoaSachTrongGioHang(KH.Ma, isbn))
                    {
                       MessageBox.Show("Xóa sách thất bại!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataTable data = GioHangDAO.Instance.LayThongTinGioHangTheoMaKhachHang(KH.Ma);
                        LoadDataGridViewGioHang(data);
                    }
                }
            }
        }

        private void dtgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int isbn = Int32.Parse(dtgvGioHang.CurrentRow.Cells["ISBN"].Value.ToString());
            string tenDauSach = dtgvGioHang.CurrentRow.Cells["TenDauSach"].Value.ToString();
            int soLuong = Int32.Parse(dtgvGioHang.CurrentRow.Cells["SoLuong"].Value.ToString());
            txtISBN.Text = isbn.ToString();
            txtTenCuonSach.Text = tenDauSach;
            int soLuongSachMax = DauSachDAO.Instance.LayDauSachTheoISBN(isbn).SoLuong;
            nmSoLuong.Value = soLuong <= soLuongSachMax ? soLuong : soLuongSachMax;
        }

       
        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien NV = NhanVienDAO.Instance.LayNhanVienTheoMaNhanVien(-1);
                FormThanhToan fThanhToan = new FormThanhToan(NV);
                int maHoaDonMoi = HoaDonDAO.Instance.LayMaHoaDonMoi();
                List<ChiTietHoaDon> DsChiTietHoaDon = LoadDsChiTietHoaDon(maHoaDonMoi);
                fThanhToan.HoaDonMoi = new HoaDon(maHoaDonMoi, KH.Ma, NV.Ma, TongGiaGoc, "NONE", ThanhTien);
                if (fThanhToan.ThanhToan(KH.Ma, NV.Ma, "", fThanhToan.HoaDonMoi, DsChiTietHoaDon))
                {
                    if (!GioHangDAO.Instance.XoaTatCaSachTrongGioHang(KH.Ma))
                    {
                        MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataTable DsGioHang = GioHangDAO.Instance.LayThongTinGioHangTheoMaKhachHang(KH.Ma);
                        LoadDataGridViewGioHang(DsGioHang);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        #endregion


    }
}
