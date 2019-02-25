using System;
using System.Collections.Generic;
using System.Text;

namespace University.Core.Domain
{

    /// <summary>
    /// Represents an instance of a course being offered during an academic term.  A course may be offered more than one time
    /// in an academic term
    /// </summary>
    public class CourseSection
    {

        /// <summary>
        /// Unique number of this course section
        /// </summary>
        public int CourseSectionId { get; set; }

        public String DepartmentCode { get; set; }

        public String CourseNumber { get; set; }


        public String TermCode { get; set; }

        public Term Term { get; set; }

        public int SectionNumber { get; set; }

    }
}
