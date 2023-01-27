using System.Drawing;
using System.Text;

namespace Serilog.Sinks.Console.LogThemes
{
    public static class LogTheme
    {
        #region FluentApi

        #region Create

        public static LogStyle Foreground(Color foreGroundColor)
        {
            return new LogStyle().SetForeground(foreGroundColor);
        }

        public static LogStyle Background(Color backGroundColor)
        {
            return new LogStyle().SetBackground(backGroundColor);
        }

        public static LogStyle FormatType(FormatTypeEnum formatType)
        {
            return new LogStyle().SetFormatType(formatType);
        }

        #endregion

        #region Extend

        public static LogStyle Foreground(this LogStyle logStyle, Color foreGroundColor)
        {
            return logStyle.SetForeground(foreGroundColor);
        }

        public static LogStyle Background(this LogStyle logStyle, Color backGroundColor)
        {
            return logStyle.SetBackground(backGroundColor);
        }

        public static LogStyle FormatType(this LogStyle logStyle, FormatTypeEnum formatType)
        {
            return logStyle.SetFormatType(formatType);
        }

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