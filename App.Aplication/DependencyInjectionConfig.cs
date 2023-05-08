using App.Aplication.Services;
using App.Domain.Entidade;
using App.Domain.Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;

namespace App.Application
{
    public class DependencyInjectionConfig
    {
        public static void Inject(IServiceCollection services)
        {
            services.AddTransient<IPessoaService, PessoaService>();
        }
    }
}
