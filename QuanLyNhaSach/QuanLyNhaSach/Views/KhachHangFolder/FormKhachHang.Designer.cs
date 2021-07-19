
namespace QuanLyNhaSach.Views.KhachHangFolder
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.pnlThongTinNhanVien = new System.Windows.Forms.Panel();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTrangChu = new System.Windows.Forms.MenuStrip();
            this.giỏHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlThongTinNhanVien.SuspendLayout();
            this.menuStripTrangChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbTenKhachHang.Location = new System.Drawing.Point(19, 16);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(405, 42);
            this.lbTenKhachHang.TabIndex = 0;
            this.lbTenKhachHang.Text = "Hoàng Thái Như Quỳnh";
            // 
            // pnlThongTinNhanVien
            // 
            this.pnlThongTinNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.pnlThongTinNhanVien.Controls.Add(this.lbChucVu);
            this.pnlThongTinNhanVien.Controls.Add(this.lbTenKhachHang);
            this.pnlThongTinNhanVien.Location = new System.Drawing.Point(0, 27);
            this.pnlThongTinNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThongTinNhanVien.Name = "pnlThongTinNhanVien";
            this.pnlThongTinNhanVien.Size = new System.Drawing.Size(1184, 110);
            this.pnlThongTinNhanVien.TabIndex = 4;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.ForeColor = System.Drawing.Color.White;
            this.lbChucVu.Location = new System.Drawing.Point(22, 63);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(191, 23);
            this.lbChucVu.TabIndex = 1;
            this.lbChucVu.Text = "Khách hàng | Mã: 001";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(204, 26);
            this.toolStripMenuItem4.Text = "Đăng xuất";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // thongTinCaNhanToolStripMenuItem
            // 
            this.thongTinCaNhanToolStripMenuItem.Name = "thongTinCaNhanToolStripMenuItem";
            this.thongTinCaNhanToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.thongTinCaNhanToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thongTinCaNhanToolStripMenuItem.Click += new System.EventHandler(this.thongTinCaNhanToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinCaNhanToolStripMenuItem,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 25);
            this.toolStripMenuItem2.Text = "Tài khoản";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // menuStripTrangChu
            // 
            this.menuStripTrangChu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.giỏHàngToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStripTrangChu.Location = new System.Drawing.Point(0, 0);
            this.menuStripTrangChu.Name = "menuStripTrangChu";
            this.menuStripTrangChu.Size = new System.Drawing.Size(1184, 29);
            this.menuStripTrangChu.TabIndex = 3;
            this.menuStripTrangChu.Text = "Trang chủ";
            // 
            // giỏHàngToolStripMenuItem
            // 
            this.giỏHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giỏHàngToolStripMenuItem.Name = "giỏHàngToolStripMenuItem";
            this.giỏHàngToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.giỏHàngToolStripMenuItem.Text = "Giỏ hàng";
            this.giỏHàngToolStripMenuItem.Click += new System.EventHandler(this.giỏHàngToolStripMenuItem_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.White;
            this.pnlChildForm.Location = new System.Drawing.Point(2, 140);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1180, 570);
            this.pnlChildForm.TabIndex = 5;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.pnlThongTinNhanVien);
            this.Controls.Add(this.menuStripTrangChu);
            this.Controls.Add(this.pnlChildForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.pnlThongTinNhanVien.ResumeLayout(false);
            this.pnlThongTinNhanVien.PerformLayout();
            this.menuStripTrangChu.ResumeLayout(false);
            this.menuStripTrangChu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.Panel pnlThongTinNhanVien;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem thongTinCaNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripTrangChu;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.ToolStripMenuItem giỏHàngToolStripMenuItem;
    }
}