using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Domain;

namespace University.Data.EF.Config
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.CourseId);
            builder.HasAlternateKey(x => new { x.DepartmentCode, x.CourseNumber });
            builder.HasOne(x => x.Department).WithMany().HasForeignKey(p => p.DepartmentCode);

            builder.Property(p => p.CourseName)
                .HasMaxLength(100);
                               

        }


    }
}
