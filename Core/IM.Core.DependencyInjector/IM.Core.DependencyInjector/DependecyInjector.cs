namespace IM.Core.DependencyInjector
{
    using IM.Core.Interfaces;
    using IM.Serilog;
    using SimpleInjector;
    /// <summary>
    /// Dependency injector 
    /// </summary>
    public static class DependecyInjector
    {
        /// <summary>
        /// The dependency injector
        /// </summary>
        /// <param name="container"></param>
        public static void ResolveDependency(Container container)
        {
            //common mappings
            container.Register<ISerilog, SerilogLogger>();
        }
    }
}
