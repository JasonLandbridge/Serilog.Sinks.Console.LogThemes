namespace Serilog.Sinks.Console.LogThemes
{
    public static partial class LogTheme
    {
        #region Predefined

        public static string Unthemed => "";

        #endregion

        #region Colors

        public const string BlackForeground = "\x1b[30m";
        public const string RedForeground = "\x1b[31m";
        public const string GreenForeground = "\x1b[32m";
        public const string YellowForeground = "\x1b[33m";
        public const string BlueForeground = "\x1b[34m";
        public const string MagentaForeground = "\x1b[35m";
        public const string CyanForeground = "\x1b[36m";
        public const string WhiteForeground = "\x1b[37m";

        #endregion
    }
}