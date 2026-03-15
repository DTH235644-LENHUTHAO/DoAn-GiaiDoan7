namespace QuanLyQuanKaraoke.Forms
{
    partial class frmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(739, 182);
            label1.Name = "label1";
            label1.Size = new Size(241, 36);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(739, 319);
            label2.Name = "label2";
            label2.Size = new Size(169, 36);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(858, 71);
            label3.Name = "label3";
            label3.Size = new Size(345, 61);
            label3.TabIndex = 2;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(739, 233);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(573, 44);
            txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(739, 370);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '•';
            txtMatKhau.Size = new Size(573, 44);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(840, 508);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(186, 70);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1058, 508);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(178, 70);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 697);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDangNhap";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txtTenDangNhap;
        public TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnHuyBo;
    }
}