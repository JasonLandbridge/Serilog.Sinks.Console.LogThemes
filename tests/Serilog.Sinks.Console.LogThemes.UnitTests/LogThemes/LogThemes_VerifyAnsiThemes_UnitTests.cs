using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    public class LogThemes_VerifyAnsiThemes_UnitTests
    {
        private readonly ITestOutputHelper _output;

        public LogThemes_VerifyAnsiThemes_UnitTests(ITestOutputHelper output)
        {
            _output = output;
        }


        [Fact]
        public void VerifyOriginalThemeCodeIsTheExactSameAsNewThemeCode_WhenUsingFluentStyling()
        {
            var dict = TestAnsiConsoleThemes.Code;
            var newDict = LogThemes.AnsiStyles<CodeAnsiThemeTemplate>();

            foreach (var originalStyle in dict)
            {
                newDict.ContainsKey(originalStyle.Key).ShouldBeTrue();
                var newStyleValue = newDict[originalStyle.Key];
                var originalStyleValue = originalStyle.Value;
                newStyleValue.ShouldBe(originalStyleValue, $"Key: {originalStyle.Key}");
            }
        }

        [Fact]
        public void VerifyOriginalThemeLiterateIsTheExactSameAsNewThemeLiterate_WhenUsingFluentStyling()
        {
            var originalDict = TestAnsiConsoleThemes.Literate;
            var newDict = LogThemes.AnsiStyles<LiterateAnsiThemeTemplate>();

            foreach (var originalStyle in originalDict)
            {
                newDict.ContainsKey(originalStyle.Key).ShouldBeTrue();
                var newStyleValue = newDict[originalStyle.Key];
                var originalStyleValue = originalStyle.Value;
                newStyleValue.ShouldBe(originalStyleValue, $"Key: {originalStyle.Key}");
            }
        }

        [Fact]
        public void VerifyOriginalThemeGrayscaleIsTheExactSameAsNewThemeGrayscale_WhenUsingFluentStyling()
        {
            var originalDict = TestAnsiConsoleThemes.Grayscale;
            var newDict = LogThemes.AnsiStyles<GrayscaleAnsiThemeTemplate>();

            foreach (var originalStyle in originalDict)
            {
                newDict.ContainsKey(originalStyle.Key).ShouldBeTrue();
                var newStyleValue = newDict[originalStyle.Key];
                var originalStyleValue = originalStyle.Value;
                newStyleValue.ShouldBe(originalStyleValue, $"Key: {originalStyle.Key}");
            }
        }

        [Fact]
        public void VerifyOriginalThemeSixteenIsTheExactSameAsNewThemeSixteen_WhenUsingFluentStyling()
        {
            var originalDict = TestAnsiConsoleThemes.Sixteen;
            var newDict = LogThemes.AnsiStyles<SixteenAnsiThemeTemplate>();

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