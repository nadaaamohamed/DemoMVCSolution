using Business_Logic.DataTransferObjects;
using Business_Logic.Servies;
using Demo.Presentation.ViewModels.DepartmentViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Demo.Presentation.Controllers
{
    public class DepartmentController(IDepartmentServies _departmentServies,
        ILogger<DepartmentController> _logger, IWebHostEnvironment _environment) : Controller
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
            if (ModelState.IsValid)
            {
                try
                {
                    int Result = _departmentServies.AddDepartment(departmentDto);
                    if (Result > 0)

                        //return View(nameof(Index),_departmentServies.GetAllDepartments());
                        return RedirectToAction(nameof(Index));

                    else

                        ModelState.AddModelError(string.Empty, "Error In Adding Department");


                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())

                        //log Error in Console and Return same View with Error message
                        ModelState.AddModelError(string.Empty, ex.Message);

                    else

                        _logger.LogError(ex.Message);
                    return View("ErrorView", ex.Message);   


                }

            }


            return View(departmentDto);



        }
        #endregion

        #region Details Of Department
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var department = _departmentServies.GetDepartmentById(id.Value);
            if (department is null) return NotFound();
            return View(department);


        }
        #endregion
        #region Edit
        public IActionResult Edit (int? id)
        {
            if(!id.HasValue) return BadRequest();
            var department = _departmentServies.GetDepartmentById(id.Value);
            if(department is null) return NotFound();
            var departmentEditViewModel = new DepartmentEditViewModel()
            {

                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                DateOfCreation = department.CreatedOn
            };
           
            return View(departmentEditViewModel);
        }
        [HttpPost]
        public IActionResult Edit([FromRoute]int id,DepartmentEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var departmentDto = new UpdatedDepartmentDto()
                    {
                        Id=id,
                        Name = viewModel.Name,
                        Code = viewModel.Code,
                        Description = viewModel.Description,
                        DateOfCreation = viewModel.DateOfCreation
                    };
                    int Result = _departmentServies.UpdateDepartment(departmentDto);
                    if (Result > 0)
                        return RedirectToAction(nameof(Index));
                    else
                       
                        ModelState.AddModelError(string.Empty, "Department Is Not Update");
                    
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())

                        //log Error in Console and Return same View with Error message
                        ModelState.AddModelError(string.Empty, ex.Message);

                    else

                        _logger.LogError(ex.Message);
                    return View(viewModel);


                }

            }

            return View(viewModel);

        }

        #endregion

    }
}
        
        
    
