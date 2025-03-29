using PitMan.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PitMan.Context
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("StudentContextDB")
        {
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}