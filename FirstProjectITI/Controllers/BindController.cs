using FirstProjectITI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProjectITI.Controllers
{
    public class BindController : Controller
    {
        //Requst HTML (data)
        //Binding Prmitive (int , string , float .....
        public IActionResult TestPrmitive(int age, string name)
        {
            return Content($"{name} \t {age}");
        }

        public IActionResult TestDic(Dictionary<string, string> phones)
        {
            return Content("Okkk");
        }
        public IActionResult testObj(Department deptObj)
        {
            return Content("obj");
        }
    }
}
