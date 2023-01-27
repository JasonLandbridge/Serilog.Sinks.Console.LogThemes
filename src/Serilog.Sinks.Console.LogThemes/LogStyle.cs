using System.Drawing;

namespace Serilog.Sinks.Console.LogThemes
{
    public class LogStyle
    {
        private Color? _foreground = null;

        private Color? _background = null;

        private FormatTypeEnum _formatType = FormatTypeEnum.None;

        public LogStyle()
        {
        }

        public LogStyle(Color? foreground, Color? background)
        {
            _foreground = foreground;
            _background = background;
        }

        public LogStyle(Color? foreground, Color? background, FormatTypeEnum formatType)
        {
            _foreground = foreground;
            _background = background;
            _formatType = formatType;
        }

        public LogStyle SetForeground(Color? foreground)
        {
            _foreground = foreground;
            return this;
        }

        public LogStyle SetBackground(Color? background)
        {
            _background = background;
            return this;
        }

        public LogStyle SetFormatType(FormatTypeEnum formatType)
        {
            _formatType = formatType;
            return this;
        }

        public string ToStyle()
        {
            return ToString();
        }

        public override string ToString()
        {
            return LogThemeBuilder.ToTheme(_foreground, _background, _formatType);
        }
    }
}