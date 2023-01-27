using System;
using System.Drawing;
using System.Text;
using ANSITerm;

namespace Serilog.Sinks.Console.LogThemes
{
    public static partial class LogTheme
    {
        #region FluentApi

        #region Create

        public static LogStyle Foreground(Color foreGroundColor)
        {
            return new LogStyle().Foreground(foreGroundColor);
        }

        public static LogStyle Foreground(Color256 foreGroundColor)
        {
            return new LogStyle().Foreground(foreGroundColor);
        }

        public static LogStyle Foreground(Ansi16Colors foreGroundColor)
        {
            return new LogStyle().Foreground(foreGroundColor);
        }

        public static LogStyle Background(Color backGroundColor)
        {
            return new LogStyle().Background(backGroundColor);
        }

        public static LogStyle Background(Color256 backGroundColor)
        {
            return new LogStyle().Background(backGroundColor);
        }

        public static LogStyle Background(Ansi16Colors backGroundColor)
        {
            return new LogStyle().Background(backGroundColor);
        }

        #region FormatType

        public static LogStyle FormatType(FormatTypeEnum formatType)
        {
            return new LogStyle().FormatType(formatType);
        }

        public static LogStyle Bold()
        {
            return new LogStyle().FormatType(FormatTypeEnum.BoldMode);
        }

        #endregion

        #endregion

        #region Extend

        #region Foreground

        public static LogStyle Foreground(this LogStyle logStyle, Color256 foreGroundColor)
        {
            var color = Color.FromArgb((int)foreGroundColor, (int)foreGroundColor, (int)foreGroundColor);
            return logStyle.SetForeground(color);
        }

        public static LogStyle Foreground(this LogStyle logStyle, Ansi16Colors foreGroundColor)
        {
            return logStyle.SetForeground(new ColorValue(foreGroundColor).AsColor());
        }

        public static LogStyle Foreground(this LogStyle logStyle, Color foreGroundColor)
        {
            return logStyle.SetForeground(foreGroundColor);
        }

        #endregion

        #region Background

        public static LogStyle Background(this LogStyle logStyle, Color backGroundColor)
        {
            return logStyle.SetBackground(backGroundColor);
        }

        public static LogStyle Background(this LogStyle logStyle, Color256 backGroundColor)
        {
            var color = Color.FromArgb((int)backGroundColor, (int)backGroundColor, (int)backGroundColor);
            return logStyle.SetForeground(color);
        }

        public static LogStyle Background(this LogStyle logStyle, Ansi16Colors backGroundColor)
        {
            return logStyle.SetForeground(new ColorValue(backGroundColor).AsColor());
        }

        #endregion


        #region FormatType

        public static LogStyle FormatType(this LogStyle logStyle, FormatTypeEnum formatType)
        {
            return logStyle.SetFormatType(formatType);
        }

        public static LogStyle Bold(this LogStyle logStyle)
        {
            return logStyle.SetFormatType(FormatTypeEnum.BoldMode);
        }

        #endregion

        #endregion

        #endregion


        #region Style

        public static string Style(Color foreground, Color background, FormatTypeEnum formatType = FormatTypeEnum.None)
        {
            return Foreground(foreground).Background(background).FormatType(formatType).ToString();
        }

        public static string Style(Color foreground, FormatTypeEnum formatType)
        {
            return Foreground(foreground).FormatType(formatType).ToString();
        }

        public static string Style(Color foreground)
        {
            return Foreground(foreground).ToString();
        }

        public static string Style()
        {
            return "";
        }

        #endregion
    }
}