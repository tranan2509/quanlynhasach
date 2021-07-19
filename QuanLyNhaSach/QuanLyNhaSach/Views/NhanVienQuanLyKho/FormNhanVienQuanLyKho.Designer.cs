
namespace QuanLyNhaSach.Views.NhanVienQuanLyKho
{
    partial class FormNhanVienQuanLyKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVienQuanLyKho));
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.pnlThongTinNhanVien = new System.Windows.Forms.Panel();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTinCaNhantoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTrangChu = new System.Windows.Forms.MenuStrip();
            this.khoHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlThongTinNhanVien.SuspendLayout();
            this.menuStripTrangChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.White;
            this.lbTenNhanVien.Location = new System.Drawing.Point(19, 16);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(285, 42);
            this.lbTenNhanVien.TabIndex = 0;
            this.lbTenNhanVien.Text = "Nguyễn Phan Sự";
            // 
            // pnlThongTinNhanVien
            // 
            this.pnlThongTinNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.pnlThongTinNhanVien.Controls.Add(this.lbChucVu);
            this.pnlThongTinNhanVien.Controls.Add(this.lbTenNhanVien);
            this.pnlThongTinNhanVien.Location = new System.Drawing.Point(0, 27);
            this.pnlThongTinNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThongTinNhanVien.Name = "pnlThongTinNhanVien";
            this.pnlThongTinNhanVien.Size = new System.Drawing.Size(1184, 110);
            this.pnlThongTinNhanVien.TabIndex = 7;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.ForeColor = System.Drawing.Color.White;
            this.lbChucVu.Location = new System.Drawing.Point(22, 63);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(195, 23);
            this.lbChucVu.TabIndex = 1;
            this.lbChucVu.Text = "Quản lý kho | Mã: 001";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(204, 26);
            this.toolStripMenuItem4.Text = "Đăng xuất";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // ThongTinCaNhantoolStripMenuItem
            // 
            this.ThongTinCaNhantoolStripMenuItem.Name = "ThongTinCaNhantoolStripMenuItem";
            this.ThongTinCaNhantoolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.ThongTinCaNhantoolStripMenuItem.Text = "Thông tin cá nhân";
            this.ThongTinCaNhantoolStripMenuItem.Click += new System.EventHandler(this.ThongTinCaNhantoolStripMenuItem_Click);
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongTinCaNhantoolStripMenuItem,
            this.toolStripMenuItem4});
            this.taiKhoanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.taiKhoanToolStripMenuItem.Text = "Tài khoản";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // menuStripTrangChu
            // 
            this.menuStripTrangChu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.khoHangToolStripMenuItem,
            this.taiKhoanToolStripMenuItem});
            this.menuStripTrangChu.Location = new System.Drawing.Point(0, 0);
            this.menuStripTrangChu.Name = "menuStripTrangChu";
            this.menuStripTrangChu.Size = new System.Drawing.Size(1184, 29);
            this.menuStripTrangChu.TabIndex = 6;
            this.menuStripTrangChu.Text = "Trang chủ";
            // 
            // khoHangToolStripMenuItem
            // 
            this.khoHangToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoHangToolStripMenuItem.Name = "khoHangToolStripMenuItem";
            this.khoHangToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.khoHangToolStripMenuItem.Text = "Kho hàng";
            this.khoHangToolStripMenuItem.Click += new System.EventHandler(this.khoHangToolStripMenuItem_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.White;
            this.pnlChildForm.Location = new System.Drawing.Point(2, 140);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1180, 570);
            this.pnlChildForm.TabIndex = 8;
            // 
            // FormNhanVienQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.pnlThongTinNhanVien);
            this.Controls.Add(this.menuStripTrangChu);
            this.Controls.Add(this.pnlChildForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNhanVienQuanLyKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.FormNhanVienQuanLyKho_Load);
            this.pnlThongTinNhanVien.ResumeLayout(false);
            this.pnlThongTinNhanVien.PerformLayout();
            this.menuStripTrangChu.ResumeLayout(false);
            this.menuStripTrangChu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Panel pnlThongTinNhanVien;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ThongTinCaNhantoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripTrangChu;
        private System.Windows.Forms.ToolStripMenuItem khoHangToolStripMenuItem;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}