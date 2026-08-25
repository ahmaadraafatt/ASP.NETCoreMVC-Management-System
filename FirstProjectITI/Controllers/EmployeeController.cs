using FirstProjectITI.Models;
using FirstProjectITI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstProjectITI.Controllers
{
    public class EmployeeController : Controller
    {
        ITIContext context = new ITIContext();
        public EmployeeController()
        {
        }
        [HttpGet]
        public IActionResult New()
        {
            ViewData["DeptList"] = context.Departments.ToList();
           return View("New");
        }
        [HttpPost]
        public IActionResult SaveNew(Employee EmpFromRequest)
        {
            if (EmpFromRequest.Name != null && EmpFromRequest.Salary >= 6000)
            {
                context.Employees.Add(EmpFromRequest);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["DeptList"] = context.Departments.ToList();
            return View("New", EmpFromRequest);
        }


        public IActionResult Index()
        {
            return View("Index" , context.Employees.ToList());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            Employee EmpModel = context.Employees.FirstOrDefault(e => e.Id == id);
            List<Department> DepartmentList = context.Departments.ToList(); 
            EmpWithDeptListViewModel EmpViewModel = new EmpWithDeptListViewModel();

            EmpViewModel.Id = EmpModel.Id;
            EmpViewModel.Name = EmpModel.Name;
            EmpViewModel.Address = EmpModel.Address;
            EmpViewModel.JobTitle = EmpModel.JobTitle;
            EmpViewModel.ImageURL = EmpModel.ImageURL;
            EmpViewModel.DepartmentID = EmpModel.DepartmentID;
            EmpViewModel.Salary = EmpModel.Salary;
            EmpViewModel.DeptList = DepartmentList;

            return View("Edit", EmpViewModel);
        }
        [HttpPost]
        public IActionResult SaveEdit(int id,Employee EmpFromRequest)
        {
            if (EmpFromRequest.Name != null) 
            {
              Employee? EmpFromDB = context.Employees.FirstOrDefault(e => e.Id == id);
                EmpFromDB.Name = EmpFromRequest.Name;
                EmpFromDB.Address = EmpFromRequest.Address;
                EmpFromDB.Salary = EmpFromRequest.Salary;
                EmpFromDB.JobTitle = EmpFromRequest.JobTitle;
                EmpFromDB.ImageURL = EmpFromRequest.ImageURL;
                EmpFromDB.DepartmentID = EmpFromRequest.DepartmentID;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", EmpFromRequest);

        }
        public IActionResult Details(int id)
        {
            string msg = "Hello From The Action";
            int Temp = 50;
            List<string> Citys = new List<string>();
            Citys.Add("Alex");
            Citys.Add("Assiut");
            Citys.Add("Cairo");

            ViewData["Msg"] = msg;
            ViewData["Citys"] = Citys;
            ViewData["Temp"] = Temp;

            Employee EmpModel = context.Employees.FirstOrDefault(e => e.Id == id);

            return View("Details", EmpModel);
        }
        public IActionResult DetailsVM(int id)
        {
            Employee EmpModel = context.Employees.Include(e => e.Departments).FirstOrDefault(e => e.Id == id);
            List<string> Citys = new List<string>();
            Citys.Add("Alex");
            Citys.Add("Assiut");
            Citys.Add("Cairo");
            EmpDeptColorTempMsgCitysViewModel EmpVM =
                new EmpDeptColorTempMsgCitysViewModel();

            EmpVM.EmpName = EmpModel.Name;
            EmpVM.DeptName = EmpModel.Departments.Name;
            EmpVM.Color = "Red";
            EmpVM.Msg = "Hello From VM";
            EmpVM.Citys = Citys;

            return View("DetailsVM", EmpVM);
        }

    }
}
