using FirstProjectITI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstProjectITI.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext Context = new ITIContext();

        public IActionResult Index()
        {
            List<Department> departmentList = Context.Departments.Include(d=>d.Emps).ToList();
            return View("Index", departmentList);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }
        //Department/saveadd? Name= sd & ManagerName = Hossam
        // Get Handel
        // Post Handel
        [HttpPost]//fillter
        public IActionResult SaveAdd(Department newdept)
        { 
            if(newdept.Name != null)
            {
                Context.Departments.Add(newdept);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Add",newdept);
        
        }

    }

}
