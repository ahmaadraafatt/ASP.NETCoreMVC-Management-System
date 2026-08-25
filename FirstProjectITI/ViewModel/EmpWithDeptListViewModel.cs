using FirstProjectITI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProjectITI.ViewModel
{
    public class EmpWithDeptListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string JobTitle { get; set; }
        public string ImageURL { get; set; }
        //[DataType(DataType.Password)]
        public string Address { get; set; }
        public int DepartmentID { get; set; }
        public List<Department> DeptList { get; set; }
    }
}
