using Service.DTOs.Admin.Groups;

namespace Service.DTOs.Admin.Teachers
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public List<GroupDTO> Groups { get; set; }
    }
}
