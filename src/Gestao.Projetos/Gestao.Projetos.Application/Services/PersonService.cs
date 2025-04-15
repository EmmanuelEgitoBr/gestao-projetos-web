using AutoMapper;
using Gestao.Projetos.Application.Dtos;
using Gestao.Projetos.Application.Interfaces;
using Gestao.Projetos.Domain.Entities;
using Gestao.Projetos.Domain.Interfaces;

namespace Gestao.Projetos.Application.Services;

public class PersonService : IPersonService
{
    private IMapper _mapper;
    private readonly IPersonRepository _personRepository;

    public PersonService(IMapper mapper, IPersonRepository personRepository)
    {
        _mapper = mapper;
        _personRepository = personRepository;
    }

    public async Task CreatePersonAsync(PersonDto person)
    {
        var personEntity = _mapper.Map<Person>(person);
        await _personRepository.CreateAsync(personEntity);
    }

    public async Task DeletePersonAsync(string id)
    {
        await _personRepository.DeleteAsync(id);
    }

    public async Task<List<PersonDto>> GetAllPersonsAsync()
    {
        var personListEntity = await _personRepository.GetAsync();
        return _mapper.Map<List<PersonDto>>(personListEntity);
    }

    public async Task<PersonDto?> GetPersonByIdAsync(string id)
    {
        var personEntity = await _personRepository.GetByIdAsync(id);
        return _mapper.Map<PersonDto>(personEntity);
    }

    public async Task UpdatePersonAsync(string id, PersonDto updatedPerson)
    {
        var personEntity = _mapper.Map<Person>(updatedPerson);
        await _personRepository.UpdateAsync(id, personEntity);
    }

    public async Task AssociateProjectToPersonAsync(string personId, string projectId)
    {
        await _personRepository.AssociateProjectToPersonAsync(personId, projectId);
    }

    public async Task<List<PersonDto?>> GetPersonsByProjectIdAsync(string projectId)
    {
        var persons = await _personRepository.GetByProjectIdAsync(projectId);
        var personsDto = _mapper.Map<List<PersonDto?>>(persons);
        return personsDto;
    }

    public async Task<List<PersonDto?>> GetAllPersonsWithoutProjectAsync()
    {
        var persons = await _personRepository.GetAllPersonsWithoutProjectAsync();
        var personsDto = _mapper.Map<List<PersonDto?>>(persons);
        return personsDto;
    }
}
