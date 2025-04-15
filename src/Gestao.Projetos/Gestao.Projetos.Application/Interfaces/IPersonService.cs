using Gestao.Projetos.Application.Dtos;

namespace Gestao.Projetos.Application.Interfaces;

public interface IPersonService
{
    Task AssociateProjectToPersonAsync(string personId, string projectId);
    Task<List<PersonDto>> GetAllPersonsAsync();
    Task<PersonDto?> GetPersonByIdAsync(string id);
    Task<List<PersonDto?>> GetPersonsByProjectIdAsync(string projectId);
    Task<List<PersonDto?>> GetAllPersonsWithoutProjectAsync();
    Task CreatePersonAsync(PersonDto person);
    Task UpdatePersonAsync(string id, PersonDto updatedPerson);
    Task DeletePersonAsync(string id);
}
