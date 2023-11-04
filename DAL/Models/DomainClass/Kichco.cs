using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("KICHCO")]
public partial class Kichco
{
    [Key]
    [Column("MAKICHCO")]
    public int Makichco { get; set; }

    [Column("TENKICHCO")]
    [StringLength(50)]
    public string? Tenkichco { get; set; }

    [Column("MOTA")]
    [StringLength(200)]
    public string? Mota { get; set; }

    public bool? Locked { get; set; }

    [InverseProperty("MaKichCoNavigation")]
    public virtual ICollection<GiayChiTiet> GiayChiTiets { get; set; } = new List<GiayChiTiet>();
}
