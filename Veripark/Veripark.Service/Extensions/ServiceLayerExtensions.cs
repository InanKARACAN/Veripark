using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veripark.Service.Services.Abstractions;
using Veripark.Service.Services.Concretes;

namespace Veripark.Service.Extensions
{
    public static class ServiceLayerExtensions
    {

        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            services.AddScoped<IMusteriTipService, MusteriTipService>();
            services.AddScoped<IOlayTipService, OlayTipService>();
            services.AddScoped<ISikayetService, SikayetService>();

            return services;
        }
    }
}
