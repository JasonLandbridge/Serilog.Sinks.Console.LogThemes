using System;
using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    internal static class ThemeDefinitions
    {
        #region AnsiThemes

        internal static Dictionary<ConsoleThemeStyle, string> Code { get; } =
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = LogTheme.Foreground(Color256.Grey253),
                [ConsoleThemeStyle.SecondaryText] = LogTheme.Foreground(Color256.Grey246),
                [ConsoleThemeStyle.TertiaryText] = LogTheme.Foreground(Color256.Grey242),

                [ConsoleThemeStyle.Invalid] = LogTheme.Foreground(Color16.YellowBold),

                [ConsoleThemeStyle.Null] = LogTheme.Foreground(Color256.DeepSkyBlue38),
                [ConsoleThemeStyle.Name] = LogTheme.Foreground(Color256.SteelBlue81),
                [ConsoleThemeStyle.String] = LogTheme.Foreground(Color256.LightSalmon216),
                [ConsoleThemeStyle.Number] = LogTheme.Foreground(Color256.DarkSeaGreen151),
                [ConsoleThemeStyle.Boolean] = LogTheme.Foreground(Color256.DeepSkyBlue38),
                [ConsoleThemeStyle.Scalar] = LogTheme.Foreground(Color256.Aquamarine79),
                [ConsoleThemeStyle.LevelVerbose] = LogTheme.Foreground(Color16.White),
                [ConsoleThemeStyle.LevelDebug] = LogTheme.Foreground(Color16.White),
                [ConsoleThemeStyle.LevelInformation] = LogTheme.Foreground(Color16.WhiteBold),
                [ConsoleThemeStyle.LevelWarning] = LogTheme.Foreground(Color256.Wheat229),
                [ConsoleThemeStyle.LevelError] = LogTheme.Foreground(Color256.DeepPink197).Background(Color256.Grey238),
                [ConsoleThemeStyle.LevelFatal] = LogTheme.Foreground(Color256.DeepPink197).Background(Color256.Grey238),
            };

        internal static Dictionary<ConsoleThemeStyle, string> Literate { get; } =
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = LogTheme.Foreground(Color256.BrightWhite15),
                [ConsoleThemeStyle.SecondaryText] = LogTheme.Foreground(Color256.White7),
                [ConsoleThemeStyle.TertiaryText] = LogTheme.Foreground(Color256.BrightBlack8),
                [ConsoleThemeStyle.Invalid] = LogTheme.Foreground(Color256.BrightYellow11),
                [ConsoleThemeStyle.Null] = LogTheme.Foreground(Color256.DodgerBlue27),
                [ConsoleThemeStyle.Name] = LogTheme.Foreground(Color256.White7),
                [ConsoleThemeStyle.String] = LogTheme.Foreground(Color256.Turquoise45),
                [ConsoleThemeStyle.Number] = LogTheme.Foreground(Color256.Magenta200),
                [ConsoleThemeStyle.Boolean] = LogTheme.Foreground(Color256.DodgerBlue27),
                [ConsoleThemeStyle.Scalar] = LogTheme.Foreground(Color256.SeaGreen85),
                [ConsoleThemeStyle.LevelVerbose] = LogTheme.Foreground(Color256.White7),
                [ConsoleThemeStyle.LevelDebug] = LogTheme.Foreground(Color256.White7),
                [ConsoleThemeStyle.LevelInformation] = LogTheme.Foreground(Color256.BrightWhite15),
                [ConsoleThemeStyle.LevelWarning] = LogTheme.Foreground(Color256.BrightYellow11),
                [ConsoleThemeStyle.LevelError] = LogTheme.Style(Color256.BrightWhite15, Color256.Red196),
                [ConsoleThemeStyle.LevelFatal] = LogTheme.Style(Color256.BrightWhite15, Color256.Red196),
            };


        internal static Dictionary<ConsoleThemeStyle, string> Grayscale { get; } = new Dictionary<ConsoleThemeStyle, string>
        {
            [ConsoleThemeStyle.Text] = LogTheme.Foreground(Color16.WhiteBold),
            [ConsoleThemeStyle.SecondaryText] = LogTheme.Foreground(Color16.White),
            [ConsoleThemeStyle.TertiaryText] = LogTheme.Foreground(Color16.BlackBold),
            [ConsoleThemeStyle.Invalid] = LogTheme.Style(Color16.WhiteBold, Color16.White),
            [ConsoleThemeStyle.Null] = LogTheme.Bold().Foreground(Color16.WhiteBold),
            [ConsoleThemeStyle.Name] = LogTheme.Foreground(Color16.White),
            [ConsoleThemeStyle.String] = LogTheme.Bold().Foreground(Color16.WhiteBold),
            [ConsoleThemeStyle.Number] = LogTheme.Bold().Foreground(Color16.WhiteBold),
            [ConsoleThemeStyle.Boolean] = LogTheme.Bold().Foreground(Color16.WhiteBold),
            [ConsoleThemeStyle.Scalar] = LogTheme.Bold().Foreground(Color16.WhiteBold),
            [ConsoleThemeStyle.LevelVerbose] = LogTheme.Foreground(Color16.BlackBold),
            [ConsoleThemeStyle.LevelDebug] = LogTheme.Foreground(Color16.BlackBold),
            [ConsoleThemeStyle.LevelInformation] = LogTheme.Foreground(Color16.WhiteBold),
            [ConsoleThemeStyle.LevelWarning] = LogTheme.Style(Color16.WhiteBold, Color16.White),
            [ConsoleThemeStyle.LevelError] = LogTheme.Style(Color16.Black, Color16.White),
            [ConsoleThemeStyle.LevelFatal] = LogTheme.Style(Color16.Black, Color16.White),
        };

        internal static Dictionary<ConsoleThemeStyle, string> Sixteen { get; } = new Dictionary<ConsoleThemeStyle, string>
        {
            [ConsoleThemeStyle.Text] = LogTheme.Unthemed,
            [ConsoleThemeStyle.SecondaryText] = LogTheme.Unthemed,
            [ConsoleThemeStyle.TertiaryText] = LogTheme.Unthemed,
            [ConsoleThemeStyle.Invalid] = LogTheme.Foreground(Color16.Yellow),
            [ConsoleThemeStyle.Null] = LogTheme.Foreground(Color16.Blue),
            [ConsoleThemeStyle.Name] = LogTheme.Unthemed,
            [ConsoleThemeStyle.String] = LogTheme.Foreground(Color16.Cyan),
            [ConsoleThemeStyle.Number] = LogTheme.Foreground(Color16.Magenta),
            [ConsoleThemeStyle.Boolean] = LogTheme.Foreground(Color16.Blue),
            [ConsoleThemeStyle.Scalar] = LogTheme.Foreground(Color16.Green),
            [ConsoleThemeStyle.LevelVerbose] = LogTheme.Unthemed,
            [ConsoleThemeStyle.LevelDebug] = LogTheme.Bold(),
            [ConsoleThemeStyle.LevelInformation] = LogTheme.Foreground(Color16.CyanBold),
            [ConsoleThemeStyle.LevelWarning] = LogTheme.Foreground(Color16.YellowBold),
            [ConsoleThemeStyle.LevelError] = LogTheme.Foreground(Color16.RedBold),
            [ConsoleThemeStyle.LevelFatal] = LogTheme.Foreground(Color16.RedBold),
        };

        internal static Dictionary<ConsoleThemeStyle, string> SixteenNonBright { get; } = new Dictionary<ConsoleThemeStyle, string>
        {
            [ConsoleThemeStyle.Text] = LogTheme.Unthemed,
            [ConsoleThemeStyle.SecondaryText] = LogTheme.Unthemed,
            [ConsoleThemeStyle.TertiaryText] = LogTheme.Unthemed,
            [ConsoleThemeStyle.Invalid] = LogTheme.Foreground(Color16.Yellow),
            [ConsoleThemeStyle.Null] = LogTheme.Foreground(Color16.Blue),
            [ConsoleThemeStyle.Name] = LogTheme.Unthemed,
            [ConsoleThemeStyle.String] =  LogTheme.Foreground(Color16.Cyan),
            [ConsoleThemeStyle.Number] = LogTheme.Foreground(Color16.Magenta),
            [ConsoleThemeStyle.Boolean] = LogTheme.Foreground(Color16.Blue),
            [ConsoleThemeStyle.Scalar] = LogTheme.Foreground(Color16.Green),
            [ConsoleThemeStyle.LevelVerbose] = LogTheme.Unthemed,
            [ConsoleThemeStyle.LevelDebug] = LogTheme.Foreground(Color16.Magenta),
            [ConsoleThemeStyle.LevelInformation] = LogTheme.Foreground(Color16.Cyan),
            [ConsoleThemeStyle.LevelWarning] = LogTheme.Foreground(Color16.Yellow),
            [ConsoleThemeStyle.LevelError] = LogTheme.Foreground(Color16.Red),
            [ConsoleThemeStyle.LevelFatal] = LogTheme.Foreground(Color16.Red),
        };

        #endregion

        #region SystemConsoleThemes

        internal static Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> SystemColored { get; } =
            new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.SecondaryText] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.TertiaryText] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.Invalid] = LogSystemTheme.Foreground(ConsoleColor.Yellow),
                [ConsoleThemeStyle.Null] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Name] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.String] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Number] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Boolean] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Scalar] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.LevelVerbose] = LogSystemTheme.Style(ConsoleColor.Gray, ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelDebug] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelInformation] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Blue),
                [ConsoleThemeStyle.LevelWarning] = LogSystemTheme.Style(ConsoleColor.DarkGray, ConsoleColor.Yellow),
                [ConsoleThemeStyle.LevelError] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red),
                [ConsoleThemeStyle.LevelFatal] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red),
            };

        internal static Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> SystemLiterate { get; } =
            new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.SecondaryText] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.TertiaryText] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.Invalid] = LogSystemTheme.Foreground(ConsoleColor.Yellow),
                [ConsoleThemeStyle.Null] = LogSystemTheme.Foreground(ConsoleColor.Blue),
                [ConsoleThemeStyle.Name] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.String] = LogSystemTheme.Foreground(ConsoleColor.Cyan),
                [ConsoleThemeStyle.Number] = LogSystemTheme.Foreground(ConsoleColor.Magenta),
                [ConsoleThemeStyle.Boolean] = LogSystemTheme.Foreground(ConsoleColor.Blue),
                [ConsoleThemeStyle.Scalar] = LogSystemTheme.Foreground(ConsoleColor.Green),
                [ConsoleThemeStyle.LevelVerbose] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.LevelDebug] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.LevelInformation] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.LevelWarning] = LogSystemTheme.Foreground(ConsoleColor.Yellow),
                [ConsoleThemeStyle.LevelError] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red),
                [ConsoleThemeStyle.LevelFatal] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.Red),
            };

        internal static Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> SystemGrayscale { get; } =
            new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.SecondaryText] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.TertiaryText] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.Invalid] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.DarkGray),
                [ConsoleThemeStyle.Null] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Name] = LogSystemTheme.Foreground(ConsoleColor.Gray),
                [ConsoleThemeStyle.String] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Number] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Boolean] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.Scalar] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.LevelVerbose] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelDebug] = LogSystemTheme.Foreground(ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelInformation] = LogSystemTheme.Foreground(ConsoleColor.White),
                [ConsoleThemeStyle.LevelWarning] = LogSystemTheme.Style(ConsoleColor.White, ConsoleColor.DarkGray),
                [ConsoleThemeStyle.LevelError] = LogSystemTheme.Style(ConsoleColor.Black, ConsoleColor.White),
                [ConsoleThemeStyle.LevelFatal] = LogSystemTheme.Style(ConsoleColor.Black, ConsoleColor.White),
            };

        #endregion
    }
}