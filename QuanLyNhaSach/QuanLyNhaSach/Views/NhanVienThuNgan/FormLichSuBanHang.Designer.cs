
namespace QuanLyNhaSach.Views.NhanVienThuNgan
{
    partial class FormLichSuBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLichSuBanHang));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlChildChiTietLichSuBanHang = new System.Windows.Forms.Panel();
            this.dtgvLichSuMuaHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "LỊCH SỬ BÁN HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(783, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 34);
            this.panel1.TabIndex = 16;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(85, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(294, 26);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvLichSuMuaHang);
            this.panel2.Controls.Add(this.pnlChildChiTietLichSuBanHang);
            this.panel2.Location = new System.Drawing.Point(19, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 486);
            this.panel2.TabIndex = 18;
            // 
            // pnlChildChiTietLichSuBanHang
            // 
            this.pnlChildChiTietLichSuBanHang.Location = new System.Drawing.Point(0, 246);
            this.pnlChildChiTietLichSuBanHang.Name = "pnlChildChiTietLichSuBanHang";
            this.pnlChildChiTietLichSuBanHang.Size = new System.Drawing.Size(1142, 240);
            this.pnlChildChiTietLichSuBanHang.TabIndex = 2;
            // 
            // dtgvLichSuMuaHang
            // 
            this.dtgvLichSuMuaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLichSuMuaHang.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLichSuMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLichSuMuaHang.Location = new System.Drawing.Point(0, 0);
            this.dtgvLichSuMuaHang.Margin = new System.Windows.Forms.Padding(0);
            this.dtgvLichSuMuaHang.Name = "dtgvLichSuMuaHang";
            this.dtgvLichSuMuaHang.Size = new System.Drawing.Size(1142, 486);
            this.dtgvLichSuMuaHang.TabIndex = 2;
            this.dtgvLichSuMuaHang.DoubleClick += new System.EventHandler(this.dtgvLichSuMuaHang_DoubleClick_1);
            // 
            // FormLichSuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 570);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLichSuBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lịch sử bán hàng";
            this.Load += new System.EventHandler(this.FormLichSuBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuMuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlChildChiTietLichSuBanHang;
        private System.Windows.Forms.DataGridView dtgvLichSuMuaHang;
    }
}