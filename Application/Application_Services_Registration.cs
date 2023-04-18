﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class Application_Services_Registration
    {
        public static IServiceCollection ConfigureApplicationServices (this IServiceCollection services) // Dependecny Injection with MediaR
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // Use for Automapper
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }

    }
}
