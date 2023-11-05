using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("HOADON")]
public partial class Hoadon
{
    [Key]
    [Column("MAHOADON")]
    public int Mahoadon { get; set; }

    [Column("MATAIKHOAN")]
    public int? Mataikhoan { get; set; }

    [Column("MAUUDAI")]
    public int? Mauudai { get; set; }

    [Column("MAKHACHHANG")]
    public int? Makhachhang { get; set; }

    [Column("NGAYTAO", TypeName = "datetime")]
    public DateTime? Ngaytao { get; set; }

    [Column("TONGTIEN")]
    public double? Tongtien { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [Column("GHICHU")]
    [StringLength(200)]
    public string? Ghichu { get; set; }

    [Column("MAHINHTHUCTHANHTOAN")]
    public int? Mahinhthucthanhtoan { get; set; }

    [InverseProperty("MaHoaDonNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    [ForeignKey("Mahinhthucthanhtoan")]
    [InverseProperty("Hoadons")]
    public virtual Hinhthucthanhtoan? MahinhthucthanhtoanNavigation { get; set; }

    [ForeignKey("Makhachhang")]
    [InverseProperty("Hoadons")]
    public virtual Khachhang? MakhachhangNavigation { get; set; }

    [ForeignKey("Mataikhoan")]
    [InverseProperty("Hoadons")]
    public virtual Taikhoan? MataikhoanNavigation { get; set; }

    [ForeignKey("Mauudai")]
    [InverseProperty("Hoadons")]
    public virtual Uudai? MauudaiNavigation { get; set; }
}
