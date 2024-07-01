using AutoMapper;
using Domain.Entities;
using Service.DTOs.Admin.Educations;
using Service.DTOs.Admin.Groups;
using Service.DTOs.Admin.Rooms;
using Service.DTOs.Admin.Students;
using Service.DTOs.Admin.Teachers;

namespace Service.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Group
            CreateMap<Group, GroupDTO>().ForMember(dest => dest.EducationName, opt => opt.MapFrom(src => src.Education.Name))
                .ForMember(dest => dest.RoomName, opt => opt.MapFrom(src => src.Room.Name));
            CreateMap<GroupCreateDTO, Group>();
            CreateMap<GroupEditDTO, Group>();

            //Student
            CreateMap<Student, STudentDTO>().ForMember(dest => dest.Groups, opt => opt.MapFrom(src =>
                src.StudentGroups.Select(gs => gs.Group)));


            CreateMap<StudentCreateDTO, Student>().ForMember(dest => dest.StudentGroups, opt => opt.MapFrom(src =>
        src.GroupId.Select(id => new StudentGroup { GroupId = id })));
            CreateMap<StudentEditDTO, Student>().ForMember(dest => dest.StudentGroups, opt => opt.MapFrom(src =>
        src.GroupId.Select(id => new StudentGroup { GroupId = id })));


            //Education
            CreateMap<Education, EducationDto>();
            CreateMap<EducationCreateDto, Education>();
            CreateMap<EducationEditDto, Education>();

            //Room
            CreateMap<Room, RoomDto>();
            CreateMap<RoomCreateDto, Room>();
            CreateMap<RoomEditDto, Room>();

            //Teacher
            CreateMap<Teacher, TeacherDto>().ForMember(dest => dest.Groups, opt => opt.MapFrom(src =>
                src.TeacherGroups.Select(gs => gs.Group))); ;
            CreateMap<TeacherCreateDto, Teacher>().ForMember(dest => dest.TeacherGroups, opt => opt.MapFrom(src =>
        src.GroupId.Select(id => new TeacherGroup { GroupId = id }))); ;
            CreateMap<TeacherEditDto, Teacher>().ForMember(dest => dest.TeacherGroups, opt => opt.MapFrom(src =>
        src.GroupId.Select(id => new TeacherGroup { GroupId = id })));
        }
    }
}
