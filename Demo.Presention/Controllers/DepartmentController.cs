using Business_Logic.Servies;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Presention.Controllers
{
    public class DepartmentController(IDepartmentServies _departmentServies) : Controller
    {
        //BaseURL/Department /Index
        public IActionResult Index()
        {
           var departments = _departmentServies.GetAllDepartments();
            return View(departments);
        }
    }
}
