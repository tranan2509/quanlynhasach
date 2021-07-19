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
    public partial class FormThanhToan : Form
    {
        private static FormThanhToan instance;
        public static FormThanhToan Instance
        {
            get
            {
                if (instance == null)
                    instance = new FormThanhToan();
                return instance;
            }
            private set { instance = value; }
        }

        public Panel pnl;

        public NhanVien NV { get; set; }
        public List<ChiTietHoaDon> DsChiTietHoaDon { get; set; }
        public List<int> DsGiaGiam;
        public List<string> DsMaGiamGiaSach;
        public HoaDon HoaDonMoi { get; set; }

        public int GiamGia = 0;
        public string MaGiamGiaSach = "NONE";
        public int DiemTichLuyKhachHangDung = 0;

        public FormThanhToan()
        {
            int maHoaDonMoi = HoaDonDAO.Instance.LayMaHoaDonMoi();
            HoaDonMoi = new HoaDon(maHoaDonMoi, -1, NV.Ma, 0, "NONE", 0);
            DsChiTietHoaDon = new List<ChiTietHoaDon>();
            DsGiaGiam = new List<int>();
            DsMaGiamGiaSach = new List<string>();
            InitializeComponent();
            ThanhTienHoaDonCapNhat(0);
        }

        public FormThanhToan(NhanVien nv)
        {
            this.NV = nv;
            int maHoaDonMoi = HoaDonDAO.Instance.LayMaHoaDonMoi();
            HoaDonMoi = new HoaDon(maHoaDonMoi, -1, NV.Ma, 0, "NONE", 0);
            DsChiTietHoaDon = new List<ChiTietHoaDon>();
            DsGiaGiam = new List<int>();
            DsMaGiamGiaSach = new List<string>();
            InitializeComponent();
            ThanhTienHoaDonCapNhat(0);
        }

        #region Methods
        void LoadForm()
        {
            ckbDiemTichLuy.Hide();
            lbThongTinSoLuongSach.Text = "";
            lbThongTinKhuyenMaiSach.Text = "";
            lbTenKhachHang.Text = "";
            LoadDanhSachDauSach();
        }

        void LoadDanhSachDauSach()
        {
            List<DauSach> DsDauSach = DauSachDAO.Instance.LayDanhSachDauSach();
            dtgvDauSach.DataSource = DsDauSach.Select(o => new
            { Column1 = o.ISBN, Column2 = o.TenDauSach, Column3 = o.GiaBia, Column4 = o.SoLuong }).ToList();
            setColumnDataGridView();
        }

        void setColumnDataGridView()
        {
            dtgvDauSach.ReadOnly = true;
            dtgvDauSach.AllowUserToAddRows = false;
            dtgvDauSach.Columns["Column1"].HeaderText = "ISBN";
            dtgvDauSach.Columns["Column2"].HeaderText = "Tên sách";
            dtgvDauSach.Columns["Column3"].HeaderText = "Giá";
            dtgvDauSach.Columns["Column4"].HeaderText = "Tồn kho";

            dtgvDauSach.Columns["Column1"].DisplayIndex = 0;
            dtgvDauSach.Columns["Column2"].DisplayIndex = 1;
            dtgvDauSach.Columns["Column3"].DisplayIndex = 2;
            dtgvDauSach.Columns["Column4"].DisplayIndex = 3;

        }

        string LayMaKhuyenMaiTuForm()
        {
            if (string.IsNullOrEmpty(txtMaKhuyenMai.Text))
                return "NONE";
            return txtMaKhuyenMai.Text;
        }

        string LayMaKhuyenMaiSachTuForm()
        {
            if (string.IsNullOrEmpty(txtMaKhuyenMaiSach.Text))
                return "NONE";
            return txtMaKhuyenMaiSach.Text;
        }

        public int ViTriISBNHoaDon(int isbn)
        {
            for (int i = 0; i < DsChiTietHoaDon.Count; i++)
                if (DsChiTietHoaDon[i].ISBN == isbn)
                    return i;
            return -1;
        }

        void ThanhTienHoaDonCapNhat(float thanhTien)
        {
            HoaDonMoi.ThanhTien = thanhTien;
            txtThanhTien.Text = Convert.ToString(HoaDonMoi.ThanhTien);
        }

        bool KiemTraSoLuongMua(int isbn, int soLuong)
        {
            return soLuong <= DauSachDAO.Instance.LaySoLuongSachTonKhoTheoISBN(isbn);
        }

        void LoadListViewHoaDon()
        {
            lsvHoaDon.Items.Clear();
            ThanhTienHoaDonCapNhat(0);
            HoaDonMoi.TongGiaGoc = 0;
            for (int i = 0; i < DsChiTietHoaDon.Count; i++)
            {
                ChiTietHoaDon item = DsChiTietHoaDon[i];
                DauSach dauSach = DauSachDAO.Instance.LayDauSachTheoISBN(item.ISBN);
                ListViewItem lsvItem = new ListViewItem(dauSach.TenDauSach);
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(dauSach.GiaBia.ToString());
                float giaGoc = (item.SoLuong * dauSach.GiaBia);
                float giamGia = DsGiaGiam[i] * giaGoc / 100;
                float thanhTien = giaGoc - giamGia;
                lsvItem.SubItems.Add(giamGia.ToString() + "đ");
                lsvItem.SubItems.Add(thanhTien.ToString() + "đ");
                lsvHoaDon.Items.Add(lsvItem);
                HoaDonMoi.TongGiaGoc += giaGoc;
                ThanhTienHoaDonCapNhat(HoaDonMoi.ThanhTien + thanhTien);
            }
        }

        void ThemDauSachVaoHoaDon(DauSach dauSach)
        {
            ListViewItem lsvItem = new ListViewItem(dauSach.TenDauSach);
            lsvItem.SubItems.Add(nmSoLuong.Value.ToString());
            lsvItem.SubItems.Add(dauSach.GiaBia.ToString());
            float giaGoc = (float)nmSoLuong.Value * dauSach.GiaBia;
            float giamGia = giaGoc * GiamGia / 100;
            float thanhTien = giaGoc - giamGia;
            lsvItem.SubItems.Add(giamGia.ToString() + "đ");
            lsvItem.SubItems.Add(thanhTien.ToString() + "đ");
            lsvHoaDon.Items.Add(lsvItem);
            HoaDonMoi.TongGiaGoc += giaGoc;
            ThanhTienHoaDonCapNhat(HoaDonMoi.ThanhTien + thanhTien);
            DsGiaGiam.Add(GiamGia);
            DsMaGiamGiaSach.Add(MaGiamGiaSach);
        }

        int LayDiemTichLuyKhachHangTheoMa(int maKhachHang, bool daDangKi = true, bool daChon = false)
        {
            if (daDangKi)
            {
                ckbDiemTichLuy.Checked = daChon;
                int diem = KhachHangDAO.Instance.LayDiemTichLuyBangMaKhachHang(maKhachHang);
                ckbDiemTichLuy.Show();
                ckbDiemTichLuy.Text = diem.ToString() + " điểm";
                return diem;
            }
            else
            {
                ckbDiemTichLuy.Checked = daChon;
                ckbDiemTichLuy.Hide();
                return 0;
            }
        }

        void ApDungMaKhuyenMai()
        {
            GiamGia = 0;
            MaGiamGiaSach = "NONE";
            string maKhuyenMaiSach = txtMaKhuyenMaiSach.Text;
            int isbn = -1;
            if (!int.TryParse(txtISBN.Text, out isbn))
            {

            }
            if (string.IsNullOrEmpty(maKhuyenMaiSach))
            {
                lbThongTinKhuyenMaiSach.ForeColor = Color.Black;
                lbThongTinKhuyenMaiSach.Text = "";
            }
            else
            {
                KhuyenMai khuyenMai = KhuyenMaiDAO.Instance.LayGiamGiaTheoMaKhuyenMai(maKhuyenMaiSach);
                if (khuyenMai == null)
                {
                    lbThongTinKhuyenMaiSach.ForeColor = Color.Red;
                    lbThongTinKhuyenMaiSach.Text = "Khuyến mãi không hợp lệ!";
                }
                else
                {
                    if (khuyenMai.DoiTuong != "Sách")
                    {
                        lbThongTinKhuyenMaiSach.ForeColor = Color.Red;
                        lbThongTinKhuyenMaiSach.Text = "Mã không áp dụng sách này!";
                    }
                    else if (khuyenMai.ISBN != isbn)
                    {
                        lbThongTinKhuyenMaiSach.ForeColor = Color.Red;
                        lbThongTinKhuyenMaiSach.Text = "Mã không áp dụng sách này!";
                    }
                    else if (khuyenMai.NgayBatDau > DateTime.Now)
                    {
                        lbThongTinKhuyenMaiSach.ForeColor = Color.Red;
                        lbThongTinKhuyenMaiSach.Text = "Mã khuyến mãi chưa đến hạn!";
                    }
                    else if (khuyenMai.NgayKetThuc < DateTime.Now)
                    {
                        lbThongTinKhuyenMaiSach.ForeColor = Color.Red;
                        lbThongTinKhuyenMaiSach.Text = "Mã khuyến mãi đã hết hạn!";
                    }
                    else if (!GiamGiaSachHopLe(khuyenMai, isbn))
                    {
                        lbThongTinKhuyenMaiSach.ForeColor = Color.Red;
                        lbThongTinKhuyenMaiSach.Text = "Chưa đủ " + khuyenMai.DieuKien + "Đ";
                    }
                    else
                    {
                        lbThongTinKhuyenMaiSach.ForeColor = Color.Green;
                        lbThongTinKhuyenMaiSach.Text = "Giảm giá " + khuyenMai.MucGiam + "%";
                        GiamGia = khuyenMai.MucGiam;
                        MaGiamGiaSach = maKhuyenMaiSach;
                    }
                }
            }
        }

        bool GiamGiaSachHopLe(KhuyenMai khuyenMai, int isbn)
        {
            int index = ViTriISBNHoaDon(isbn);
            int soLuong = (int)nmSoLuong.Value;
            if (index > -1)
            {
                soLuong += DsChiTietHoaDon[index].SoLuong;
            }
            DauSach dauSach = DauSachDAO.Instance.LayDauSachTheoISBN(isbn);
            if (soLuong * dauSach.GiaBia >= khuyenMai.DieuKien)
                return true;
            return false;
        }


        void ThemMaKhuyenMaiHoaDon()
        {
            lbThongTinKhuyenMai.ForeColor = Color.Green;
            lbThongTinKhuyenMai.Text = "Khuyến mãi không hợp lệ!";
            string khuyenMaiHoaDon = txtMaKhuyenMai.Text;
            HoaDonMoi.MaKhuyenMai = "NONE";
            if (!string.IsNullOrEmpty(khuyenMaiHoaDon))
            {
                KhuyenMai khuyenMai = KhuyenMaiDAO.Instance.LayGiamGiaTheoMaKhuyenMai(khuyenMaiHoaDon);
                if (khuyenMai != null)
                {
                    if (khuyenMai.DoiTuong != "Hóa đơn")
                    {
                        lbThongTinKhuyenMai.ForeColor = Color.Red;
                        lbThongTinKhuyenMai.Text = "KM không áp dụng cho hóa đơn!";
                    }
                    else if (khuyenMai.DieuKien > HoaDonMoi.ThanhTien)
                    {
                        lbThongTinKhuyenMai.ForeColor = Color.Red;
                        lbThongTinKhuyenMai.Text = "Chưa đủ " + khuyenMai.DieuKien + "đ";
                    }
                    else
                    {
                        HoaDonMoi.MaKhuyenMai = khuyenMai.MaKhuyenMai;
                        lbThongTinKhuyenMai.ForeColor = Color.Green;
                        float giamGia = HoaDonMoi.ThanhTien * khuyenMai.MucGiam / 100;
                        float thanhTien = HoaDonMoi.ThanhTien - giamGia;
                        lbThongTinKhuyenMai.Text = "Tổng: " + HoaDonMoi.ThanhTien + "đ | Giảm: " + giamGia + "đ";
                        ThanhTienHoaDonCapNhat(thanhTien);
                    }
                }
                else
                {
                    lbThongTinKhuyenMai.ForeColor = Color.Red;
                    lbThongTinKhuyenMai.Text = "Khuyến mãi không hợp lệ!";
                }
            }
            else
            {
                lbThongTinKhuyenMai.ForeColor = Color.Green;
                lbThongTinKhuyenMai.Text = "Chưa áp dụng";
            }
        }


        void LoadHoaDonMoi(int maKhachHang, int maNhanVien)
        {
            ThanhTienHoaDonCapNhat(0);
            int maHoaDonMoi = HoaDonDAO.Instance.LayMaHoaDonMoi();
            string maKhuyenMai = LayMaKhuyenMaiTuForm();
            try
            {
                HoaDonMoi = new HoaDon(maHoaDonMoi, maKhachHang, maNhanVien, 0, maKhuyenMai, 0);
                DsChiTietHoaDon.Clear();
                DsGiaGiam.Clear();
                DsMaGiamGiaSach.Clear();
                lsvHoaDon.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Không thể khởi tạo hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool ThanhToan(int maKhachHang, int maNhanVien, string maKhuyenMai, HoaDon HoaDonMoi, List<ChiTietHoaDon> DsChiTietHoaDon)
        {
            if (DsChiTietHoaDon.Count == 0)
                return false;
            try
            {
                HoaDonMoi.NgayThanhToan = DateTime.Now;
                HoaDonMoi.MaNhanVien = maNhanVien;
                if (string.IsNullOrEmpty(maKhuyenMai))
                    maKhuyenMai = "NONE";
                if (HoaDonDAO.Instance.ThemHoaDon(HoaDonMoi))
                {
                    foreach (ChiTietHoaDon item in DsChiTietHoaDon)
                    {
                        if (!ChiTietHoaDonDAO.Instance.ThemChiTietHoaDon(item))
                        {
                            if (HoaDonDAO.Instance.XoaHoaDon(HoaDonMoi.MaHoaDon))
                            {
                                MessageBox.Show("Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            return false;
                        }
                    }
                    int diemKhachHangDung = DiemTichLuyKhachHangDung;
                    int diemTichLuy = LayDiemTichLuyKhachHangTheoMa(maKhachHang);
                    int diemTichLuyMoi = diemTichLuy - diemKhachHangDung;
                    DiemTichLuyKhachHangDung = 0;
                    ckbDiemTichLuy.Text = diemTichLuyMoi.ToString() + " điểm";
                    KhachHangDAO.Instance.CapNhatDiemTichLuyBangMaKhachHang(maKhachHang, diemTichLuyMoi);
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHoaDonMoi(maKhachHang, maNhanVien);
                    LoadDanhSachDauSach();
                    return true;
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                HoaDonDAO.Instance.XoaHoaDon(HoaDonMoi.MaHoaDon);
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region Events
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnHoaDonMoi_Click(object sender, EventArgs e)
        {
            int maKhachHang;
            try
            {
                if (!string.IsNullOrEmpty(txtMaKhachHang.Text))
                    maKhachHang = int.Parse(txtMaKhachHang.Text);
                else
                    maKhachHang = -1;
                LoadHoaDonMoi(maKhachHang, NV.Ma);
            }
            catch
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int isbn = int.Parse(txtISBN.Text);
                string maKhuyenMai = txtMaKhuyenMaiSach.Text;
                if (string.IsNullOrEmpty(maKhuyenMai))
                {
                    maKhuyenMai = "NONE";
                }
                int soLuong = (int)nmSoLuong.Value;
                KhuyenMai khuyenMai = KhuyenMaiDAO.Instance.LayGiamGiaTheoMaKhuyenMai(maKhuyenMai);
                DauSach dauSach = DauSachDAO.Instance.LayDauSachTheoISBN(isbn);
                if (dauSach != null)
                {
                    int index = ViTriISBNHoaDon(isbn);
                    if (index >= 0)
                    {
                        int quantity = soLuong + DsChiTietHoaDon[index].SoLuong;
                        if (quantity > 0)
                        {
                            if (KiemTraSoLuongMua(isbn, quantity))
                            {

                                if (khuyenMai != null)
                                {
                                    if (lbThongTinKhuyenMaiSach.ForeColor == Color.Green && khuyenMai.DoiTuong == "Sách" && khuyenMai.ISBN == isbn)
                                    {
                                        DsGiaGiam[index] = GiamGia;
                                        DsMaGiamGiaSach[index] = maKhuyenMai;
                                    }
                                    else
                                    {
                                        DsGiaGiam[index] = 0;
                                        DsMaGiamGiaSach[index] = "NONE";
                                    }
                                }
                                else
                                {
                                    DsGiaGiam[index] = 0;
                                    DsMaGiamGiaSach[index] = "NONE";
                                }
                                DsChiTietHoaDon[index].SoLuong = quantity;
                                dauSach.SoLuong -= quantity;
                            }
                            else
                                MessageBox.Show("Kho không đủ sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            DsChiTietHoaDon.RemoveAt(index);
                        LoadListViewHoaDon();
                    }
                    else
                    {
                        if (soLuong < 0)
                        {
                            MessageBox.Show("Số lượng sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (KiemTraSoLuongMua(isbn, soLuong))
                        {
                            if (khuyenMai == null || khuyenMai.ISBN != isbn || khuyenMai.DoiTuong != "Sách")
                                maKhuyenMai = "NONE";
                            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(HoaDonMoi.MaHoaDon, isbn, maKhuyenMai, soLuong);
                            DsChiTietHoaDon.Add(chiTietHoaDon);
                            dauSach.SoLuong -= soLuong;
                            ThemDauSachVaoHoaDon(dauSach);
                        }
                        else
                        {
                            MessageBox.Show("Kho không đủ sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    ApDungMaKhuyenMai();
                    ThemMaKhuyenMaiHoaDon();
                }
                else
                {
                    MessageBox.Show("Sách không có trong kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("ISBN không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            ApDungMaKhuyenMai();
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                LoadDanhSachDauSach();
            }
            else
            {
                try
                {
                    int isbn = int.Parse(txtISBN.Text);
                    List<DauSach> DsDauSach = DauSachDAO.Instance.LayDauSachTheoISBN(isbn, true);
                    dtgvDauSach.DataSource = DsDauSach;
                    dtgvDauSach.DataSource = DsDauSach.Select(o => new
                    { Column1 = o.ISBN, Column2 = o.TenDauSach, Column3 = o.GiaBia, Column4 = o.SoLuong }).ToList();
                    setColumnDataGridView();
                }
                catch
                {
                    MessageBox.Show("ISBN không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            ApDungMaKhuyenMai();
            try
            {
                lb20.ForeColor = Color.Black;
                if (string.IsNullOrEmpty(txtMaKhachHang.Text))
                {
                    lbTenKhachHang.Text = "";
                    LayDiemTichLuyKhachHangTheoMa(-1, false);
                }
                else
                {
                    int maKhachHang = Convert.ToInt32(txtMaKhachHang.Text);
                    KhachHang khachHang = KhachHangDAO.Instance.LayThongTinKhachHang(maKhachHang);
                    if (khachHang == null)
                    {
                        LayDiemTichLuyKhachHangTheoMa(maKhachHang, false);
                        lbTenKhachHang.Text = "Khách hàng không hợp lệ";
                        lbTenKhachHang.ForeColor = Color.Red;
                        HoaDonMoi.MaKhachHang = -1;
                    }
                    else
                    {
                        LayDiemTichLuyKhachHangTheoMa(maKhachHang, true);
                        lbTenKhachHang.Text = khachHang.HoTen;
                        lbTenKhachHang.ForeColor = Color.Black;
                        HoaDonMoi.MaKhachHang = maKhachHang;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maKhachHang = -1;   
            string maKhuyenMai = txtMaKhuyenMai.Text;
            if (!string.IsNullOrEmpty(txtMaKhachHang.Text))
               {
                   maKhachHang = Convert.ToInt32(txtMaKhachHang.Text);
               }
            ThanhToan(maKhachHang, NV.Ma, maKhuyenMai, HoaDonMoi, DsChiTietHoaDon);
        }

        private void nmSoLuong_ValueChanged(object sender, EventArgs e)
        {
            ApDungMaKhuyenMai();
        }

        private void txtMaKhuyenMaiSach_TextChanged(object sender, EventArgs e)
        {
            ApDungMaKhuyenMai();
        }

        private void txtMaKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            ThemMaKhuyenMaiHoaDon();
        }

        private void ckbDiemTichLuy_CheckedChanged(object sender, EventArgs e)
        {
            int diemTichLuy;
            if (ckbDiemTichLuy.Checked == true)
            {
                diemTichLuy = LayDiemTichLuyKhachHangTheoMa(int.Parse(txtMaKhachHang.Text), true, true);
                if (diemTichLuy <= HoaDonMoi.ThanhTien)
                {
                    DiemTichLuyKhachHangDung = diemTichLuy;
                    ckbDiemTichLuy.Text = 0.ToString() + " điểm";
                    ThanhTienHoaDonCapNhat(HoaDonMoi.ThanhTien - diemTichLuy);
                }
                else
                {
                    diemTichLuy -= (int)HoaDonMoi.ThanhTien;
                    DiemTichLuyKhachHangDung = (int)HoaDonMoi.ThanhTien;
                    ckbDiemTichLuy.Text = diemTichLuy.ToString() + " điểm";
                    ThanhTienHoaDonCapNhat(0);
                }
            }
            else
            {
                diemTichLuy = LayDiemTichLuyKhachHangTheoMa(int.Parse(txtMaKhachHang.Text), true, false);
                ThanhTienHoaDonCapNhat(HoaDonMoi.ThanhTien + DiemTichLuyKhachHangDung);
                ckbDiemTichLuy.Text = diemTichLuy.ToString() + " điểm";
                DiemTichLuyKhachHangDung = 0;
            }
        }

        #endregion
    }
}
