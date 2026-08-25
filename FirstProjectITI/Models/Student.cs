using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProjectITI.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        [MaxLength(30,ErrorMessage = "Name Must Be Less Then 30 Letter")]
        [MinLength(3,ErrorMessage ="Name Must Be More Then 3 Letter")]
        [UniqueName]
        public string Name { get; set; }
        [Required]
        [RegularExpression("Alex|Asiut")]
        public  string Address{ get; set; }
        [Required]
        [Range(20, 50)]
        public int Age { get; set; }
        [Required]
        public string Image { get; set; }
        [ForeignKey("Department")]
        [Display(Name = "Department Name")]
        public  int Dept_id{ get; set; }
        public virtual Department? Department { get; set; }
        }
}
