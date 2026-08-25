using System.ComponentModel.DataAnnotations;

namespace FirstProjectITI.Models
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value == null)
                return null;
            string newName = value.ToString();
            ITIContext context = new ITIContext();
           Student std = context.students.FirstOrDefault(s=> s.Name == newName);
            if(std != null)
            {
                return new ValidationResult("Name Must Be Unique");
            }
            return  ValidationResult.Success;
        }
    }
}
