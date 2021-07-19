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

namespace QuanLyNhaSach.Views.NhanVienAdmin
{
    public partial class FormKhuyenMai : Form
    {
        public NhanVien NV { get; set; }
        public FormKhuyenMai()
        {
            InitializeComponent();
        }
        public FormKhuyenMai(NhanVien nv)
        {
            NV = nv;
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            txt_MaKhuyenMai.Text = "";
            txt_TenKhuyenMai.Text = "";
            cbb_DoiTuong.DataSource = KhuyenMaiDAO.Instance.DsDoiTuong;

            txt_DieuKien.Text = "";
            txt_MucGiam.Text = "";
            dateTimePicker_NgayBatDau.Value = DateTime.Now;
            dateTimePicker_NgayKetThuc.Value = DateTime.Now;
        }

        bool verif()
        {
            bool check = true;
            if (txt_MaKhuyenMai.Text == "")
            {
                errorProvider.SetError(txt_MaKhuyenMai, "Nhập Mã khuyến mãi!!!");
                check = false;
            }
            if (txt_TenKhuyenMai.Text == "")
            {
                errorProvider.SetError(txt_TenKhuyenMai, "Nhập Tên khuyến mãi!!!");
                check = false;
            }
            if (txt_DieuKien.Text == "")
            {
                errorProvider.SetError(txt_DieuKien, "Nhập điều kiện khuyến mãi!!!");
                check = false;
            }
            if (txt_MucGiam.Text == "")
            {
                errorProvider.SetError(txt_MucGiam, "Nhập mức giảm của khuyến mãi!!!");
                check = false;
            }
            return check;
        }

        private void HienThiDanhSachNhanVien()
        {
            DataTable dt = KhuyenMaiDAO.Instance.LayDanhSachKhuyenMai();
            dataGridView.DataSource = dt;
            dataGridView.ReadOnly = true;
            dataGridView.Columns["MaKhuyenMai"].HeaderText = "Mã";
            dataGridView.Columns["TenKhuyenMai"].HeaderText = "Khuyến mãi";
            dataGridView.Columns["DoiTuong"].HeaderText = "Đối tượng";
            dataGridView.Columns["ISBN"].HeaderText = "Mã sách";
            dataGridView.Columns["DieuKien"].HeaderText = "Điều kiện";
            dataGridView.Columns["MucGiam"].HeaderText = "Mức giảm";
            dataGridView.Columns["NgayBatDau"].HeaderText = "Bắt đầu";
            dataGridView.Columns["NgayKetThuc"].HeaderText = "Kết thúc";

            dataGridView.Columns["MaKhuyenMai"].DisplayIndex = 0;
            dataGridView.Columns["TenKhuyenMai"].DisplayIndex = 1;
            dataGridView.Columns["DoiTuong"].DisplayIndex = 2;
            dataGridView.Columns["ISBN"].DisplayIndex = 3;
            dataGridView.Columns["DieuKien"].DisplayIndex = 4;
            dataGridView.Columns["MucGiam"].DisplayIndex = 5;
            dataGridView.Columns["NgayBatDau"].DisplayIndex = 6;
            dataGridView.Columns["NgayKetThuc"].DisplayIndex = 7;

            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[1].Width = 130;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[4].Width = 110;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 100;

        }
        private void HienThiDanhSachISBN()
        {
            DataTable dt = KhuyenMaiDAO.Instance.LayDanhSachISBN();
            int i;
            string str;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                str = dt.Rows[i]["ISBN"].ToString();
                cbb_ISBN.Items.Add(str);
            }
            if (cbb_ISBN.Items.Count > 0)
                cbb_ISBN.SelectedIndex = 0;
        }

        #endregion

        #region Events
        private void FormKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadForm();
            HienThiDanhSachISBN();
            HienThiDanhSachNhanVien();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    string MaKhuyenMai = txt_MaKhuyenMai.Text;
                    string TenKhuyenMai = txt_TenKhuyenMai.Text;
                    string DoiTuong = cbb_DoiTuong.Text;
                    int MaCuonSach = Convert.ToInt32(cbb_ISBN.Text);
                    int DieuKien = Convert.ToInt32(txt_DieuKien.Text);
                    int MucGiam = Convert.ToInt32(txt_MucGiam.Text);
                    DateTime Ngaybatdau = dateTimePicker_NgayBatDau.Value;
                    DateTime Ngayketthuc = dateTimePicker_NgayKetThuc.Value;
                    if (KhuyenMaiDAO.Instance.KiemTraMaKhuyenMai(MaKhuyenMai) == false)
                    {
                        if (KhuyenMaiDAO.Instance.ThemKhuyenMai(MaKhuyenMai, TenKhuyenMai, DoiTuong, MaCuonSach, DieuKien, MucGiam, Ngaybatdau, Ngayketthuc))
                        {
                            MessageBox.Show("Thêm Khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadForm();
                            HienThiDanhSachNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Khuyến mãi đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm khuyến mãi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnt_Moi_Click(object sender, EventArgs e)
        {
            LoadForm();
            HienThiDanhSachISBN();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (verif())
                {
                    string MaKhuyenMai = txt_MaKhuyenMai.Text;
                    string TenKhuyenMai = txt_TenKhuyenMai.Text;
                    string DoiTuong = cbb_DoiTuong.Text;
                    int MaCuonSach = Convert.ToInt32(cbb_ISBN.Text);
                    int DieuKien = Convert.ToInt32(txt_DieuKien.Text);
                    int MucGiam = Convert.ToInt32(txt_MucGiam.Text);
                    DateTime Ngaybatdau = dateTimePicker_NgayBatDau.Value;
                    DateTime Ngayketthuc = dateTimePicker_NgayKetThuc.Value;
                    if (KhuyenMaiDAO.Instance.KiemTraMaKhuyenMai(MaKhuyenMai))
                    {
                        if (KhuyenMaiDAO.Instance.SuaKhuyenMai(MaKhuyenMai, TenKhuyenMai, DoiTuong, MaCuonSach, DieuKien, MucGiam, Ngaybatdau, Ngayketthuc))
                        {
                            MessageBox.Show("Cập nhật Khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadForm();
                            HienThiDanhSachNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã Khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cập nhật khuyến mãi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            DataTable dt;
            dt = KhuyenMaiDAO.Instance.LayDanhSachKhuyenMai();
            txt_TenKhuyenMai.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_MaKhuyenMai.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            cbb_DoiTuong.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            int isbn = (int)dataGridView.CurrentRow.Cells[3].Value;
            cbb_ISBN.Text = isbn.ToString();
            int dk = (int)dataGridView.CurrentRow.Cells[4].Value;
            txt_DieuKien.Text = dk.ToString();
            int mg = (int)dataGridView.CurrentRow.Cells[5].Value;
            txt_MucGiam.Text = mg.ToString();
            dateTimePicker_NgayBatDau.Value = (DateTime)dataGridView.CurrentRow.Cells[6].Value;
            dateTimePicker_NgayKetThuc.Value = (DateTime)dataGridView.CurrentRow.Cells[7].Value;
        }
    }
}
