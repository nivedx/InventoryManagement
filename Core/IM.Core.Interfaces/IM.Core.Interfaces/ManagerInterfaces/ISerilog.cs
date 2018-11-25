namespace IM.Core.Interfaces
{
    /// <summary>
    /// Iserilog interface contain contracts of serilog handling methods.
    /// </summary>
    public interface ISerilog
    {
        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="data">The data.</param>
        void LogException(object data);
    }
}
