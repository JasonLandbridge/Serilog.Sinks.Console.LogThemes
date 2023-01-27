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
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var rnd = new Random();
            for (var i = 0; i < 100; i++)
            {
                for (var j = 0; j < TestLogger.LogLevels.Count; j++)
                {
                    var theme = FakeData.GetFakeTheme(i + j + rnd.Next()).Generate();
                    await TestLogger.LogTest(theme);
                }
            }

            stopWatch.Stop();
            _output.WriteLine($"Elapsed time: {stopWatch.ElapsedMilliseconds}");
        }
    }
}