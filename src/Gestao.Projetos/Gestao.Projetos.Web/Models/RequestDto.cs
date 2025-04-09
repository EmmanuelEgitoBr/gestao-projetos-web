using Gestao.Projetos.Web.Models.Enuns;

namespace Gestao.Projetos.Web.Models;

public class RequestDto
{
    public object? Content { get; set; }
    public ApiType ApiType { get; set; } = ApiType.GET;
    public string Url { get; set; } = string.Empty;
    public string AccessToken { get; set; } = string.Empty;
}
