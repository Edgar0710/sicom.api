using Microsoft.Extensions.DependencyInjection;
using Sicom.Bussines.Bussines;
using Sicom.Bussines.iBusiness;
using Sicom.Data.IRepository;
using Sicom.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sicom.API.Dependencies
{
    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));
            services.AddScoped<ISicomBusiness, SicomBusiness>();


        }
    }
}
