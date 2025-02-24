using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo.config
{
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //modelBuilder.Entity<Employee>().HasKey(e => e.Id);
            builder.HasKey(nameof(Employee.Id));
            builder.Property(e => e.Id).UseIdentityColumn(10, 10);
            builder.Property(e => e.Name).HasColumnName("EmpName").HasColumnType("varchar(50)").IsRequired();
        }
    }
}
