using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MyBlog.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddMediatR(Assembly.GetExecutingAssembly());

            return service;
        }
    }
}
