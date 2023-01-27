using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public static partial class LogThemes
    {
        public static AnsiConsoleTheme Sixteen { get; } = new AnsiConsoleTheme(
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = LogTheme.Unthemed,
                [ConsoleThemeStyle.SecondaryText] = LogTheme.Unthemed,
                [ConsoleThemeStyle.TertiaryText] = LogTheme.Unthemed,
                [ConsoleThemeStyle.Invalid] = LogTheme.YellowForeground,
                [ConsoleThemeStyle.Null] = LogTheme.BlueForeground,
                [ConsoleThemeStyle.Name] = LogTheme.Unthemed,
                [ConsoleThemeStyle.String] = LogTheme.CyanForeground,
                [ConsoleThemeStyle.Number] = LogTheme.MagentaForeground,
                [ConsoleThemeStyle.Boolean] = LogTheme.BlueForeground,
                [ConsoleThemeStyle.Scalar] = LogTheme.GreenForeground,
                [ConsoleThemeStyle.LevelVerbose] = LogTheme.Unthemed,
                [ConsoleThemeStyle.LevelDebug] = LogTheme.Bold,
                [ConsoleThemeStyle.LevelInformation] = Ansi16Colors.BrightCyan.ToAnsiString(),
                [ConsoleThemeStyle.LevelWarning] = Ansi16Colors.BrightYellow.ToAnsiString(),
                [ConsoleThemeStyle.LevelError] = Ansi16Colors.BrightRed.ToAnsiString(),
                [ConsoleThemeStyle.LevelFatal] = Ansi16Colors.BrightRed.ToAnsiString(),
            });

        public static AnsiConsoleTheme SixteenNonBright { get; } = new AnsiConsoleTheme(
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = LogTheme.Unthemed,
                [ConsoleThemeStyle.SecondaryText] = LogTheme.Unthemed,
                [ConsoleThemeStyle.TertiaryText] = LogTheme.Unthemed,
                [ConsoleThemeStyle.Invalid] = LogTheme.YellowForeground,
                [ConsoleThemeStyle.Null] = LogTheme.BlueForeground,
                [ConsoleThemeStyle.Name] = LogTheme.Unthemed,
                [ConsoleThemeStyle.String] = LogTheme.CyanForeground,
                [ConsoleThemeStyle.Number] = LogTheme.MagentaForeground,
                [ConsoleThemeStyle.Boolean] = LogTheme.BlueForeground,
                [ConsoleThemeStyle.Scalar] = LogTheme.GreenForeground,
                [ConsoleThemeStyle.LevelVerbose] = LogTheme.Unthemed,
                [ConsoleThemeStyle.LevelDebug] = Ansi16Colors.Magenta.ToAnsiString(),
                [ConsoleThemeStyle.LevelInformation] = Ansi16Colors.Cyan.ToAnsiString(),
                [ConsoleThemeStyle.LevelWarning] = Ansi16Colors.Yellow.ToAnsiString(),
                [ConsoleThemeStyle.LevelError] = Ansi16Colors.Red.ToAnsiString(),
                [ConsoleThemeStyle.LevelFatal] = Ansi16Colors.Red.ToAnsiString(),
            });

        // public static AnsiConsoleTheme Sixteen { get; } = new AnsiConsoleTheme(
        //     new Dictionary<ConsoleThemeStyle, string>
        //     {
        //         [ConsoleThemeStyle.Text] = AnsiEscapeSequence.Unthemed,
        //         [ConsoleThemeStyle.SecondaryText] = AnsiEscapeSequence.Unthemed,
        //         [ConsoleThemeStyle.TertiaryText] = AnsiEscapeSequence.Unthemed,
        //         [ConsoleThemeStyle.Invalid] = AnsiEscapeSequence.Yellow,
        //         [ConsoleThemeStyle.Null] = AnsiEscapeSequence.Blue,
        //         [ConsoleThemeStyle.Name] = AnsiEscapeSequence.Unthemed,
        //         [ConsoleThemeStyle.String] = AnsiEscapeSequence.Cyan,
        //         [ConsoleThemeStyle.Number] = AnsiEscapeSequence.Magenta,
        //         [ConsoleThemeStyle.Boolean] = AnsiEscapeSequence.Blue,
        //         [ConsoleThemeStyle.Scalar] = AnsiEscapeSequence.Green,
        //         [ConsoleThemeStyle.LevelVerbose] = AnsiEscapeSequence.Unthemed,
        //         [ConsoleThemeStyle.LevelDebug] = AnsiEscapeSequence.Bold,
        //         [ConsoleThemeStyle.LevelInformation] = AnsiEscapeSequence.BrightCyan,
        //         [ConsoleThemeStyle.LevelWarning] = AnsiEscapeSequence.BrightYellow,
        //         [ConsoleThemeStyle.LevelError] = AnsiEscapeSequence.BrightRed,
        //         [ConsoleThemeStyle.LevelFatal] = AnsiEscapeSequence.BrightRed,
        //     });
    }
}