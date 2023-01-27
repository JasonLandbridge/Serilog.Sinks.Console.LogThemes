using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    public static class TestLogger
    {
        public static List<LogEventLevel> LogLevels { get; } = new List<LogEventLevel>()
        {
            LogEventLevel.Verbose,
            LogEventLevel.Debug,
            LogEventLevel.Information,
            LogEventLevel.Warning,
            LogEventLevel.Error,
            LogEventLevel.Fatal,
        };

        public static Logger Create(ConsoleTheme? theme)
        {
            return new LoggerConfiguration()
                .WriteTo.Debug(outputTemplate: LogConfig.Template)
                .WriteTo.Console(theme: theme, outputTemplate: LogConfig.Template)
                .MinimumLevel.Is(LogEventLevel.Verbose)
                .CreateLogger();
        }

        public static async Task LogTest(ConsoleTheme? theme, int printDelay = 100)
        {
            var position = new { Latitude = 25, Longitude = 134 };

            foreach (var logEventLevel in LogLevels)
            {
                using var logger = Create(theme);
                var logEvent = logger.ToLogEvent(logEventLevel,
                    "This is a {LogEventLevel} log message with a json object: {Position}, a number {Count}, a bool: {Boolean}",
                    null,
                    "TestClass",
                    "TestMethod",
                    666,

                    // template properties
                    Enum.GetName(typeof(LogEventLevel), logEventLevel),
                    position,
                    9999,
                    true);
                logger.Write(logEvent);
                await Task.Delay(printDelay);
            }
        }
    }
}