using Gestao.Projetos.Web.Models;

namespace Gestao.Projetos.Web.Services.Interfaces.Base;

public interface IBaseService
{
    Task<ResponseDto?> SendAsync(RequestDto requestDto);
}
