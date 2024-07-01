using Service.DTOs.Admin.Educations;

namespace Service.Service.Interface
{
    public interface IEducationService
    {
        Task CreateAsync(EducationCreateDto model);
        Task<IEnumerable<EducationDto>> GetAllWithAsync();

        Task<EducationDto> GetByIdAsync(int? id);
        Task DeleteAsync(int id);

        Task EditAsync(int id, EducationEditDto model);

        Task<IEnumerable<EducationDto>> GetByName(string name);

        Task<IEnumerable<EducationDto>> SortByName(string message);

    }
}
