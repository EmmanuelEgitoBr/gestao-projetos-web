using Gestao.Projetos.Application.Dtos;

namespace Gestao.Projetos.Application.Interfaces;

public interface IPersonService
{
    Task<List<PersonDto>> GetAllPersonsAsync();
    Task<PersonDto?> GetPersonByIdAsync(string id);
    Task CreatePersonAsync(PersonDto person);
    Task UpdatePersonAsync(string id, PersonDto updatedPerson);
    Task DeletePersonAsync(string id);
}
