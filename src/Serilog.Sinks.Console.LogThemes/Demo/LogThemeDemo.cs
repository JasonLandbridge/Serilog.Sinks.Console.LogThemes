using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes.Demo
{
    public static class LogThemeDemo
    {
        private static readonly Random Random = new Random();

        public static readonly string Template =
            "{NewLine}[{Timestamp:HH:mm:ss}] [{Level}] [{ClassName}.{MemberName}:{LineNumber}] => {Message:lj}{NewLine}{Exception}";

        private static string DefaultTemplate => "{NewLine}[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}";

        private static List<LogEventLevel> LogLevels { get; } = new List<LogEventLevel>()
        {
            LogEventLevel.Verbose,
            LogEventLevel.Debug,
            LogEventLevel.Information,
            LogEventLevel.Warning,
            LogEventLevel.Error,
            LogEventLevel.Fatal,
        };

        public static async Task TestAllThemes(
            string outputTemplate = "",
            int printDelay = 0,
            LoggerConfiguration? customConfiguration = null,
            bool disposeLogger = true)
        {
            var defaultTemplate = "{NewLine}[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}";

            customConfiguration ??= new LoggerConfiguration();

            var defaultLogger = customConfiguration
                .WriteTo.Console(outputTemplate: defaultTemplate)
                .MinimumLevel.Is(LogEventLevel.Verbose)
                .CreateLogger();

            foreach (var consoleTheme in LogThemes.AllThemeDictionary())
            {
                defaultLogger.Information("Theme name: {ThemeName}", consoleTheme.Key);
                await TestTheme(consoleTheme.Value, outputTemplate, printDelay);
            }

            if (disposeLogger)
            {
                defaultLogger.Dispose();
            }
        }

        public static async Task TestTheme(
            ConsoleTheme theme,
            string outputTemplate = "",
            int printDelay = 0,
            LoggerConfiguration? customConfiguration = null,
            bool disposeLogger = true)
        {
            if (outputTemplate == "")
            {
                outputTemplate = Template;
            }

            customConfiguration ??= new LoggerConfiguration();

            var logger = customConfiguration
                .WriteTo.Console(theme: theme, outputTemplate: outputTemplate)
                .MinimumLevel.Is(LogEventLevel.Verbose)
                .CreateLogger();

            await Print(logger, printDelay);

            if (disposeLogger)
            {
                logger.Dispose();
            }
        }


        private static async Task Print(ILogger logger, int printDelay = 0)
        {
            var position = new { Latitude = 25, Longitude = 134 };
            var exception = new Exception("Test Exception");

            foreach (var logEventLevel in LogLevels)
            {
                var logEvent = logger.ToLogEvent(logEventLevel,
                    "This is a {LogEventLevel} log message with a json object: {Position}",
                    null,
                    "TestClass",
                    "TestMethod",
                    Random.Next(1, 1000),

                    // template properties
                    Enum.GetName(typeof(LogEventLevel), logEventLevel),
                    position);

                var logEvent2 = logger.ToLogEvent(logEventLevel,
                    "A number {Count}, a bool: {Boolean}, a DateTime: {DateTime}, a Guid: {Guid}",
                    exception,
                    "TestClass",
                    "TestMethod",
                    Random.Next(1, 1000),

                    // template properties
                    Random.Next(1, 1000),
                    true,
                    DateTime.Now,
                    Guid.NewGuid());

                logger.Write(logEvent);
                logger.Write(logEvent2);

                await Task.Delay(printDelay);
            }
        }


        private static LogEvent ToLogEvent(
            this ILogger logInstance,
            LogEventLevel logLevel,
            string messageTemplate,
            Exception? exception = default,
            string className = default!,
            string memberName = default!,
            int sourceLineNumber = default!,
            params object?[]? propertyValues)
        {
            var dateTimeOffset = DateTimeOffset.Now;

            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logInstance.BindMessageTemplate(messageTemplate, propertyValues, out var parsedTemplate, out var boundProperties);
            if (parsedTemplate is null)
            {
                logInstance.Error("LogExtensions.ToLogEvent() => Failed to parse {MessageTemplate} with {@PropertyValues}", messageTemplate,
                    propertyValues);
                return new LogEvent(dateTimeOffset, LogEventLevel.Error, null, MessageTemplate.Empty, new List<LogEventProperty>());
            }

            var properties = boundProperties?.ToList() ?? new List<LogEventProperty>();
            properties.AddRange(new List<LogEventProperty>()
            {
                // This works when each file only has 1 class and is named the same
                new LogEventProperty("ClassName", new ScalarValue(className)),
                new LogEventProperty("MemberName", new ScalarValue(memberName)),
                new LogEventProperty("LineNumber", new ScalarValue(sourceLineNumber)),
            });

            return new LogEvent(dateTimeOffset, logLevel, exception, parsedTemplate, properties);
        }
    }
}