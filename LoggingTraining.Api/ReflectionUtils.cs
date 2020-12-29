using System.Reflection;

namespace LoggingTraining.Api
{
    public static class ReflectionUtils
    {
        public static string GetAssemblyInformationalVersion<T>() where T : class
        {
            return typeof(T).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }
    }
}