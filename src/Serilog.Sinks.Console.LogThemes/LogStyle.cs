using System;
using System.Drawing;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public class LogStyle
    {
        private Color? _foreground = null;

        private Color? _background = null;

        private ConsoleColor? _foregroundSystemConsole = null;

        private ConsoleColor? _backgroundSystemConsole = null;

        private FormatTypeEnum _formatType = FormatTypeEnum.None;

        public LogStyle()
        {
        }


        #region ANSIMode

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

        #region Setters

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

        #endregion

        #endregion

        #region SystemConsoleMode

        public LogStyle SetForeground(ConsoleColor? foreground)
        {
            _foregroundSystemConsole = foreground;
            return this;
        }

        public LogStyle SetBackground(ConsoleColor? background)
        {
            _backgroundSystemConsole = background;
            return this;
        }

        #endregion

        public string ToStyle()
        {
            return ToString();
        }

        public override string ToString()
        {
            return LogThemeBuilder.ToTheme(_foreground, _background, _formatType);
        }

        public SystemConsoleThemeStyle ToSystemStyle()
        {
            return new SystemConsoleThemeStyle()
            {
                Foreground = _foregroundSystemConsole,
                Background = _foregroundSystemConsole,
            };
        }
    }
}