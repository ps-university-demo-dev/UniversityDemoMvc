using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Data.EF.Repositories
{
    internal class SemesterRepository : ISemesterRepository
    {
        public SemesterRepository(UniversityContext context)
        {
            _dataContext = context;
        }

        private UniversityContext _dataContext;


        public List<Semester> LoadSemesters()
        {
            return _dataContext.Semesters.ToList(); ;
        }

    }
}
