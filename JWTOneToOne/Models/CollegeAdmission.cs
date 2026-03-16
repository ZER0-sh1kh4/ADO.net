namespace JWTOneToOne.Models
{
    public class CollegeAdmission
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        public string Course { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
