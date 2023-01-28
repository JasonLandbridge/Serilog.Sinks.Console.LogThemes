using System;
using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public static partial class LogThemes
    {
        public static SystemConsoleTheme SystemLiterate { get; } = new SystemConsoleTheme(ThemeDefinitions.SystemLiterate);

        public static SystemConsoleTheme SystemGrayscale { get; } = new SystemConsoleTheme(ThemeDefinitions.SystemGrayscale);

        public static SystemConsoleTheme SystemColored { get; } = new SystemConsoleTheme(ThemeDefinitions.SystemColored);
    }
}