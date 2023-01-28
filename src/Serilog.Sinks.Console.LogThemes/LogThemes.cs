using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public static partial class LogThemes
    {
        #region SystemConsoleThemes

        public static SystemConsoleTheme SystemLiterate { get; } = new SystemConsoleTheme(ThemeDefinitions.SystemLiterate);

        public static SystemConsoleTheme SystemGrayscale { get; } = new SystemConsoleTheme(ThemeDefinitions.SystemGrayscale);

        public static SystemConsoleTheme SystemColored { get; } = new SystemConsoleTheme(ThemeDefinitions.SystemColored);

        #endregion

        #region AnsiThemes

        public static AnsiConsoleTheme Code { get; } = new AnsiConsoleTheme(ThemeDefinitions.Code);
        public static AnsiConsoleTheme Literate { get; } = new AnsiConsoleTheme(ThemeDefinitions.Literate);
        public static AnsiConsoleTheme Grayscale { get; } = new AnsiConsoleTheme(ThemeDefinitions.Grayscale);
        public static AnsiConsoleTheme Sixteen { get; } = new AnsiConsoleTheme(ThemeDefinitions.Sixteen);
        public static AnsiConsoleTheme SixteenNonBright { get; } = new AnsiConsoleTheme(ThemeDefinitions.SixteenNonBright);

        #endregion

        #region Use

        public static ConsoleTheme UseSystemConsoleTheme<T>() where T : BaseSystemConsoleTheme, new()
        {
            return new SystemConsoleTheme(new T().ToTheme());
        }

        public static ConsoleTheme UseAnsiTheme<T>() where T : BaseAnsiTheme, new()
        {
            return new AnsiConsoleTheme(new T().ToTheme());
        }

        #endregion
    }
}