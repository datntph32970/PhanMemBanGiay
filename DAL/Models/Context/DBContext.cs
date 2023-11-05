using System;
using System.Collections.Generic;
using DAL.Models.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chatlieu> Chatlieus { get; set; }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Giay> Giays { get; set; }

    public virtual DbSet<GiayChiTiet> GiayChiTiets { get; set; }

    public virtual DbSet<Hinhthucthanhtoan> Hinhthucthanhtoans { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Kichco> Kichcos { get; set; }

    public virtual DbSet<Mausac> Mausacs { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    public virtual DbSet<Uudai> Uudais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= ACER\\SQLEXPRESS ;Initial Catalog= DBGIAY_DUAN1;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chatlieu>(entity =>
        {
            entity.HasKey(e => e.Machatlieu).HasName("PK__CHATLIEU__80F939F8CD8A216D");
        });

        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Machucvu).HasName("PK__CHUCVU__9FA9FD6AE527E363");
        });

        modelBuilder.Entity<Giay>(entity =>
        {
            entity.HasKey(e => e.Magiay).HasName("PK__GIAY__0C880C58E0550CAB");

            entity.HasOne(d => d.MathuonghieuNavigation).WithMany(p => p.Giays).HasConstraintName("FK__GIAY__MATHUONGHI__4F7CD00D");
        });

        modelBuilder.Entity<GiayChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaGiayChiTiet).HasName("PK__Giay_Chi__5366151851BFC86D");

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.GiayChiTiets).HasConstraintName("FK__Giay_ChiT__MaCha__571DF1D5");

            entity.HasOne(d => d.MaGiayNavigation).WithMany(p => p.GiayChiTiets).HasConstraintName("FK__Giay_ChiT__MaGia__5629CD9C");

            entity.HasOne(d => d.MaKichCoNavigation).WithMany(p => p.GiayChiTiets).HasConstraintName("FK__Giay_ChiT__MaKic__59063A47");

            entity.HasOne(d => d.MaMauSacNavigation).WithMany(p => p.GiayChiTiets).HasConstraintName("FK__Giay_ChiT__MaMau__5812160E");
        });

        modelBuilder.Entity<Hinhthucthanhtoan>(entity =>
        {
            entity.HasKey(e => e.Mahinhthucthanhtoan).HasName("PK__HINHTHUC__C3B2561FC1ADAB18");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonChiTiet).HasName("PK__HoaDonCh__6C2FD0CEE6BA27B4");

            entity.HasOne(d => d.MaGiayNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__MaGia__52593CB8");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__MaHoa__534D60F1");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahoadon).HasName("PK__HOADON__A4999DF5175F9D8C");

            entity.HasOne(d => d.MahinhthucthanhtoanNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MAHINHTH__44FF419A");

            entity.HasOne(d => d.MakhachhangNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MAKHACHH__440B1D61");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MATAIKHO__4222D4EF");

            entity.HasOne(d => d.MauudaiNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MAUUDAI__4316F928");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makhachhang).HasName("PK__KHACHHAN__30035C2F55C560EB");
        });

        modelBuilder.Entity<Kichco>(entity =>
        {
            entity.HasKey(e => e.Makichco).HasName("PK__KICHCO__7EDFFF290207918E");
        });

        modelBuilder.Entity<Mausac>(entity =>
        {
            entity.HasKey(e => e.Mamausac).HasName("PK__MAUSAC__99E7A68F5A97564B");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Mataikhoan).HasName("PK__TAIKHOAN__2ED8B517B139BD2E");

            entity.HasOne(d => d.MachucvuNavigation).WithMany(p => p.Taikhoans).HasConstraintName("FK__TAIKHOAN__MACHUC__398D8EEE");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.Mathuonghieu).HasName("PK__THUONGHI__B319F638706DCA03");
        });

        modelBuilder.Entity<Uudai>(entity =>
        {
            entity.HasKey(e => e.Mauudai).HasName("PK__UUDAI__3F58B4FDB497B367");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
