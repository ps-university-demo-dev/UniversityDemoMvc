using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Data.EF.Repositories
{
    internal class DepartmentRepository : IDepartmentRepository
    {


        public DepartmentRepository(UniversityContext context)
        {
            _dataContext = context;
        }

        private UniversityContext _dataContext;

        public List<Department> GetDepartments()
        {
            return _dataContext.Departments.ToList();
        }



    }
}
