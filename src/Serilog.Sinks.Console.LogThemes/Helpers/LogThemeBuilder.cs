using System.Drawing;
using System.Text;

namespace Serilog.Sinks.Console.LogThemes
{
    internal static class LogThemeBuilder
    {
        internal static string Esc => "\x1b";

        internal static string ToTheme(Color? foreground, Color? background, FormatTypeEnum formatType = FormatTypeEnum.None)
        {
            var builder = new StringBuilder(Esc + "["); // ESC character

            if (formatType != FormatTypeEnum.None)
                builder.Append(formatType.ToAnsiString() + ";"); // Formatting style, bold, italic etc

            if (foreground != null)
                builder.Append(foreground.ToAnsiString(ColorLayerEnum.ForegroundColor)); // Font color

            if (foreground != null && background != null)
                builder.Append(";");

            if (foreground != null)
                builder.Append(background.ToAnsiString(ColorLayerEnum.BackgroundColor)); // Font background color

            builder.Append("m"); // exit command
            return builder.ToString();
        }
    }
}