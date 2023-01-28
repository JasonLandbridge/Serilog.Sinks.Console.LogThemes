using System;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public class ColoredSystemThemeTemplate : BaseSystemConsoleTheme
    {
        protected override SystemConsoleThemeStyle Text => LogSystemTheme.Foreground(ConsoleColor.Gray);
        protected override SystemConsoleThemeStyle SecondaryText => LogSystemTheme.Foreground(ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle TertiaryText => LogSystemTheme.Foreground(ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle Invalid => LogSystemTheme.Foreground(ConsoleColor.Yellow);
        protected override SystemConsoleThemeStyle Null => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle Name => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle String => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle Number => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle Boolean => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle Scalar => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle LevelVerbose => LogSystemTheme.Style(ConsoleColor.Gray, ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle LevelDebug => LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle LevelInformation => LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Blue);
        protected override SystemConsoleThemeStyle LevelWarning => LogSystemTheme.Style(ConsoleColor.DarkGray, ConsoleColor.Yellow);
        protected override SystemConsoleThemeStyle LevelError => LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red);
        protected override SystemConsoleThemeStyle LevelFatal => LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red);
    }
}