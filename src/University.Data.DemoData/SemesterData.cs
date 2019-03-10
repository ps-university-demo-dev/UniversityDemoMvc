using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.Domain;

namespace University.Data.DemoData
{
    public class SemesterData
    {

        internal SemesterData()
        {
            _semesters = new List<Semester>()
            {
                new Semester() { Code = "FA", Name = "Fall"},
                new Semester() { Code = "SP", Name = "Spring" },
                new Semester() { Code = "SU", Name = "Summer" }
            };
        }


        private List<Semester> _semesters = new List<Semester>();


        public Semester this[string code]
        {
            get => _semesters.FirstOrDefault(s => s.Code == code);
        }


        public List<Semester> AllSemesters
        {
            get => _semesters.ToList();
        }

    }
}
