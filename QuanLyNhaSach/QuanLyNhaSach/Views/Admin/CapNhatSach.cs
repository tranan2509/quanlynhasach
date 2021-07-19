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

namespace QuanLyNhaSach
{
    public partial class CapNhatSach : Form
    {
        public CapNhatSach()
        {
            InitializeComponent();
        }
       
        private void HienThiDanhSach()
        {
            DataTable dt = DauSachDAO.Instance.LayDanhSachDauSachAdmin();
            dataGridView.DataSource = dt;
            dataGridView.ReadOnly = true;
            dataGridView.Columns["ISBN"].HeaderText = "Mã";
            dataGridView.Columns["TenDauSach"].HeaderText = "Tên đầu sách";
            dataGridView.Columns["GiaGoc"].HeaderText = "Giá gốc";
            dataGridView.Columns["GiaBia"].HeaderText = "Giá bìa";
            dataGridView.Columns["ISBN"].DisplayIndex = 0;
            dataGridView.Columns["TenDauSach"].DisplayIndex = 1;
            dataGridView.Columns["GiaGoc"].DisplayIndex = 2;
            dataGridView.Columns["GiaBia"].DisplayIndex = 3;
            dataGridView.Columns["ISBN"].Width = 70;
            dataGridView.Columns["TenDauSach"].Width = 140;
           

        }
        void loadform()
        {
            txt_Ten.Text = "";
            txt_ISBN.Text = "";
            txt_GiaGoc.Text = "";
            txt_GiaBia.Text = "";
            HienThiDanhSach();
        }
        bool verif()
        {
            bool check = true;
            if (txt_ISBN.Text == "")
            {
                errorProvider.SetError(txt_ISBN, "Nhập Mã Đầu Sách!!!");
                check = false;
            }
            if (txt_Ten.Text == "")
            {
                errorProvider.SetError(txt_Ten, "Nhập Tên đầu sách!!!");
                check = false;
            }
            return check;
        }
        private void CapNhatSach_Load(object sender, EventArgs e)
        {
            loadform();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if(verif())
                {
                    int MaSach = Convert.ToInt32(txt_ISBN.Text);
                    string TenSach = txt_Ten.Text;
                    float giaGoc = float.Parse(txt_GiaGoc.Text);
                    float GiaBia = float.Parse(txt_GiaBia.Text);
                    if(DauSachDAO.Instance.KiemTraMaISBN(MaSach))
                    {
                        if(DauSachDAO.Instance.CapNhatDauSachAdmin(MaSach, TenSach, giaGoc, GiaBia))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CapNhatSach_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Cập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            DataTable dt;
            dt = DauSachDAO.Instance.LayDanhSachDauSachAdmin();
            int isbn = (int)dataGridView.CurrentRow.Cells[0].Value;
            txt_ISBN.Text = isbn.ToString();
            txt_Ten.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_GiaGoc.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txt_GiaBia.Text= dataGridView.CurrentRow.Cells[3].Value.ToString();
        
        }
    }
}
