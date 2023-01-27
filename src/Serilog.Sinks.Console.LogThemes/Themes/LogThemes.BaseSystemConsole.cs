using System;
using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public static partial class LogThemes
    {
        public static SystemConsoleTheme SystemLiterate { get; } = new SystemConsoleTheme(
            new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.SecondaryText] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.TertiaryText] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.Invalid] = LogSystemTheme.Foreground(ConsoleColor.Yellow),
                [ConsoleThemeStyle.Null] = LogSystemTheme.Foreground(ConsoleColor.Blue),
                [ConsoleThemeStyle.Name] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.String] = LogSystemTheme.Foreground(ConsoleColor.Cyan),
                [ConsoleThemeStyle.Number] = LogSystemTheme.Foreground(ConsoleColor.Magenta),
                [ConsoleThemeStyle.Boolean] = LogSystemTheme.Foreground(ConsoleColor.Blue),
                [ConsoleThemeStyle.Scalar] = LogSystemTheme.Foreground(ConsoleColor.Green),
                [ConsoleThemeStyle.LevelVerbose] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.LevelDebug] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.LevelInformation] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.LevelWarning] = LogSystemTheme.Foreground(ConsoleColor.Yellow),
                [ConsoleThemeStyle.LevelError] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red),
                [ConsoleThemeStyle.LevelFatal] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red),
            });

        public static SystemConsoleTheme SystemGrayscale { get; } = new SystemConsoleTheme(
            new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.SecondaryText] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.TertiaryText] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.Invalid] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.DarkGray),
                [ConsoleThemeStyle.Null] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Name] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.String] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Number] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Boolean] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Scalar] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.LevelVerbose] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelDebug] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelInformation] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.LevelWarning] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelError] = LogSystemTheme.Style(ConsoleColor.Black, ConsoleColor.White),
                [ConsoleThemeStyle.LevelFatal] = LogSystemTheme.Style(ConsoleColor.Black, ConsoleColor.White),
            });

        public static SystemConsoleTheme SystemColored { get; } = new SystemConsoleTheme(
            new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.SecondaryText] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.TertiaryText] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.Invalid] = LogSystemTheme.Foreground(ConsoleColor.Yellow),
                [ConsoleThemeStyle.Null] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Name] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.String] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Number] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Boolean] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Scalar] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.LevelVerbose] = LogSystemTheme.Style(ConsoleColor.Gray, ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelDebug] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelInformation] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Blue),
                [ConsoleThemeStyle.LevelWarning] = LogSystemTheme.Style(ConsoleColor.DarkGray, ConsoleColor.Yellow),
                [ConsoleThemeStyle.LevelError] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red),
                [ConsoleThemeStyle.LevelFatal] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red),
            });
    }
}