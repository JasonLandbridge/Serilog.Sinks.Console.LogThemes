using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Serilog.Sinks.SystemConsole.Themes;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace Serilog.Sinks.Console.LogThemes.UnitTests.Demos
{
    public class LogDisplay_UnitTests
    {
        private readonly ITestOutputHelper _output;

        public LogDisplay_UnitTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task ShouldDisplayRandomLogTypesWithDifferentColors_WhenSetupCorrectly()
        {
            // Arrange
            var stopWatch = new Stopwatch();
            var rnd = new Random();

            // Act
            stopWatch.Start();
            for (var i = 0; i < 30; i++)
            {
                for (var j = 0; j < TestLogger.LogLevels.Count; j++)
                {
                    var theme = FakeData.GetFakeTheme(i + j + rnd.Next()).Generate();
                    await TestLogger.LogTest(theme, "FakeClass.FakeMethod", 50);
                }
            }

            // Assert
            stopWatch.Stop();
            _output.WriteLine($"Elapsed time: {stopWatch.ElapsedMilliseconds}");

            true.ShouldBeTrue();
        }

        [Fact]
        public async Task ShouldCreateLogStyleStringWithAllLogThemeStyleSignatures_WhenGivenValidParameters()
        {
            // Arrange
            string ToFullName(string className, string methodName)
            {
                return $"{className}.{methodName}";
            }

            var themeDict = new Dictionary<string, ConsoleTheme>()
            {
                { ToFullName(nameof(SystemConsoleTheme), nameof(SystemConsoleTheme.Literate)) , SystemConsoleTheme.Literate },
                { ToFullName(nameof(LogThemes), nameof(LogThemes.SystemLiterate)) , LogThemes.SystemLiterate },

                { ToFullName(nameof(SystemConsoleTheme), nameof(SystemConsoleTheme.Grayscale)) , SystemConsoleTheme.Grayscale },
                { ToFullName(nameof(LogThemes), nameof(LogThemes.SystemGrayscale)) , LogThemes.SystemGrayscale },

                { ToFullName(nameof(SystemConsoleTheme), nameof(SystemConsoleTheme.Colored)) , SystemConsoleTheme.Colored },
                { ToFullName(nameof(LogThemes), nameof(LogThemes.SystemColored)) , LogThemes.SystemColored },

                { ToFullName(nameof(AnsiConsoleTheme), nameof(AnsiConsoleTheme.Literate)) , AnsiConsoleTheme.Literate },
                { ToFullName(nameof(LogThemes), nameof(LogThemes.Literate)) , LogThemes.Literate },

                { ToFullName(nameof(AnsiConsoleTheme), nameof(AnsiConsoleTheme.Grayscale)) , AnsiConsoleTheme.Grayscale },
                { ToFullName(nameof(LogThemes), nameof(LogThemes.Grayscale)) , LogThemes.Grayscale },

                { ToFullName(nameof(AnsiConsoleTheme), nameof(AnsiConsoleTheme.Code)) , AnsiConsoleTheme.Code },
                { ToFullName(nameof(LogThemes), nameof(LogThemes.Code)) , LogThemes.Code },

                { ToFullName(nameof(AnsiConsoleTheme), nameof(AnsiConsoleTheme.Sixteen)) , AnsiConsoleTheme.Sixteen },
                { ToFullName(nameof(LogThemes), nameof(LogThemes.Sixteen)) , LogThemes.Sixteen },
                { ToFullName(nameof(LogThemes), nameof(LogThemes.SixteenNonBright)) , LogThemes.SixteenNonBright },
            };

            // Act
            foreach (var theme in themeDict)
            {
                await TestLogger.LogTest(theme.Value, theme.Key, 50);
            }

            // Assert
            true.ShouldBeTrue();
        }


    }
}