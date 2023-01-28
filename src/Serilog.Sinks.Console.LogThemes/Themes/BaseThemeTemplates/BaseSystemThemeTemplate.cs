using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public abstract class BaseSystemConsoleTheme
    {
        protected virtual SystemConsoleThemeStyle Text { get; }

        protected virtual SystemConsoleThemeStyle SecondaryText { get; }

        protected virtual SystemConsoleThemeStyle TertiaryText { get; }

        protected virtual SystemConsoleThemeStyle Invalid { get; }

        protected virtual SystemConsoleThemeStyle Null { get; }

        protected virtual SystemConsoleThemeStyle Name { get; }

        protected virtual SystemConsoleThemeStyle String { get; }

        protected virtual SystemConsoleThemeStyle Number { get; }

        protected virtual SystemConsoleThemeStyle Boolean { get; }

        protected virtual SystemConsoleThemeStyle Scalar { get; }

        protected virtual SystemConsoleThemeStyle LevelVerbose { get; }

        protected virtual SystemConsoleThemeStyle LevelDebug { get; }

        protected virtual SystemConsoleThemeStyle LevelInformation { get; }

        protected virtual SystemConsoleThemeStyle LevelWarning { get; }

        protected virtual SystemConsoleThemeStyle LevelError { get; }

        protected virtual SystemConsoleThemeStyle LevelFatal { get; }

        public Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> ToStyleDictionary()
        {
            return new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
            {
                [ConsoleThemeStyle.Text] = Text,
                [ConsoleThemeStyle.SecondaryText] = SecondaryText,
                [ConsoleThemeStyle.TertiaryText] = TertiaryText,
                [ConsoleThemeStyle.Invalid] = Invalid,
                [ConsoleThemeStyle.Null] = Null,
                [ConsoleThemeStyle.Name] = Name,
                [ConsoleThemeStyle.String] = String,
                [ConsoleThemeStyle.Number] = Number,
                [ConsoleThemeStyle.Boolean] = Boolean,
                [ConsoleThemeStyle.Scalar] = Scalar,
                [ConsoleThemeStyle.LevelVerbose] = LevelVerbose,
                [ConsoleThemeStyle.LevelDebug] = LevelDebug,
                [ConsoleThemeStyle.LevelInformation] = LevelInformation,
                [ConsoleThemeStyle.LevelWarning] = LevelWarning,
                [ConsoleThemeStyle.LevelError] = LevelError,
                [ConsoleThemeStyle.LevelFatal] = LevelFatal,
            };
        }
    }
}