using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTNTHAM_2210900124_PRJ.Models
{
    public class DtntDatabaseContextController : Controller
    {
        public class DtntDatabaseContext : DbContext
        {
            public DtntDatabaseContext() : base("name=DtntDatabaseContext") { }

            public DbSet<DtntQUANTRI> DtntQUANTRI { get; set; }
            public DbSet<DtntKhachHang> DtntKhachHang { get; set; }
            public DbSet<DtntThanhVien> DtntThanhVien { get; set; }
            public DbSet<DtntGiaodichTK> DtntGiaodichTK { get; set; }
            public DbSet<DtntNguoiHoTro> DtntNguoiHoTro { get; set; }
        }
    }
}