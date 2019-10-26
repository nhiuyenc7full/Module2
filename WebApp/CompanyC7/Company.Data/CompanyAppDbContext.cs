using CompanyC7.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyC7.Data
{
    public class CompanyAppDbContext :DbContext
    {
        public CompanyAppDbContext(DbContextOptions<CompanyAppDbContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
    }
}
