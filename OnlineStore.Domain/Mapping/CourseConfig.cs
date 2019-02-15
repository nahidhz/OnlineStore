using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Mapping
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        void IEntityTypeConfiguration<Course>.Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title).IsRequired().HasMaxLength(255);
            builder.HasOne(a => a.CourseCategory).WithMany();
        }
    }
}
