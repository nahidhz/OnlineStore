using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Services.IServices;
using OnlineStore.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Config
{
   public static class OnlineStoreBootstrapper
    {
        public static void WireUp(IServiceCollection services)
        {
            services.AddScoped<ICourseCategoryService, CourseCategoryService>();
            services.AddScoped<ICourseService, CourseService>();
          //  services.AddScoped<OnlineStoreContext>();

        }
    }
}
