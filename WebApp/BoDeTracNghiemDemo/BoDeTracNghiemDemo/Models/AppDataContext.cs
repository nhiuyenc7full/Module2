using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoDeTracNghiemDemo.Models;

namespace BoDeTracNghiemDemo.Models
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

        }
        public DbSet<Thi> This { set; get; }
        public DbSet<DapAn> DapAns { set; get; }
        public DbSet<TheLoai> TheLoais { set; get; }
        public DbSet<CauHoiThi> CauHoiThis { set; get; }
        public DbSet<Diem> Diems { set; get; }
        public DbSet<NguoiDung> NguoiDungs { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CauHoiThi>().HasKey(ct => new { ct.CauHoiId, ct.ThiId });
        }
        public DbSet<BoDeTracNghiemDemo.Models.CauHoi> CauHoi { get; set; }
    }
}
