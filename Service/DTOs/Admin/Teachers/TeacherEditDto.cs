namespace Service.DTOs.Admin.Teachers
{
    public class TeacherEditDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public List<int> GroupId { get; set; }
    }
}
