using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    internal static class ThemeDefinitions
    {
        internal static Dictionary<ConsoleThemeStyle, string> Code { get; } =
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = LogTheme.Foreground(Color256.Grey253),
                [ConsoleThemeStyle.SecondaryText] = LogTheme.Foreground(Color256.Grey246),
                [ConsoleThemeStyle.TertiaryText] = LogTheme.Foreground(Color256.Grey242),

                [ConsoleThemeStyle.Invalid] = LogTheme.Foreground(Ansi16Colors.YellowBold),

                [ConsoleThemeStyle.Null] = LogTheme.Foreground(Color256.DeepSkyBlue38),
                [ConsoleThemeStyle.Name] = LogTheme.Foreground(Color256.SteelBlue81),
                [ConsoleThemeStyle.String] = LogTheme.Foreground(Color256.LightSalmon216),
                [ConsoleThemeStyle.Number] = LogTheme.Foreground(Color256.DarkSeaGreen151),
                [ConsoleThemeStyle.Boolean] = LogTheme.Foreground(Color256.DeepSkyBlue38),
                [ConsoleThemeStyle.Scalar] = LogTheme.Foreground(Color256.Aquamarine79),
                [ConsoleThemeStyle.LevelVerbose] = LogTheme.Foreground(Ansi16Colors.White),
                [ConsoleThemeStyle.LevelDebug] = LogTheme.Foreground(Ansi16Colors.White),
                [ConsoleThemeStyle.LevelInformation] = LogTheme.Foreground(Ansi16Colors.WhiteBold),
                [ConsoleThemeStyle.LevelWarning] = LogTheme.Foreground(Color256.Wheat229),
                [ConsoleThemeStyle.LevelError] = LogTheme.Foreground(Color256.DeepPink197).Background(Color256.Grey238),
                [ConsoleThemeStyle.LevelFatal] = LogTheme.Foreground(Color256.DeepPink197).Background(Color256.Grey238),
            };
    }
}