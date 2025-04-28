using System;
using System.Runtime.InteropServices;


namespace SpdlogWrapperCSharp
{
    public  partial class SpdlogWrapper
    {

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "create_console_logger", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void CreateConsoleLogger(string name);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "create_basic_logger", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void CreateBasicLogger(string name, string filePath);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "create_daily_logger", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void CreateDailyLogger(string name, string filePath, int hour, int minute);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "create_rotating_logger", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void CreateRotatingLogger(string name, string filePath, int maxSize, int maxFiles);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "log_trace", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void LogTrace(string loggerName, string message);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "log_debug", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void LogDebug(string loggerName, string message);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "log_info", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void LogInfo(string loggerName, string message);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "log_warn", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void LogWarn(string loggerName, string message);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "log_error", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void LogError(string loggerName, string message);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "log_critical", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void LogCritical(string loggerName, string message);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "set_level", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void SetLevel(string loggerName, int level);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "set_pattern", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void SetPattern(string loggerName, string pattern);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "flush_logger", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void FlushLogger(string loggerName);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "flush_on", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void FlushOn(string loggerName, int level);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "flush_every_seconds", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void FlushEverySeconds(int seconds);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "shutdown_logging", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void ShutdownLogging();

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "drop_logger", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void DropLogger(string loggerName);

        [LibraryImport("SpdlogWrapperCPP", EntryPoint = "drop_all_loggers", StringMarshalling = StringMarshalling.Utf8)]
        public static partial void DropAllLoggers();
    }
}