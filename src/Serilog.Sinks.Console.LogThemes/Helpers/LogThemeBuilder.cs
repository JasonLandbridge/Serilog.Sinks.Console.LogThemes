using System.Drawing;
using System.Text;

namespace Serilog.Sinks.Console.LogThemes
{
    internal static class LogThemeBuilder
    {
        internal static string Esc => "\x1b[";

        internal static string ToTheme(Color? foreground, Color? background, FormatTypeEnum formatType = FormatTypeEnum.None)
        {
            var builder = new StringBuilder();

            if (formatType != FormatTypeEnum.None)
            {
                // Formatting style, bold, italic etc
                builder.Append(Esc + formatType.ToAnsiString() + "m");
            }

            if (foreground != null)
            {
                // Font color
                builder.Append(Esc + foreground.ToAnsiString(ColorLayerEnum.ForegroundColor) + "m");
            }

            if (background != null)
            {
                // Font background color
                builder.Append(Esc + background.ToAnsiString(ColorLayerEnum.BackgroundColor) + "m");
            }

            return builder.ToString();
        }

        internal static string ToTheme(Ansi16Colors? foreground, Ansi16Colors? background, FormatTypeEnum formatType = FormatTypeEnum.None)
        {
            var builder = new StringBuilder();

            if (formatType != FormatTypeEnum.None)
            {
                // Formatting style, bold, italic etc
                builder.Append(Esc + formatType.ToAnsiString() + "m");
            }

            if (foreground != null)
            {
                // Font color
                builder.Append(Esc + foreground.Value.ToAnsiString());
            }

            if (background != null)
            {
                // Font background color
                builder.Append(Esc + background.Value.ToAnsiString());
            }

            return builder.ToString();
        }
    }
}