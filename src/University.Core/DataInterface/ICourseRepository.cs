using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Domain;

namespace University.Core.DataInterface
{
    public interface ICourseRepository
    {

        List<Course> GetCourses();


        List<Course> GetCourses(String departmentCode);


        Course GetCourse(String courseId);

    }
}
