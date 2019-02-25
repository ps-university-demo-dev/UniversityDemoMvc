using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Mvc.Controllers
{
    public class TermsController : Controller
    {
        public TermsController(ITermRepository termRepository)
        {
            _termRepository = termRepository;
        }


        private ITermRepository _termRepository;


        // GET: Grades
        public IActionResult Index()
        {
            List<Term> terms = _termRepository.LoadTerms();

            return View(terms);
        }
    }
}