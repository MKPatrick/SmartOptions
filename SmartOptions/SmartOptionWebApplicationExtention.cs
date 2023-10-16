using Microsoft.AspNetCore.Builder;
using System.Reflection;

namespace SmartOptions
{

    public static class SmartOptionWebApplicationExtention
    {
        /// <summary>
        /// Register all Classes which has the Attribute SmartOptions with IOptions Pattern
        /// </summary>
        /// <param name="builder"></param>
        public static void SmartOptionsInitalize(this WebApplicationBuilder builder)
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            var typesWithAttribute = assembly.GetTypes().Where(type =>
                Attribute.IsDefined(type, typeof(SmartOption)));

            foreach (Type type in typesWithAttribute)
            {
                var attribute = Attribute.GetCustomAttribute(type, typeof(SmartOption)) as SmartOption;

                MethodInfo createConfiguration = typeof(SmartOptionConfiguration).GetMethod("CreateConfiguration");
                MethodInfo createConfigurationMethodInfo = createConfiguration.MakeGenericMethod(type);
                createConfigurationMethodInfo.Invoke(new SmartOptionConfiguration(), new object[] { builder, attribute.OptionPosition });
            }
        }
    }
}
