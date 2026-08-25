namespace FirstProjectITI.Models
{
    public class StudentBL
    {
        List<Student> students;

        public StudentBL()
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Ahmed", Image = "2.jpg" });
            students.Add(new Student() { Id = 2, Name = "Mohammed", Image = "2.jpg" });
            students.Add(new Student() { Id = 3, Name = "Nour", Image = "m.Png" });
            students.Add(new Student() { Id = 4, Name = "Sarah", Image = "m.Png" });
        }

        public List<Student> GetAll()
        {
            return students;
        }
        public Student GetById(int id)=>
        students.FirstOrDefault(s => s.Id == id);
        


    }

}
