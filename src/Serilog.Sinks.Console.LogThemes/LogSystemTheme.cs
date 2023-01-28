using System;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public static class LogSystemTheme
    {
        #region FluentApi

        #region SystemConsoleMode

        #region Create

        public static SystemConsoleThemeStyle Foreground(ConsoleColor foreGroundColor)
        {
            return new SystemConsoleThemeStyle()
            {
                Foreground = foreGroundColor,
            };
        }

        public static SystemConsoleThemeStyle Background(ConsoleColor backGroundColor)
        {
            return new SystemConsoleThemeStyle()
            {
                Background = backGroundColor,
            };
        }

        #endregion

        #region Extend

        public static SystemConsoleThemeStyle Foreground(this SystemConsoleThemeStyle logStyle, ConsoleColor foreGroundColor)
        {
            logStyle.Foreground = foreGroundColor;
            return logStyle;
        }

        public static SystemConsoleThemeStyle Background(this SystemConsoleThemeStyle logStyle, ConsoleColor backGroundColor)
        {
            logStyle.Background = backGroundColor;
            return logStyle;
        }

        #endregion

        #endregion

        #endregion


        #region Style

        public static SystemConsoleThemeStyle Style(ConsoleColor foreground, ConsoleColor background)
        {
            return Foreground(foreground).Background(background);
        }

        public static SystemConsoleThemeStyle Style(ConsoleColor foreground)
        {
            return Foreground(foreground);
        }

        #endregion
    }
}