
namespace QuanLyNhaSach.Views.KhachHangFolder
{
    partial class FormQuanLyGioHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyGioHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvGioHang = new System.Windows.Forms.DataGridView();
            this.pnlChildThongTinSach = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCuonSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.pnlChildLichSuMuaHang = new System.Windows.Forms.Panel();
            this.pnlLichSuMuaHang = new System.Windows.Forms.Panel();
            this.btnLichSuMuaHang = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMuaHang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGioHang)).BeginInit();
            this.pnlChildThongTinSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.pnlChildLichSuMuaHang.SuspendLayout();
            this.pnlLichSuMuaHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgvGioHang);
            this.panel1.Controls.Add(this.pnlChildThongTinSach);
            this.panel1.Controls.Add(this.pnlChildLichSuMuaHang);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 532);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(897, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "THÔNG TIN SÁCH";
            // 
            // dtgvGioHang
            // 
            this.dtgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dtgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGioHang.Location = new System.Drawing.Point(0, 44);
            this.dtgvGioHang.Name = "dtgvGioHang";
            this.dtgvGioHang.Size = new System.Drawing.Size(852, 159);
            this.dtgvGioHang.TabIndex = 28;
            this.dtgvGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGioHang_CellClick);
            // 
            // pnlChildThongTinSach
            // 
            this.pnlChildThongTinSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChildThongTinSach.Controls.Add(this.btnMuaHang);
            this.pnlChildThongTinSach.Controls.Add(this.btnXoa);
            this.pnlChildThongTinSach.Controls.Add(this.btnCapNhat);
            this.pnlChildThongTinSach.Controls.Add(this.nmSoLuong);
            this.pnlChildThongTinSach.Controls.Add(this.label2);
            this.pnlChildThongTinSach.Controls.Add(this.txtTenCuonSach);
            this.pnlChildThongTinSach.Controls.Add(this.label3);
            this.pnlChildThongTinSach.Controls.Add(this.label7);
            this.pnlChildThongTinSach.Controls.Add(this.txtISBN);
            this.pnlChildThongTinSach.Location = new System.Drawing.Point(858, 44);
            this.pnlChildThongTinSach.Name = "pnlChildThongTinSach";
            this.pnlChildThongTinSach.Size = new System.Drawing.Size(281, 485);
            this.pnlChildThongTinSach.TabIndex = 30;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(16, 217);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 31, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 35);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Black;
            this.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(144, 217);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 35);
            this.btnCapNhat.TabIndex = 32;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(8, 164);
            this.nmSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(267, 26);
            this.nmSoLuong.TabIndex = 31;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Số lượng:";
            // 
            // txtTenCuonSach
            // 
            this.txtTenCuonSach.BackColor = System.Drawing.Color.White;
            this.txtTenCuonSach.Location = new System.Drawing.Point(8, 97);
            this.txtTenCuonSach.Name = "txtTenCuonSach";
            this.txtTenCuonSach.ReadOnly = true;
            this.txtTenCuonSach.Size = new System.Drawing.Size(268, 26);
            this.txtTenCuonSach.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên cuốn sách: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.White;
            this.txtISBN.Location = new System.Drawing.Point(8, 33);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(268, 26);
            this.txtISBN.TabIndex = 0;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // pnlChildLichSuMuaHang
            // 
            this.pnlChildLichSuMuaHang.Controls.Add(this.pnlLichSuMuaHang);
            this.pnlChildLichSuMuaHang.Location = new System.Drawing.Point(0, 209);
            this.pnlChildLichSuMuaHang.Name = "pnlChildLichSuMuaHang";
            this.pnlChildLichSuMuaHang.Size = new System.Drawing.Size(852, 320);
            this.pnlChildLichSuMuaHang.TabIndex = 29;
            // 
            // pnlLichSuMuaHang
            // 
            this.pnlLichSuMuaHang.Controls.Add(this.btnLichSuMuaHang);
            this.pnlLichSuMuaHang.Location = new System.Drawing.Point(679, 282);
            this.pnlLichSuMuaHang.Name = "pnlLichSuMuaHang";
            this.pnlLichSuMuaHang.Size = new System.Drawing.Size(175, 35);
            this.pnlLichSuMuaHang.TabIndex = 31;
            // 
            // btnLichSuMuaHang
            // 
            this.btnLichSuMuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLichSuMuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuMuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuMuaHang.ForeColor = System.Drawing.Color.White;
            this.btnLichSuMuaHang.Location = new System.Drawing.Point(3, 2);
            this.btnLichSuMuaHang.Name = "btnLichSuMuaHang";
            this.btnLichSuMuaHang.Size = new System.Drawing.Size(170, 32);
            this.btnLichSuMuaHang.TabIndex = 0;
            this.btnLichSuMuaHang.Text = "Lịch sử mua hàng";
            this.btnLichSuMuaHang.UseVisualStyleBackColor = false;
            this.btnLichSuMuaHang.Click += new System.EventHandler(this.btnLichSuMuaHang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "GIỎ HÀNG";
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMuaHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaHang.ForeColor = System.Drawing.Color.White;
            this.btnMuaHang.Location = new System.Drawing.Point(144, 262);
            this.btnMuaHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(120, 35);
            this.btnMuaHang.TabIndex = 34;
            this.btnMuaHang.Text = "Mua hàng";
            this.btnMuaHang.UseVisualStyleBackColor = false;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // FormQuanLyGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 570);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQuanLyGioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyGioHang";
            this.Load += new System.EventHandler(this.FormQuanLyGioHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGioHang)).EndInit();
            this.pnlChildThongTinSach.ResumeLayout(false);
            this.pnlChildThongTinSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.pnlChildLichSuMuaHang.ResumeLayout(false);
            this.pnlLichSuMuaHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvGioHang;
        private System.Windows.Forms.Panel pnlChildThongTinSach;
        private System.Windows.Forms.Panel pnlChildLichSuMuaHang;
        private System.Windows.Forms.Button btnLichSuMuaHang;
        private System.Windows.Forms.Panel pnlLichSuMuaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCuonSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnMuaHang;
    }
}