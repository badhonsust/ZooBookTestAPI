using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBook.Application.Interfaces;
using ZooBook.Application.Services;
using ZooBook.Domain.Entities;
using ZooBook.Domain.Interfaces;
using ZooBook.Infra.Data.Repositories;

namespace ZooBook.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();


        }
    }
}
