using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.Domain;

namespace University.Data.DemoData
{
    public class GradeData
    {

        internal GradeData()
        {
            _grades = new List<Grade>()
            {
                new Grade() { GradeCode = "A", Description = "Excellent", Points = 4.0m, IncludeInGpa = true },
                new Grade() { GradeCode = "B", Description = "Above Average", Points = 3.0m, IncludeInGpa = true },
                new Grade() { GradeCode = "C", Description = "Average", Points = 2.0m, IncludeInGpa = true },
                new Grade() { GradeCode = "D", Description = "Below Average", Points = 1.0m, IncludeInGpa = true },
                new Grade() { GradeCode = "F", Description = "Failed", Points = 0.0m, IncludeInGpa = true },
                new Grade() { GradeCode = "W", Description = "Withdrawal", IncludeInGpa = false },
            };
        }

        private List<Grade> _grades = new List<Grade>();


        public Grade this[string code]
        {
            get => _grades.FirstOrDefault(g => g.GradeCode == code);
        }


        public List<Grade> AllGrades
        {
            get => _grades.ToList();
        }

    }
}
