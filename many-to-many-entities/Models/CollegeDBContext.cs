using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace many_to_many_entities.Models
{
    public class CollegeDBContext : DbContext
    {
        public CollegeDBContext() : base("CollegeDB")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}