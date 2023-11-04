using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("GIAY")]
public partial class Giay
{
    [Key]
    [Column("MAGIAY")]
    public int Magiay { get; set; }

    [Column("TENGIAY")]
    [StringLength(50)]
    public string? Tengiay { get; set; }

    [Column("MATHUONGHIEU")]
    public int? Mathuonghieu { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [Column("GIA")]
    public double? Gia { get; set; }

    [Column("MOTA")]
    [StringLength(200)]
    public string? Mota { get; set; }

    public bool? Locked { get; set; }

    [InverseProperty("MaGiayNavigation")]
    public virtual ICollection<GiayChiTiet> GiayChiTiets { get; set; } = new List<GiayChiTiet>();

    [InverseProperty("MaGiayNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    [ForeignKey("Mathuonghieu")]
    [InverseProperty("Giays")]
    public virtual Thuonghieu? MathuonghieuNavigation { get; set; }
}
