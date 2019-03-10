using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Data.EF.Repositories
{
    internal class GradeRepository : IGradeRepository
    {

        public GradeRepository(UniversityContext context)
        {
            _dataContext = context;
        }

        private UniversityContext _dataContext;


        public List<Grade> LoadGrades()
        {
            return _dataContext.Grades.ToList();
        }
    }
}
