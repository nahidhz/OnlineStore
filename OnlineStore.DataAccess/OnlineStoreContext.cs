using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.DataAccess
{
   public class OnlineStoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=test;initial catalog=OnlineStore;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseCategoryConfig());
            modelBuilder.ApplyConfiguration(new CourseConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
