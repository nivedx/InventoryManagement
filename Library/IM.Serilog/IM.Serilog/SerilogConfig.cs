namespace IM.Serilog
{
    using global::Serilog;
    using Microsoft.Extensions.Configuration;
    using System;    
    /// <summary>
    /// Serilog configuration class
    /// </summary>
    public static class SerilogConfig
    {
        private static IConfiguration _configuration;

        /// <summary>
        /// To initialize IConfiguration
        /// </summary>
        public static void Init(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        /// <summary>
        /// Logger  configuration.
        /// </summary>
        public static void LoggerConfiguration()
        {
            string logPath = AppDomain.CurrentDomain.BaseDirectory + _configuration["AppConfiguration:LogPath"];
            Log.Logger = new LoggerConfiguration()
               .WriteTo.File(logPath + "/Log.txt",
                  //create new file if given size is exceeded
                  rollOnFileSizeLimit: true,
                  //setting file size
                  fileSizeLimitBytes: 1_971_520)
               .CreateLogger();
        }
    }
}
