using System.Collections.Generic;
using System.Drawing;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public static class CustomLogThemes
    {
        public static AnsiConsoleTheme ColoredDarkAnsi { get; } = new AnsiConsoleTheme(
            new Dictionary<ConsoleThemeStyle, string>
            {
                // Timestamp, classname, method name and line number
                [ConsoleThemeStyle.SecondaryText] = LogTheme
                    .Foreground(Color.Gray)
                    .FormatType(FormatTypeEnum.ItalicMode),

                // Brackets, dots and colons
                [ConsoleThemeStyle.TertiaryText] = LogTheme.Style(Color.Gray),

                // Log message
                [ConsoleThemeStyle.Text] = LogTheme
                    .Foreground(Color.LightGray),

                [ConsoleThemeStyle.Invalid] = LogTheme.Style(Color.Yellow),
                [ConsoleThemeStyle.Null] = LogTheme.Style(Color.LightGray),
                [ConsoleThemeStyle.Name] = LogTheme.Style(Color.White),

                // Log values
                [ConsoleThemeStyle.String] = LogTheme.Style(Color.DarkRed),
                [ConsoleThemeStyle.Number] = LogTheme.Style(Color.DarkGreen),
                [ConsoleThemeStyle.Boolean] = LogTheme.Style(Color.DarkKhaki),
                [ConsoleThemeStyle.Scalar] = LogTheme.Style(Color.Black),

                // Log Level coloring
                [ConsoleThemeStyle.LevelVerbose] = LogTheme.Style(Color.White, Color.DarkGray),
                [ConsoleThemeStyle.LevelDebug] = LogTheme.Style(Color.White, Color.DarkGray),
                [ConsoleThemeStyle.LevelInformation] = LogTheme.Style(Color.White, Color.FromArgb(23, 126, 137)),
                [ConsoleThemeStyle.LevelWarning] = LogTheme.Style(Color.Black, Color.FromArgb(255, 200, 87)),
                [ConsoleThemeStyle.LevelError] = LogTheme.Style(Color.White, Color.Red),
                [ConsoleThemeStyle.LevelFatal] = LogTheme.Style(Color.White, Color.DarkRed),
            });
    }
}