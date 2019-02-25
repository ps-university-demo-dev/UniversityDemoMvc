using System;
using System.Collections.Generic;
using System.Text;

namespace University.Core.Domain
{
    public class Courses
    {

        public String DepartmentCode { get; set; }

        public Department Department { get; set; }

        public String CourseNumber { get; set; }

        public String CourseName { get; set; }


        public decimal Credits { get; set; }

    }
}
