using AutoMapper;
using Domain.Entities;
using Microsoft.Extensions.Logging;
using Repository.Repositories.Interface;
using Service.DTOs.Admin.Educations;
using Service.Helpers.Exceptions;
using Service.Service.Interface;

namespace Service.Service
{
    public class EducationService:IEducationService
    {
        private readonly IEducationRepository _educationRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<EducationService> _logger;

        public EducationService(IMapper mapper,
                           IEducationRepository educationRepo,
                           ILogger<EducationService> logger)

        {
            _educationRepo = educationRepo;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task CreateAsync(EducationCreateDto model)
        {
            if (model == null) throw new ArgumentNullException();

            await _educationRepo.CreateAsync(_mapper.Map<Education>(model));
        }

        public async Task DeleteAsync(int id)
        {
            if (id == null)
            {
                _logger.LogWarning("Id is null");
                throw new ArgumentNullException();
            }
            var data = await _educationRepo.GetById((int)id);
            await _educationRepo.DeleteAsync(data);
        }

        public async Task EditAsync(int id, EducationEditDto model)
        {
            if (model == null) throw new ArgumentNullException();
            var data = await _educationRepo.GetById(id);

            if (data is null) throw new ArgumentNullException();

            var editData = _mapper.Map(model, data);
            await _educationRepo.EditAsync(editData);
        }


        public async Task<IEnumerable<EducationDto>> GetAllWithAsync()
        {
            _logger.LogInformation("Get All method is working");

            var data = await _educationRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<EducationDto>>(data);
        }


        public async Task<EducationDto> GetByIdAsync(int? id)
        {
            return _mapper.Map<EducationDto>(await _educationRepo.GetById((int)id));
        }

        public async Task<IEnumerable<EducationDto>> GetByName(string name)
        {
            if (name == null) throw new NotFoundException("Name is null");
            var data = _mapper.Map<IEnumerable<EducationDto>>(await _educationRepo.GetByName(name));

            return data;
        }

        public async Task<IEnumerable<EducationDto>> SortByName(string message)
        {
            if (message == null) throw new NotFoundException("Meesage is null");
            var data = _mapper.Map<IEnumerable<EducationDto>>(await _educationRepo.SortByName(message));

            return data;
        }
    }
}
