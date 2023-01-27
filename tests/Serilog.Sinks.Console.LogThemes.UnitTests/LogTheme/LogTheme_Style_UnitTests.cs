using System.Collections.Generic;
using System.Drawing;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    public class LogTheme_Style_UnitTests
    {
        private readonly ITestOutputHelper _output;

        public LogTheme_Style_UnitTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void ShouldCreateLogStyleStringWithAllLogThemeStyleSignatures_WhenGivenValidParameters()
        {
            // Arrange
            var styleList = new List<string>();

            // Act
            styleList.Add(LogTheme.Style(Color.Gray));
            styleList.Add(LogTheme.Style(Color.White, Color.Black));
            styleList.Add(LogTheme.Style(Color.White, Color.Black, FormatTypeEnum.BoldMode));
            styleList.Add(LogTheme.Style(Color.White, FormatTypeEnum.BoldMode));

            // Assert
            foreach (var style in styleList)
            {
                style.ShouldStartWith("\x1b[");
                style.ShouldEndWith("m");
            }
        }
    }
};