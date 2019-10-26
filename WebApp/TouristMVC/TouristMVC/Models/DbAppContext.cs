using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristMVC.Models
{
    public class DbAppContext : IdentityDbContext<IdentityUser>
    {
        public DbAppContext(DbContextOptions<DbAppContext> options) : base(options)
        {

        }
        public DbSet<Tourist> Tourists { set; get; }
        public DbSet<Country> Countries { set; get; }
    }
}
