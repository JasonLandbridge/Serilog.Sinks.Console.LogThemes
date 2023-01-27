using System.Collections.Generic;
using System.Drawing;
using ANSITerm;
using Serilog.Sinks.SystemConsole.Themes;
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

        [Fact]
        public void ShouldHaveTheSameAnsiCodesAsSerilogsSinksConsole_WhenUsingFluentStyling()
        {
            var dict = TestAnsiConsoleThemes.Code;

            foreach (var originalStyle in dict)
            {
                ThemeDefinitions.Code.ContainsKey(originalStyle.Key).ShouldBeTrue();
                var newStyleValue = ThemeDefinitions.Code[originalStyle.Key];
                newStyleValue.ShouldBe(originalStyle.Value, $"Key: {originalStyle.Key}");
            }
        }
    }
};