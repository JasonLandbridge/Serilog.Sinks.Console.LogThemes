using System.Collections.Generic;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public abstract class AnsiBaseTheme
    {
        protected abstract string Text { get; }

        protected abstract string SecondaryText { get; }

        protected abstract string TertiaryText { get; }

        protected abstract string Invalid { get; }

        protected abstract string Null { get; }

        protected abstract string Name { get; }

        protected abstract string String { get; }

        protected abstract string Number { get; }

        protected abstract string Boolean { get; }

        protected abstract string Scalar { get; }

        protected abstract string LevelVerbose { get; }

        protected abstract string LevelDebug { get; }

        protected abstract string LevelInformation { get; }

        protected abstract string LevelWarning { get; }

        protected abstract string LevelError { get; }

        protected abstract string LevelFatal { get; }

        public Dictionary<ConsoleThemeStyle, string> ToStyleDictionary()
        {
            return new Dictionary<ConsoleThemeStyle, string>
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