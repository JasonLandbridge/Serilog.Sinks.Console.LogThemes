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
        public static AnsiConsoleTheme SixteenNonBright { get; } = new AnsiConsoleTheme(ThemeDefinitions.SixteenNonBright);
    }
}