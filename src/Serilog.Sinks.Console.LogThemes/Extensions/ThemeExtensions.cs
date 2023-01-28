using System;
using System.Drawing;

namespace Serilog.Sinks.Console.LogThemes
{
    public static class ThemeExtensions
    {
        public static string ToAnsiString(this FormatTypeEnum formatType)
        {
            return formatType switch
            {
                FormatTypeEnum.None => "0",
                FormatTypeEnum.BoldMode => "1",
                FormatTypeEnum.DimFaintMode => "2",
                FormatTypeEnum.ItalicMode => "3",
                FormatTypeEnum.UnderlineMode => "4",
                FormatTypeEnum.BlinkingMode => "5",
                FormatTypeEnum.InverseReverseMode => "7",
                FormatTypeEnum.HiddenMode => "8",
                FormatTypeEnum.Strikethrough => "9",
                _ => "0",
            };
        }

        public static string ToForegroundAnsiString(this Ansi16Colors ansi16Colors)
        {
            switch (ansi16Colors)
            {
                case Ansi16Colors.Black:
                    return "30m";
                case Ansi16Colors.Red:
                    return "31m";
                case Ansi16Colors.Green:
                    return "32m";
                case Ansi16Colors.Yellow:
                    return "33m";
                case Ansi16Colors.Blue:
                    return "34m";
                case Ansi16Colors.Magenta:
                    return "35m";
                case Ansi16Colors.Cyan:
                    return "36m";
                case Ansi16Colors.White:
                    return "37m";

                case Ansi16Colors.BlackBold:
                    return "30;1m";
                case Ansi16Colors.RedBold:
                    return "31;1m";
                case Ansi16Colors.GreenBold:
                    return "32;1m";
                case Ansi16Colors.YellowBold:
                    return "33;1m";
                case Ansi16Colors.BlueBold:
                    return "34;1m";
                case Ansi16Colors.MagentaBold:
                    return "35;1m";
                case Ansi16Colors.CyanBold:
                    return "36;1m";
                case Ansi16Colors.WhiteBold:
                    return "37;1m";

                case Ansi16Colors.BrightBlack:
                    return "90;1m";
                case Ansi16Colors.BrightRed:
                    return "91;1m";
                case Ansi16Colors.BrightGreen:
                    return "92;1m";
                case Ansi16Colors.BrightYellow:
                    return "93;1m";
                case Ansi16Colors.BrightBlue:
                    return "94;1m";
                case Ansi16Colors.BrightMagenta:
                    return "95;1m";
                case Ansi16Colors.BrightCyan:
                    return "96;1m";
                case Ansi16Colors.BrightWhite:
                    return "97;1m";

                case Ansi16Colors.Default:
                    return "39m";
                case Ansi16Colors.Reset:
                    return "0m";

                default:
                    throw new ArgumentOutOfRangeException(nameof(ansi16Colors), ansi16Colors, null);
            }
        }

        public static string ToBackgroundAnsiString(this Ansi16Colors ansi16Colors)
        {
            switch (ansi16Colors)
            {
                case Ansi16Colors.Black:
                    return "40m";
                case Ansi16Colors.Red:
                    return "41m";
                case Ansi16Colors.Green:
                    return "42m";
                case Ansi16Colors.Yellow:
                    return "43m";
                case Ansi16Colors.Blue:
                    return "44m";
                case Ansi16Colors.Magenta:
                    return "45m";
                case Ansi16Colors.Cyan:
                    return "46m";
                case Ansi16Colors.White:
                    return "47m";

                case Ansi16Colors.BlackBold:
                    return "30;1m";
                case Ansi16Colors.RedBold:
                    return "31;1m";
                case Ansi16Colors.GreenBold:
                    return "32;1m";
                case Ansi16Colors.YellowBold:
                    return "33;1m";
                case Ansi16Colors.BlueBold:
                    return "34;1m";
                case Ansi16Colors.MagentaBold:
                    return "35;1m";
                case Ansi16Colors.CyanBold:
                    return "36;1m";
                case Ansi16Colors.WhiteBold:
                    return "37;1m";

                case Ansi16Colors.BrightBlack:
                    return "100;1m";
                case Ansi16Colors.BrightRed:
                    return "101;1m";
                case Ansi16Colors.BrightGreen:
                    return "102;1m";
                case Ansi16Colors.BrightYellow:
                    return "103;1m";
                case Ansi16Colors.BrightBlue:
                    return "104;1m";
                case Ansi16Colors.BrightMagenta:
                    return "105;1m";
                case Ansi16Colors.BrightCyan:
                    return "106;1m";
                case Ansi16Colors.BrightWhite:
                    return "107;1m";

                case Ansi16Colors.Default:
                    return "49m";
                case Ansi16Colors.Reset:
                    return "0m";

                default:
                    throw new ArgumentOutOfRangeException(nameof(ansi16Colors), ansi16Colors, null);
            }
        }

        public static string ToAnsiString(this Color? color, ColorLayerEnum colorLayerEnum)
        {
            if (color is null)
                return "";

            var colorString = "";

            // TODO Colorlayer enum can most likely be deleted
            if (colorLayerEnum == ColorLayerEnum.ForegroundColor)
                colorString += "38;";

            if (colorLayerEnum == ColorLayerEnum.BackgroundColor)
                colorString += "48;";

            // Is 255 color?
            if (color.Value.R == color.Value.G && color.Value.R == color.Value.B)
            {
                return colorString + $"5;0{color.Value.R}";
            }
            return colorString + $"5;0{color.Value.R};0{color.Value.G};0{color.Value.B}";
        }
    }
}