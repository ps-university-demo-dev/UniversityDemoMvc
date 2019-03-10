using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Data.EF.Repositories
{
    internal class TermRepository : ITermRepository
    {

        public TermRepository(UniversityContext context)
        {
            _dataContext = context;
        }

        private UniversityContext _dataContext;

        public List<Term> LoadTerms() => _dataContext.Terms
                .Include(t => t.Semester)
                .ToList();
    }
}
