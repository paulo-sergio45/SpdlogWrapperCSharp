using System;
using System.Runtime.InteropServices;


namespace SpdlogWrapperCSharp
{
    public class SpdlogWrapperDllImport
    {

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void create_basic_logger(string name, string filePath);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void create_daily_logger(string name, string filePath, int hour, int minute);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void create_rotating_logger(string name, string filePath, int maxSize, int maxFiles);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void create_console_logger(string name);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void log_trace(string loggerName, string msg);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void log_debug(string loggerName, string msg);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void log_info(string loggerName, string msg);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void log_warn(string loggerName, string msg);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void log_error(string loggerName, string msg);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void log_critical(string loggerName, string msg);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void set_level(string loggerName, int level);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void set_pattern(string loggerName, string pattern);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void flush_logger(string loggerName);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void flush_on(string loggerName, int level);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void flush_every_seconds(int seconds);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void shutdown_logging();

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void drop_logger(string loggerName);

        [DllImport("SpdlogWrapperCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void drop_all_loggers();

        // Métodos que simplificam a interface para o usuário
        public void CreateBasicLogger(string name, string filePath)
        {
            create_basic_logger(name, filePath);
        }

        public void CreateDailyLogger(string name, string filePath, int hour, int minute)
        {
            create_daily_logger(name, filePath, hour, minute);
        }

        public void CreateRotatingLogger(string name, string filePath, int maxSize, int maxFiles)
        {
            create_rotating_logger(name, filePath, maxSize, maxFiles);
        }

        public void CreateConsoleLogger(string name)
        {
            create_console_logger(name);
        }

        public void LogTrace(string loggerName, string msg)
        {
            log_trace(loggerName, msg);
        }

        public void LogDebug(string loggerName, string msg)
        {
            log_debug(loggerName, msg);
        }

        public void LogInfo(string loggerName, string msg)
        {
            log_info(loggerName, msg);
        }

        public void LogWarn(string loggerName, string msg)
        {
            log_warn(loggerName, msg);
        }

        public void LogError(string loggerName, string msg)
        {
            log_error(loggerName, msg);
        }

        public void LogCritical(string loggerName, string msg)
        {
            log_critical(loggerName, msg);
        }

        public void SetLevel(string loggerName, int level)
        {
            set_level(loggerName, level);
        }

        public void SetPattern(string loggerName, string pattern)
        {
            set_pattern(loggerName, pattern);
        }

        public void FlushLogger(string loggerName)
        {
            flush_logger(loggerName);
        }

        public void FlushOn(string loggerName, int level)
        {
            flush_on(loggerName, level);
        }

        public void FlushEverySeconds(int seconds)
        {
            flush_every_seconds(seconds);
        }

        public void ShutdownLogging()
        {
            shutdown_logging();
        }

        public void DropLogger(string loggerName)
        {
            drop_logger(loggerName);
        }

        public void DropAllLoggers()
        {
            drop_all_loggers();
        }
    }
}