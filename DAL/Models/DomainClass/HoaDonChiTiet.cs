using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("HoaDonChiTiet")]
public partial class HoaDonChiTiet
{
    [Key]
    public int MaHoaDonChiTiet { get; set; }

    public int? MaGiay { get; set; }

    public int? MaHoaDon { get; set; }

    public int? SoLuongMua { get; set; }

    public double? Gia { get; set; }

    [ForeignKey("MaGiay")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual Giay? MaGiayNavigation { get; set; }

    [ForeignKey("MaHoaDon")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual Hoadon? MaHoaDonNavigation { get; set; }
}
