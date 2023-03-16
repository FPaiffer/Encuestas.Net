

using Condomify.Infrastructure.Data.Repositories;
using Encuestas.Net.Application.Interfaces;
using Encuestas.Net.Application.Interfaces.Contracts;
using Encuestas.Net.Domain.Interfaces.Contracts;
using Encuestas.Net.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Encuestas.Net.Infrastructure.Ioc.DependencyInjections
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            #region DataBaseConnection
            services.AddDbContext<DataBaseContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            #endregion

            AddServices(services);
            AddRepository(services);

            return services;
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<ISurveyService, SurveyService>();
            services.AddScoped<IRespondentService, RespondentService>();
			services.AddScoped<IRespondentResponseService, RespondentResponseService>();
		}

        private static void AddRepository(IServiceCollection services)
        {
            services.AddScoped<ISurveyReporsitory, SurveyRepository>();
            services.AddScoped<IRespondentReporsitory, RespondentRepository>();
			services.AddScoped<IRespondentResponseReporsitory, RespondentResponseRepository>();
		}     
    }
}
