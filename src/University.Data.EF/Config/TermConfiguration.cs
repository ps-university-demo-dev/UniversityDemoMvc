using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Domain;

namespace University.Data.EF.Config
{
    internal class TermConfiguration : IEntityTypeConfiguration<Term>
    {
        public void Configure(EntityTypeBuilder<Term> builder)
        {
            builder.HasKey(x => x.TermCode);
            builder.HasOne(x => x.Semester).WithMany().HasForeignKey(p => p.SemesterCode);
        }
    }
}
