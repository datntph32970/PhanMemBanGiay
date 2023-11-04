using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("TAIKHOAN")]
public partial class Taikhoan
{
    [Key]
    [Column("MATAIKHOAN")]
    public int Mataikhoan { get; set; }

    [Column("USERNAME")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Username { get; set; }

    [Column("PASWORD")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Pasword { get; set; }

    [Column("HOVATEN")]
    [StringLength(50)]
    public string? Hovaten { get; set; }

    [Column("GIOITINH")]
    public bool? Gioitinh { get; set; }

    [Column("SODIENTHOAI")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sodienthoai { get; set; }

    [Column("DIACHI")]
    [StringLength(200)]
    public string? Diachi { get; set; }

    [Column("EMAIL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("NGAYTHANGNAMSINH", TypeName = "date")]
    public DateTime? Ngaythangnamsinh { get; set; }

    [Column("NGAYTAOTAIKHOAN", TypeName = "date")]
    public DateTime? Ngaytaotaikhoan { get; set; }

    [Column("MACHUCVU")]
    public int? Machucvu { get; set; }

    public bool? Locked { get; set; }

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    [ForeignKey("Machucvu")]
    [InverseProperty("Taikhoans")]
    public virtual Chucvu? MachucvuNavigation { get; set; }
}
