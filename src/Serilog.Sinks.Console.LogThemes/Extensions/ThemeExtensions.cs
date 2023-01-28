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

        public static string ToForegroundAnsiString(this Color16 color16)
        {
            switch (color16)
            {
                case Color16.Black:
                    return "30m";
                case Color16.Red:
                    return "31m";
                case Color16.Green:
                    return "32m";
                case Color16.Yellow:
                    return "33m";
                case Color16.Blue:
                    return "34m";
                case Color16.Magenta:
                    return "35m";
                case Color16.Cyan:
                    return "36m";
                case Color16.White:
                    return "37m";

                case Color16.BlackBold:
                    return "30;1m";
                case Color16.RedBold:
                    return "31;1m";
                case Color16.GreenBold:
                    return "32;1m";
                case Color16.YellowBold:
                    return "33;1m";
                case Color16.BlueBold:
                    return "34;1m";
                case Color16.MagentaBold:
                    return "35;1m";
                case Color16.CyanBold:
                    return "36;1m";
                case Color16.WhiteBold:
                    return "37;1m";

                case Color16.BrightBlack:
                    return "90;1m";
                case Color16.BrightRed:
                    return "91;1m";
                case Color16.BrightGreen:
                    return "92;1m";
                case Color16.BrightYellow:
                    return "93;1m";
                case Color16.BrightBlue:
                    return "94;1m";
                case Color16.BrightMagenta:
                    return "95;1m";
                case Color16.BrightCyan:
                    return "96;1m";
                case Color16.BrightWhite:
                    return "97;1m";

                case Color16.Default:
                    return "39m";
                case Color16.Reset:
                    return "0m";

                default:
                    throw new ArgumentOutOfRangeException(nameof(color16), color16, null);
            }
        }

        public static string ToBackgroundAnsiString(this Color16 color16)
        {
            switch (color16)
            {
                case Color16.Black:
                    return "40m";
                case Color16.Red:
                    return "41m";
                case Color16.Green:
                    return "42m";
                case Color16.Yellow:
                    return "43m";
                case Color16.Blue:
                    return "44m";
                case Color16.Magenta:
                    return "45m";
                case Color16.Cyan:
                    return "46m";
                case Color16.White:
                    return "47m";

                case Color16.BlackBold:
                    return "30;1m";
                case Color16.RedBold:
                    return "31;1m";
                case Color16.GreenBold:
                    return "32;1m";
                case Color16.YellowBold:
                    return "33;1m";
                case Color16.BlueBold:
                    return "34;1m";
                case Color16.MagentaBold:
                    return "35;1m";
                case Color16.CyanBold:
                    return "36;1m";
                case Color16.WhiteBold:
                    return "37;1m";

                case Color16.BrightBlack:
                    return "100;1m";
                case Color16.BrightRed:
                    return "101;1m";
                case Color16.BrightGreen:
                    return "102;1m";
                case Color16.BrightYellow:
                    return "103;1m";
                case Color16.BrightBlue:
                    return "104;1m";
                case Color16.BrightMagenta:
                    return "105;1m";
                case Color16.BrightCyan:
                    return "106;1m";
                case Color16.BrightWhite:
                    return "107;1m";

                case Color16.Default:
                    return "49m";
                case Color16.Reset:
                    return "0m";

                default:
                    throw new ArgumentOutOfRangeException(nameof(color16), color16, null);
            }
        }


        public static string ToForegroundAnsiString(this Color? color)
        {
            if (color is null)
                return "";

            // Is 255 color?
            if (color.Value.R == color.Value.G && color.Value.R == color.Value.B)
            {
                return $"38;5;0{color.Value.R}";
            }
            return $"38;5;0{color.Value.R};0{color.Value.G};0{color.Value.B}";
        }

        public static string ToBackgroundAnsiString(this Color? color)
        {
            if (color is null)
                return "";

            // Is 255 color?
            if (color.Value.R == color.Value.G && color.Value.R == color.Value.B)
            {
                return $"48;5;0{color.Value.R}";
            }
            return $"48;5;0{color.Value.R};0{color.Value.G};0{color.Value.B}";
        }
    }
}