using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCTourism.ViewModels;

namespace MVCTourism.Models
{
    public class TourismDbContext : IdentityDbContext<IdentityUser>
    {
        public TourismDbContext(DbContextOptions<TourismDbContext> options) : base(options)
        {

        }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
