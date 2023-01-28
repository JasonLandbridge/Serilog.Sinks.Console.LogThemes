using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public static partial class LogThemes
    {
        public static AnsiConsoleTheme Code { get; } = new AnsiConsoleTheme(ThemeDefinitions.Code);
        public static AnsiConsoleTheme Literate { get; } = new AnsiConsoleTheme(ThemeDefinitions.Literate);
        public static AnsiConsoleTheme Grayscale { get; } = new AnsiConsoleTheme(ThemeDefinitions.Grayscale);
        public static AnsiConsoleTheme Sixteen { get; } = new AnsiConsoleTheme(ThemeDefinitions.Sixteen);

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
                [ConsoleThemeStyle.LevelDebug] = Ansi16Colors.Magenta.ToForegroundAnsiString(),
                [ConsoleThemeStyle.LevelInformation] = Ansi16Colors.Cyan.ToForegroundAnsiString(),
                [ConsoleThemeStyle.LevelWarning] = Ansi16Colors.Yellow.ToForegroundAnsiString(),
                [ConsoleThemeStyle.LevelError] = Ansi16Colors.Red.ToForegroundAnsiString(),
                [ConsoleThemeStyle.LevelFatal] = Ansi16Colors.Red.ToForegroundAnsiString(),
            });
    }
}