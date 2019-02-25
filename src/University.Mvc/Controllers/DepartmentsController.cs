using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Core.DataInterface;

namespace University.Mvc.Controllers
{
    public class DepartmentsController : Controller
    {

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }


        private IDepartmentRepository _departmentRepository;

        public IActionResult Index()
        {
            var departments = _departmentRepository.GetDepartments();
            return View(departments);
        }
    }
}