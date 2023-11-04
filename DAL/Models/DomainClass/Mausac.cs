using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("MAUSAC")]
public partial class Mausac
{
    [Key]
    [Column("MAMAUSAC")]
    public int Mamausac { get; set; }

    [Column("TENMAUSAC")]
    [StringLength(50)]
    public string? Tenmausac { get; set; }

    [Column("MOTA")]
    [StringLength(200)]
    public string? Mota { get; set; }

    public bool? Locked { get; set; }

    [InverseProperty("MaMauSacNavigation")]
    public virtual ICollection<GiayChiTiet> GiayChiTiets { get; set; } = new List<GiayChiTiet>();
}
