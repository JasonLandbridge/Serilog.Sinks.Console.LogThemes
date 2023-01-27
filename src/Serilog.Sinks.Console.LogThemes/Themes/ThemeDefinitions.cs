using System.Collections.Generic;
using ANSITerm;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    internal static class ThemeDefinitions
    {
        internal static Dictionary<ConsoleThemeStyle, string> Code { get; } =
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = LogTheme.Foreground(Color256.Grey253).ToString(),
                [ConsoleThemeStyle.SecondaryText] = LogTheme.Foreground(Color256.Grey246).ToString(),
                [ConsoleThemeStyle.TertiaryText] = LogTheme.Foreground(Color256.Grey242).ToString(),

                [ConsoleThemeStyle.Invalid] = LogTheme.Foreground(Ansi16Colors.BrightYellow).Bold().ToString(),

                [ConsoleThemeStyle.Null] = LogTheme.Foreground(Color256.DeepSkyBlue38).ToString(),
                [ConsoleThemeStyle.Name] = LogTheme.Foreground(Color256.SteelBlue81).ToString(),
                [ConsoleThemeStyle.String] = LogTheme.Foreground(Color256.LightSalmon216).ToString(),
                [ConsoleThemeStyle.Number] = LogTheme.Foreground(Color256.DarkSeaGreen151).ToString(),
                [ConsoleThemeStyle.Boolean] = LogTheme.Foreground(Color256.DeepSkyBlue38).ToString(),
                [ConsoleThemeStyle.Scalar] = LogTheme.Foreground(Color256.Aquamarine79).ToString(),
                [ConsoleThemeStyle.LevelVerbose] = LogTheme.Foreground(Ansi16Colors.White).ToString(),
                [ConsoleThemeStyle.LevelDebug] = LogTheme.Foreground(Ansi16Colors.White).ToString(),
                [ConsoleThemeStyle.LevelInformation] = LogTheme.Foreground(Ansi16Colors.White).Bold().ToString(),
                [ConsoleThemeStyle.LevelWarning] = LogTheme.Foreground(Color256.Wheat229).ToString(),
                [ConsoleThemeStyle.LevelError] = LogTheme.Foreground(Color256.DeepPink197).Background(Color256.Grey238).ToString(),
                [ConsoleThemeStyle.LevelFatal] = LogTheme.Foreground(Color256.DeepPink197).Background(Color256.Grey238).ToString(),
            };
    }
}