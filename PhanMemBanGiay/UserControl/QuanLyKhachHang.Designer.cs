namespace PhanMemBanGiay
{
    partial class QuanLyKhachHang
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
            label2 = new Label();
            txtTenKhachHang = new TextBox();
            btnThem = new Button();
            label3 = new Label();
            dgvKhachHang = new DataGridView();
            txtSoDienThoai = new TextBox();
            txtTimKiem = new TextBox();
            cbbTimKiem = new ComboBox();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnKhoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(390, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(332, 47);
            label1.TabIndex = 0;
            label1.Text = "Quản lý khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 182);
            label2.Name = "label2";
            label2.Size = new Size(106, 16);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhachHang.Location = new Point(169, 174);
            txtTenKhachHang.Multiline = true;
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(289, 35);
            txtTenKhachHang.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(766, 582);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 40);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(603, 182);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 1;
            label3.Text = "Số điện thoại:";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(3, 246);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowTemplate.Height = 25;
            dgvKhachHang.Size = new Size(1102, 313);
            dgvKhachHang.TabIndex = 4;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(697, 174);
            txtSoDienThoai.Multiline = true;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(301, 35);
            txtSoDienThoai.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(362, 96);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm....";
            txtTimKiem.Size = new Size(377, 35);
            txtTimKiem.TabIndex = 2;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(201, 97);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(155, 23);
            cbbTimKiem.TabIndex = 5;
            cbbTimKiem.SelectedIndexChanged += cbbTimKiem_SelectedIndexChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(745, 93);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(139, 40);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(881, 582);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 40);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnKhoa
            // 
            btnKhoa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhoa.Location = new Point(996, 582);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.Size = new Size(109, 40);
            btnKhoa.TabIndex = 3;
            btnKhoa.Text = "Khóa";
            btnKhoa.UseVisualStyleBackColor = true;
            // 
            // QuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbbTimKiem);
            Controls.Add(dgvKhachHang);
            Controls.Add(btnTimKiem);
            Controls.Add(btnKhoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTimKiem);
            Controls.Add(txtTenKhachHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuanLyKhachHang";
            Size = new Size(1108, 648);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenKhachHang;
        private Button btnThem;
        private Label label3;
        private DataGridView dgvKhachHang;
        private TextBox txtSoDienThoai;
        private TextBox txtTimKiem;
        private ComboBox cbbTimKiem;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnKhoa;
    }
}
