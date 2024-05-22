using BioDnaLab.Application.Common.Behaviour;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(ctg=>
            {
                ctg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
                //validator
                ctg.AddBehavior(typeof(IPipelineBehavior<,>),typeof(ValidationBehaviour<,>));
            });

            return services;
        }
    }
}
