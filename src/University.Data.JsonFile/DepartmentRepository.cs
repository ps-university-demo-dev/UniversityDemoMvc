using System;
using System.Collections.Generic;
using System.Text;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Data.JsonFile
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public DepartmentRepository(String dataDirectory)
        {
            _dataDirectory = dataDirectory;
        }

        private String _dataDirectory;




        public List<Department> GetDepartments()
        {
            FileDataObject fdo = new FileDataObject(_dataDirectory);
            return fdo.ReadDepartmentsFile();
        }

    }
}
