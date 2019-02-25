using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Core.DataInterface;

namespace University.Mvc.Controllers
{
    public class SemestersController : Controller
    {

        public SemestersController(ISemesterRepository semesterRepository)
        {
            _semesterRepository = semesterRepository;
        }

        private ISemesterRepository _semesterRepository;

        public IActionResult Index()
        {
            var semesters = _semesterRepository.LoadSemesters();
            return View(semesters);
        }
    }
}