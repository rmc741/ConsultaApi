using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaAPI.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddComponents(this IServiceCollection service)
    {
        //service.AddTransient<IValidator<GetCandidatoByCpfRequest>, CpfValidator>();
        //service.AddTransient<IValidator<SendEmailRequest>, EmailValidator>();
        //
        //service.AddSingleton<ICandidatoRepository>(provider =>
        //{
        //    var logger = provider.GetRequiredService<ILogger<CandidatoRepository>>();
        //    var databaseSettings = provider.GetRequiredService<IOptions<StorageAccountOptions>>();
        //    var key = provider.GetRequiredService<IOptions<SecurityOptions>>();
        //    return new CandidatoRepository(logger, databaseSettings.Value.ConexaoSqlServer, key.Value.ChaveCriptografada);
        //});

        return service;
    }

    public static IServiceCollection AddApiOptions(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
                //.Configure<StorageAccountOptions>(options =>
                //{
                //    options.ConexaoSqlServer = configuracoes.GetValue<string>("StorageAccount:ConexaoSqlServer");
                //});
    }
}
