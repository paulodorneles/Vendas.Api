using Api.Domain.Interfaces.Services.User;
using Api.Domain.Interfaces.Services;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<IProdutoService, ProdutoService>();
            serviceCollection.AddTransient<IClienteService, ClienteService>();
            serviceCollection.AddTransient<IPedidoService, PedidoService>();
            serviceCollection.AddTransient<ICategoriaService, CategoriaService>();            
        }
    }
}
