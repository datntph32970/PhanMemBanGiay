namespace PhanMemBanGiay
{
    partial class QuanLyNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbbTimKiem = new ComboBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtHoVaTen = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtSoDienThoai = new TextBox();
            label7 = new Label();
            txtDiaChi = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtNgayTaoTaiKhoan = new TextBox();
            dgvNhanVien = new DataGridView();
            cbbGioiTinh = new ComboBox();
            dtpNgayThangNamSinh = new DateTimePicker();
            cbbChucVu = new ComboBox();
            btnKhoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(416, 10);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(305, 47);
            label1.TabIndex = 1;
            label1.Text = "Quản lý nhân viên";
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(187, 80);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(155, 23);
            cbbTimKiem.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(731, 76);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(139, 40);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(348, 79);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm....";
            txtTimKiem.Size = new Size(377, 35);
            txtTimKiem.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(177, 124);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(289, 35);
            txtUserName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 133);
            label2.Name = "label2";
            label2.Size = new Size(73, 16);
            label2.TabIndex = 9;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 174);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 9;
            label3.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(177, 165);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(289, 35);
            txtPassword.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(104, 215);
            label4.Name = "label4";
            label4.Size = new Size(67, 16);
            label4.TabIndex = 9;
            label4.Text = "Họ và tên:";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoVaTen.Location = new Point(177, 206);
            txtHoVaTen.Multiline = true;
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(289, 35);
            txtHoVaTen.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(114, 256);
            label5.Name = "label5";
            label5.Size = new Size(57, 16);
            label5.TabIndex = 9;
            label5.Text = "Giới tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(83, 297);
            label6.Name = "label6";
            label6.Size = new Size(88, 16);
            label6.TabIndex = 9;
            label6.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(177, 288);
            txtSoDienThoai.Multiline = true;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(289, 35);
            txtSoDienThoai.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(649, 138);
            label7.Name = "label7";
            label7.Size = new Size(50, 16);
            label7.TabIndex = 9;
            label7.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(705, 129);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(289, 35);
            txtDiaChi.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(655, 179);
            label8.Name = "label8";
            label8.Size = new Size(44, 16);
            label8.TabIndex = 9;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(705, 170);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 35);
            txtEmail.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(564, 220);
            label9.Name = "label9";
            label9.Size = new Size(135, 16);
            label9.TabIndex = 9;
            label9.Text = "Ngày tháng năm sinh:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(642, 261);
            label10.Name = "label10";
            label10.Size = new Size(57, 16);
            label10.TabIndex = 9;
            label10.Text = "Chức vụ:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(577, 302);
            label11.Name = "label11";
            label11.Size = new Size(122, 16);
            label11.TabIndex = 9;
            label11.Text = "Ngày tạo tài khoản:";
            // 
            // txtNgayTaoTaiKhoan
            // 
            txtNgayTaoTaiKhoan.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgayTaoTaiKhoan.Location = new Point(705, 293);
            txtNgayTaoTaiKhoan.Multiline = true;
            txtNgayTaoTaiKhoan.Name = "txtNgayTaoTaiKhoan";
            txtNgayTaoTaiKhoan.Size = new Size(289, 35);
            txtNgayTaoTaiKhoan.TabIndex = 10;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(3, 339);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowTemplate.Height = 25;
            dgvNhanVien.Size = new Size(1102, 247);
            dgvNhanVien.TabIndex = 11;
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Location = new Point(177, 253);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(165, 23);
            cbbGioiTinh.TabIndex = 12;
            // 
            // dtpNgayThangNamSinh
            // 
            dtpNgayThangNamSinh.Location = new Point(705, 217);
            dtpNgayThangNamSinh.Name = "dtpNgayThangNamSinh";
            dtpNgayThangNamSinh.Size = new Size(200, 23);
            dtpNgayThangNamSinh.TabIndex = 13;
            // 
            // cbbChucVu
            // 
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(705, 258);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(165, 23);
            cbbChucVu.TabIndex = 12;
            // 
            // btnKhoa
            // 
            btnKhoa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhoa.Location = new Point(988, 592);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.Size = new Size(109, 40);
            btnKhoa.TabIndex = 14;
            btnKhoa.Text = "Khóa";
            btnKhoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(873, 592);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 40);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(758, 592);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 40);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnKhoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dtpNgayThangNamSinh);
            Controls.Add(cbbChucVu);
            Controls.Add(cbbGioiTinh);
            Controls.Add(dgvNhanVien);
            Controls.Add(txtNgayTaoTaiKhoan);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(txtDiaChi);
            Controls.Add(label7);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHoVaTen);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(cbbTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Name = "QuanLyNhanVien";
            Size = new Size(1108, 648);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbTimKiem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private TextBox txtUserName;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtHoVaTen;
        private Label label5;
        private Label label6;
        private TextBox txtSoDienThoai;
        private Label label7;
        private TextBox txtDiaChi;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtNgayTaoTaiKhoan;
        private DataGridView dgvNhanVien;
        private ComboBox cbbGioiTinh;
        private DateTimePicker dtpNgayThangNamSinh;
        private ComboBox cbbChucVu;
        private Button btnKhoa;
        private Button btnSua;
        private Button btnThem;
    }
}
