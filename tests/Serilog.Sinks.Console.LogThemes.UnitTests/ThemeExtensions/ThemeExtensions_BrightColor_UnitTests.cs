using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Serilog.Sinks.SystemConsole.Themes;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    public class ThemeExtensions_BrightColor_UnitTests
    {
        private readonly ITestOutputHelper _output;

        public ThemeExtensions_BrightColor_UnitTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task ShouldCreateLogStyleStringWithAllLogThemeStyleSignatures_WhenGivenValidParameters()
        {
            // Arrange
            var themeDict = new Dictionary<string, ConsoleTheme>()
            {
                { nameof(LogThemes.SystemLiterate), LogThemes.SystemLiterate },
                { nameof(LogThemes.Literate), LogThemes.Literate },

                { nameof(LogThemes.SystemGrayscale), LogThemes.SystemGrayscale },
                { nameof(LogThemes.Grayscale), LogThemes.Grayscale },

                { nameof(LogThemes.SystemColored), LogThemes.SystemColored },

                { $"{nameof(AnsiConsoleTheme)}.{nameof(AnsiConsoleTheme.Code)}", AnsiConsoleTheme.Code },
                { $"{nameof(LogThemes)}.{nameof(LogThemes.Code)}", LogThemes.Code },

                { nameof(LogThemes.Sixteen), LogThemes.Sixteen },
                { nameof(LogThemes.SixteenNonBright), LogThemes.SixteenNonBright },
            };

            // Act
            foreach (var theme in themeDict)
            {
                await TestLogger.LogTest(theme.Value, theme.Key);
            }

            // Assert
        }
    }
};