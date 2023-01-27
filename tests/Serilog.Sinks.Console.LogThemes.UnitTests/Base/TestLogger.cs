using Serilog.Core;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    public static class TestLogger
    {
        public static Logger Create(ConsoleTheme? theme)
        {
            return new LoggerConfiguration()
                .WriteTo.Debug(outputTemplate: LogConfig.Template)
                .WriteTo.Console(theme: theme, outputTemplate: LogConfig.Template)
                .CreateLogger();
        }
    }
}