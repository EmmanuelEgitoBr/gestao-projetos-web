using Gestao.Projetos.Domain.Entities;

namespace Gestao.Projetos.Domain.Interfaces;

public interface IPersonRepository
{
    Task AssociateProjectToPersonAsync(string personId, string projectId);
    Task<List<Person>> GetAsync();
    Task<Person?> GetByIdAsync(string id);
    Task<List<Person?>> GetByProjectIdAsync(string projectId);
    Task<List<Person?>> GetAllPersonsWithoutProjectAsync();
    Task CreateAsync(Person person);
    Task UpdateAsync(string id, Person updatedPerson);
    Task DeleteAsync(string id);
}
