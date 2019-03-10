using System;
using System.Collections.Generic;
using System.Text;

namespace University.Core.Domain
{
    /// <summary>
    /// Represents a grade that can be earned for a course.
    /// </summary>
    /// <remarks>
    /// Included in grades is also the code W for Withdrawal when a student withdraws from the course.
    /// In this case, the grade is not included in GPA calculations
    /// </remarks>
    public class Grade
    {
        /// <summary>
        /// The letter grade of the grade or W for withdrawal from a course
        /// </summary>
        public String GradeCode { get; set; }


        public String Description { get; set; }


        /// <summary>
        /// The number of points the grade is worth (A = 4.0, B = 3.0, etc)
        /// </summary>
        public decimal? Points { get; set; }

        /// <summary>
        /// Flag to indicate if this result should be included in GPA calculations
        /// </summary>
        public bool IncludeInGpa { get; set; }

    }
}
