using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Mapping
{
    public class CourseCategoryConfig : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title).IsRequired().HasMaxLength(255);
            builder.HasOne(a => a.ParentCategory).WithMany();
        }
    }
}
