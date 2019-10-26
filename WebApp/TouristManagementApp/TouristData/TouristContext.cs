using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TouristCore;

namespace TouristData
{
    public class TouristContext :DbContext
    {
        public TouristContext(DbContextOptions<TouristContext> options) : base(options)
        {

        }
        public DbSet<Tourist> Tourists { get; set; }
    }
}
