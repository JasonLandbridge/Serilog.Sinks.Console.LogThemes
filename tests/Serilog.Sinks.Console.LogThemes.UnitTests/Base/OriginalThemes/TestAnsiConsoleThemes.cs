using System;
using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    /// <summary>
    /// These classes are an exact copy of the original Serilog.Sinks.Console themes
    /// Purely used for verifying that our versions are an exact match
    /// </summary>
    internal static class TestAnsiConsoleThemes
    {
        #region TestAnsiThemes

        internal static Dictionary<ConsoleThemeStyle, string> Code { get; } =
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = "\x1b[38;5;0253m",
                [ConsoleThemeStyle.SecondaryText] = "\x1b[38;5;0246m",
                [ConsoleThemeStyle.TertiaryText] = "\x1b[38;5;0242m",

                [ConsoleThemeStyle.Invalid] = "\x1b[33;1m",

                [ConsoleThemeStyle.Null] = "\x1b[38;5;0038m",
                [ConsoleThemeStyle.Name] = "\x1b[38;5;0081m",
                [ConsoleThemeStyle.String] = "\x1b[38;5;0216m",
                [ConsoleThemeStyle.Number] = "\x1b[38;5;0151m",
                [ConsoleThemeStyle.Boolean] = "\x1b[38;5;0038m",
                [ConsoleThemeStyle.Scalar] = "\x1b[38;5;0079m",
                [ConsoleThemeStyle.LevelVerbose] = "\x1b[37m",
                [ConsoleThemeStyle.LevelDebug] = "\x1b[37m",
                [ConsoleThemeStyle.LevelInformation] = "\x1b[37;1m",
                [ConsoleThemeStyle.LevelWarning] = "\x1b[38;5;0229m",
                [ConsoleThemeStyle.LevelError] = "\x1b[38;5;0197m\x1b[48;5;0238m",
                [ConsoleThemeStyle.LevelFatal] = "\x1b[38;5;0197m\x1b[48;5;0238m",
            };

        internal static Dictionary<ConsoleThemeStyle, string> Literate { get; } =
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = "\x1b[38;5;0015m",
                [ConsoleThemeStyle.SecondaryText] = "\x1b[38;5;0007m",
                [ConsoleThemeStyle.TertiaryText] = "\x1b[38;5;0008m",
                [ConsoleThemeStyle.Invalid] = "\x1b[38;5;0011m",
                [ConsoleThemeStyle.Null] = "\x1b[38;5;0027m",
                [ConsoleThemeStyle.Name] = "\x1b[38;5;0007m",
                [ConsoleThemeStyle.String] = "\x1b[38;5;0045m",
                [ConsoleThemeStyle.Number] = "\x1b[38;5;0200m",
                [ConsoleThemeStyle.Boolean] = "\x1b[38;5;0027m",
                [ConsoleThemeStyle.Scalar] = "\x1b[38;5;0085m",
                [ConsoleThemeStyle.LevelVerbose] = "\x1b[38;5;0007m",
                [ConsoleThemeStyle.LevelDebug] = "\x1b[38;5;0007m",
                [ConsoleThemeStyle.LevelInformation] = "\x1b[38;5;0015m",
                [ConsoleThemeStyle.LevelWarning] = "\x1b[38;5;0011m",
                [ConsoleThemeStyle.LevelError] = "\x1b[38;5;0015m\x1b[48;5;0196m",
                [ConsoleThemeStyle.LevelFatal] = "\x1b[38;5;0015m\x1b[48;5;0196m",
            };

        internal static Dictionary<ConsoleThemeStyle, string> Grayscale { get; } =
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = "\x1b[37;1m",
                [ConsoleThemeStyle.SecondaryText] = "\x1b[37m",
                [ConsoleThemeStyle.TertiaryText] = "\x1b[30;1m",
                [ConsoleThemeStyle.Invalid] = "\x1b[37;1m\x1b[47m",
                [ConsoleThemeStyle.Null] = "\x1b[1m\x1b[37;1m",
                [ConsoleThemeStyle.Name] = "\x1b[37m",
                [ConsoleThemeStyle.String] = "\x1b[1m\x1b[37;1m",
                [ConsoleThemeStyle.Number] = "\x1b[1m\x1b[37;1m",
                [ConsoleThemeStyle.Boolean] = "\x1b[1m\x1b[37;1m",
                [ConsoleThemeStyle.Scalar] = "\x1b[1m\x1b[37;1m",
                [ConsoleThemeStyle.LevelVerbose] = "\x1b[30;1m",
                [ConsoleThemeStyle.LevelDebug] = "\x1b[30;1m",
                [ConsoleThemeStyle.LevelInformation] = "\x1b[37;1m",
                [ConsoleThemeStyle.LevelWarning] = "\x1b[37;1m\x1b[47m",
                [ConsoleThemeStyle.LevelError] = "\x1b[30m\x1b[47m",
                [ConsoleThemeStyle.LevelFatal] = "\x1b[30m\x1b[47m",
            };

        internal static Dictionary<ConsoleThemeStyle, string> Sixteen { get; } =
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = AnsiEscapeSequence.Unthemed,
                [ConsoleThemeStyle.SecondaryText] = AnsiEscapeSequence.Unthemed,
                [ConsoleThemeStyle.TertiaryText] = AnsiEscapeSequence.Unthemed,
                [ConsoleThemeStyle.Invalid] = AnsiEscapeSequence.Yellow,

                [ConsoleThemeStyle.Null] = AnsiEscapeSequence.Blue,
                [ConsoleThemeStyle.Name] = AnsiEscapeSequence.Unthemed,
                [ConsoleThemeStyle.String] = AnsiEscapeSequence.Cyan,
                [ConsoleThemeStyle.Number] = AnsiEscapeSequence.Magenta,
                [ConsoleThemeStyle.Boolean] = AnsiEscapeSequence.Blue,
                [ConsoleThemeStyle.Scalar] = AnsiEscapeSequence.Green,
                [ConsoleThemeStyle.LevelVerbose] = AnsiEscapeSequence.Unthemed,
                [ConsoleThemeStyle.LevelDebug] = AnsiEscapeSequence.Bold,
                [ConsoleThemeStyle.LevelInformation] = AnsiEscapeSequence.BrightCyan,
                [ConsoleThemeStyle.LevelWarning] = AnsiEscapeSequence.BrightYellow,
                [ConsoleThemeStyle.LevelError] = AnsiEscapeSequence.BrightRed,
                [ConsoleThemeStyle.LevelFatal] = AnsiEscapeSequence.BrightRed,
            };

        #endregion

        #region TestSystemConsoleThemes

        internal static Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> SystemLiterate { get; } =
            new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
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

        internal static Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> SystemGrayscale { get; } =
            new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.SecondaryText] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Gray },
                [ConsoleThemeStyle.TertiaryText] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.Invalid] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.Null] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.Name] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Gray },
                [ConsoleThemeStyle.String] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.Number] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.Boolean] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.Scalar] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.LevelVerbose] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.LevelDebug] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.LevelInformation] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.LevelWarning] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.LevelError] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Black, Background = ConsoleColor.White },
                [ConsoleThemeStyle.LevelFatal] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Black, Background = ConsoleColor.White },
            };

        internal static Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> SystemColored { get; } =
            new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Gray },
                [ConsoleThemeStyle.SecondaryText] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.TertiaryText] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.Invalid] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Yellow },
                [ConsoleThemeStyle.Null] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.Name] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.String] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.Number] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.Boolean] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.Scalar] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White },
                [ConsoleThemeStyle.LevelVerbose] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.Gray, Background = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.LevelDebug] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.DarkGray },
                [ConsoleThemeStyle.LevelInformation] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.Blue },
                [ConsoleThemeStyle.LevelWarning] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.DarkGray, Background = ConsoleColor.Yellow },
                [ConsoleThemeStyle.LevelError] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.Red },
                [ConsoleThemeStyle.LevelFatal] = new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.Red },
            };

        #endregion

        private class AnsiEscapeSequence
        {
            public const string Unthemed = "";
            public const string Reset = "\x1b[0m";
            public const string Bold = "\x1b[1m";

            public const string Black = "\x1b[30m";
            public const string Red = "\x1b[31m";
            public const string Green = "\x1b[32m";
            public const string Yellow = "\x1b[33m";
            public const string Blue = "\x1b[34m";
            public const string Magenta = "\x1b[35m";
            public const string Cyan = "\x1b[36m";
            public const string White = "\x1b[37m";

            public const string BrightBlack = "\x1b[30;1m";
            public const string BrightRed = "\x1b[31;1m";
            public const string BrightGreen = "\x1b[32;1m";
            public const string BrightYellow = "\x1b[33;1m";
            public const string BrightBlue = "\x1b[34;1m";
            public const string BrightMagenta = "\x1b[35;1m";
            public const string BrightCyan = "\x1b[36;1m";
            public const string BrightWhite = "\x1b[37;1m";
        }
    }
}