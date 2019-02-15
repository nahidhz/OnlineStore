using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Models
{
   public class Course
    {
        public long Id { get; set; }
        public long Title { get; set; }
        public CourseCategory CourseCategory { get; set; }
    }
}
