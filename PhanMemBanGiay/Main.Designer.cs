namespace PhanMemBanGiay
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CNTrangChu = new ToolStripMenuItem();
            cửaHàngToolStripMenuItem = new ToolStripMenuItem();
            CNQuanLyNhanVien = new ToolStripMenuItem();
            CNQuanLyKhachHang = new ToolStripMenuItem();
            CNQuanLyUuDai = new ToolStripMenuItem();
            CNQuanLyHangCungCap = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            CNQuanLySanPham = new ToolStripMenuItem();
            quảnLíThuộcTínhToolStripMenuItem = new ToolStripMenuItem();
            CNQuanLyMauSac = new ToolStripMenuItem();
            CNQuanLyKichCo = new ToolStripMenuItem();
            CNQuanLyChatLieu = new ToolStripMenuItem();
            giaoDịchToolStripMenuItem = new ToolStripMenuItem();
            CNQuanLyHoaDon = new ToolStripMenuItem();
            CNTaoHoaDon = new ToolStripMenuItem();
            CNThongKe = new ToolStripMenuItem();
            CNThongKeSPTrongKho = new ToolStripMenuItem();
            CNThongKeSPDaBan = new ToolStripMenuItem();
            CNThongKeDoanhThu = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            CNXemThongTinTK = new ToolStripMenuItem();
            CNDangXuat = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            trangChu1 = new TrangChu();
            thongTinTaiKhoan1 = new ThongTinTaiKhoan();
            thongKeTheoDoanhThu1 = new ThongKeTheoDoanhThu();
            thongKeSanPhamTrongKho1 = new ThongKeSanPhamTrongKho();
            thongKeSanPhamDaBan1 = new ThongKeSanPhamDaBan();
            taoHoaDon1 = new TaoHoaDon();
            quanLyUuDai1 = new QuanLyUuDai();
            quanLySanPham1 = new QuanLySanPham();
            quanLyNhanVien1 = new QuanLyNhanVien();
            quanLyMauSac1 = new QuanLyMauSac();
            quanLyKichCo1 = new QuanLyKichCo();
            quanLyKhachHang1 = new QuanLyKhachHang();
            quanLyHoaDon1 = new QuanLyHoaDon();
            quanLyHangCungCap1 = new QuanLyHangCungCap();
            quanLyChatLieu1 = new QuanLyChatLieu();
            thanhToánToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CNTrangChu
            // 
            CNTrangChu.Name = "CNTrangChu";
            CNTrangChu.Size = new Size(71, 20);
            CNTrangChu.Text = "Trang chủ";
            CNTrangChu.Click += CNTrangChu_Click;
            // 
            // cửaHàngToolStripMenuItem
            // 
            cửaHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CNQuanLyNhanVien, CNQuanLyKhachHang, CNQuanLyUuDai, CNQuanLyHangCungCap });
            cửaHàngToolStripMenuItem.Name = "cửaHàngToolStripMenuItem";
            cửaHàngToolStripMenuItem.Size = new Size(70, 20);
            cửaHàngToolStripMenuItem.Text = "Cửa hàng";
            // 
            // CNQuanLyNhanVien
            // 
            CNQuanLyNhanVien.Name = "CNQuanLyNhanVien";
            CNQuanLyNhanVien.Size = new Size(197, 22);
            CNQuanLyNhanVien.Text = "Quản lý nhân viên";
            CNQuanLyNhanVien.Click += CNQuanLyNhanVien_Click;
            // 
            // CNQuanLyKhachHang
            // 
            CNQuanLyKhachHang.Name = "CNQuanLyKhachHang";
            CNQuanLyKhachHang.Size = new Size(197, 22);
            CNQuanLyKhachHang.Text = "Quản lý khách hàng";
            CNQuanLyKhachHang.Click += CNQuanLyKhachHang_Click;
            // 
            // CNQuanLyUuDai
            // 
            CNQuanLyUuDai.Name = "CNQuanLyUuDai";
            CNQuanLyUuDai.Size = new Size(197, 22);
            CNQuanLyUuDai.Text = "Quản lý ưu đãi";
            CNQuanLyUuDai.Click += CNQuanLyUuDai_Click;
            // 
            // CNQuanLyHangCungCap
            // 
            CNQuanLyHangCungCap.Name = "CNQuanLyHangCungCap";
            CNQuanLyHangCungCap.Size = new Size(197, 22);
            CNQuanLyHangCungCap.Text = "Quản lý hãng cung cấp";
            CNQuanLyHangCungCap.Click += CNQuanLyHangCungCap_Click;
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CNQuanLySanPham, quảnLíThuộcTínhToolStripMenuItem });
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(72, 20);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // CNQuanLySanPham
            // 
            CNQuanLySanPham.Name = "CNQuanLySanPham";
            CNQuanLySanPham.Size = new Size(173, 22);
            CNQuanLySanPham.Text = "Quản lý sản phẩm";
            CNQuanLySanPham.Click += CNQuanLySanPham_Click;
            // 
            // quảnLíThuộcTínhToolStripMenuItem
            // 
            quảnLíThuộcTínhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CNQuanLyMauSac, CNQuanLyKichCo, CNQuanLyChatLieu });
            quảnLíThuộcTínhToolStripMenuItem.Name = "quảnLíThuộcTínhToolStripMenuItem";
            quảnLíThuộcTínhToolStripMenuItem.Size = new Size(173, 22);
            quảnLíThuộcTínhToolStripMenuItem.Text = "Quản lý thuộc tính";
            // 
            // CNQuanLyMauSac
            // 
            CNQuanLyMauSac.Name = "CNQuanLyMauSac";
            CNQuanLyMauSac.Size = new Size(163, 22);
            CNQuanLyMauSac.Text = "Quản lí màu sắc";
            CNQuanLyMauSac.Click += CNQuanLyMauSac_Click;
            // 
            // CNQuanLyKichCo
            // 
            CNQuanLyKichCo.Name = "CNQuanLyKichCo";
            CNQuanLyKichCo.Size = new Size(163, 22);
            CNQuanLyKichCo.Text = "Quản lý kích cỡ";
            CNQuanLyKichCo.Click += CNQuanLyKichCo_Click;
            // 
            // CNQuanLyChatLieu
            // 
            CNQuanLyChatLieu.Name = "CNQuanLyChatLieu";
            CNQuanLyChatLieu.Size = new Size(163, 22);
            CNQuanLyChatLieu.Text = "Quản lý chất liệu";
            CNQuanLyChatLieu.Click += CNQuanLyChatLieu_Click;
            // 
            // giaoDịchToolStripMenuItem
            // 
            giaoDịchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CNQuanLyHoaDon, CNTaoHoaDon, thanhToánToolStripMenuItem, CNThongKe });
            giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            giaoDịchToolStripMenuItem.Size = new Size(112, 20);
            giaoDịchToolStripMenuItem.Text = "Quản lý giao dịch";
            // 
            // CNQuanLyHoaDon
            // 
            CNQuanLyHoaDon.Name = "CNQuanLyHoaDon";
            CNQuanLyHoaDon.Size = new Size(162, 22);
            CNQuanLyHoaDon.Text = "Quản lý hóa đơn";
            CNQuanLyHoaDon.Click += CNQuanLyHoaDon_Click;
            // 
            // CNTaoHoaDon
            // 
            CNTaoHoaDon.Name = "CNTaoHoaDon";
            CNTaoHoaDon.Size = new Size(162, 22);
            CNTaoHoaDon.Text = "Tạo hóa đơn";
            CNTaoHoaDon.Click += CNTaoHoaDon_Click;
            // 
            // CNThongKe
            // 
            CNThongKe.DropDownItems.AddRange(new ToolStripItem[] { CNThongKeSPTrongKho, CNThongKeSPDaBan, CNThongKeDoanhThu });
            CNThongKe.Name = "CNThongKe";
            CNThongKe.Size = new Size(162, 22);
            CNThongKe.Text = "Thống kê";
            // 
            // CNThongKeSPTrongKho
            // 
            CNThongKeSPTrongKho.Name = "CNThongKeSPTrongKho";
            CNThongKeSPTrongKho.Size = new Size(233, 22);
            CNThongKeSPTrongKho.Text = "Thống kê sản phẩm trong kho";
            CNThongKeSPTrongKho.Click += CNThongKeSPTrongKho_Click;
            // 
            // CNThongKeSPDaBan
            // 
            CNThongKeSPDaBan.Name = "CNThongKeSPDaBan";
            CNThongKeSPDaBan.Size = new Size(233, 22);
            CNThongKeSPDaBan.Text = "Thống kê sản phẩm đã bán";
            CNThongKeSPDaBan.Click += CNThongKeSPDaBan_Click;
            // 
            // CNThongKeDoanhThu
            // 
            CNThongKeDoanhThu.Name = "CNThongKeDoanhThu";
            CNThongKeDoanhThu.Size = new Size(233, 22);
            CNThongKeDoanhThu.Text = "Thống kê doanh thu";
            CNThongKeDoanhThu.Click += CNThongKeDoanhThu_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CNXemThongTinTK, CNDangXuat });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(69, 20);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // CNXemThongTinTK
            // 
            CNXemThongTinTK.Name = "CNXemThongTinTK";
            CNXemThongTinTK.Size = new Size(202, 22);
            CNXemThongTinTK.Text = "Xem thông tin tài khoản";
            CNXemThongTinTK.Click += CNXemThongTinTK_Click;
            // 
            // CNDangXuat
            // 
            CNDangXuat.Name = "CNDangXuat";
            CNDangXuat.Size = new Size(202, 22);
            CNDangXuat.Text = "Đăng xuất";
            CNDangXuat.Click += CNDangXuat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { CNTrangChu, cửaHàngToolStripMenuItem, sảnPhẩmToolStripMenuItem, giaoDịchToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1132, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(trangChu1);
            panel1.Controls.Add(thongTinTaiKhoan1);
            panel1.Controls.Add(thongKeTheoDoanhThu1);
            panel1.Controls.Add(thongKeSanPhamTrongKho1);
            panel1.Controls.Add(thongKeSanPhamDaBan1);
            panel1.Controls.Add(taoHoaDon1);
            panel1.Controls.Add(quanLyUuDai1);
            panel1.Controls.Add(quanLySanPham1);
            panel1.Controls.Add(quanLyNhanVien1);
            panel1.Controls.Add(quanLyMauSac1);
            panel1.Controls.Add(quanLyKichCo1);
            panel1.Controls.Add(quanLyKhachHang1);
            panel1.Controls.Add(quanLyHoaDon1);
            panel1.Controls.Add(quanLyHangCungCap1);
            panel1.Controls.Add(quanLyChatLieu1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 648);
            panel1.TabIndex = 1;
            // 
            // trangChu1
            // 
            trangChu1.Location = new Point(-3, 0);
            trangChu1.Name = "trangChu1";
            trangChu1.Size = new Size(1108, 648);
            trangChu1.TabIndex = 14;
            // 
            // thongTinTaiKhoan1
            // 
            thongTinTaiKhoan1.Location = new Point(3, 0);
            thongTinTaiKhoan1.Name = "thongTinTaiKhoan1";
            thongTinTaiKhoan1.Size = new Size(1108, 648);
            thongTinTaiKhoan1.TabIndex = 13;
            // 
            // thongKeTheoDoanhThu1
            // 
            thongKeTheoDoanhThu1.Location = new Point(0, -3);
            thongKeTheoDoanhThu1.Name = "thongKeTheoDoanhThu1";
            thongKeTheoDoanhThu1.Size = new Size(1108, 648);
            thongKeTheoDoanhThu1.TabIndex = 12;
            // 
            // thongKeSanPhamTrongKho1
            // 
            thongKeSanPhamTrongKho1.Location = new Point(3, -3);
            thongKeSanPhamTrongKho1.Name = "thongKeSanPhamTrongKho1";
            thongKeSanPhamTrongKho1.Size = new Size(1108, 648);
            thongKeSanPhamTrongKho1.TabIndex = 11;
            // 
            // thongKeSanPhamDaBan1
            // 
            thongKeSanPhamDaBan1.Location = new Point(-3, 0);
            thongKeSanPhamDaBan1.Name = "thongKeSanPhamDaBan1";
            thongKeSanPhamDaBan1.Size = new Size(1108, 648);
            thongKeSanPhamDaBan1.TabIndex = 10;
            // 
            // taoHoaDon1
            // 
            taoHoaDon1.Location = new Point(3, 0);
            taoHoaDon1.Name = "taoHoaDon1";
            taoHoaDon1.Size = new Size(1108, 648);
            taoHoaDon1.TabIndex = 9;
            // 
            // quanLyUuDai1
            // 
            quanLyUuDai1.Location = new Point(0, 0);
            quanLyUuDai1.Name = "quanLyUuDai1";
            quanLyUuDai1.Size = new Size(1108, 648);
            quanLyUuDai1.TabIndex = 8;
            // 
            // quanLySanPham1
            // 
            quanLySanPham1.Location = new Point(0, 0);
            quanLySanPham1.Name = "quanLySanPham1";
            quanLySanPham1.Size = new Size(1108, 648);
            quanLySanPham1.TabIndex = 7;
            // 
            // quanLyNhanVien1
            // 
            quanLyNhanVien1.Location = new Point(3, 0);
            quanLyNhanVien1.Name = "quanLyNhanVien1";
            quanLyNhanVien1.Size = new Size(1108, 648);
            quanLyNhanVien1.TabIndex = 6;
            // 
            // quanLyMauSac1
            // 
            quanLyMauSac1.Location = new Point(0, -3);
            quanLyMauSac1.Name = "quanLyMauSac1";
            quanLyMauSac1.Size = new Size(1108, 648);
            quanLyMauSac1.TabIndex = 5;
            // 
            // quanLyKichCo1
            // 
            quanLyKichCo1.Location = new Point(3, 0);
            quanLyKichCo1.Name = "quanLyKichCo1";
            quanLyKichCo1.Size = new Size(1108, 648);
            quanLyKichCo1.TabIndex = 4;
            // 
            // quanLyKhachHang1
            // 
            quanLyKhachHang1.Location = new Point(3, -3);
            quanLyKhachHang1.Name = "quanLyKhachHang1";
            quanLyKhachHang1.Size = new Size(1108, 648);
            quanLyKhachHang1.TabIndex = 3;
            // 
            // quanLyHoaDon1
            // 
            quanLyHoaDon1.Location = new Point(0, -3);
            quanLyHoaDon1.Name = "quanLyHoaDon1";
            quanLyHoaDon1.Size = new Size(1108, 648);
            quanLyHoaDon1.TabIndex = 2;
            // 
            // quanLyHangCungCap1
            // 
            quanLyHangCungCap1.Location = new Point(3, -3);
            quanLyHangCungCap1.Name = "quanLyHangCungCap1";
            quanLyHangCungCap1.Size = new Size(1108, 648);
            quanLyHangCungCap1.TabIndex = 1;
            // 
            // quanLyChatLieu1
            // 
            quanLyChatLieu1.Location = new Point(0, 0);
            quanLyChatLieu1.Name = "quanLyChatLieu1";
            quanLyChatLieu1.Size = new Size(1108, 648);
            quanLyChatLieu1.TabIndex = 0;
            // 
            // thanhToánToolStripMenuItem
            // 
            thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            thanhToánToolStripMenuItem.Size = new Size(162, 22);
            thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1132, 687);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem CNTrangChu;
        private ToolStripMenuItem cửaHàngToolStripMenuItem;
        private ToolStripMenuItem CNQuanLyNhanVien;
        private ToolStripMenuItem CNQuanLyKhachHang;
        private ToolStripMenuItem CNQuanLyUuDai;
        private ToolStripMenuItem CNQuanLyHangCungCap;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem CNQuanLySanPham;
        private ToolStripMenuItem quảnLíThuộcTínhToolStripMenuItem;
        private ToolStripMenuItem giaoDịchToolStripMenuItem;
        private ToolStripMenuItem CNQuanLyHoaDon;
        private ToolStripMenuItem CNTaoHoaDon;
        private ToolStripMenuItem CNThongKe;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem CNXemThongTinTK;
        private ToolStripMenuItem CNDangXuat;
        private MenuStrip menuStrip1;
        private Panel panel1;
        private ToolStripMenuItem CNQuanLyMauSac;
        private ToolStripMenuItem CNQuanLyKichCo;
        private ToolStripMenuItem CNQuanLyChatLieu;
        private ToolStripMenuItem CNThongKeSPTrongKho;
        private ToolStripMenuItem CNThongKeSPDaBan;
        private ToolStripMenuItem CNThongKeDoanhThu;
        private ThongKeSanPhamDaBan thongKeSanPhamDaBan1;
        private TaoHoaDon taoHoaDon1;
        private QuanLyUuDai quanLyUuDai1;
        private QuanLySanPham quanLySanPham1;
        private QuanLyNhanVien quanLyNhanVien1;
        private QuanLyMauSac quanLyMauSac1;
        private QuanLyKhachHang quanLyKhachHang1;
        private QuanLyKichCo quanLyKichCo1;
        private QuanLyHoaDon quanLyHoaDon1;
        private QuanLyHangCungCap quanLyHangCungCap1;
        private QuanLyChatLieu quanLyChatLieu1;
        private ThongKeTheoDoanhThu thongKeTheoDoanhThu1;
        private ThongKeSanPhamTrongKho thongKeSanPhamTrongKho1;
        private TrangChu trangChu1;
        private ThongTinTaiKhoan thongTinTaiKhoan1;
        private ToolStripMenuItem thanhToánToolStripMenuItem;
    }
}