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
    public partial class FormDoanhThu : Form
    {
        public NhanVien NV { get; set; }
        public FormDoanhThu()
        {
            InitializeComponent();
        }
        public FormDoanhThu(NhanVien nv)
        {
            NV = nv;
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            dateTime_NgayBatDau.Value = DateTime.Now;
            dateTime_NgayKetThuc.Value = DateTime.Now;
            cbb_loai.DataSource = HoaDonDAO.Instance.DsThongKe;

        }

        #endregion

        #region Events
        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String LoaiThongKe = cbb_loai.Text;
            DateTime NgayBatDau = dateTime_NgayBatDau.Value;
            DateTime NgayKetThuc = dateTime_NgayKetThuc.Value;
            DataTable tb = new DataTable();
            if (LoaiThongKe == "Ngày")
            {
                tb = HoaDonDAO.Instance.LayThongKeTheoNgay(NgayBatDau, NgayKetThuc);
                dataGridView_DonhThu.DataSource = tb;
                dataGridView_DonhThu.AutoResizeColumns();
                dataGridView_DonhThu.Columns["Ngày"].DisplayIndex = 0;
                dataGridView_DonhThu.Columns["Tổng Doanh Thu"].DisplayIndex = 1;
                dataGridView_DonhThu.Columns[0].Width = 130;
                dataGridView_DonhThu.Columns[1].Width = 350;
            }
            else if (LoaiThongKe == "Tháng")
            {
                tb = HoaDonDAO.Instance.LayThongKeTheoThang(NgayBatDau, NgayKetThuc);
                dataGridView_DonhThu.DataSource = tb;
                dataGridView_DonhThu.AutoResizeColumns();
                dataGridView_DonhThu.Columns["Tháng"].DisplayIndex = 0;
                dataGridView_DonhThu.Columns["Tổng Doanh Thu"].DisplayIndex = 1;
                dataGridView_DonhThu.Columns[0].Width = 130;
                dataGridView_DonhThu.Columns[1].Width = 350;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng loại thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion


    }
}
