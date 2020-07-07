using System;
using System.Collections.Generic;
using System.Text;
using Library_managements.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library_managements.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Sach> Sach { get; set; }
        public DbSet<DocGia> DocGia { get; set; }

        public DbSet<LichSuMuon> LichSuMuon { get; set; }

        public DbSet<PhieuTra> PhieuTra { get; set; }
    }
}
