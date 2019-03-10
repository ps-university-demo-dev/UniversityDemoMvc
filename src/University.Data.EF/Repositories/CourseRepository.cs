using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Data.EF.Repositories
{
    internal class CourseRepository : ICourseRepository
    {
        public CourseRepository(UniversityContext context)
        {
            _dataContext = context;
        }


        private UniversityContext _dataContext;

        public Course GetCourse(string courseId)
        {
            return _dataContext.Courses
                .Include(c => c.Department)
                .Where(c => c.CourseId == courseId)
                .FirstOrDefault();
        }

        public List<Course> GetCourses()
        {
            return _dataContext.Courses
                .Include(c => c.Department)
                .ToList(); ;
        }

        public List<Course> GetCourses(string departmentCode)
        {
            return _dataContext.Courses
                .Include(c => c.Department)
                .Where(c => c.DepartmentCode == departmentCode)
                .ToList();
        }
    }
}
