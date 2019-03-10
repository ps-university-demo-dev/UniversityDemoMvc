using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using University.Core.Domain;

namespace University.Data.DemoData
{
    public class DepartmentData
    {

        internal DepartmentData()
        {
            _departments = new List<Department>()
            {
                new Department() { DepartmentCode = "MA", DepartmentName = "Math", },
                new Department() { DepartmentCode = "PH", DepartmentName = "Physics", },
                new Department() { DepartmentCode = "CH", DepartmentName = "Chemistry", },
                new Department() { DepartmentCode = "CM", DepartmentName = "Chemical Engineering", },
                new Department() { DepartmentCode = "EE", DepartmentName = "Electrical Engineering", },
                new Department() { DepartmentCode = "ME", DepartmentName = "Mechanical Engineering", },
                new Department() { DepartmentCode = "CE", DepartmentName = "Civil Engineering", },
                new Department() { DepartmentCode = "CS", DepartmentName = "Computer Science", },
                new Department() { DepartmentCode = "LA", DepartmentName = "Liberal Arts", },
                new Department() { DepartmentCode = "MG", DepartmentName = "Engineering Management", }
             };
        }

        private static List<Department> _departments = new List<Department>();


        public Department this[string code]
        {
            get => _departments.FirstOrDefault(d => d.DepartmentCode == code);
        }


        public List<Department> AllDepartments
        {
            get => _departments.ToList();
        }



    }
}
