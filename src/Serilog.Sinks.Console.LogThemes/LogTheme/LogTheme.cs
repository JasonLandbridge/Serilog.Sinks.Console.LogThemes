using System;
using System.Drawing;
using System.Text;

namespace Serilog.Sinks.Console.LogThemes
{
    public static partial class LogTheme
    {
        #region FluentApi

        #region Create

        public static string Empty => "";

        public static string Foreground(Color foreGroundColor)
        {
            return LogThemeBuilder.ToTheme(foreGroundColor, null);
        }

        public static string Foreground(Color256 foreGroundColor)
        {
            return string.Empty.Foreground(foreGroundColor);
        }

        public static string Foreground(Ansi16Colors foreGroundColor, bool bold = false)
        {
            return string.Empty.Foreground(foreGroundColor, bold);
        }

        public static string Background(Color backGroundColor)
        {
            return LogThemeBuilder.ToTheme(null, backGroundColor);
        }

        public static string Background(Color256 backGroundColor)
        {
            return string.Empty.Background(backGroundColor);
        }

        public static string Background(Ansi16Colors backGroundColor)
        {
            return string.Empty.Background(backGroundColor);
        }

        #region FormatType

        public static string FormatType(FormatTypeEnum formatType)
        {
            return string.Empty.FormatType(formatType);
        }

        public static string Bold()
        {
            return string.Empty.FormatType(FormatTypeEnum.BoldMode);
        }

        #endregion

        #endregion

        #region Extend

        #region Foreground

        public static string Foreground(this string logStyle, Color256 foreGroundColor)
        {
            return logStyle + LogThemeBuilder.ToTheme(foreGroundColor, null);
        }

        public static string Foreground(this string logStyle, Ansi16Colors foreGroundColor, bool bold = false)
        {
            return logStyle + LogThemeBuilder.ToTheme(foreGroundColor, null, bold: bold);
        }

        public static string Foreground(this string logStyle, Color foreGroundColor)
        {
            return logStyle + LogThemeBuilder.ToTheme(foreGroundColor, null);
        }

        #endregion

        #region Background

        public static string Background(this string logStyle, Color backGroundColor)
        {
            return logStyle + LogThemeBuilder.ToTheme(null, backGroundColor);
        }

        public static string Background(this string logStyle, Color256 backGroundColor)
        {
            return logStyle + LogThemeBuilder.ToTheme(null, backGroundColor);
        }

        public static string Background(this string logStyle, Ansi16Colors backGroundColor)
        {
            return logStyle + LogThemeBuilder.ToTheme(null, backGroundColor);
        }

        #endregion


        #region FormatType

        public static string FormatType(this string logStyle, FormatTypeEnum formatType)
        {
            return logStyle + LogThemeBuilder.ToTheme(formatType);
        }

        public static string Bold(this string logStyle)
        {
            return logStyle.FormatType(FormatTypeEnum.BoldMode);
        }

        #endregion

        #endregion

        #endregion


        #region Style

        public static string Style(Color foreground, Color background, FormatTypeEnum formatType = FormatTypeEnum.None)
        {
            return Foreground(foreground).Background(background).FormatType(formatType);
        }

        public static string Style(Color foreground, FormatTypeEnum formatType)
        {
            return Foreground(foreground).FormatType(formatType);
        }

        public static string Style(Color foreground)
        {
            return Foreground(foreground);
        }

        #region Color16

        public static string Style(Ansi16Colors foreground, Ansi16Colors background)
        {
            return Foreground(foreground).Background(background);
        }

        #endregion

        #region Color256

        public static string Style(Color256 foreground, Color256 background)
        {
            return Foreground(foreground).Background(background);
        }

        #endregion

        public static string Style()
        {
            return string.Empty;
        }

        #endregion
    }
}