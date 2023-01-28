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
        public void ShouldHaveAllStyleOutputStartAndEndWithCertainCharacters_WhenUsingFluentStyling()
        {
            // Arrange
            var styleList = new List<string>();

            // Act
            styleList.Add(LogTheme.Style(Color.Gray));
            styleList.Add(LogTheme.Style(Color.White, Color.Black));
            styleList.Add(LogTheme.Style(Color.White, Color.Black, FormatTypeEnum.BoldMode));
            styleList.Add(LogTheme.Style(Color.White, FormatTypeEnum.BoldMode));

            styleList.Add(LogTheme.Foreground(Color.Blue));
            styleList.Add(LogTheme.Background(Color.Red));
            styleList.Add(LogTheme.FormatType(FormatTypeEnum.BoldMode));
            styleList.Add(LogTheme.Foreground(Color.Blue)
                .Background(Color.Red));
            styleList.Add(LogTheme.Foreground(Color.Blue)
                .FormatType(FormatTypeEnum.BoldMode));
            styleList.Add(LogTheme.Foreground(Color.Blue)
                .Background(Color.Red)
                .FormatType(FormatTypeEnum.BoldMode));

            styleList.Add(LogTheme.Foreground(Ansi16Colors.Blue));
            styleList.Add(LogTheme.Background(Ansi16Colors.Red));
            styleList.Add(LogTheme.FormatType(FormatTypeEnum.BoldMode));
            styleList.Add(LogTheme.Foreground(Ansi16Colors.Blue)
                .Background(Ansi16Colors.Red));
            styleList.Add(LogTheme.Foreground(Ansi16Colors.Blue)
                .FormatType(FormatTypeEnum.BoldMode));
            styleList.Add(LogTheme.Foreground(Ansi16Colors.Blue)
                .Background(Ansi16Colors.Red)
                .FormatType(FormatTypeEnum.BoldMode));

            styleList.Add(LogTheme.Foreground(Color256.Blue19));
            styleList.Add(LogTheme.Background(Color256.Red124));
            styleList.Add(LogTheme.FormatType(FormatTypeEnum.BoldMode));
            styleList.Add(LogTheme.Foreground(Color256.Blue19)
                .Background(Color256.Red160));
            styleList.Add(LogTheme.Foreground(Color256.BlueViolet57)
                .FormatType(FormatTypeEnum.BoldMode));
            styleList.Add(LogTheme.Foreground(Color256.Blue21)
                .Background(Color256.IndianRed131)
                .FormatType(FormatTypeEnum.BoldMode));

            // Assert
            foreach (var style in styleList)
            {
                style.ShouldStartWith("\x1b[");
                style.ShouldEndWith("m");
            }
        }
    }
};