using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Core.DataInterface;

namespace University.Mvc.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseRepository coursesRepository;

        public CoursesController(ICourseRepository coursesRepository)
        {
            this.coursesRepository = coursesRepository;
        }


        // GET: Courses
        public ActionResult Index()
        {
            var courses = coursesRepository.GetCourses()
                .OrderBy(c => c.DepartmentCode)
                .ThenBy(c => c.CourseNumber)
                .ToList();
            return View(courses);
        }

        // GET: Courses/Details/PH101
        public ActionResult Details(string courseId)
        {
            var course = coursesRepository.GetCourse(courseId);
            return View(course);
        }




    }
}