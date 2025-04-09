using Gestao.Projetos.Web.Models;
using Gestao.Projetos.Web.Models.Enuns;
using Gestao.Projetos.Web.Services.Interfaces;
using Gestao.Projetos.Web.Services.Interfaces.Base;
using Gestao.Projetos.Web.Settings;

namespace Gestao.Projetos.Web.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IBaseService _baseService;

        public ProjectService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto> CreateProjectAsync(ProjectDto projectDto)
        {
            var request = new RequestDto()
            {
                ApiType = ApiType.POST,
                Content = projectDto,
                Url = AppSettings.ApiBaseUrl + $"/api/projects/create"
            };
            return await _baseService.SendAsync(request!)!;
        }

        public async Task<ResponseDto> DeleteProjectAsync(string id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.DELETE,
                Url = AppSettings.ApiBaseUrl + $"/api/projects/delete/{id}"
            });
        }

        public async Task<ResponseDto> GetAllProjectsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.GET,
                Url = AppSettings.ApiBaseUrl + "/api/projects"
            });
        }

        public async Task<ResponseDto> GetProjectByIdAsync(string id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.GET,
                Url = AppSettings.ApiBaseUrl + $"/api/projects/{id}"
            });
        }

        public async Task<ResponseDto> UpdateProjectAsync(string id, ProjectDto projectDto)
        {
            var request = new RequestDto()
            {
                ApiType = ApiType.PUT,
                Content = projectDto,
                Url = AppSettings.ApiBaseUrl + $"/api/projects/update/{id}"
            };
            return await _baseService.SendAsync(request!)!;
        }
    }
}
