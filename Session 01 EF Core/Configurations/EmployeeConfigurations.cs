using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using Session_01_EF_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_EF_Core.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee> //Mapping ده الكلاس اللي هيعمل ال 
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //حطه هنا fluent API  روح هات ال


            // Id
            builder.HasKey(E => E.EmpId); // هنا خليت ال EmpId --> PK
            builder//.Property(E => E.EmpId)
                   //.Property("EmpId")
            .Property(nameof(Employee.EmpId)) // التلت طرق دول صح 
             .UseIdentityColumn(1, 1); // طب هنا عاوز عاوز احط constains علي Column ال EmpId
                                       // Name
            builder.Property(E => E.Name)
             .HasColumnType("Varchar")
             .HasMaxLength(50)
             .HasDefaultValue("Ahmed");

            // Salary
            builder.Property(E => E.Salary)
             .HasColumnType("money");

        }
    }
}
