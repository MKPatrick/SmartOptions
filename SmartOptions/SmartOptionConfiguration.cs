using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SmartOptions
{
    public class SmartOptionConfiguration
    {

        public static void CreateConfiguration<T>(WebApplicationBuilder builder, string optionPosition) where T : class
        {
            builder.Services.Configure<T>(
              builder.Configuration.GetSection(optionPosition));
        }

    }
}
