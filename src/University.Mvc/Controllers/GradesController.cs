using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Mvc.Controllers
{
    public class GradesController : Controller
    {

        public GradesController(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }


        private IGradeRepository _gradeRepository;


        // GET: Grades
        public ActionResult Index()
        {
            List<Grade> grades = _gradeRepository.LoadGrades();

            return View(grades);
        }


    }
}