namespace IM.Serilog
{
    using IM.Core.Interfaces;
    using global::Serilog;
    using System;
    /// <summary>
    /// Serilog Logger 
    /// </summary>
    /// <seealso cref="EAD.Core.Interfaces.ISerilog" />
    public class SerilogLogger : ISerilog
    {
        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="data">The data.</param>
        public void LogException(object data)
        {
            Log.Error("Exception Occured {@data}", data, DateTime.Now);
        }
    }
}
