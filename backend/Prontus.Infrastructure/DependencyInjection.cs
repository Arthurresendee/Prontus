using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prontus.Core.Interfaces;
using Prontus.Infrastructure.Data;
using Prontus.Infrastructure.Repositories;
using Prontus.Infrastructure.UnitOfWork;

namespace Prontus.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProntusDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ProntusDbContext).Assembly.FullName)));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IPacienteRepository, PacienteRepository>();
            services.AddScoped<IDentistaRepository, DentistaRepository>();
            services.AddScoped<IProcedimentoRepository, ProcedimentoRepository>();
            services.AddScoped<IPlanoRepository, PlanoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
} 