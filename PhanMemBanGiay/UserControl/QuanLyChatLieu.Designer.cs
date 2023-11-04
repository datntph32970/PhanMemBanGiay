namespace PhanMemBanGiay
{
    partial class QuanLyChatLieu
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
            cbbTimKiem = new ComboBox();
            dgvChatLieu = new DataGridView();
            btnTimKiem = new Button();
            btnKhoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label3 = new Label();
            txtMoTa = new TextBox();
            txtTimKiem = new TextBox();
            txtTenChatLieu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).BeginInit();
            SuspendLayout();
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(201, 106);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(155, 23);
            cbbTimKiem.TabIndex = 17;
            // 
            // dgvChatLieu
            // 
            dgvChatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChatLieu.Location = new Point(3, 198);
            dgvChatLieu.Name = "dgvChatLieu";
            dgvChatLieu.RowTemplate.Height = 25;
            dgvChatLieu.Size = new Size(1102, 387);
            dgvChatLieu.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(745, 102);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(139, 40);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnKhoa
            // 
            btnKhoa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhoa.Location = new Point(996, 591);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.Size = new Size(109, 40);
            btnKhoa.TabIndex = 13;
            btnKhoa.Text = "Khóa";
            btnKhoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(881, 591);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 40);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(766, 591);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 40);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(641, 165);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 7;
            label3.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoTa.Location = new Point(690, 157);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(301, 35);
            txtMoTa.TabIndex = 9;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(362, 105);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm....";
            txtTimKiem.Size = new Size(377, 35);
            txtTimKiem.TabIndex = 10;
            // 
            // txtTenChatLieu
            // 
            txtTenChatLieu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenChatLieu.Location = new Point(162, 157);
            txtTenChatLieu.Multiline = true;
            txtTenChatLieu.Name = "txtTenChatLieu";
            txtTenChatLieu.Size = new Size(289, 35);
            txtTenChatLieu.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 165);
            label2.Name = "label2";
            label2.Size = new Size(86, 16);
            label2.TabIndex = 8;
            label2.Text = "Tên chất liệu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(399, 17);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(285, 47);
            label1.TabIndex = 6;
            label1.Text = "Quản lý chất liệu";
            // 
            // QuanLyChatLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbbTimKiem);
            Controls.Add(dgvChatLieu);
            Controls.Add(btnTimKiem);
            Controls.Add(btnKhoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(txtMoTa);
            Controls.Add(txtTimKiem);
            Controls.Add(txtTenChatLieu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuanLyChatLieu";
            Size = new Size(1108, 648);
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbTimKiem;
        private DataGridView dgvChatLieu;
        private Button btnTimKiem;
        private Button btnKhoa;
        private Button btnSua;
        private Button btnThem;
        private Label label3;
        private TextBox txtMoTa;
        private TextBox txtTimKiem;
        private TextBox txtTenChatLieu;
        private Label label2;
        private Label label1;
    }
}
