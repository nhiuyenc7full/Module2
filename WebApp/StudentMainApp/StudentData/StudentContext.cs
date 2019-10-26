using Microsoft.EntityFrameworkCore;
using StudentCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentData
{
    public class StudentContext : DbContext
    {
        //public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        //{

        //}
        public DbSet<Student> Students {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-A5B5UBC\\SQLEXPRESS;Database=StudentMainApp;Integrated Security=True;");
        }
    }
}
