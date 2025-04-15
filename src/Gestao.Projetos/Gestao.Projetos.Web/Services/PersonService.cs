using Gestao.Projetos.Web.Models;
using Gestao.Projetos.Web.Models.Enuns;
using Gestao.Projetos.Web.Services.Interfaces;
using Gestao.Projetos.Web.Services.Interfaces.Base;
using Gestao.Projetos.Web.Settings;

namespace Gestao.Projetos.Web.Services;

public class PersonService : IPersonService
{
    private readonly IBaseService _baseService;

    public PersonService(IBaseService baseService)
    {
        _baseService = baseService;
    }

    public async Task<ResponseDto> CreatePersonAsync(PersonDto personDto)
    {
        var request = new RequestDto()
        {
            ApiType = ApiType.POST,
            Content = personDto,
            Url = AppSettings.ApiBaseUrl + $"/api/persons/create"
        };
        return await _baseService.SendAsync(request)!;
    }

    public async Task<ResponseDto> DeletePersonAsync(string id)
    {
        return await _baseService.SendAsync(new RequestDto()
        {
            ApiType = ApiType.DELETE,
            Url = AppSettings.ApiBaseUrl + $"/api/persons/delete/{id}"
        });
    }

    public async Task<ResponseDto> GetAllPersonsAsync()
    {
        return await _baseService.SendAsync(new RequestDto()
        {
            ApiType = ApiType.GET,
            Url = AppSettings.ApiBaseUrl + "/api/persons"
        });
    }

    public async Task<ResponseDto> GetPersonByIdAsync(string id)
    {
        return await _baseService.SendAsync(new RequestDto()
        {
            ApiType = ApiType.GET,
            Url = AppSettings.ApiBaseUrl + $"/api/persons/{id}"
        });
    }

    public async Task<ResponseDto> GetPersonsByProjectIdAsync(string projectId)
    {
        return await _baseService.SendAsync(new RequestDto()
        {
            ApiType = ApiType.GET,
            Url = AppSettings.ApiBaseUrl + $"/api/persons/get-by-project/{projectId}"
        });
    }

    public async Task<ResponseDto> GetPersonsWithoutProjectAsync()
    {
        return await _baseService.SendAsync(new RequestDto()
        {
            ApiType = ApiType.GET,
            Url = AppSettings.ApiBaseUrl + $"/api/persons/without-project"
        });
    }

    public async Task<ResponseDto> UpdatePersonAsync(string id, PersonDto personDto)
    {
        var request = new RequestDto()
        {
            ApiType = ApiType.PUT,
            Content = personDto,
            Url = AppSettings.ApiBaseUrl + $"/api/persons/update/{id}"
        };
        return await _baseService.SendAsync(request!)!;
    }
}
