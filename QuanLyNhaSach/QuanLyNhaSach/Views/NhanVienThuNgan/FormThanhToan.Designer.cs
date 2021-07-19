
namespace QuanLyNhaSach.Views.NhanVienThuNgan
{
    partial class FormThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan));
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.ckbDiemTichLuy = new System.Windows.Forms.CheckBox();
            this.lbThongTinSoLuongSach = new System.Windows.Forms.Label();
            this.lbThongTinKhuyenMaiSach = new System.Windows.Forms.Label();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.txtMaKhuyenMaiSach = new System.Windows.Forms.TextBox();
            this.lb20 = new System.Windows.Forms.Label();
            this.dtgvDauSach = new System.Windows.Forms.DataGridView();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.liTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.liSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.liDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.liGiamGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.liThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.btnHoaDonMoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbThongTinKhuyenMai = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(428, 25);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(131, 26);
            this.txtThanhTien.TabIndex = 2;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckbDiemTichLuy
            // 
            this.ckbDiemTichLuy.AutoSize = true;
            this.ckbDiemTichLuy.Location = new System.Drawing.Point(262, 90);
            this.ckbDiemTichLuy.Name = "ckbDiemTichLuy";
            this.ckbDiemTichLuy.Size = new System.Drawing.Size(117, 24);
            this.ckbDiemTichLuy.TabIndex = 25;
            this.ckbDiemTichLuy.Text = "Điểm tích lũy";
            this.ckbDiemTichLuy.UseVisualStyleBackColor = true;
            this.ckbDiemTichLuy.CheckedChanged += new System.EventHandler(this.ckbDiemTichLuy_CheckedChanged);
            // 
            // lbThongTinSoLuongSach
            // 
            this.lbThongTinSoLuongSach.AutoSize = true;
            this.lbThongTinSoLuongSach.Location = new System.Drawing.Point(258, 124);
            this.lbThongTinSoLuongSach.Name = "lbThongTinSoLuongSach";
            this.lbThongTinSoLuongSach.Size = new System.Drawing.Size(177, 20);
            this.lbThongTinSoLuongSach.TabIndex = 23;
            this.lbThongTinSoLuongSach.Text = "Thông tin số lượng sách";
            // 
            // lbThongTinKhuyenMaiSach
            // 
            this.lbThongTinKhuyenMaiSach.AutoSize = true;
            this.lbThongTinKhuyenMaiSach.Location = new System.Drawing.Point(258, 155);
            this.lbThongTinKhuyenMaiSach.Name = "lbThongTinKhuyenMaiSach";
            this.lbThongTinKhuyenMaiSach.Size = new System.Drawing.Size(159, 20);
            this.lbThongTinKhuyenMaiSach.TabIndex = 22;
            this.lbThongTinKhuyenMaiSach.Text = "Thông tin khuyến mãi";
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Location = new System.Drawing.Point(258, 59);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(123, 20);
            this.lbTenKhachHang.TabIndex = 21;
            this.lbTenKhachHang.Text = "Tên khách hàng";
            // 
            // txtMaKhuyenMaiSach
            // 
            this.txtMaKhuyenMaiSach.Location = new System.Drawing.Point(167, 152);
            this.txtMaKhuyenMaiSach.Name = "txtMaKhuyenMaiSach";
            this.txtMaKhuyenMaiSach.Size = new System.Drawing.Size(85, 26);
            this.txtMaKhuyenMaiSach.TabIndex = 19;
            this.txtMaKhuyenMaiSach.TextChanged += new System.EventHandler(this.txtMaKhuyenMaiSach_TextChanged);
            // 
            // lb20
            // 
            this.lb20.AutoSize = true;
            this.lb20.Location = new System.Drawing.Point(47, 155);
            this.lb20.Name = "lb20";
            this.lb20.Size = new System.Drawing.Size(98, 20);
            this.lb20.TabIndex = 20;
            this.lb20.Text = "Mã giảm giá:";
            // 
            // dtgvDauSach
            // 
            this.dtgvDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDauSach.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDauSach.Location = new System.Drawing.Point(4, 243);
            this.dtgvDauSach.Name = "dtgvDauSach";
            this.dtgvDauSach.Size = new System.Drawing.Size(450, 293);
            this.dtgvDauSach.TabIndex = 18;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(167, 56);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(85, 26);
            this.txtMaKhachHang.TabIndex = 16;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã khách hàng:";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(9, 28);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(108, 26);
            this.txtMaKhuyenMai.TabIndex = 0;
            this.txtMaKhuyenMai.TextChanged += new System.EventHandler(this.txtMaKhuyenMai_TextChanged);
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.liTenSach,
            this.liSoLuong,
            this.liDonGia,
            this.liGiamGia,
            this.liThanhTien});
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(495, 16);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(668, 472);
            this.lsvHoaDon.TabIndex = 14;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // liTenSach
            // 
            this.liTenSach.Text = "Tên Sách";
            this.liTenSach.Width = 261;
            // 
            // liSoLuong
            // 
            this.liSoLuong.Text = "Số Lượng";
            this.liSoLuong.Width = 88;
            // 
            // liDonGia
            // 
            this.liDonGia.Text = "Giá";
            this.liDonGia.Width = 94;
            // 
            // liGiamGia
            // 
            this.liGiamGia.Text = "Giảm Giá";
            this.liGiamGia.Width = 104;
            // 
            // liThanhTien
            // 
            this.liThanhTien.Text = "Thành Tiền";
            this.liThanhTien.Width = 117;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(167, 88);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(85, 26);
            this.txtISBN.TabIndex = 10;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(47, 91);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(89, 20);
            this.ISBN.TabIndex = 11;
            this.ISBN.Text = "ISBN sách:";
            // 
            // btnHoaDonMoi
            // 
            this.btnHoaDonMoi.BackColor = System.Drawing.Color.Teal;
            this.btnHoaDonMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonMoi.ForeColor = System.Drawing.Color.White;
            this.btnHoaDonMoi.Location = new System.Drawing.Point(84, 202);
            this.btnHoaDonMoi.Name = "btnHoaDonMoi";
            this.btnHoaDonMoi.Size = new System.Drawing.Size(129, 32);
            this.btnHoaDonMoi.TabIndex = 15;
            this.btnHoaDonMoi.Text = "Hóa đơn mới";
            this.btnHoaDonMoi.UseCompatibleTextRendering = true;
            this.btnHoaDonMoi.UseVisualStyleBackColor = false;
            this.btnHoaDonMoi.Click += new System.EventHandler(this.btnHoaDonMoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "THÔNG TIN MUA HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã giảm giá:";
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(167, 122);
            this.nmSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmSoLuong.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(85, 26);
            this.nmSoLuong.TabIndex = 13;
            this.nmSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.ValueChanged += new System.EventHandler(this.nmSoLuong_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng:";
            // 
            // lbThongTinKhuyenMai
            // 
            this.lbThongTinKhuyenMai.AutoSize = true;
            this.lbThongTinKhuyenMai.ForeColor = System.Drawing.Color.Green;
            this.lbThongTinKhuyenMai.Location = new System.Drawing.Point(128, 31);
            this.lbThongTinKhuyenMai.Name = "lbThongTinKhuyenMai";
            this.lbThongTinKhuyenMai.Size = new System.Drawing.Size(109, 20);
            this.lbThongTinKhuyenMai.TabIndex = 9;
            this.lbThongTinKhuyenMai.Text = "Chưa áp dụng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Green;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(565, 8);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(100, 46);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseCompatibleTextRendering = true;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thông tin giảm giá:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbThongTinKhuyenMai);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaKhuyenMai);
            this.panel1.Location = new System.Drawing.Point(494, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 61);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thành tiền:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(219, 202);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 32);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseCompatibleTextRendering = true;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckbDiemTichLuy);
            this.panel2.Controls.Add(this.lbThongTinSoLuongSach);
            this.panel2.Controls.Add(this.lbThongTinKhuyenMaiSach);
            this.panel2.Controls.Add(this.lbTenKhachHang);
            this.panel2.Controls.Add(this.txtMaKhuyenMaiSach);
            this.panel2.Controls.Add(this.lb20);
            this.panel2.Controls.Add(this.dtgvDauSach);
            this.panel2.Controls.Add(this.txtMaKhachHang);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtISBN);
            this.panel2.Controls.Add(this.ISBN);
            this.panel2.Controls.Add(this.btnHoaDonMoi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nmSoLuong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(18, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 539);
            this.panel2.TabIndex = 16;
            // 
            // FormThanhToan
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 570);
            this.Controls.Add(this.lsvHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThanhToan";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.CheckBox ckbDiemTichLuy;
        private System.Windows.Forms.Label lbThongTinSoLuongSach;
        private System.Windows.Forms.Label lbThongTinKhuyenMaiSach;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.TextBox txtMaKhuyenMaiSach;
        private System.Windows.Forms.Label lb20;
        private System.Windows.Forms.DataGridView dtgvDauSach;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKhuyenMai;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader liTenSach;
        private System.Windows.Forms.ColumnHeader liSoLuong;
        private System.Windows.Forms.ColumnHeader liDonGia;
        private System.Windows.Forms.ColumnHeader liGiamGia;
        private System.Windows.Forms.ColumnHeader liThanhTien;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Button btnHoaDonMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbThongTinKhuyenMai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
    }
}