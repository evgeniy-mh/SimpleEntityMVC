using MyUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MyUniversity.DataAccessLayer
{
    public class SchoolContext:DbContext
    {
        //The name of the connection string is passed in to the constructor. (Web.config)
        public SchoolContext(): base("SchoolContext")
        {

        }

        /* DbSet property for each entity set. 
         * Entity set typically corresponds to a database table, and an entity corresponds to a row in the table.
         */
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}