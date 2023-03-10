using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    public class LogThemes_VerifySystemConsoleThemes_UnitTests
    {
        private readonly ITestOutputHelper _output;

        public LogThemes_VerifySystemConsoleThemes_UnitTests(ITestOutputHelper output)
        {
            _output = output;
        }


        [Fact]
        public void VerifyOriginalThemeSystemColoredIsTheExactSameAsNewThemeSystemColored_WhenUsingFluentStyling()
        {
            var dict = TestAnsiConsoleThemes.SystemColored;
            var newDict = LogThemes.SystemStyles<ColoredSystemThemeTemplate>();

            foreach (var originalStyle in dict)
            {
                newDict.ContainsKey(originalStyle.Key).ShouldBeTrue();
                var newStyleValue = newDict[originalStyle.Key];
                var originalStyleValue = originalStyle.Value;
                newStyleValue.ShouldBe(originalStyleValue, $"Key: {originalStyle.Key}");
            }
        }

        [Fact]
        public void VerifyOriginalThemeSystemLiterateIsTheExactSameAsNewThemeSystemLiterate_WhenUsingFluentStyling()
        {
            var originalDict = TestAnsiConsoleThemes.SystemLiterate;
            var newDict = LogThemes.SystemStyles<LiterateSystemThemeTemplate>();

            foreach (var originalStyle in originalDict)
            {
                newDict.ContainsKey(originalStyle.Key).ShouldBeTrue();
                var newStyleValue = newDict[originalStyle.Key];
                var originalStyleValue = originalStyle.Value;
                newStyleValue.ShouldBe(originalStyleValue, $"Key: {originalStyle.Key}");
            }
        }

        [Fact]
        public void VerifyOriginalThemeSystemGrayscaleIsTheExactSameAsNewThemeSystemGrayscale_WhenUsingFluentStyling()
        {
            var originalDict = TestAnsiConsoleThemes.SystemGrayscale;
            var newDict = LogThemes.SystemStyles<GrayscaleSystemThemeTemplate>();

            foreach (var originalStyle in originalDict)
            {
                newDict.ContainsKey(originalStyle.Key).ShouldBeTrue();
                var newStyleValue = newDict[originalStyle.Key];
                var originalStyleValue = originalStyle.Value;
                newStyleValue.ShouldBe(originalStyleValue, $"Key: {originalStyle.Key}");
            }
        }
    }
};