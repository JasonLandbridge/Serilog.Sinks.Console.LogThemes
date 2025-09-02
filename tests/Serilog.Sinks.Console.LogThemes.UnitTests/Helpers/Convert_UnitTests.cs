using System;
using System.Collections.Generic;
using System.Reflection;
using Serilog.Sinks.SystemConsole.Themes;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace Serilog.Sinks.Console.LogThemes.UnitTests.Helpers
{
    public class Convert_UnitTests
    {
        private readonly ITestOutputHelper _output;

        public Convert_UnitTests(ITestOutputHelper output)
        {
            _output = output;
        }

        #region Foreground Color Mapping Tests

        [Theory]
        [InlineData(ConsoleColor.Black, "30")]
        [InlineData(ConsoleColor.DarkRed, "31")]
        [InlineData(ConsoleColor.DarkGreen, "32")]
        [InlineData(ConsoleColor.DarkYellow, "33")]
        [InlineData(ConsoleColor.DarkBlue, "34")]
        [InlineData(ConsoleColor.DarkMagenta, "35")]
        [InlineData(ConsoleColor.DarkCyan, "36")]
        [InlineData(ConsoleColor.Gray, "37")]
        [InlineData(ConsoleColor.DarkGray, "90")]
        [InlineData(ConsoleColor.Red, "91")]
        [InlineData(ConsoleColor.Green, "92")]
        [InlineData(ConsoleColor.Yellow, "93")]
        [InlineData(ConsoleColor.Blue, "94")]
        [InlineData(ConsoleColor.Magenta, "95")]
        [InlineData(ConsoleColor.Cyan, "96")]
        [InlineData(ConsoleColor.White, "97")]
        public void ShouldMapForegroundColorsCorrectly(ConsoleColor color, string expectedAnsiCode)
        {
            // Arrange
            var systemTheme = CreateSystemThemeWithForeground(color);

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            var ansiStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Text);
            ansiStyle.ShouldContain($"\x1b[{expectedAnsiCode}m");
            
            _output.WriteLine($"Foreground {color} -> ANSI: {ansiStyle}");
        }

        #endregion

        #region Background Color Mapping Tests

        [Theory]
        [InlineData(ConsoleColor.Black, "40")]
        [InlineData(ConsoleColor.DarkRed, "41")]
        [InlineData(ConsoleColor.DarkGreen, "42")]
        [InlineData(ConsoleColor.DarkYellow, "43")]
        [InlineData(ConsoleColor.DarkBlue, "44")]
        [InlineData(ConsoleColor.DarkMagenta, "45")]
        [InlineData(ConsoleColor.DarkCyan, "46")]
        [InlineData(ConsoleColor.Gray, "47")]
        [InlineData(ConsoleColor.DarkGray, "100")]
        [InlineData(ConsoleColor.Red, "101")]
        [InlineData(ConsoleColor.Green, "102")]
        [InlineData(ConsoleColor.Yellow, "103")]
        [InlineData(ConsoleColor.Blue, "104")]
        [InlineData(ConsoleColor.Magenta, "105")]
        [InlineData(ConsoleColor.Cyan, "106")]
        [InlineData(ConsoleColor.White, "107")]
        public void ShouldMapBackgroundColorsCorrectly(ConsoleColor color, string expectedAnsiCode)
        {
            // Arrange
            var systemTheme = CreateSystemThemeWithBackground(color);

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            var ansiStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Text);
            ansiStyle.ShouldContain($"\x1b[{expectedAnsiCode}m");
            
            _output.WriteLine($"Background {color} -> ANSI: {ansiStyle}");
        }

        #endregion

        #region Combined Foreground and Background Tests

        [Theory]
        [InlineData(ConsoleColor.White, ConsoleColor.Red, "97", "101")]
        [InlineData(ConsoleColor.Black, ConsoleColor.White, "30", "107")]
        [InlineData(ConsoleColor.Blue, ConsoleColor.Yellow, "94", "103")]
        [InlineData(ConsoleColor.Green, ConsoleColor.DarkBlue, "92", "44")]
        [InlineData(ConsoleColor.DarkGray, ConsoleColor.Gray, "90", "47")]
        public void ShouldMapCombinedForegroundAndBackgroundColorsCorrectly(
            ConsoleColor foreground, 
            ConsoleColor background, 
            string expectedForegroundCode, 
            string expectedBackgroundCode)
        {
            // Arrange
            var systemTheme = CreateSystemThemeWithBothColors(foreground, background);

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            var ansiStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Text);
            ansiStyle.ShouldContain($"\x1b[{expectedForegroundCode}m");
            ansiStyle.ShouldContain($"\x1b[{expectedBackgroundCode}m");
            
            _output.WriteLine($"Foreground {foreground} + Background {background} -> ANSI: {ansiStyle}");
        }

        #endregion

        #region Theme Conversion Tests

        [Fact]
        public void ShouldConvertCompleteSystemThemeToAnsiTheme()
        {
            // Arrange
            var systemTheme = CreateCompleteSystemTheme();

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            ansiTheme.ShouldNotBeNull();
            var stylesDictionary = GetAnsiThemeStylesDictionary(ansiTheme);
            stylesDictionary.ShouldNotBeNull();
            stylesDictionary.Count.ShouldBe(16); // All ConsoleThemeStyle enum values

            // Verify all expected theme styles are present
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.Text);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.SecondaryText);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.TertiaryText);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.Invalid);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.Null);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.Name);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.String);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.Number);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.Boolean);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.Scalar);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.LevelVerbose);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.LevelDebug);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.LevelInformation);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.LevelWarning);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.LevelError);
            stylesDictionary.ShouldContainKey(ConsoleThemeStyle.LevelFatal);
        }

        [Fact]
        public void ShouldConvertPredefinedSystemLiterateTheme()
        {
            // Arrange
            var systemTheme = LogThemes.SystemLiterate;

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            ansiTheme.ShouldNotBeNull();
            var stylesDictionary = GetAnsiThemeStylesDictionary(ansiTheme);
            stylesDictionary.Count.ShouldBe(16);
            
            // Test specific color mappings for known theme
            GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Text).ShouldContain("\x1b[97m"); // White
            GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.SecondaryText).ShouldContain("\x1b[37m"); // Gray
            GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.String).ShouldContain("\x1b[96m"); // Cyan
            GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Number).ShouldContain("\x1b[95m"); // Magenta
        }

        [Fact]
        public void ShouldConvertPredefinedSystemGrayscaleTheme()
        {
            // Arrange
            var systemTheme = LogThemes.SystemGrayscale;

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            ansiTheme.ShouldNotBeNull();
            var stylesDictionary = GetAnsiThemeStylesDictionary(ansiTheme);
            stylesDictionary.Count.ShouldBe(16);
            
            // Test that error level has both foreground and background
            var errorStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.LevelError);
            errorStyle.ShouldContain("\x1b[30m"); // Black foreground
            errorStyle.ShouldContain("\x1b[107m"); // White background
        }

        [Fact]
        public void ShouldConvertPredefinedSystemColoredTheme()
        {
            // Arrange
            var systemTheme = LogThemes.SystemColored;

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            ansiTheme.ShouldNotBeNull();
            var stylesDictionary = GetAnsiThemeStylesDictionary(ansiTheme);
            stylesDictionary.Count.ShouldBe(16);
            
            // Test that information level has both foreground and background
            var infoStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.LevelInformation);
            infoStyle.ShouldContain("\x1b[97m"); // White foreground
            infoStyle.ShouldContain("\x1b[104m"); // Blue background
        }

        #endregion

        #region Edge Cases Tests

        [Fact]
        public void ShouldHandleNullForegroundColor()
        {
            // Arrange
            var systemTheme = CreateSystemThemeWithNullForeground();

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            var ansiStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Text);
            ansiStyle.ShouldContain("\x1b[101m"); // Should only contain background color
            ansiStyle.ShouldNotContain("\x1b[30m"); // Should not contain any foreground color
        }

        [Fact]
        public void ShouldHandleNullBackgroundColor()
        {
            // Arrange
            var systemTheme = CreateSystemThemeWithNullBackground();

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            var ansiStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Text);
            ansiStyle.ShouldContain("\x1b[97m"); // Should only contain foreground color
            ansiStyle.ShouldNotContain("\x1b[40m"); // Should not contain any background color
        }

        [Fact]
        public void ShouldHandleNullBothColors()
        {
            // Arrange
            var systemTheme = CreateSystemThemeWithNullColors();

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            var ansiStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Text);
            ansiStyle.ShouldBe(""); // Empty string when no colors are set
        }

        [Fact]
        public void ShouldPreserveDictionaryStructure()
        {
            // Arrange
            var originalStyles = new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.LevelError] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.Red }
            };
            var systemTheme = new SystemConsoleTheme(originalStyles);

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            var stylesDictionary = GetAnsiThemeStylesDictionary(ansiTheme);
            stylesDictionary.Keys.ShouldBe(originalStyles.Keys, ignoreOrder: true);
        }

        #endregion

        #region AnsiCode Validation Tests

        [Fact]
        public void ShouldProduceValidAnsiEscapeSequences()
        {
            // Arrange
            var systemTheme = CreateSystemThemeWithForeground(ConsoleColor.Red);

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            var ansiStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Text);
            ansiStyle.ShouldStartWith("\x1b["); // ESC character followed by bracket
            ansiStyle.ShouldEndWith("m"); // ANSI sequence should end with 'm'
        }

        [Fact]
        public void ShouldProduceCorrectAnsiSequenceOrder()
        {
            // Arrange - when both colors are specified, foreground should come before background
            var systemTheme = CreateSystemThemeWithBothColors(ConsoleColor.White, ConsoleColor.Red);

            // Act
            var ansiTheme = systemTheme.ToAnsiTheme();

            // Assert
            var ansiStyle = GetAnsiThemeStyle(ansiTheme, ConsoleThemeStyle.Text);
            var foregroundIndex = ansiStyle.IndexOf("\x1b[97m", StringComparison.Ordinal); // White foreground
            var backgroundIndex = ansiStyle.IndexOf("\x1b[101m", StringComparison.Ordinal); // Red background
            
            foregroundIndex.ShouldBeLessThan(backgroundIndex);
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Uses reflection to access the internal Styles dictionary of AnsiConsoleTheme
        /// </summary>
        private static Dictionary<ConsoleThemeStyle, string> GetAnsiThemeStylesDictionary(AnsiConsoleTheme theme)
        {
            var field = typeof(AnsiConsoleTheme).GetField("_styles", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                return (Dictionary<ConsoleThemeStyle, string>)field.GetValue(theme)!;
            }
            
            // Fallback - try property
            var property = typeof(AnsiConsoleTheme).GetProperty("Styles", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            if (property != null)
            {
                return (Dictionary<ConsoleThemeStyle, string>)property.GetValue(theme)!;
            }
            
            throw new InvalidOperationException("Could not access AnsiConsoleTheme styles dictionary via reflection");
        }
        
        /// <summary>
        /// Gets a specific style from the AnsiConsoleTheme using reflection
        /// </summary>
        private static string GetAnsiThemeStyle(AnsiConsoleTheme theme, ConsoleThemeStyle style)
        {
            var styles = GetAnsiThemeStylesDictionary(theme);
            return styles[style];
        }

        private static SystemConsoleTheme CreateSystemThemeWithForeground(ConsoleColor color)
        {
            var styles = new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Foreground = color }
            };
            return new SystemConsoleTheme(styles);
        }

        private static SystemConsoleTheme CreateSystemThemeWithBackground(ConsoleColor color)
        {
            var styles = new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Background = color }
            };
            return new SystemConsoleTheme(styles);
        }

        private static SystemConsoleTheme CreateSystemThemeWithBothColors(ConsoleColor foreground, ConsoleColor background)
        {
            var styles = new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Foreground = foreground, Background = background }
            };
            return new SystemConsoleTheme(styles);
        }

        private static SystemConsoleTheme CreateSystemThemeWithNullForeground()
        {
            var styles = new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Foreground = null, Background = ConsoleColor.Red }
            };
            return new SystemConsoleTheme(styles);
        }

        private static SystemConsoleTheme CreateSystemThemeWithNullBackground()
        {
            var styles = new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = null }
            };
            return new SystemConsoleTheme(styles);
        }

        private static SystemConsoleTheme CreateSystemThemeWithNullColors()
        {
            var styles = new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Foreground = null, Background = null }
            };
            return new SystemConsoleTheme(styles);
        }

        private static SystemConsoleTheme CreateCompleteSystemTheme()
        {
            var styles = new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.SecondaryText] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Gray },
                [ConsoleThemeStyle.TertiaryText] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.Invalid] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Yellow },
                [ConsoleThemeStyle.Null] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Blue },
                [ConsoleThemeStyle.Name] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Gray },
                [ConsoleThemeStyle.String] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Cyan },
                [ConsoleThemeStyle.Number] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Magenta },
                [ConsoleThemeStyle.Boolean] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Blue },
                [ConsoleThemeStyle.Scalar] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Green },
                [ConsoleThemeStyle.LevelVerbose] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Gray },
                [ConsoleThemeStyle.LevelDebug] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Gray },
                [ConsoleThemeStyle.LevelInformation] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.LevelWarning] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Yellow },
                [ConsoleThemeStyle.LevelError] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.Red },
                [ConsoleThemeStyle.LevelFatal] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.Red },
            };
            return new SystemConsoleTheme(styles);
        }

        #endregion
    }
}
