using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("CHATLIEU")]
public partial class Chatlieu
{
    [Key]
    [Column("MACHATLIEU")]
    public int Machatlieu { get; set; }

    [Column("TENCHATLIEU")]
    [StringLength(50)]
    public string? Tenchatlieu { get; set; }

    [Column("MOTA")]
    [StringLength(200)]
    public string? Mota { get; set; }

    public bool? Locked { get; set; }

    [InverseProperty("MaChatLieuNavigation")]
    public virtual ICollection<GiayChiTiet> GiayChiTiets { get; set; } = new List<GiayChiTiet>();
}
