using Gestao.Projetos.Web.Models;

namespace Gestao.Projetos.Web.Services.Interfaces;

public interface IPersonService
{
    Task<ResponseDto> CreatePersonAsync(PersonDto personDto);
    Task<ResponseDto> DeletePersonAsync(string id);
    Task<ResponseDto> GetAllPersonsAsync();
    Task<ResponseDto> GetPersonByIdAsync(string id);
    Task<ResponseDto> UpdatePersonAsync(string id, PersonDto personDto);
}
