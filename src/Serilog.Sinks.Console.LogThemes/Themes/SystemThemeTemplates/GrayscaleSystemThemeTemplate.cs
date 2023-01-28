using System;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public class GrayscaleSystemThemeTemplate : BaseSystemConsoleTheme
    {
        protected override SystemConsoleThemeStyle Text => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle SecondaryText => LogSystemTheme.Foreground(ConsoleColor.Gray);
        protected override SystemConsoleThemeStyle TertiaryText => LogSystemTheme.Foreground(ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle Invalid => LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle Null => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle Name => LogSystemTheme.Foreground(ConsoleColor.Gray);
        protected override SystemConsoleThemeStyle String => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle Number => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle Boolean => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle Scalar => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle LevelVerbose => LogSystemTheme.Foreground(ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle LevelDebug => LogSystemTheme.Foreground(ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle LevelInformation => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle LevelWarning => LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle LevelError => LogSystemTheme.Style(ConsoleColor.Black, ConsoleColor.White);
        protected override SystemConsoleThemeStyle LevelFatal => LogSystemTheme.Style(ConsoleColor.Black, ConsoleColor.White);
    }
}