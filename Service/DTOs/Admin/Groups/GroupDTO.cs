namespace Service.DTOs.Admin.Groups
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int StudentCount { get; set; }
        public string EducationName { get; set; }
        public string RoomName { get; set; }
    }
}
