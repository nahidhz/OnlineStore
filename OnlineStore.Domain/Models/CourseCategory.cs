using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Models
{
   public class CourseCategory
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategory ParentCategory { get; set; }
    }
}
