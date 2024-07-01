using Domain.Common;

namespace Domain.Entities
{
    public class Group: BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int StudentCount { get; set; }
        public List<StudentGroup> StudentGroups { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
        public List<TeacherGroup> TeacherGroups { get; set; }

        public int EducationId { get; set; }
        public Education Education { get; set; }

    }
}
