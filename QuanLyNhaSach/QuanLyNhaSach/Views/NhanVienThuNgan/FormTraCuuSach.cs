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
    public partial class FormTraCuuSach : Form
    {
        public NhanVien NV { get; set; }

        public FormTraCuuSach()
        {
            InitializeComponent();
        }

        public FormTraCuuSach(NhanVien nv)
        {
            NV = nv;
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            dtgvSach.ReadOnly = true;
            dtgvSach.AllowUserToAddRows = false;
            DataTable bangSach = DauSachDAO.Instance.LayThongTinDayDuDauSach();
            LoadDanhSachSach(bangSach);
        }

        void LoadDanhSachSach(DataTable data)
        {
            dtgvSach.DataSource = data;
            dtgvSach.Columns["ISBN"].HeaderText = "ISBN";
            dtgvSach.Columns["TenDauSach"].HeaderText = "Tên sách";
            dtgvSach.Columns["TacGia"].HeaderText = "Tác giả";
            dtgvSach.Columns["NXB"].HeaderText = "NXB";
            dtgvSach.Columns["NamXuatBan"].HeaderText = "Năm XB";
            dtgvSach.Columns["GiaBia"].HeaderText = "Giá";
            dtgvSach.Columns["SoLuong"].HeaderText = "Tồn kho";
            dtgvSach.Columns["TenTheLoai"].HeaderText = "Thể loại";
            dtgvSach.Columns["ISBN"].DisplayIndex = 0;
            dtgvSach.Columns["TenDauSach"].DisplayIndex = 1;
            dtgvSach.Columns["TacGia"].DisplayIndex = 2;
            dtgvSach.Columns["NXB"].DisplayIndex = 3;
            dtgvSach.Columns["NamXuatBan"].DisplayIndex = 4;
            dtgvSach.Columns["GiaBia"].DisplayIndex = 5;
            dtgvSach.Columns["SoLuong"].DisplayIndex = 6;
            dtgvSach.Columns["TenTheLoai"].DisplayIndex = 7;
        }

        #endregion

        #region Events
        private void FormTraCuuSach_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            DataTable bangSach = null;
            if (string.IsNullOrEmpty(keyword))
            {
                bangSach = DauSachDAO.Instance.LayThongTinDayDuDauSach();
            }
            else
            {
                bangSach = DauSachDAO.Instance.LayThongTinDauSachTheoTuKhoa(keyword);
            }
            LoadDanhSachSach(bangSach);
        }

        #endregion
    }
}
