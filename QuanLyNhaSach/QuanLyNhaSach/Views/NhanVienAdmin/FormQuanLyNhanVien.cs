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
    public partial class FormQuanLyNhanVien : Form
    {
        public BoPhan BP { get; set; }
        public NhanVien NV { get; set; }
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        public FormQuanLyNhanVien(NhanVien nv)
        {
            NV = nv;
            InitializeComponent();
        }
        #region Methods
        void LoadForm()
        {
            txt_TenNhanVien.Text = "";
            date_NgaySinh.Value = new DateTime(2000, 1, 1);
            radioButton_Nam.Checked = true;
            radioButton_Nu.Checked = false;
            txt_SDT.Text = "";
            txt_CMND.Text = "";
            txt_Email.Text = "";
            label_ma.Visible = false;
            txt_MaNhanVien.Visible = false;
            txt_MaNhanVien.Text = "";
        }

        bool verif()
        {
            errorProvider.Clear();
            bool check = true;

            if (txt_TenNhanVien.Text == "")
            {
                errorProvider.SetError(txt_TenNhanVien, "Nhập Tên nhân viên!!!");
                check = false;
            }
            if (txt_SDT.Text == "")
            {
                errorProvider.SetError(txt_SDT, "Nhập số điện thoại nhân viên!!!");
                check = false;
            }
            if (txt_CMND.Text == "")
            {
                errorProvider.SetError(txt_CMND, "Nhập CMND của nhân viên!!!");
                check = false;
            }
            if (txt_Email.Text == "")
            {
                errorProvider.SetError(txt_Email, "Nhập email của nhân viên!!!");
                check = false;
            }
            if (cbb_BoPhan.Text == "")
            {
                errorProvider.SetError(cbb_BoPhan, "Nhập Bộ Phận hiện tại của nhân viên!!!");
                check = false;
            }
            if (txt_MaNhanVien.Visible == true)
            {
                if (txt_MaNhanVien.Text == "")
                {
                    errorProvider.SetError(txt_MaNhanVien, "Nhập Mã nhân viên!!!");
                    check = false;
                }

            }

            return check;
        }

        private void HienThiDanhSachNhanVien()
        {

            DataTable dt = NhanVienDAO.Instance.LayDanhSachNhanVien();
            dataGridView_NhanVien.DataSource = dt;
            dataGridView_NhanVien.ReadOnly = true;
            dataGridView_NhanVien.AllowUserToAddRows = false;
            dataGridView_NhanVien.Columns["MaNhanVien"].HeaderText = "Mã";
            dataGridView_NhanVien.Columns["HoTen"].HeaderText = "Họ tên";
            dataGridView_NhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dataGridView_NhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataGridView_NhanVien.Columns["DienThoai"].HeaderText = "Điện thoại";
            dataGridView_NhanVien.Columns["Email"].HeaderText = "Email";
            dataGridView_NhanVien.Columns["CMND"].HeaderText = "CMND";
            dataGridView_NhanVien.Columns["MaBoPhan"].HeaderText = "Mã bộ phận";
            dataGridView_NhanVien.Columns["MaTaiKhoan"].HeaderText = "Mã tài khoản";

            dataGridView_NhanVien.Columns["MaNhanVien"].DisplayIndex = 0;
            dataGridView_NhanVien.Columns["HoTen"].DisplayIndex = 1;
            dataGridView_NhanVien.Columns["NgaySinh"].DisplayIndex = 2;
            dataGridView_NhanVien.Columns["GioiTinh"].DisplayIndex = 3;
            dataGridView_NhanVien.Columns["DienThoai"].DisplayIndex = 4;
            dataGridView_NhanVien.Columns["Email"].DisplayIndex = 5;
            dataGridView_NhanVien.Columns["CMND"].DisplayIndex = 6;
            dataGridView_NhanVien.Columns["MaBoPhan"].DisplayIndex = 7;
            dataGridView_NhanVien.Columns["MaTaiKhoan"].DisplayIndex = 8;

            dataGridView_NhanVien.Columns[1].Width = 130;
            dataGridView_NhanVien.Columns[2].Width = 120;
            dataGridView_NhanVien.Columns[4].Width = 120;
            dataGridView_NhanVien.Columns[7].Width = 120;
            dataGridView_NhanVien.Columns[8].Width = 140;

        }

        private void HienThiDanhSachBoPhan()
        {
            DataTable dt = BoPhanDAO.Instance.LayDanhSachBoPhan();
            int i;
            string str;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                str = dt.Rows[i]["TenBoPhan"].ToString();
                cbb_BoPhan.Items.Add(str);
            }
            if (cbb_BoPhan.Items.Count > 0)
                cbb_BoPhan.SelectedIndex = 0;
        }

        private void HienThiThongTinChiTietNhanVien()
        {
            try
            {
                DataTable dt;
                dt = NhanVienDAO.Instance.LayDanhSachNhanVien();
                txt_TenNhanVien.Text = dataGridView_NhanVien.CurrentRow.Cells[1].Value.ToString();
                if (dataGridView_NhanVien.CurrentRow.Cells[2].Value.ToString() != "")
                    date_NgaySinh.Value = (DateTime)dataGridView_NhanVien.CurrentRow.Cells[2].Value;
                else
                    date_NgaySinh.Value = new DateTime(2000, 1, 1);
                txt_CMND.Text = dataGridView_NhanVien.CurrentRow.Cells[6].Value.ToString();
                txt_Email.Text = dataGridView_NhanVien.CurrentRow.Cells[5].Value.ToString();
                txt_SDT.Text = dataGridView_NhanVien.CurrentRow.Cells[4].Value.ToString();
                int MaBoPhan = (int)dataGridView_NhanVien.CurrentRow.Cells[7].Value;
                cbb_BoPhan.Text = BoPhanDAO.Instance.LayTenBoPhan(MaBoPhan);
                if (dataGridView_NhanVien.CurrentRow.Cells[3].Value.ToString() == "Nữ")
                {
                    radioButton_Nu.Checked = true;
                }
                else
                    radioButton_Nam.Checked = true;
                label_ma.Visible = true;
                txt_MaNhanVien.Visible = true;
                txt_MaNhanVien.Text = dataGridView_NhanVien.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Events
        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadForm();
            HienThiDanhSachBoPhan();
            HienThiDanhSachNhanVien();
            errorProvider.Clear();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {

                if (verif())
                {
                    string TenNhanVien = txt_TenNhanVien.Text;
                    DateTime NgaySinh = date_NgaySinh.Value;
                    string GioiTinh = "Nữ";
                    if (radioButton_Nam.Checked)
                    {
                        GioiTinh = "Nam";
                    }
                    string SoDienThoai = txt_SDT.Text;
                    string CMND = txt_CMND.Text;
                    string Email = txt_Email.Text;
                    string TenBoPhan = cbb_BoPhan.Text;
                    int MaBoPhan = BoPhanDAO.Instance.LayMaBoPhan(TenBoPhan);
                    if (!KhachHangDAO.Instance.EmailHopLe(Email))
                    {
                        MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return; 
                    }

                    if (MaBoPhan != -1)
                    {
                        if (NhanVienDAO.Instance.ThemNhanVien(TenNhanVien, NgaySinh, GioiTinh, SoDienThoai, Email, CMND, MaBoPhan))
                        {
                            MessageBox.Show("Thêm Nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormQuanLyNhanVien_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bộ phận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {

                if (verif())
                {
                    int MaNhanVien = Convert.ToInt32(txt_MaNhanVien.Text);
                    string TenNhanVien = txt_TenNhanVien.Text;
                    DateTime NgaySinh = date_NgaySinh.Value;
                    string GioiTinh = "Nữ";
                    if (radioButton_Nam.Checked)
                    {
                        GioiTinh = "Nam";
                    }
                    string SoDienThoai = txt_SDT.Text;
                    string CMND = txt_CMND.Text;
                    string Email = txt_Email.Text;
                    string TenBoPhan = cbb_BoPhan.Text;
                    int MaBoPhan = BoPhanDAO.Instance.LayMaBoPhan(TenBoPhan);
                    if (!KhachHangDAO.Instance.EmailHopLe(Email))
                    {
                        MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (MaBoPhan != -1)
                    {
                        if (NhanVienDAO.Instance.KiemTraMaNhanVien(MaNhanVien))
                        {
                            if (NhanVienDAO.Instance.SuaNhanVien(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, SoDienThoai, Email, CMND, MaBoPhan))
                            {
                                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormQuanLyNhanVien_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bộ phận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Moi_Click(object sender, EventArgs e)
        {
            LoadForm();
            HienThiDanhSachNhanVien();
            errorProvider.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaNhanVien.Text.Trim() != "")
                {
                    int MaNhanVien = Convert.ToInt32(txt_MaNhanVien.Text);
                    if (NhanVienDAO.Instance.KiemTraMaNhanVien(MaNhanVien))
                    {
                        if (MessageBox.Show("Bạn có muốn xóa Nhân Viên có mã: " + MaNhanVien + " không?", "Xóa Nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (NhanVienDAO.Instance.XoaNhanVien(MaNhanVien))
                            {
                                MessageBox.Show("Xóa nhân viên hoàn tất.", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormQuanLyNhanVien_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Nhân viên chưa được xóa!!", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xóa Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_NhanVien_DoubleClick(object sender, EventArgs e)
        {
            HienThiThongTinChiTietNhanVien();
        }
        #endregion

    }
}
