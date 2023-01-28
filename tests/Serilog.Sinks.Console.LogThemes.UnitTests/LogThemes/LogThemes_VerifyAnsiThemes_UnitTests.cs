using System.Collections.Generic;
using System.Drawing;
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
            var newDict = ThemeDefinitions.Code;

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
            var newDict = ThemeDefinitions.Literate;

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
            var newDict = ThemeDefinitions.Grayscale;

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
            var newDict = ThemeDefinitions.Sixteen;

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