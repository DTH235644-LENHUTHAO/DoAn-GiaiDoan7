namespace QuanLyQuanKaraoke.Forms
{
    partial class frmHoaDon
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
            groupBox1 = new GroupBox();
            txtNhanVien = new TextBox();
            label11 = new Label();
            txtThoiGianKetThuc = new TextBox();
            label4 = new Label();
            txtThoiGianBatDau = new TextBox();
            label3 = new Label();
            txtKhachHang = new TextBox();
            label2 = new Label();
            txtPhong = new TextBox();
            label1 = new Label();
            btnThoat = new Button();
            btnLuu = new Button();
            btnTinhTien = new Button();
            groupBox2 = new GroupBox();
            txtTienGiam = new TextBox();
            label10 = new Label();
            txtTongTien = new TextBox();
            label9 = new Label();
            txtGiamGia = new TextBox();
            label7 = new Label();
            cboKhuyenMai = new ComboBox();
            txtTienDV = new TextBox();
            label5 = new Label();
            txtTienPhong = new TextBox();
            label6 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            DatPhongID = new DataGridViewTextBoxColumn();
            DichVuID = new DataGridViewTextBoxColumn();
            TenDV = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNhanVien);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtThoiGianKetThuc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtThoiGianBatDau);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtKhachHang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPhong);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1755, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // txtNhanVien
            // 
            txtNhanVien.Location = new Point(1275, 56);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.Size = new Size(290, 44);
            txtNhanVien.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1044, 64);
            label11.Name = "label11";
            label11.Size = new Size(225, 36);
            label11.TabIndex = 11;
            label11.Text = "Nhân viên lập :";
            // 
            // txtThoiGianKetThuc
            // 
            txtThoiGianKetThuc.Location = new Point(341, 230);
            txtThoiGianKetThuc.Name = "txtThoiGianKetThuc";
            txtThoiGianKetThuc.Size = new Size(636, 44);
            txtThoiGianKetThuc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 238);
            label4.Name = "label4";
            label4.Size = new Size(286, 36);
            label4.TabIndex = 6;
            label4.Text = "Thời gian kết thúc :";
            // 
            // txtThoiGianBatDau
            // 
            txtThoiGianBatDau.Location = new Point(341, 153);
            txtThoiGianBatDau.Name = "txtThoiGianBatDau";
            txtThoiGianBatDau.Size = new Size(636, 44);
            txtThoiGianBatDau.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 161);
            label3.Name = "label3";
            label3.Size = new Size(280, 36);
            label3.TabIndex = 4;
            label3.Text = "Thời gian bắt đầu :";
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(687, 61);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(290, 44);
            txtKhachHang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 69);
            label2.Name = "label2";
            label2.Size = new Size(202, 36);
            label2.TabIndex = 2;
            label2.Text = "Khách hàng :";
            // 
            // txtPhong
            // 
            txtPhong.Location = new Point(175, 61);
            txtPhong.Name = "txtPhong";
            txtPhong.Size = new Size(223, 44);
            txtPhong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 69);
            label1.Name = "label1";
            label1.Size = new Size(122, 36);
            label1.TabIndex = 0;
            label1.Text = "Phòng :";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1513, 243);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.DodgerBlue;
            btnLuu.Location = new Point(1513, 151);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(1513, 59);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(150, 46);
            btnTinhTien.TabIndex = 8;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTienGiam);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnTinhTien);
            groupBox2.Controls.Add(txtGiamGia);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cboKhuyenMai);
            groupBox2.Controls.Add(txtTienDV);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTienPhong);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(11, 364);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1755, 329);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tổng tiền";
            // 
            // txtTienGiam
            // 
            txtTienGiam.Location = new Point(918, 153);
            txtTienGiam.Name = "txtTienGiam";
            txtTienGiam.Size = new Size(438, 44);
            txtTienGiam.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(714, 161);
            label10.Name = "label10";
            label10.Size = new Size(171, 36);
            label10.TabIndex = 13;
            label10.Text = "Tiền giảm :";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(918, 243);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(438, 44);
            txtTongTien.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(712, 251);
            label9.Name = "label9";
            label9.Size = new Size(210, 36);
            label9.TabIndex = 11;
            label9.Text = "TỔNG TIỀN :";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(916, 64);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(438, 44);
            txtGiamGia.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(712, 72);
            label7.Name = "label7";
            label7.Size = new Size(159, 36);
            label7.TabIndex = 9;
            label7.Text = "Giảm giá :";
            // 
            // cboKhuyenMai
            // 
            cboKhuyenMai.FormattingEnabled = true;
            cboKhuyenMai.Location = new Point(243, 66);
            cboKhuyenMai.Name = "cboKhuyenMai";
            cboKhuyenMai.Size = new Size(438, 44);
            cboKhuyenMai.TabIndex = 8;
            cboKhuyenMai.SelectedIndexChanged += cboKhuyenMai_SelectedIndexChanged;
            // 
            // txtTienDV
            // 
            txtTienDV.Location = new Point(241, 243);
            txtTienDV.Name = "txtTienDV";
            txtTienDV.Size = new Size(440, 44);
            txtTienDV.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 251);
            label5.Name = "label5";
            label5.Size = new Size(204, 36);
            label5.TabIndex = 6;
            label5.Text = "Tiền dịch vụ :";
            // 
            // txtTienPhong
            // 
            txtTienPhong.Location = new Point(243, 153);
            txtTienPhong.Name = "txtTienPhong";
            txtTienPhong.Size = new Size(438, 44);
            txtTienPhong.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 161);
            label6.Name = "label6";
            label6.Size = new Size(189, 36);
            label6.TabIndex = 4;
            label6.Text = "Tiền phòng :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 69);
            label8.Name = "label8";
            label8.Size = new Size(203, 36);
            label8.TabIndex = 0;
            label8.Text = "Khuyến mãi :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 699);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1754, 534);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dịch vụ đã dùng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, DatPhongID, DichVuID, TenDV, SoLuong, DonGia, ThanhTien });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1748, 491);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            // 
            // DatPhongID
            // 
            DatPhongID.DataPropertyName = "DatPhongID";
            DatPhongID.HeaderText = "Mã đặt phòng";
            DatPhongID.MinimumWidth = 10;
            DatPhongID.Name = "DatPhongID";
            // 
            // DichVuID
            // 
            DichVuID.DataPropertyName = "DichVuID";
            DichVuID.HeaderText = "Mã dịch vụ";
            DichVuID.MinimumWidth = 10;
            DichVuID.Name = "DichVuID";
            // 
            // TenDV
            // 
            TenDV.DataPropertyName = "TenDV";
            TenDV.HeaderText = "Tên dịch vụ";
            TenDV.MinimumWidth = 10;
            TenDV.Name = "TenDV";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 10;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 10;
            DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 10;
            ThanhTien.Name = "ThanhTien";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1796, 1245);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHoaDon";
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtKhachHang;
        private Label label2;
        private TextBox txtPhong;
        private Label label1;
        private TextBox txtThoiGianBatDau;
        private Label label3;
        private TextBox txtThoiGianKetThuc;
        private Label label4;
        private GroupBox groupBox2;
        private ComboBox cboKhuyenMai;
        private TextBox txtTienDV;
        private Label label5;
        private TextBox txtTienPhong;
        private Label label6;
        private Label label8;
        private Button btnTinhTien;
        private TextBox txtTongTien;
        private Label label9;
        private TextBox txtGiamGia;
        private Label label7;
        private Button btnThoat;
        private Button btnLuu;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DatPhongID;
        private DataGridViewTextBoxColumn DichVuID;
        private DataGridViewTextBoxColumn TenDV;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private TextBox txtTienGiam;
        private Label label10;
        private TextBox txtNhanVien;
        private Label label11;
    }
}