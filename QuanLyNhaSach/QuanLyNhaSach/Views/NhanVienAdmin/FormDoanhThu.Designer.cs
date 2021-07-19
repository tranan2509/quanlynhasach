
namespace QuanLyNhaSach.Views.KhachHangFolder
{
    partial class FormDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoanhThu));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.dateTime_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateTime_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_DonhThu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonhThu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "DOANH THU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView_DonhThu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 532);
            this.panel1.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Black;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(737, 3);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 27);
            this.btn_search.TabIndex = 37;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Từ:";
            // 
            // cbb_loai
            // 
            this.cbb_loai.FormattingEnabled = true;
            this.cbb_loai.Items.AddRange(new object[] {
            "Ngày",
            "Tháng"});
            this.cbb_loai.Location = new System.Drawing.Point(132, 2);
            this.cbb_loai.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(104, 28);
            this.cbb_loai.TabIndex = 35;
            // 
            // dateTime_NgayKetThuc
            // 
            this.dateTime_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_NgayKetThuc.Location = new System.Drawing.Point(528, 2);
            this.dateTime_NgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_NgayKetThuc.Name = "dateTime_NgayKetThuc";
            this.dateTime_NgayKetThuc.Size = new System.Drawing.Size(107, 26);
            this.dateTime_NgayKetThuc.TabIndex = 34;
            // 
            // dateTime_NgayBatDau
            // 
            this.dateTime_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_NgayBatDau.Location = new System.Drawing.Point(355, 3);
            this.dateTime_NgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_NgayBatDau.Name = "dateTime_NgayBatDau";
            this.dateTime_NgayBatDau.Size = new System.Drawing.Size(107, 26);
            this.dateTime_NgayBatDau.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Loại thống kê:";
            // 
            // dataGridView_DonhThu
            // 
            this.dataGridView_DonhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DonhThu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DonhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DonhThu.Location = new System.Drawing.Point(2, 71);
            this.dataGridView_DonhThu.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_DonhThu.Name = "dataGridView_DonhThu";
            this.dataGridView_DonhThu.RowHeadersWidth = 51;
            this.dataGridView_DonhThu.RowTemplate.Height = 24;
            this.dataGridView_DonhThu.Size = new System.Drawing.Size(1138, 459);
            this.dataGridView_DonhThu.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbb_loai);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTime_NgayKetThuc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTime_NgayBatDau);
            this.panel2.Location = new System.Drawing.Point(3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 35);
            this.panel2.TabIndex = 38;
            // 
            // FormDoanhThu
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
            this.Name = "FormDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoanhThu";
            this.Load += new System.EventHandler(this.FormDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonhThu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.DateTimePicker dateTime_NgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateTime_NgayBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_DonhThu;
        private System.Windows.Forms.Panel panel2;
    }
}