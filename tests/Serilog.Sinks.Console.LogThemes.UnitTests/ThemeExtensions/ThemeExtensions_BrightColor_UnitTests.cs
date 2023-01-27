using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
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
            var themeNonBright = LogThemes.SixteenNonBright;
            var theme = LogThemes.Sixteen;

            // Act
            await TestLogger.LogTest(themeNonBright);
            await TestLogger.LogTest(theme);

            // Assert

        }
    }
};