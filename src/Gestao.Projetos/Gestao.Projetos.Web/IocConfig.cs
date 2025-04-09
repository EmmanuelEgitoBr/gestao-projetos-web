using Gestao.Projetos.Web.Services;
using Gestao.Projetos.Web.Services.Base;
using Gestao.Projetos.Web.Services.Interfaces;
using Gestao.Projetos.Web.Services.Interfaces.Base;
using Gestao.Projetos.Web.Settings;

namespace Gestao.Projetos.Web;

public static class IocConfig
{
    public static IServiceCollection ApplyIoC(this IServiceCollection services,
            IConfiguration configuration)
    {
        AppSettings.ApiBaseUrl = configuration.GetValue<string>("ServicesUrls:ApiBaseUrl")!;

        services.AddTransient<IBaseService, BaseService>();
        services.AddTransient<IPersonService, PersonService>();
        services.AddTransient<IProjectService, ProjectService>();

        services.AddHttpContextAccessor();
        services.AddHttpClient();

        return services;
    }
}
