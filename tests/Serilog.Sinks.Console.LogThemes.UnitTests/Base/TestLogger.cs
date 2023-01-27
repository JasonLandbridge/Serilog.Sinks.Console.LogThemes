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

        public static Logger CreateDefault()
        {
            var defaultTemplate = "{NewLine}[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}";
            return new LoggerConfiguration()
                .WriteTo.Debug(outputTemplate: defaultTemplate)
                .WriteTo.Console(outputTemplate: defaultTemplate)
                .MinimumLevel.Is(LogEventLevel.Verbose)
                .CreateLogger();
        }

        public static async Task LogTest(ConsoleTheme theme, string themeName = "", int printDelay = 100)
        {
            var position = new { Latitude = 25, Longitude = 134 };

            if (themeName != "")
            {
                using var defaultLogger = CreateDefault();
                defaultLogger.Information("Theme name: {ThemeName}", themeName);
            }

            foreach (var logEventLevel in LogLevels)
            {
                using var logger = Create(theme);
                var logEvent = logger.ToLogEvent(logEventLevel,
                    "This is a {LogEventLevel} log message with a json object: {Position}, a number {Count}, a bool: {Boolean}, a DateTime: {DateTime}, a Guid: {Guid}",
                    null,
                    "TestClass",
                    "TestMethod",
                    666,

                    // template properties
                    Enum.GetName(typeof(LogEventLevel), logEventLevel),
                    position,
                    9999,
                    true,
                    DateTime.Now,
                    Guid.NewGuid());
                logger.Write(logEvent);
                await Task.Delay(printDelay);
            }
        }
    }
}