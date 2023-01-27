using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Serilog.Events;

namespace Serilog.Sinks.Console.LogThemes.UnitTests.LogDisplay
{
    public class LogDisplay_UnitTests
    {
        private readonly ITestOutputHelper _output;

        public LogDisplay_UnitTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task ShouldDisplayAllLogTypesWithDifferentColors_WhenSetupCorrectly()
        {
            var position = new { Latitude = 25, Longitude = 134 };
            var logLevels = new List<LogEventLevel>()
            {
                LogEventLevel.Verbose,
                LogEventLevel.Debug,
                LogEventLevel.Information,
                LogEventLevel.Warning,
                LogEventLevel.Error,
                LogEventLevel.Fatal,
            };

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var rnd = new Random();
            for (var i = 0; i < 100; i++)
            {
                for (var j = 0; j < logLevels.Count; j++)
                {
                    var logEventLevel = logLevels[j];
                    var theme = FakeData.GetFakeTheme(i + j + rnd.Next()).Generate();
                    using var logger = TestLogger.Create(theme);
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
                    await Task.Delay(100);
                }
            }

            stopWatch.Stop();
            _output.WriteLine($"Elapsed time: {stopWatch.ElapsedMilliseconds}");
        }
    }
}