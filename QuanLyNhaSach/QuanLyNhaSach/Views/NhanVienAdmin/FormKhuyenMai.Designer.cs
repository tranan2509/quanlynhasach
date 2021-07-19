
namespace QuanLyNhaSach.Views.NhanVienAdmin
{
    partial class FormKhuyenMai
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhuyenMai));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel_Inf = new System.Windows.Forms.Panel();
            this.bnt_Moi = new System.Windows.Forms.Button();
            this.txt_DieuKien = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_TenKhuyenMai = new System.Windows.Forms.TextBox();
            this.txt_MucGiam = new System.Windows.Forms.TextBox();
            this.txt_MaKhuyenMai = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_ISBN = new System.Windows.Forms.ComboBox();
            this.cbb_DoiTuong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel_Inf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.panel_Inf);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 532);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(381, 30);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(759, 500);
            this.dataGridView.TabIndex = 31;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // panel_Inf
            // 
            this.panel_Inf.Controls.Add(this.bnt_Moi);
            this.panel_Inf.Controls.Add(this.txt_DieuKien);
            this.panel_Inf.Controls.Add(this.btn_update);
            this.panel_Inf.Controls.Add(this.btn_add);
            this.panel_Inf.Controls.Add(this.txt_TenKhuyenMai);
            this.panel_Inf.Controls.Add(this.txt_MucGiam);
            this.panel_Inf.Controls.Add(this.txt_MaKhuyenMai);
            this.panel_Inf.Controls.Add(this.dateTimePicker_NgayKetThuc);
            this.panel_Inf.Controls.Add(this.dateTimePicker_NgayBatDau);
            this.panel_Inf.Controls.Add(this.label9);
            this.panel_Inf.Controls.Add(this.label8);
            this.panel_Inf.Controls.Add(this.label7);
            this.panel_Inf.Controls.Add(this.label6);
            this.panel_Inf.Controls.Add(this.label1);
            this.panel_Inf.Controls.Add(this.cbb_ISBN);
            this.panel_Inf.Controls.Add(this.cbb_DoiTuong);
            this.panel_Inf.Controls.Add(this.label4);
            this.panel_Inf.Controls.Add(this.label3);
            this.panel_Inf.Controls.Add(this.label2);
            this.panel_Inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Inf.Location = new System.Drawing.Point(2, 30);
            this.panel_Inf.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Inf.Name = "panel_Inf";
            this.panel_Inf.Size = new System.Drawing.Size(375, 500);
            this.panel_Inf.TabIndex = 30;
            // 
            // bnt_Moi
            // 
            this.bnt_Moi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bnt_Moi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Moi.Location = new System.Drawing.Point(16, 380);
            this.bnt_Moi.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Moi.Name = "bnt_Moi";
            this.bnt_Moi.Size = new System.Drawing.Size(101, 32);
            this.bnt_Moi.TabIndex = 8;
            this.bnt_Moi.Text = "Mới";
            this.bnt_Moi.UseVisualStyleBackColor = false;
            this.bnt_Moi.Click += new System.EventHandler(this.bnt_Moi_Click);
            // 
            // txt_DieuKien
            // 
            this.txt_DieuKien.Location = new System.Drawing.Point(161, 190);
            this.txt_DieuKien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DieuKien.Name = "txt_DieuKien";
            this.txt_DieuKien.Size = new System.Drawing.Size(183, 26);
            this.txt_DieuKien.TabIndex = 4;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Aqua;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(248, 380);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 32);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(134, 380);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 32);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_TenKhuyenMai
            // 
            this.txt_TenKhuyenMai.Location = new System.Drawing.Point(161, 58);
            this.txt_TenKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenKhuyenMai.Name = "txt_TenKhuyenMai";
            this.txt_TenKhuyenMai.Size = new System.Drawing.Size(183, 26);
            this.txt_TenKhuyenMai.TabIndex = 1;
            // 
            // txt_MucGiam
            // 
            this.txt_MucGiam.Location = new System.Drawing.Point(161, 231);
            this.txt_MucGiam.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MucGiam.Name = "txt_MucGiam";
            this.txt_MucGiam.Size = new System.Drawing.Size(183, 26);
            this.txt_MucGiam.TabIndex = 5;
            // 
            // txt_MaKhuyenMai
            // 
            this.txt_MaKhuyenMai.Location = new System.Drawing.Point(161, 14);
            this.txt_MaKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaKhuyenMai.Name = "txt_MaKhuyenMai";
            this.txt_MaKhuyenMai.Size = new System.Drawing.Size(183, 26);
            this.txt_MaKhuyenMai.TabIndex = 0;
            // 
            // dateTimePicker_NgayKetThuc
            // 
            this.dateTimePicker_NgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayKetThuc.Location = new System.Drawing.Point(159, 324);
            this.dateTimePicker_NgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_NgayKetThuc.Name = "dateTimePicker_NgayKetThuc";
            this.dateTimePicker_NgayKetThuc.Size = new System.Drawing.Size(185, 26);
            this.dateTimePicker_NgayKetThuc.TabIndex = 7;
            // 
            // dateTimePicker_NgayBatDau
            // 
            this.dateTimePicker_NgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayBatDau.Location = new System.Drawing.Point(161, 277);
            this.dateTimePicker_NgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_NgayBatDau.Name = "dateTimePicker_NgayBatDau";
            this.dateTimePicker_NgayBatDau.Size = new System.Drawing.Size(183, 26);
            this.dateTimePicker_NgayBatDau.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 329);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày kết thúc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 282);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày bắt đầu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mức giảm(%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điều kiện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã cuốn Sách:";
            // 
            // cbb_ISBN
            // 
            this.cbb_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ISBN.FormattingEnabled = true;
            this.cbb_ISBN.Location = new System.Drawing.Point(161, 147);
            this.cbb_ISBN.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_ISBN.Name = "cbb_ISBN";
            this.cbb_ISBN.Size = new System.Drawing.Size(183, 28);
            this.cbb_ISBN.TabIndex = 3;
            // 
            // cbb_DoiTuong
            // 
            this.cbb_DoiTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_DoiTuong.FormattingEnabled = true;
            this.cbb_DoiTuong.Location = new System.Drawing.Point(161, 100);
            this.cbb_DoiTuong.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_DoiTuong.Name = "cbb_DoiTuong";
            this.cbb_DoiTuong.Size = new System.Drawing.Size(183, 28);
            this.cbb_DoiTuong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đối tượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khuyến mãi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khuyến mãi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "KHUYẾN MÃI";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormKhuyenMai
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
            this.Name = "FormKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhuyenMai";
            this.Load += new System.EventHandler(this.FormKhuyenMai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel_Inf.ResumeLayout(false);
            this.panel_Inf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_Inf;
        private System.Windows.Forms.Button bnt_Moi;
        private System.Windows.Forms.TextBox txt_DieuKien;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_TenKhuyenMai;
        private System.Windows.Forms.TextBox txt_MucGiam;
        private System.Windows.Forms.TextBox txt_MaKhuyenMai;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBatDau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_ISBN;
        private System.Windows.Forms.ComboBox cbb_DoiTuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}