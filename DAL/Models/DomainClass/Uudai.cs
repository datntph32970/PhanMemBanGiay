using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("UUDAI")]
public partial class Uudai
{
    [Key]
    [Column("MAUUDAI")]
    public int Mauudai { get; set; }

    [Column("TENUUDAI")]
    [StringLength(50)]
    public string? Tenuudai { get; set; }

    [Column("NGAYBATDAU", TypeName = "datetime")]
    public DateTime? Ngaybatdau { get; set; }

    [Column("NGAYKETTHUC", TypeName = "datetime")]
    public DateTime? Ngayketthuc { get; set; }

    [Column("PHANTRAM")]
    public int? Phantram { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [Column("SOLUONG")]
    public int? Soluong { get; set; }

    [InverseProperty("MauudaiNavigation")]
    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
