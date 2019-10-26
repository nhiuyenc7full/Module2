using Microsoft.EntityFrameworkCore;
using OnePiece.Domain;
using System;
using System.Collections.Generic;
using System.Text;


namespace OnePieceWeb.Data
{
    public class OnePieceContext : DbContext
    {
        public OnePieceContext(DbContextOptions<OnePieceContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Pirate> Pirates { get; set; }
        public DbSet<DevilFruit> DevilFruits { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<CharacterPosition> CharacterPositions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterPosition>().HasKey(character => new { character.CharacterId, character.PositionId });
            modelBuilder.Entity<CharacterPosition>().HasOne(cp => cp.Position).WithMany(p => p.CharacterPositions).HasForeignKey(cp => cp.PositionId);
            modelBuilder.Entity<CharacterPosition>().HasOne(cp => cp.Character).WithMany(c => c.CharacterPositions).HasForeignKey(cp => cp.CharacterId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server = DESKTOP-A5B5UBC\\SQLEXPRESS;Database = OnePieceWeb; Trusted_Connection = True; ");
        }
    }
}
