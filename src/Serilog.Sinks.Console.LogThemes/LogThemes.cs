using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public static partial class LogThemes
    {
        #region SystemConsoleThemes

        public static SystemConsoleTheme SystemLiterate => UseSystemConsoleTheme<LiterateSystemThemeTemplate>();

        public static SystemConsoleTheme SystemGrayscale => UseSystemConsoleTheme<GrayscaleSystemThemeTemplate>();

        public static SystemConsoleTheme SystemColored => UseSystemConsoleTheme<ColoredSystemThemeTemplate>();

        #endregion

        #region AnsiThemes

        public static AnsiConsoleTheme Code => UseAnsiTheme<CodeAnsiThemeTemplate>();
        public static AnsiConsoleTheme Literate => UseAnsiTheme<LiterateAnsiThemeTemplate>();
        public static AnsiConsoleTheme Grayscale => UseAnsiTheme<GrayscaleAnsiThemeTemplate>();
        public static AnsiConsoleTheme Sixteen => UseAnsiTheme<SixteenAnsiThemeTemplate>();
        public static AnsiConsoleTheme SixteenNonBright => UseAnsiTheme<SixteenNotBrightAnsiThemeTemplate>();

        #endregion

        #region Use

        public static SystemConsoleTheme UseSystemConsoleTheme<T>() where T : BaseSystemConsoleTheme, new()
        {
            return new SystemConsoleTheme(new T().ToStyleDictionary());
        }

        public static AnsiConsoleTheme UseAnsiTheme<T>() where T : AnsiBaseTheme, new()
        {
            return new AnsiConsoleTheme(new T().ToStyleDictionary());
        }

        #endregion

        #region Get Dictionary Styles

        internal static Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> SystemStyles<T>() where T : BaseSystemConsoleTheme, new()
        {
            return new T().ToStyleDictionary();
        }

        internal static Dictionary<ConsoleThemeStyle, string> AnsiStyles<T>() where T : AnsiBaseTheme, new()
        {
            return new T().ToStyleDictionary();
        }

        #endregion
    }
}