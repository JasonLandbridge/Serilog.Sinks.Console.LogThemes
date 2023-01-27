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

        public static string ToAnsiString(this Ansi16Colors ansi16Colors)
        {
            var esc = LogThemeBuilder.Esc;
            switch (ansi16Colors)
            {
                case Ansi16Colors.Black:
                    return esc + "[30;1m";
                case Ansi16Colors.Red:
                    return esc + "[31;1m";
                case Ansi16Colors.Green:
                    return esc + "[32;1m";
                case Ansi16Colors.Yellow:
                    return esc + "[33;1m";
                case Ansi16Colors.Blue:
                    return esc + "[34;1m";
                case Ansi16Colors.Magenta:
                    return esc + "[35;1m";
                case Ansi16Colors.Cyan:
                    return esc + "[36;1m";
                case Ansi16Colors.White:
                    return esc + "[37;1m";

                case Ansi16Colors.BrightBlack:
                    return esc + "[90;1m";
                case Ansi16Colors.BrightRed:
                    return esc + "[91;1m";
                case Ansi16Colors.BrightGreen:
                    return esc + "[92;1m";
                case Ansi16Colors.BrightYellow:
                    return esc + "[93;1m";
                case Ansi16Colors.BrightBlue:
                    return esc + "[94;1m";
                case Ansi16Colors.BrightMagenta:
                    return esc + "[95;1m";
                case Ansi16Colors.BrightCyan:
                    return esc + "[96;1m";
                case Ansi16Colors.BrightWhite:
                    return esc + "[97;1m";

                case Ansi16Colors.Default:
                    return esc + "[39;1m";
                case Ansi16Colors.Reset:
                    return esc + "[0;1m";

                default:
                    throw new ArgumentOutOfRangeException(nameof(ansi16Colors), ansi16Colors, null);
            }
        }

        public static string ToAnsiString(this Color? color, ColorLayerEnum colorLayerEnum)
        {
            if (color is null)
                return "";

            var colorString = "";

            if (colorLayerEnum == ColorLayerEnum.ForegroundColor)
                colorString += "38;";

            if (colorLayerEnum == ColorLayerEnum.BackgroundColor)
                colorString += "48;";

            return colorString + $"5;{color.Value.R};{color.Value.G};{color.Value.B}";
        }
    }
}