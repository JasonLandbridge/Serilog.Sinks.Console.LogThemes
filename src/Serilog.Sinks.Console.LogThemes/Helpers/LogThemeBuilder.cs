using System.Drawing;
using System.Text;

namespace Serilog.Sinks.Console.LogThemes
{
    internal static class LogThemeBuilder
    {
        internal static string Esc => "\x1b[";

        internal static int Color256Format => 5;

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
                builder.Append(Esc + foreground.ToForegroundAnsiString() + "m");
            }

            if (background != null)
            {
                // Font background color
                builder.Append(Esc + background.ToBackgroundAnsiString() + "m");
            }

            return builder.ToString();
        }

        internal static string ToTheme(
            Color16? foreground,
            Color16? background,
            FormatTypeEnum formatType = FormatTypeEnum.None,
            bool bold = false)
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
                builder.Append(Esc + foreground.Value.ToForegroundAnsiString());
            }

            if (background != null)
            {
                // Font background color
                builder.Append(Esc + background.Value.ToBackgroundAnsiString());
            }

            return builder.ToString();
        }

        internal static string ToTheme(Color256? foreground, Color256? background, FormatTypeEnum formatType = FormatTypeEnum.None)
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
                builder.Append(Esc + $"38;{Color256Format};" + ((int)foreground.Value).ToString("D4") + "m");
            }

            if (background != null)
            {
                // Font background color
                builder.Append(Esc + $"48;{Color256Format};" + ((int)background.Value).ToString("D4") + "m");
            }

            return builder.ToString();
        }

        internal static string ToTheme(FormatTypeEnum formatType = FormatTypeEnum.None)
        {
            var builder = new StringBuilder();

            if (formatType != FormatTypeEnum.None)
            {
                // Formatting style, bold, italic etc
                builder.Append(Esc + formatType.ToAnsiString() + "m");
            }

            return builder.ToString();
        }
    }
}