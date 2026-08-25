using FirstProjectITI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace FirstProjectITI.Controllers
{
    public class StudentController : Controller
    {
        ITIContext context = new ITIContext();

        public IActionResult Index()
        {
            List<Student> StudentListModel = context.students.ToList();
            return View("Index", StudentListModel);
        }

        public IActionResult Details(int id)
        {
            Student StudentModel = context.students.FirstOrDefault(s => s.Id == id);
            return View("ShowDetails", StudentModel);
        }
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Student newStd)
        {
            if (ModelState.IsValid)
            {
                //Custom Validatoin Dept_ID != 0 
                if (newStd.Dept_id != 0)
                {
                    try
                    {
                        context.students.Add(newStd);
                        context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    catch (Exception ex)
                    {
                        //error message send view
                        ModelState.AddModelError("Dept_id", ex.Message);//div
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Select Department");

                }
            }

            ViewData["DeptList"] = context.Departments.ToList();
            return View(newStd);

        }
        public IActionResult SaveEdit(int id, Student newStd)
        {
            Student oldStudent = context.students.FirstOrDefault(s => s.Id == id);
            if (ModelState.IsValid)
            {
                oldStudent.Name = newStd.Name;
                oldStudent.Address = newStd.Address;
                oldStudent.Age = newStd.Age;
                oldStudent.Image = newStd.Image;
                oldStudent.Dept_id = newStd.Dept_id;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", oldStudent);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student StudentModel = context.students.FirstOrDefault(s => s.Id == id);
            return View("Edit", StudentModel);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Student StudentToDelete = context.students.FirstOrDefault(s => s.Id == id);
            context.students.Remove(StudentToDelete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
