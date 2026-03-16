namespace Loginpage.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public ICollection<Mark>Marks { get; set; }
    }
}
