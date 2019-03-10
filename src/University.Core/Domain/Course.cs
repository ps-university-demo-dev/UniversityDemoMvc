using System;
using System.Collections.Generic;
using System.Text;

namespace University.Core.Domain
{
    public class Course
    {

        public String CourseId { get; set; }

        public String DepartmentCode { get; set; }

        public Department Department { get; set; }

        public String CourseNumber { get; set; }

        public String CourseName { get; set; }


        public decimal Credits { get; set; }

    }
}
