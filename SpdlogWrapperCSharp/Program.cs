using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpdlogWrapperCSharp
{
    class Program
    {
        static void Main()
        {
            SpdlogWrapper.CreateConsoleLogger("console_logger");

            SpdlogWrapper.SetLevel("console_logger", 0);

            SpdlogWrapper.LogTrace("console_logger", "Mensagem de TRACE no console logger");
            SpdlogWrapper.LogDebug("console_logger", "Mensagem de DEBUG no console logger");
            SpdlogWrapper.LogInfo("console_logger", "Mensagem de INFO no console logger");
            SpdlogWrapper.LogWarn("console_logger", "Mensagem de WARN no console logger");
            SpdlogWrapper.LogError("console_logger", "Mensagem de ERROR no console logger");
            SpdlogWrapper.LogCritical("console_logger", "Mensagem de CRITICAL no console logger");

            SpdlogWrapper.LogInfo("console_logger", "Criando logger basico");
            SpdlogWrapper.CreateBasicLogger("basic_logger", "basic_log.txt");

            SpdlogWrapper.LogInfo("console_logger", "Criando logger diario");
            SpdlogWrapper.CreateDailyLogger("daily_logger", "daily_log.txt", 0, 0);

            SpdlogWrapper.LogInfo("console_logger", "Criando logger rotativo");
            SpdlogWrapper.CreateRotatingLogger("rotating_logger", "rotating_log.txt", 1024 * 1024, 3);

            SpdlogWrapper.LogInfo("basic_logger", "Mensagem de INFO no basic logger");
            SpdlogWrapper.LogWarn("basic_logger", "Mensagem de WARN no basic logger");

            SpdlogWrapper.LogInfo("daily_logger", "Mensagem de INFO no daily logger");

            SpdlogWrapper.LogInfo("rotating_logger", "Mensagem de INFO no rotating logger");

            SpdlogWrapper.LogInfo("console_logger", "Alterando padrao de formatacao do 'basic_logger'");
            SpdlogWrapper.SetPattern("basic_logger", "[%Y-%m-%d %H:%M:%S] [%l] %v");

            SpdlogWrapper.LogInfo("console_logger", "Alterando nivel de log do 'daily_logger' para DEBUG");
            SpdlogWrapper.SetLevel("daily_logger", 1);

            SpdlogWrapper.LogInfo("console_logger", "Alterando nivel de log do 'console_logger' para WARN");
            SpdlogWrapper.SetLevel("console_logger", 2);

            SpdlogWrapper.LogInfo("basic_logger", "Nova mensagem de INFO com padrao alterado");

            SpdlogWrapper.LogDebug("daily_logger", "Mensagem de DEBUG no daily logger apos mudanca de nivel");

            SpdlogWrapper.LogDebug("console_logger", "Mensagem de DEBUG no console logger");
            SpdlogWrapper.LogWarn("console_logger", "Mensagem de WARN no console logger");

            SpdlogWrapper.LogInfo("console_logger", "Forcando flush no 'basic_logger'");
            SpdlogWrapper.FlushLogger("basic_logger");

            SpdlogWrapper.LogInfo("console_logger", "Forcando flush no 'daily_logger'");
            SpdlogWrapper.FlushLogger("daily_logger");

            SpdlogWrapper.LogInfo("console_logger", "Finalizando o logging");
            SpdlogWrapper.ShutdownLogging();

            SpdlogWrapper.LogInfo("console_logger", "Removendo o logger 'rotating_logger'");
            SpdlogWrapper.DropLogger("rotating_logger");

            SpdlogWrapper.LogInfo("console_logger", "Removendo todos os loggers");
            SpdlogWrapper.DropAllLoggers();
        }
    }
}