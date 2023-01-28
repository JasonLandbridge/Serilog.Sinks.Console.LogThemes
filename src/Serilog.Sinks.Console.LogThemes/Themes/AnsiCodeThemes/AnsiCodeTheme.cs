using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public class AnsiCodeTheme : BaseAnsiTheme
    {
        protected override string Text => ThemeDefinitions.Code[ConsoleThemeStyle.Text];
        protected override string SecondaryText => ThemeDefinitions.Code[ConsoleThemeStyle.SecondaryText];
        protected override string TertiaryText => ThemeDefinitions.Code[ConsoleThemeStyle.TertiaryText];
        protected override string Invalid => ThemeDefinitions.Code[ConsoleThemeStyle.Invalid];
        protected override string Null => ThemeDefinitions.Code[ConsoleThemeStyle.Null];
        protected override string Name => ThemeDefinitions.Code[ConsoleThemeStyle.Name];
        protected override string String => ThemeDefinitions.Code[ConsoleThemeStyle.String];
        protected override string Number => ThemeDefinitions.Code[ConsoleThemeStyle.Number];
        protected override string Boolean => ThemeDefinitions.Code[ConsoleThemeStyle.Boolean];
        protected override string Scalar => ThemeDefinitions.Code[ConsoleThemeStyle.Scalar];
        protected override string LevelVerbose => ThemeDefinitions.Code[ConsoleThemeStyle.LevelVerbose];
        protected override string LevelDebug => ThemeDefinitions.Code[ConsoleThemeStyle.LevelDebug];
        protected override string LevelInformation => ThemeDefinitions.Code[ConsoleThemeStyle.LevelInformation];
        protected override string LevelWarning => ThemeDefinitions.Code[ConsoleThemeStyle.LevelWarning];
        protected override string LevelError => ThemeDefinitions.Code[ConsoleThemeStyle.LevelError];
        protected override string LevelFatal => ThemeDefinitions.Code[ConsoleThemeStyle.LevelFatal];
    }
}