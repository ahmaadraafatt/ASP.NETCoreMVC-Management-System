using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProjectITI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string JobTitle { get; set; }
        public string ImageURL { get; set; }
        public string Address { get; set; }
        [ForeignKey("Departments")]
        [Display(Name = "Department")]
        public int DepartmentID { get; set; }
        public Department Departments { get; set; }
    }
}
