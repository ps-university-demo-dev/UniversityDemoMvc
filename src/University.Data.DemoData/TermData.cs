using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.Domain;

namespace University.Data.DemoData
{
    public class TermData
    {

        internal TermData()
        {
            _terms = new List<Term>()
            {
                new Term() { TermCode = "FA2013", SemesterCode = "FA", Year = 2013, Semester = UniversityData.Semesters["FA"] },
                new Term() { TermCode = "SP2014", SemesterCode = "SP", Year = 2014, Semester = UniversityData.Semesters["SP"] },
                new Term() { TermCode = "FA2014", SemesterCode = "FA", Year = 2014, Semester = UniversityData.Semesters["FA"] },
                new Term() { TermCode = "SP2015", SemesterCode = "SP", Year = 2015, Semester = UniversityData.Semesters["SP"] },
                new Term() { TermCode = "FA2015", SemesterCode = "FA", Year = 2015, Semester = UniversityData.Semesters["FA"] },
                new Term() { TermCode = "SP2016", SemesterCode = "SP", Year = 2016, Semester = UniversityData.Semesters["SP"] },
                new Term() { TermCode = "FA2016", SemesterCode = "FA", Year = 2016, Semester = UniversityData.Semesters["FA"] },
                new Term() { TermCode = "SP2017", SemesterCode = "SP", Year = 2017, Semester = UniversityData.Semesters["SP"] },
                new Term() { TermCode = "FA2017", SemesterCode = "FA", Year = 2017, Semester = UniversityData.Semesters["FA"] },
                new Term() { TermCode = "SP2018", SemesterCode = "SP", Year = 2018, Semester = UniversityData.Semesters["SP"] },
                new Term() { TermCode = "FA2018", SemesterCode = "FA", Year = 2018, Semester = UniversityData.Semesters["FA"] },
                new Term() { TermCode = "SP2019", SemesterCode = "SP", Year = 2019, Semester = UniversityData.Semesters["SP"] }
            };
        }


        private List<Term> _terms = new List<Term>();


        public Term this[string code]
        {
            get => _terms.FirstOrDefault(s => s.TermCode == code);
        }


        public List<Term> AllTerms
        {
            get => _terms.ToList();
        }

    }
}
