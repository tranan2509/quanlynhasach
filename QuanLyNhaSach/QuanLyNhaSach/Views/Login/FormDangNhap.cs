using QuanLyNhaSach.DAO;
using QuanLyNhaSach.Model;
using QuanLyNhaSach.Views.KhachHangFolder;
using QuanLyNhaSach.Views.NhanVienAdmin;
using QuanLyNhaSach.Views.NhanVienQuanLyKho;
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

namespace QuanLyNhaSach.Views.Login
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }


        #region Method
        void LoadForm()
        {

        }
        #endregion

        #region Events

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            PasswordTextbox.UseSystemPasswordChar = !PasswordTextbox.UseSystemPasswordChar;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTextbox.Text;
                string password = PasswordTextbox.Text;

                if (username.Trim() == "" || password.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String command = "SELECT * from dbo.loginTaiKhoan('" + username + "', '" + password + "');";

                    DataTable thongTin = DataProvider.Instance.ExecuteQuery(command);//DAO.My_DB.Instance.Execute(command);
                    if (thongTin.Rows.Count > 0)
                    {
                        usernameTextbox.Text = "";
                        PasswordTextbox.Text = "";
                        globalUser.userid = Int32.Parse(thongTin.Rows[0]["MaNguoiDung"].ToString());
                        globalUser.maBoPhan = Int32.Parse(thongTin.Rows[0]["MaBoPhan"].ToString());
                        globalUser.maTaiKhoan = thongTin.Rows[0]["MaTaiKhoan"].ToString();

                        if (globalUser.maBoPhan == 1)
                        {
                            //MessageBox.Show("Đăng nhập khách hangg", "Đăng nhập");
                            KhachHang kh = KhachHangDAO.Instance.LayThongTinKhachHang(globalUser.userid);
                            FormKhachHang fKhachHang = new FormKhachHang(kh);
                            this.Hide();
                            fKhachHang.ShowDialog(this);
                            this.Show();
                            //Chuyển tới form khách hàng
                        }
                        else if (globalUser.maBoPhan == 2)
                        {
                            this.Hide();
                            NhanVien NV = NhanVienDAO.Instance.LayNhanVienTheoMaNhanVien(globalUser.userid);
                            //QuanLiForm adminForm = new QuanLiForm(NV);
                            AdminForm adminForm = new AdminForm(NV);
                            adminForm.ShowDialog();
                            this.Show();
                        }
                        else if (globalUser.maBoPhan == 3)
                        {
                            //MessageBox.Show("Đăng nhập bộ phận" + globalUser.maBoPhan, "Đăng nhập");
                            NhanVien NV = NhanVienDAO.Instance.LayNhanVienTheoMaNhanVien(globalUser.userid);
                            FormNhanVienThuNgan fNVThuNgan = new FormNhanVienThuNgan(NV);
                            this.Hide();
                            fNVThuNgan.ShowDialog(this);
                            this.Show();
                        }
                        else if (globalUser.maBoPhan == 4)
                        {
                            NhanVien NV = NhanVienDAO.Instance.LayNhanVienTheoMaNhanVien(globalUser.userid);
                            FormNhanVienQuanLyKho fNVQuanLyKho = new FormNhanVienQuanLyKho(NV);
                            this.Hide();
                            fNVQuanLyKho.ShowDialog(this);
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}
