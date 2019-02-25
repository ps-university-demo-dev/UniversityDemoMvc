using System;
using System.Collections.Generic;
using System.Text;

namespace University.Core.Domain
{
    /// <summary>
    /// Represents an acedemic term, i.e. the Fall 2018 semester
    /// </summary>
    public sealed class Term
    {

        public String TermCode { get; set; }

        public String SemesterCode { get; set; }

        public Semester Semester { get; set; }

        public int Year { get; set; }

    }
}
