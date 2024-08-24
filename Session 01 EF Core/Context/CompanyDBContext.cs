using Microsoft.EntityFrameworkCore;
using Session_01_EF_Core.Configurations;
using Session_01_EF_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_EF_Core.Context
{
    internal class CompanyDBContext : DbContext 
    {
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Id
            //modelBuilder.Entity<Employee>().HasKey(E => E.EmpId); // هنا خليت ال EmpId --> PK
            //modelBuilder.Entity<Employee>()
            //            //.Property(E => E.EmpId)
            //            //.Property("EmpId")
            //            .Property(nameof(Employee.EmpId)) // التلت طرق دول صح 
            //            .UseIdentityColumn(1,1); // طب هنا عاوز عاوز احط constains علي Column ال EmpId
            //// Name
            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Name)
            //            .HasColumnType("Varchar")
            //            .HasMaxLength(50)
            //            .HasDefaultValue("Ahmed");

            //// Salary
            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Salary)
            //            .HasColumnType("money");

            //---------------------------------------------------------------------------------------
            // في override تاني بدل ما اعمل كب الكلام ده لوحده اعمله ف مكان واحد كدا
            //modelBuilder.Entity<Employee>(E =>
            //{
            //    // Id
            //    E.HasKey(E => E.EmpId); // هنا خليت ال EmpId --> PK
            //    E//.Property(E => E.EmpId)
            //     //.Property("EmpId")
            //     .Property(nameof(Employee.EmpId)) // التلت طرق دول صح 
            //     .UseIdentityColumn(1, 1); // طب هنا عاوز عاوز احط constains علي Column ال EmpId
            //                                          // Name
            //    E.Property(E => E.Name)
            //     .HasColumnType("Varchar")
            //     .HasMaxLength(50)
            //     .HasDefaultValue("Ahmed");

            //    // Salary
            //    E.Property(E => E.Salary)
            //     .HasColumnType("money");

            //});





            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations()); //بتاعك apply ده ال  
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // مسؤاله انها تفتح connection
        {
            optionsBuilder.UseSqlServer("Server =.; Database = Company; Trusted_Connection = True ; ");   
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}
