using Business_Logic.DataTransferObjects;
using Business_Logic.Servies;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Presentation.Controllers
{
    public class DepartmentController(IDepartmentServies _departmentServies , 
        ILogger<DepartmentController> _logger , IWebHostEnvironment _environment) : Controller
    {
        //BaseURL/Department /Index
        public IActionResult Index()
        {
           var departments = _departmentServies.GetAllDepartments();
            return View(departments);
        }
        #region Create Department
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreateDepartmentDto departmentDto)
        {
            if(ModelState.IsValid)
            {
                try
                {
                   int Result= _departmentServies.AddDepartment(departmentDto);
                    if (Result > 0)
                    
                        //return View(nameof(Index),_departmentServies.GetAllDepartments());
                        return RedirectToAction(nameof(Index)); 

                    else
                    
                        ModelState.AddModelError(string.Empty, "Error In Adding Department");
                    

                }
                catch(Exception ex)
                {
                    if (_environment.IsDevelopment())
                    
                        //log Error in Console and Return same View with Error message
                        ModelState.AddModelError(string.Empty, ex.Message);
                    
                    else
                    
                        _logger.LogError(ex.Message);
                    

                }
                
            }
            
            
                return View(departmentDto);

            

        }
    }
        #endregion
}

