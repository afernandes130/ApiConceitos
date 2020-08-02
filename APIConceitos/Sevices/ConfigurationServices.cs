using APIConceitos.IServices;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConceitos.Sevices
{
    public static class ConfigurationServices
    {

        public static void AddServicesRespository(this IServiceCollection services)
        {
            services.AddScoped<IDppCustomerService, DppCustomerService>();
        }
    }
}
