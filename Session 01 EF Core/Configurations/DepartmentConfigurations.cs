using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_01_EF_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_EF_Core.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department> //Mapping ده الكلاس اللي هيعمل ال 
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
          
        }
    }
}
