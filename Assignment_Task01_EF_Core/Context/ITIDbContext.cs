using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task01_EF_Core.Context
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source =. ; Initial Catalog = ITI_DB ;Integrated Security =true");
            optionsBuilder.UseSqlServer("Server=.;Database=ITI_DB;Trusted_Connection=True;Encrypt=False");

        }
        public DbSet<Student> students { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Topic> topic { get; set; }
        public DbSet<Course_Inst> course_Insts { get; set; }
        public DbSet<Stud_Course> stud_courses { get; set; }

    }
}
