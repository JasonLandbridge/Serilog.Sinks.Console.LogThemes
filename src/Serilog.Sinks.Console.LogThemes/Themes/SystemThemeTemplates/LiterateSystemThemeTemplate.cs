using System;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public class LiterateSystemThemeTemplate : BaseSystemConsoleTheme
    {
        protected override SystemConsoleThemeStyle Text => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle SecondaryText => LogSystemTheme.Foreground(ConsoleColor.Gray);
        protected override SystemConsoleThemeStyle TertiaryText => LogSystemTheme.Foreground(ConsoleColor.DarkGray);
        protected override SystemConsoleThemeStyle Invalid => LogSystemTheme.Foreground(ConsoleColor.Yellow);
        protected override SystemConsoleThemeStyle Null => LogSystemTheme.Foreground(ConsoleColor.Blue);
        protected override SystemConsoleThemeStyle Name => LogSystemTheme.Foreground(ConsoleColor.Gray);
        protected override SystemConsoleThemeStyle String => LogSystemTheme.Foreground(ConsoleColor.Cyan);
        protected override SystemConsoleThemeStyle Number => LogSystemTheme.Foreground(ConsoleColor.Magenta);
        protected override SystemConsoleThemeStyle Boolean => LogSystemTheme.Foreground(ConsoleColor.Blue);
        protected override SystemConsoleThemeStyle Scalar => LogSystemTheme.Foreground(ConsoleColor.Green);
        protected override SystemConsoleThemeStyle LevelVerbose => LogSystemTheme.Foreground(ConsoleColor.Gray);
        protected override SystemConsoleThemeStyle LevelDebug => LogSystemTheme.Foreground(ConsoleColor.Gray);
        protected override SystemConsoleThemeStyle LevelInformation => LogSystemTheme.Foreground(ConsoleColor.White);
        protected override SystemConsoleThemeStyle LevelWarning => LogSystemTheme.Foreground(ConsoleColor.Yellow);
        protected override SystemConsoleThemeStyle LevelError => LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red);
        protected override SystemConsoleThemeStyle LevelFatal => LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red);
    }
}