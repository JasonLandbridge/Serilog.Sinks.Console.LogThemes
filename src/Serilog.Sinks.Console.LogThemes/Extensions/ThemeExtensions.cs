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