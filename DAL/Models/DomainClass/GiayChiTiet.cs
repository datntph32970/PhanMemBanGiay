using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("Giay_ChiTiet")]
public partial class GiayChiTiet
{
    [Key]
    [Column("Ma_Giay_ChiTiet")]
    public int MaGiayChiTiet { get; set; }

    public int? MaGiay { get; set; }

    public int? MaChatLieu { get; set; }

    public int? MaMauSac { get; set; }

    public int? MaKichCo { get; set; }

    public int? SoLuongCon { get; set; }

    [ForeignKey("MaChatLieu")]
    [InverseProperty("GiayChiTiets")]
    public virtual Chatlieu? MaChatLieuNavigation { get; set; }

    [ForeignKey("MaGiay")]
    [InverseProperty("GiayChiTiets")]
    public virtual Giay? MaGiayNavigation { get; set; }

    [ForeignKey("MaKichCo")]
    [InverseProperty("GiayChiTiets")]
    public virtual Kichco? MaKichCoNavigation { get; set; }

    [ForeignKey("MaMauSac")]
    [InverseProperty("GiayChiTiets")]
    public virtual Mausac? MaMauSacNavigation { get; set; }
}
